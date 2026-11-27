using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace test1
{
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            cmbRole.SelectedIndex = 1; // Default to Staff/Cashier
            LoadSuppliersDropdown();
            LoadUsers();
        }

        private void LoadSuppliersDropdown()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT SupplierID, SupplierName FROM Suppliers ORDER BY SupplierName", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbSupplier.DataSource = dt;
                    cmbSupplier.DisplayMember = "SupplierName";
                    cmbSupplier.ValueMember = "SupplierID";
                    if (dt.Rows.Count > 0) cmbSupplier.SelectedIndex = 0;
                }
            }
            catch
            {
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isSupplier = cmbRole.Text == "Supplier";
            lblSupplier.Visible = isSupplier;
            cmbSupplier.Visible = isSupplier;
        }

        public void LoadUsers()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT u.UserID, u.Username, u.FullName, 
                                            CASE WHEN u.SupplierID IS NOT NULL THEN u.Role + ' (' + s.SupplierName + ')' ELSE u.Role END AS RoleDisplay,
                                            u.Role, u.SupplierID, u.IsActive, u.CreatedAt 
                                     FROM Users u
                                     LEFT JOIN Suppliers s ON u.SupplierID = s.SupplierID
                                     ORDER BY u.Role, u.Username";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    colUserID.DataPropertyName = "UserID";
                    colUsername.DataPropertyName = "Username";
                    colFullName.DataPropertyName = "FullName";
                    colRole.DataPropertyName = "RoleDisplay";
                    colIsActive.DataPropertyName = "IsActive";
                    colCreated.DataPropertyName = "CreatedAt";

                    dgvUsers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvUsers.DataSource is DataTable dt && e.RowIndex < dt.Rows.Count)
            {
                DataRow row = ((DataRowView)dgvUsers.Rows[e.RowIndex].DataBoundItem).Row;
                txtUsername.Text = row["Username"]?.ToString();
                txtFullName.Text = row["FullName"]?.ToString();
                cmbRole.Text = row["Role"]?.ToString();
                chkIsActive.Checked = Convert.ToBoolean(row["IsActive"]);

                if (row["SupplierID"] != DBNull.Value)
                {
                    cmbSupplier.SelectedValue = Convert.ToInt32(row["SupplierID"]);
                }

                txtPassword.Clear();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string role = cmbRole.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Please fill in Username, Password, and Full Name!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            object supplierIdVal = (role == "Supplier" && cmbSupplier.SelectedValue != null)
                ? (object)Convert.ToInt32(cmbSupplier.SelectedValue)
                : DBNull.Value;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO Users (Username, Password, FullName, Role, SupplierID, IsActive)
                                     VALUES (@Username, @Password, @FullName, @Role, @SupplierID, @Active)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.Parameters.AddWithValue("@SupplierID", supplierIdVal);
                        cmd.Parameters.AddWithValue("@Active", chkIsActive.Checked);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"User account '{username}' created successfully with role '{role}'!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear_Click(null, null);
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Username already exists or database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a user from the table to update!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedUserId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["colUserID"].Value);
            string username = txtUsername.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string role = cmbRole.Text;
            string newPassword = txtPassword.Text.Trim();

            object supplierIdVal = (role == "Supplier" && cmbSupplier.SelectedValue != null)
                ? (object)Convert.ToInt32(cmbSupplier.SelectedValue)
                : DBNull.Value;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"UPDATE Users 
                                     SET Username = @Username, 
                                         FullName = @FullName, 
                                         Role = @Role, 
                                         SupplierID = @SupplierID, 
                                         IsActive = @Active";

                    if (!string.IsNullOrEmpty(newPassword))
                    {
                        query += ", Password = @Password";
                    }

                    query += " WHERE UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", selectedUserId);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.Parameters.AddWithValue("@SupplierID", supplierIdVal);
                        cmd.Parameters.AddWithValue("@Active", chkIsActive.Checked);

                        if (!string.IsNullOrEmpty(newPassword))
                            cmd.Parameters.AddWithValue("@Password", newPassword);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("User account updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear_Click(null, null);
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnToggleActive_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;

            int selectedUserId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["colUserID"].Value);
            bool currentActive = Convert.ToBoolean(dgvUsers.CurrentRow.Cells["colIsActive"].Value);
            bool newStatus = !currentActive;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE Users SET IsActive = @Active WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Active", newStatus);
                        cmd.Parameters.AddWithValue("@UserID", selectedUserId);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error changing status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtFullName.Clear();
            cmbRole.SelectedIndex = 1;
            chkIsActive.Checked = true;
        }
    }
}
