using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace test1
{
    public partial class FormPaymentTracker : Form
    {
        private int selectedContractId = 0;
        private decimal currentTotalAmount = 0m;
        private decimal currentRemainingBalance = 0m;

        public FormPaymentTracker()
        {
            InitializeComponent();
        }

        private void FormPaymentTracker_Load(object sender, EventArgs e)
        {
            dgvContractsList.AutoGenerateColumns = false;
            dgvInstallmentSchedule.AutoGenerateColumns = false;

            if (cmbStatusFilter.Items.Count > 0) cmbStatusFilter.SelectedIndex = 0;
            LoadPaymentMethods(); // Load from DB instead of hardcoded

            // Wire up method change to toggle Receipt/Ref# field
            cmbPaymentMethod.SelectedIndexChanged += cmbPaymentMethod_SelectedIndexChanged;

            colContractID.DataPropertyName = "ContractID";
            colCustomer.DataPropertyName = "CustomerName";
            colContact.DataPropertyName = "ContactNumber";
            colUnitPurchased.DataPropertyName = "UnitPurchased";
            colTotalAmount.DataPropertyName = "TotalAmount";
            colBalanceLeft.DataPropertyName = "RemainingBalance";
            colNextDue.DataPropertyName = "NextDueDate";

            colTotalAmount.DefaultCellStyle.Format = "₱#,##0.00";
            colBalanceLeft.DefaultCellStyle.Format = "₱#,##0.00";

            colMonth.DataPropertyName = "MonthNumber";
            colDueDate.DataPropertyName = "DueDate";
            colAmountDue.DataPropertyName = "AmountDue";
            colAmountPaid.DataPropertyName = "AmountPaid";
            colDatePaid.DataPropertyName = "DatePaid";
            colStatus.DataPropertyName = "Status";
            colRemarks.DataPropertyName = "Remarks";

            colAmountDue.DefaultCellStyle.Format = "₱#,##0.00";
            colAmountPaid.DefaultCellStyle.Format = "₱#,##0.00";

            LoadPaymentMethods();
            cmbPaymentMethod_SelectedIndexChanged(null, null); // Set initial ref field state

            LoadContracts();
        }

        // ── Load payment methods from DB (falls back to defaults if table missing) ──
        private void LoadPaymentMethods()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string saved = cmbPaymentMethod.SelectedItem?.ToString();
                    cmbPaymentMethod.Items.Clear();

                    SqlDataAdapter da = new SqlDataAdapter("SELECT MethodName FROM PaymentMethods WHERE IsActive = 1 ORDER BY SortOrder, MethodName", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                            cmbPaymentMethod.Items.Add(row["MethodName"].ToString());
                    }
                    else
                    {
                        // Fallback defaults
                        cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "GCash", "Bank Transfer", "Check" });
                    }

                    // Restore selection or default to Cash
                    int idx = cmbPaymentMethod.Items.IndexOf(saved ?? "Cash");
                    cmbPaymentMethod.SelectedIndex = idx >= 0 ? idx : 0;
                }
            }
            catch
            {
                // If PaymentMethods table doesn't exist yet, use defaults
                if (cmbPaymentMethod.Items.Count == 0)
                    cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "GCash", "Bank Transfer", "Check" });
                if (cmbPaymentMethod.SelectedIndex < 0) cmbPaymentMethod.SelectedIndex = 0;
            }
        }

        // ── Disable Receipt Ref # for Cash (auto-generated) and enable for other methods ──
        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isCash = cmbPaymentMethod.SelectedItem?.ToString()?.Equals("Cash", StringComparison.OrdinalIgnoreCase) ?? true;
            txtReceiptRef.Enabled = !isCash;
            txtReceiptRef.BackColor = isCash
                ? System.Drawing.Color.FromArgb(235, 235, 235)
                : System.Drawing.SystemColors.Window;
            txtReceiptRef.Text = isCash ? "(Auto-generated)" : "";
            lblReceipt.Text = isCash ? "Receipt / Ref #:" : "Receipt / Ref # *:";
        }

        public void LoadContracts()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string filterStatus = cmbStatusFilter.SelectedItem != null ? cmbStatusFilter.SelectedItem.ToString() : "All Accounts";
                    string search = txtSearchContract.Text.Trim();

                    string query = @"SELECT c.ContractID, 
                                            cust.FullName AS CustomerName, 
                                            cust.ContactNumber, 
                                            inv.Brand + ' ' + inv.Model + ' (' + inv.Horsepower + ')' AS UnitPurchased, 
                                            c.TotalAmount,
                                            COALESCE((SELECT SUM(CASE WHEN s.AmountDue > s.AmountPaid
                                                                     THEN s.AmountDue - s.AmountPaid
                                                                     ELSE 0 END)
                                                      FROM InstallmentSchedule s
                                                      WHERE s.ContractID = c.ContractID), c.RemainingBalance) AS RemainingBalance,
                                            (SELECT MIN(DueDate) FROM InstallmentSchedule s WHERE s.ContractID = c.ContractID AND s.Status <> 'PAID') AS NextDueDate,
                                            c.ContractStatus
                                     FROM SalesContracts c
                                     INNER JOIN Customers cust ON c.CustomerID = cust.CustomerID
                                     INNER JOIN Inventory inv ON c.ItemID = inv.ItemID
                                     WHERE 1=1";

                    if (filterStatus == "Active Only")
                    {
                        query += " AND c.ContractStatus = 'Active'";
                    }
                    else if (filterStatus == "Fully Paid")
                    {
                        query += " AND c.ContractStatus = 'Completed'";
                    }

                    if (!string.IsNullOrWhiteSpace(search))
                    {
                        query += " AND (cust.FullName LIKE @search OR CAST(c.ContractID AS NVARCHAR) LIKE @search OR cust.ContactNumber LIKE @search)";
                    }

                    query += " ORDER BY c.ContractID DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(search))
                            cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvContractsList.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading contracts: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvContractsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvContractsList.CurrentRow == null) return;

            try
            {
                DataGridViewRow row = dgvContractsList.CurrentRow;
                selectedContractId = Convert.ToInt32(row.Cells["colContractID"].Value);
                lblCustNameDisplay.Text = row.Cells["colCustomer"].Value?.ToString() ?? "";
                lblUnitDisplay.Text = row.Cells["colUnitPurchased"].Value?.ToString() ?? "";

                currentTotalAmount = Convert.ToDecimal(row.Cells["colTotalAmount"].Value);
                currentRemainingBalance = Convert.ToDecimal(row.Cells["colBalanceLeft"].Value);

                decimal totalPaid = currentTotalAmount - currentRemainingBalance;

                lblTotalDisplay.Text = "₱" + currentTotalAmount.ToString("N2");
                lblPaidDisplay.Text = "₱" + totalPaid.ToString("N2");
                lblBalanceDisplay.Text = "₱" + currentRemainingBalance.ToString("N2");

                LoadInstallmentSchedule(selectedContractId);
            }
            catch
            {
            }
        }

        private void LoadInstallmentSchedule(int contractId)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT ScheduleID, MonthNumber, DueDate, AmountDue, AmountPaid, DatePaid, Status, Remarks 
                                     FROM InstallmentSchedule 
                                     WHERE ContractID = @ContractID 
                                     ORDER BY MonthNumber ASC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ContractID", contractId);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvInstallmentSchedule.DataSource = dt;

                        // Default next payment amount and grid selection to the first unpaid month
                        decimal nextDue = 0m;
                        int firstUnpaidIndex = -1;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            string st = dt.Rows[i]["Status"].ToString();
                            if (!st.Equals("PAID", StringComparison.OrdinalIgnoreCase))
                            {
                                decimal due = Convert.ToDecimal(dt.Rows[i]["AmountDue"]);
                                decimal paid = Convert.ToDecimal(dt.Rows[i]["AmountPaid"]);
                                nextDue = due - paid;
                                firstUnpaidIndex = i;
                                break;
                            }
                        }

                        if (firstUnpaidIndex >= 0 && firstUnpaidIndex < dgvInstallmentSchedule.Rows.Count)
                        {
                            dgvInstallmentSchedule.ClearSelection();
                            dgvInstallmentSchedule.Rows[firstUnpaidIndex].Selected = true;
                            dgvInstallmentSchedule.CurrentCell = dgvInstallmentSchedule.Rows[firstUnpaidIndex].Cells[0];
                        }

                        nudPaymentAmount.Value = Math.Min(nudPaymentAmount.Maximum, Math.Max(0m, nextDue));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading installment schedule: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRecordPayment_Click(object sender, EventArgs e)
        {
            if (selectedContractId <= 0)
            {
                MessageBox.Show("Please select an active installment contract from the list first.", "Select Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal paymentAmount = nudPaymentAmount.Value;
            if (paymentAmount <= 0)
            {
                MessageBox.Show("Please enter a payment amount greater than zero.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ── Block over-payment ──
            if (currentRemainingBalance <= 0)
            {
                MessageBox.Show(
                    "This contract is already FULLY PAID.\nNo further payments can be recorded.",
                    "Account Settled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (paymentAmount > currentRemainingBalance)
            {
                DialogResult overPay = MessageBox.Show(
                    string.Format("The amount entered (P{0:N2}) exceeds the remaining balance (P{1:N2}).\n\nDo you want to record P{1:N2} instead (exact remaining balance)?",
                        paymentAmount, currentRemainingBalance),
                    "Amount Exceeds Balance", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (overPay == DialogResult.Yes)
                    paymentAmount = currentRemainingBalance;
                else
                    return;
            }

            string paymentMethod = cmbPaymentMethod.SelectedItem != null ? cmbPaymentMethod.SelectedItem.ToString() : "Cash";
            bool isCash = paymentMethod.Equals("Cash", StringComparison.OrdinalIgnoreCase);
            string receiptRef = isCash
                ? "CASH-" + DateTime.Now.ToString("yyyyMMddHHmmss")
                : (string.IsNullOrWhiteSpace(txtReceiptRef.Text) ? "REF-" + DateTime.Now.ToString("yyyyMMddHHmmss") : txtReceiptRef.Text.Trim());

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (SqlTransaction trans = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Fetch all unpaid or partially paid schedules in month order
                            string querySched = @"SELECT ScheduleID, MonthNumber, AmountDue, AmountPaid, Status 
                                                  FROM InstallmentSchedule 
                                                  WHERE ContractID = @ContractID AND Status <> 'PAID' 
                                                  ORDER BY MonthNumber ASC";

                            DataTable dtSched = new DataTable();
                            using (SqlCommand cmdSched = new SqlCommand(querySched, conn, trans))
                            {
                                cmdSched.Parameters.AddWithValue("@ContractID", selectedContractId);
                                SqlDataAdapter da = new SqlDataAdapter(cmdSched);
                                da.Fill(dtSched);
                            }

                            decimal remainingToDistribute = paymentAmount;

                            foreach (DataRow r in dtSched.Rows)
                            {
                                if (remainingToDistribute <= 0) break;

                                int schedId = Convert.ToInt32(r["ScheduleID"]);
                                decimal due = Convert.ToDecimal(r["AmountDue"]);
                                decimal paid = Convert.ToDecimal(r["AmountPaid"]);
                                decimal balanceForMonth = due - paid;

                                if (remainingToDistribute >= balanceForMonth)
                                {
                                    // Month fully settled
                                    string updateSched = @"UPDATE InstallmentSchedule 
                                                          SET AmountPaid = AmountDue, 
                                                              DatePaid = GETDATE(), 
                                                              Status = 'PAID', 
                                                              Remarks = 'Fully paid via ' + @Method 
                                                          WHERE ScheduleID = @ScheduleID";

                                    using (SqlCommand cmdUp = new SqlCommand(updateSched, conn, trans))
                                    {
                                        cmdUp.Parameters.AddWithValue("@Method", paymentMethod);
                                        cmdUp.Parameters.AddWithValue("@ScheduleID", schedId);
                                        cmdUp.ExecuteNonQuery();
                                    }

                                    remainingToDistribute -= balanceForMonth;
                                }
                                else
                                {
                                    // Month partially settled
                                    string updateSched = @"UPDATE InstallmentSchedule 
                                                          SET AmountPaid = AmountPaid + @Payment, 
                                                              DatePaid = GETDATE(), 
                                                              Status = 'PARTIAL', 
                                                              Remarks = 'Partial payment received' 
                                                          WHERE ScheduleID = @ScheduleID";

                                    using (SqlCommand cmdUp = new SqlCommand(updateSched, conn, trans))
                                    {
                                        cmdUp.Parameters.AddWithValue("@Payment", remainingToDistribute);
                                        cmdUp.Parameters.AddWithValue("@ScheduleID", schedId);
                                        cmdUp.ExecuteNonQuery();
                                    }

                                    remainingToDistribute = 0;
                                }
                            }

                            // 2. Insert into PaymentTransactions
                            string paymentType = (paymentAmount >= currentRemainingBalance) ? "Full Settlement" : "Monthly Installment";
                            string insertTx = @"INSERT INTO PaymentTransactions (ContractID, ScheduleID, PaymentDate, Amount, PaymentType, PaymentMethod, ReferenceReceipt, ReceivedBy)
                                               VALUES (@ContractID, NULL, GETDATE(), @Amount, @PaymentType, @PaymentMethod, @ReferenceReceipt, @ReceivedBy)";

                            using (SqlCommand cmdTx = new SqlCommand(insertTx, conn, trans))
                            {
                                cmdTx.Parameters.AddWithValue("@ContractID", selectedContractId);
                                cmdTx.Parameters.AddWithValue("@Amount", paymentAmount);
                                cmdTx.Parameters.AddWithValue("@PaymentType", paymentType);
                                cmdTx.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                                cmdTx.Parameters.AddWithValue("@ReferenceReceipt", receiptRef);
                                cmdTx.Parameters.AddWithValue("@ReceivedBy", UserSession.FullName ?? "Staff");
                                cmdTx.ExecuteNonQuery();
                            }

                            // 3. Recalculate the contract balance from the installment schedule.
                            // Do not subtract from the stored value because it may already be stale.
                            string updateContract = @"UPDATE c
                                                     SET RemainingBalance = balances.RemainingBalance,
                                                         ContractStatus = CASE WHEN balances.RemainingBalance <= 0 THEN 'Completed' ELSE c.ContractStatus END
                                                     FROM SalesContracts c
                                                     CROSS APPLY
                                                     (
                                                         SELECT COALESCE(SUM(CASE WHEN s.AmountDue > s.AmountPaid
                                                                                 THEN s.AmountDue - s.AmountPaid
                                                                                 ELSE 0 END), 0) AS RemainingBalance
                                                         FROM InstallmentSchedule s
                                                         WHERE s.ContractID = c.ContractID
                                                     ) balances
                                                     WHERE c.ContractID = @ContractID";

                            using (SqlCommand cmdContract = new SqlCommand(updateContract, conn, trans))
                            {
                                cmdContract.Parameters.AddWithValue("@ContractID", selectedContractId);
                                cmdContract.ExecuteNonQuery();
                            }

                            trans.Commit();

                            MessageBox.Show(
                                string.Format("Payment of ₱{0:N2} recorded successfully!\nReceipt Ref: {1}\nMethod: {2}",
                                    paymentAmount, receiptRef, paymentMethod),
                                "Payment Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtReceiptRef.Clear();
                            cmbPaymentMethod_SelectedIndexChanged(null, null);
                            LoadContracts();
                            LoadInstallmentSchedule(selectedContractId);
                        }
                        catch (Exception exInner)
                        {
                            trans.Rollback();
                            throw exInner;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Payment processing failed: " + ex.Message, "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPayFullSettlement_Click(object sender, EventArgs e)
        {
            if (selectedContractId <= 0)
            {
                MessageBox.Show("Please select a contract first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Read the balance again so Pay Full never uses a stale grid value
            // or the original contract total.
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT COALESCE((SELECT SUM(CASE WHEN s.AmountDue > s.AmountPaid
                                                           THEN s.AmountDue - s.AmountPaid
                                                           ELSE 0 END)
                                            FROM InstallmentSchedule s
                                            WHERE s.ContractID = c.ContractID), c.RemainingBalance)
                          FROM SalesContracts c
                          WHERE c.ContractID = @ContractID", conn))
                    {
                        cmd.Parameters.AddWithValue("@ContractID", selectedContractId);
                        object value = cmd.ExecuteScalar();
                        if (value == null || value == DBNull.Value)
                        {
                            MessageBox.Show("The selected contract balance could not be found.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        currentRemainingBalance = Convert.ToDecimal(value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to read the current remaining balance: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (currentRemainingBalance <= 0)
            {
                MessageBox.Show("This contract is already fully paid!", "Account Settled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                string.Format("Confirm full early settlement of ₱{0:N2} for Contract #{1}?\n\nThis will mark all remaining installment months as fully paid.",
                    currentRemainingBalance, selectedContractId),
                "Confirm Full Payoff", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            nudPaymentAmount.Value = currentRemainingBalance;
            btnRecordPayment_Click(sender, e);
        }

        private void btnExtendDueDate_Click(object sender, EventArgs e)
        {
            if (selectedContractId <= 0 || dgvInstallmentSchedule.CurrentRow == null)
            {
                MessageBox.Show("Please select an installment schedule month from the table to extend.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int monthNum = Convert.ToInt32(dgvInstallmentSchedule.CurrentRow.Cells["colMonth"].Value);
                string status = dgvInstallmentSchedule.CurrentRow.Cells["colStatus"].Value?.ToString() ?? "";
                string remarks = dgvInstallmentSchedule.CurrentRow.Cells["colRemarks"].Value?.ToString() ?? "";

                if (status.Equals("PAID", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Month #{monthNum} is already PAID. Please select an unpaid month to extend.", "Already Paid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (remarks.IndexOf("Extended", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    MessageBox.Show($"Month #{monthNum} has already been extended once.\nOnly one 15-day extension is allowed!", "Extension Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dr = MessageBox.Show($"Extend Month #{monthNum} due date by 15 days?\n(Note: Only 1 extension is allowed for this installment.)", "Extend Due Date", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string updateQuery = @"UPDATE InstallmentSchedule 
                                              SET DueDate = DATEADD(DAY, 15, DueDate), 
                                                  Remarks = 'Extended 15 days upon request' 
                                              WHERE ContractID = @ContractID AND MonthNumber = @Month
                                                AND (Remarks IS NULL OR Remarks NOT LIKE '%Extended%')";

                        using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@ContractID", selectedContractId);
                            cmd.Parameters.AddWithValue("@Month", monthNum);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show($"Month #{monthNum} due date successfully extended by 15 days!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadContracts();
                    LoadInstallmentSchedule(selectedContractId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error extending due date: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            if (selectedContractId <= 0)
            {
                MessageBox.Show("Please select a contract to print statement of account.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string receiptText = string.Format(
                "====================================================\n" +
                "       COLLAINE REFRIGERATION & AIRCONDITIONING    \n" +
                "              Sales * Parts * Service * Install     \n" +
                "====================================================\n" +
                "Statement of Account / Installment Ledger\n\n" +
                "Contract ID : #{0}\n" +
                "Customer    : {1}\n" +
                "Unit Model  : {2}\n" +
                "Total Amount: ₱{3:N2}\n" +
                "Balance Left: ₱{4:N2}\n" +
                "Issued Date : {5:MMMM dd, yyyy HH:mm}\n" +
                "Cashier/User: {6}\n" +
                "====================================================\n" +
                "         Thank you for choosing COLLAINE RAC!       \n" +
                "====================================================",
                selectedContractId,
                lblCustNameDisplay.Text,
                lblUnitDisplay.Text,
                currentTotalAmount,
                currentRemainingBalance,
                DateTime.Now,
                UserSession.FullName ?? "Engr. Nicdao (Admin)"
            );

            MessageBox.Show(receiptText, "Official Statement of Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadContracts();
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadContracts();
        }

        private void txtSearchContract_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadContracts();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
