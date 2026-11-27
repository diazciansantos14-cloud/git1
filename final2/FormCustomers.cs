using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace test1
{
    public partial class FormCustomers : Form
    {
        private int selectedCustomerId = 0;

        public FormCustomers()
        {
            InitializeComponent();
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0; // Default: Good Standing
            colID.DataPropertyName = "CustomerID";
            colName.DataPropertyName = "FullName";
            colContact.DataPropertyName = "ContactNumber";
            colAddress.DataPropertyName = "InstallationAddress";
            colValidID.DataPropertyName = "ValidIDInfo";
            colDateReg.DataPropertyName = "DateRegistered";
            colStatus.DataPropertyName = "CustomerStatus";

            LoadCustomerData();
        }

        public void LoadCustomerData(string search = "")
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT CustomerID, FullName, ContactNumber, InstallationAddress, 
                                            ValidIDInfo, DateRegistered, CustomerStatus 
                                     FROM Customers 
                                     WHERE 1=1";

                    if (!string.IsNullOrWhiteSpace(search))
                    {
                        query += " AND (FullName LIKE @search OR InstallationAddress LIKE @search OR ContactNumber LIKE @search)";
                    }

                    query += " ORDER BY CustomerID DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(search))
                        {
                            cmd.Parameters.AddWithValue("@search", "%" + search.Trim() + "%");
                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvCustomers.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the customer's Full Name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("Please enter a valid Contact Number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContact.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string insertQuery = @"INSERT INTO Customers (FullName, ContactNumber, InstallationAddress, ValidIDInfo, DateRegistered, CustomerStatus)
                                          VALUES (@FullName, @ContactNumber, @InstallationAddress, @ValidIDInfo, GETDATE(), @CustomerStatus)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@ContactNumber", txtContact.Text.Trim());
                        cmd.Parameters.AddWithValue("@InstallationAddress", string.IsNullOrWhiteSpace(txtAddress.Text) ? (object)DBNull.Value : txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@ValidIDInfo", string.IsNullOrWhiteSpace(txtValidID.Text) ? (object)DBNull.Value : txtValidID.Text.Trim());
                        cmd.Parameters.AddWithValue("@CustomerStatus", cmbStatus.SelectedItem != null ? cmbStatus.SelectedItem.ToString() : "Good Standing");

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Customer registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadCustomerData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId <= 0)
            {
                MessageBox.Show("Please select a customer from the table first.", "Select Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the customer's Full Name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string updateQuery = @"UPDATE Customers 
                                          SET FullName = @FullName, 
                                              ContactNumber = @ContactNumber, 
                                              InstallationAddress = @InstallationAddress, 
                                              ValidIDInfo = @ValidIDInfo, 
                                              CustomerStatus = @CustomerStatus 
                                          WHERE CustomerID = @CustomerID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", selectedCustomerId);
                        cmd.Parameters.AddWithValue("@FullName", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@ContactNumber", txtContact.Text.Trim());
                        cmd.Parameters.AddWithValue("@InstallationAddress", string.IsNullOrWhiteSpace(txtAddress.Text) ? (object)DBNull.Value : txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@ValidIDInfo", string.IsNullOrWhiteSpace(txtValidID.Text) ? (object)DBNull.Value : txtValidID.Text.Trim());
                        cmd.Parameters.AddWithValue("@CustomerStatus", cmbStatus.SelectedItem != null ? cmbStatus.SelectedItem.ToString() : "Good Standing");

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Customer details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadCustomerData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvCustomers.CurrentRow == null) return;

            try
            {
                DataGridViewRow row = dgvCustomers.CurrentRow;
                selectedCustomerId = Convert.ToInt32(row.Cells["colID"].Value);
                txtName.Text = row.Cells["colName"].Value?.ToString() ?? "";
                txtContact.Text = row.Cells["colContact"].Value?.ToString() ?? "";
                txtAddress.Text = row.Cells["colAddress"].Value?.ToString() ?? "";
                txtValidID.Text = row.Cells["colValidID"].Value?.ToString() ?? "";

                string status = row.Cells["colStatus"].Value?.ToString() ?? "Good Standing";
                int idx = cmbStatus.FindStringExact(status);
                if (idx >= 0) cmbStatus.SelectedIndex = idx;
                else cmbStatus.Text = status;
            }
            catch
            {
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            ClearForm();
            LoadCustomerData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCustomerData(txtSearch.Text);
        }

        private void ClearForm()
        {
            selectedCustomerId = 0;
            txtName.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtValidID.Clear();
            cmbStatus.SelectedIndex = 0;
        }
    }
}
