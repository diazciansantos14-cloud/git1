using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace test1
{
    public partial class FormInstallations : Form
    {
        private string connectionString = @"Server=.\SQLEXPRESS;Database=RAC_DB;Integrated Security=True;TrustServerCertificate=True;";

        public FormInstallations()
        {
            InitializeComponent();
        }

        private void FormInstallations_Load(object sender, EventArgs e)
        {
            LoadTechnicians();
            cmbFilterStatus.SelectedIndex = 0; // "Pending Installation"
        }

        private void LoadTechnicians()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    cmbTechnician.Items.Clear();
                    cmbTechnician.Items.Add("-- (Unassigned) --");

                    using (SqlCommand cmd = new SqlCommand("SELECT FullName FROM Users WHERE Role = 'Technician' ORDER BY FullName", conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            cmbTechnician.Items.Add(reader["FullName"].ToString());
                    }

                    cmbTechnician.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading technicians: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadInstallations()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT c.ContractID, cust.FullName AS CustomerName, cust.ContactNumber,
                                            cust.InstallationAddress, 
                                            inv.ItemID, inv.Brand + ' ' + inv.Model + ' (' + inv.Horsepower + ')' AS ACUnit,
                                            inv.SerialNumber, c.ContractDate, c.InstallationStatus, 
                                            c.InstalledDate, c.AssignedTechnician, c.InstallationNotes
                                     FROM SalesContracts c
                                     INNER JOIN Customers cust ON c.CustomerID = cust.CustomerID
                                     INNER JOIN Inventory inv ON c.ItemID = inv.ItemID
                                     WHERE 1=1";

                    if (cmbFilterStatus.SelectedIndex == 0) // Pending Only
                        query += " AND c.InstallationStatus = 'Pending Installation'";
                    else if (cmbFilterStatus.SelectedIndex == 1) // Installed Only
                        query += " AND c.InstallationStatus = 'Installed'";

                    if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                        query += " AND (cust.FullName LIKE @search OR cust.InstallationAddress LIKE @search OR inv.Model LIKE @search)";

                    query += " ORDER BY c.ContractID DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                            cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        colContractID.DataPropertyName = "ContractID";
                        colCustomer.DataPropertyName = "CustomerName";
                        colContact.DataPropertyName = "ContactNumber";
                        colAddress.DataPropertyName = "InstallationAddress";
                        colItemID.DataPropertyName = "ItemID";
                        colUnit.DataPropertyName = "ACUnit";
                        colSerial.DataPropertyName = "SerialNumber";
                        colSaleDate.DataPropertyName = "ContractDate";
                        colStatus.DataPropertyName = "InstallationStatus";
                        colInstallDate.DataPropertyName = "InstalledDate";
                        colTech.DataPropertyName = "AssignedTechnician";

                        dgvInstallations.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading installations: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadInstallations();
        }

        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInstallations();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadInstallations();
        }

        private void dgvInstallations_SelectionChanged(object sender, EventArgs e)
        {
            // The grid can raise SelectionChanged while technicians are still loading.
            if (cmbTechnician.Items.Count == 0)
                return;

            if (dgvInstallations.CurrentRow == null || dgvInstallations.CurrentRow.Cells["colTech"].Value == null)
            {
                cmbTechnician.SelectedIndex = 0;
                return;
            }

            string assignedTechnician = dgvInstallations.CurrentRow.Cells["colTech"].Value.ToString().Trim();
            if (string.IsNullOrWhiteSpace(assignedTechnician))
            {
                cmbTechnician.SelectedIndex = 0;
                return;
            }

            int technicianIndex = cmbTechnician.Items.IndexOf(assignedTechnician);
            if (technicianIndex < 0)
            {
                cmbTechnician.Items.Add(assignedTechnician);
                technicianIndex = cmbTechnician.Items.Count - 1;
            }

            cmbTechnician.SelectedIndex = technicianIndex;
        }

        // CONFIRM INSTALLATION -> DEDUCTS STOCK PHYSICALLY FROM INVENTORY!
        private void btnConfirmInstalled_Click(object sender, EventArgs e)
        {
            if (dgvInstallations.CurrentRow == null)
            {
                MessageBox.Show("Please select a pending installation job from the table!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string currentStatus = dgvInstallations.CurrentRow.Cells["colStatus"].Value?.ToString();
            if (currentStatus == "Installed")
            {
                MessageBox.Show("This unit has already been installed and physical stock was already deducted!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int contractId = Convert.ToInt32(dgvInstallations.CurrentRow.Cells["colContractID"].Value);
            int itemId = Convert.ToInt32(dgvInstallations.CurrentRow.Cells["colItemID"].Value);
            string customerName = dgvInstallations.CurrentRow.Cells["colCustomer"].Value?.ToString();
            string acUnit = dgvInstallations.CurrentRow.Cells["colUnit"].Value?.ToString();

            string technician = cmbTechnician.SelectedIndex > 0 && cmbTechnician.SelectedItem != null
                ? cmbTechnician.SelectedItem.ToString()
                : UserSession.FullName;

            DialogResult confirm = MessageBox.Show(
                $"Confirm that the {acUnit} has been physically installed at {customerName}'s address?\n\nThis will physically DEDUCT 1 UNIT from live inventory stock.",
                "Confirm AC Installation (Goods Issue)",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction trans = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Check if stock is available
                            string checkQuery = "SELECT StockQty FROM Inventory WHERE ItemID = @ItemID";
                            int currentStock = 0;
                            using (SqlCommand cmdCheck = new SqlCommand(checkQuery, conn, trans))
                            {
                                cmdCheck.Parameters.AddWithValue("@ItemID", itemId);
                                currentStock = Convert.ToInt32(cmdCheck.ExecuteScalar());
                            }

                            if (currentStock <= 0)
                            {
                                MessageBox.Show("Warning: Warehouse stock is currently 0! Receive stock from suppliers first.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                trans.Rollback();
                                return;
                            }

                            // 2. Physically deduct 1 unit from Inventory
                            string deductStock = "UPDATE Inventory SET StockQty = StockQty - 1 WHERE ItemID = @ItemID";
                            using (SqlCommand cmdDeduct = new SqlCommand(deductStock, conn, trans))
                            {
                                cmdDeduct.Parameters.AddWithValue("@ItemID", itemId);
                                cmdDeduct.ExecuteNonQuery();
                            }

                            // 3. Update SalesContracts status to 'Installed'
                            string updateContract = @"UPDATE SalesContracts 
                                                     SET InstallationStatus = 'Installed', 
                                                         InstalledDate = GETDATE(), 
                                                         AssignedTechnician = @Tech 
                                                     WHERE ContractID = @ContractID";

                            using (SqlCommand cmdUpdate = new SqlCommand(updateContract, conn, trans))
                            {
                                cmdUpdate.Parameters.AddWithValue("@Tech", technician);
                                cmdUpdate.Parameters.AddWithValue("@ContractID", contractId);
                                cmdUpdate.ExecuteNonQuery();
                            }

                            trans.Commit();
                            MessageBox.Show($"Installation completed successfully!\n1 unit has been deducted from physical inventory stock.", "Job Order Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (cmbTechnician.Items.Count > 0)
                                cmbTechnician.SelectedIndex = 0;
                            LoadInstallations();
                        }
                        catch (Exception)
                        {
                            trans.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to confirm installation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
