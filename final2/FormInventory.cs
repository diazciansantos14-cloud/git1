using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace test1
{
    public partial class FormInventory : Form
    {
        public FormInventory()
        {
            InitializeComponent();
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            if (cmbBrandFilter.Items.Count > 0) cmbBrandFilter.SelectedIndex = 0; 
            if (cmbTypeFilter.Items.Count > 0) cmbTypeFilter.SelectedIndex = 0;  

            colItemID.DataPropertyName = "ItemID";
            colBrand.DataPropertyName = "Brand";
            colModel.DataPropertyName = "Model";
            colUnitType.DataPropertyName = "UnitType";
            colHP.DataPropertyName = "Horsepower";
            colInverter.DataPropertyName = "InverterStatus";
            colSerial.DataPropertyName = "SerialNumber";
            colCashPrice.DataPropertyName = "CashPrice";
            colInstallPrice.DataPropertyName = "InstallmentPrice";
            colStockQty.DataPropertyName = "StockQty";

            colCashPrice.DefaultCellStyle.Format = "₱#,##0.00";
            colInstallPrice.DefaultCellStyle.Format = "₱#,##0.00";

            LoadInventoryData();
        }

        public void LoadInventoryData()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT ItemID, Brand, Model, UnitType, Horsepower, 
                                            InverterStatus, SerialNumber, CostPrice, CashPrice, 
                                            InstallmentPrice, StockQty 
                                     FROM Inventory 
                                     WHERE 1=1";

                    if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                    {
                        query += " AND (Model LIKE @search OR SerialNumber LIKE @search OR Brand LIKE @search)";
                    }
                    if (cmbBrandFilter.SelectedIndex > 0)
                    {
                        query += " AND Brand = @brand";
                    }
                    if (cmbTypeFilter.SelectedIndex > 0)
                    {
                        query += " AND UnitType = @unitType";
                    }
                    if (chkInStockOnly.Checked)
                    {
                        query += " AND StockQty > 0";
                    }

                    query += " ORDER BY Brand, Horsepower";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                            cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");

                        if (cmbBrandFilter.SelectedIndex > 0)
                            cmd.Parameters.AddWithValue("@brand", cmbBrandFilter.SelectedItem.ToString());

                        if (cmbTypeFilter.SelectedIndex > 0)
                            cmd.Parameters.AddWithValue("@unitType", cmbTypeFilter.SelectedItem.ToString());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvInventory.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadInventoryData();
        }

        private void cmbBrandFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInventoryData();
        }

        private void cmbTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInventoryData();
        }

        private void chkInStockOnly_CheckedChanged(object sender, EventArgs e)
        {
            LoadInventoryData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            if (cmbBrandFilter.Items.Count > 0) cmbBrandFilter.SelectedIndex = 0;
            if (cmbTypeFilter.Items.Count > 0) cmbTypeFilter.SelectedIndex = 0;
            chkInStockOnly.Checked = false;
            ClearInputFields();
            LoadInventoryData();
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvInventory.CurrentRow != null)
            {
                DataGridViewRow row = dgvInventory.CurrentRow;
                cmbBrand.Text = row.Cells["colBrand"].Value?.ToString() ?? "";
                txtModel.Text = row.Cells["colModel"].Value?.ToString() ?? "";
                cmbUnitType.Text = row.Cells["colUnitType"].Value?.ToString() ?? "";
                cmbHP.Text = row.Cells["colHP"].Value?.ToString() ?? "";
                cmbInverter.Text = row.Cells["colInverter"].Value?.ToString() ?? "";
                txtSerialNo.Text = row.Cells["colSerial"].Value?.ToString() ?? "";

                if (decimal.TryParse(row.Cells["colCashPrice"].Value?.ToString(), out decimal cash))
                    nudCashPrice.Value = Math.Min(nudCashPrice.Maximum, Math.Max(nudCashPrice.Minimum, cash));

                if (decimal.TryParse(row.Cells["colInstallPrice"].Value?.ToString(), out decimal install))
                    nudInstallPrice.Value = Math.Min(nudInstallPrice.Maximum, Math.Max(nudInstallPrice.Minimum, install));

                if (int.TryParse(row.Cells["colStockQty"].Value?.ToString(), out int qty))
                    nudStockQty.Value = Math.Min(nudStockQty.Maximum, Math.Max(nudStockQty.Minimum, qty));
            }
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbBrand.Text) || string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Please specify both Brand and Model name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string insertQuery = @"INSERT INTO Inventory (Brand, Model, UnitType, Horsepower, InverterStatus, SerialNumber, CostPrice, CashPrice, InstallmentPrice, StockQty)
                                          VALUES (@Brand, @Model, @UnitType, @HP, @Inverter, @Serial, 0, @Cash, @Install, @Qty)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Brand", cmbBrand.Text.Trim());
                        cmd.Parameters.AddWithValue("@Model", txtModel.Text.Trim());
                        cmd.Parameters.AddWithValue("@UnitType", cmbUnitType.Text.Trim());
                        cmd.Parameters.AddWithValue("@HP", cmbHP.Text.Trim());
                        cmd.Parameters.AddWithValue("@Inverter", string.IsNullOrWhiteSpace(cmbInverter.Text) ? "Inverter" : cmbInverter.Text.Trim());
                        cmd.Parameters.AddWithValue("@Serial", string.IsNullOrWhiteSpace(txtSerialNo.Text) ? (object)DBNull.Value : txtSerialNo.Text.Trim());
                        cmd.Parameters.AddWithValue("@Cash", nudCashPrice.Value);
                        cmd.Parameters.AddWithValue("@Install", nudInstallPrice.Value);
                        cmd.Parameters.AddWithValue("@Qty", (int)nudStockQty.Value);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("AC Unit added to inventory successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputFields();
                LoadInventoryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add unit: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateUnit_Click(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow == null)
            {
                MessageBox.Show("Please select an AC unit from the table to update!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int selectedId = Convert.ToInt32(dgvInventory.CurrentRow.Cells["colItemID"].Value);
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string updateQuery = @"UPDATE Inventory 
                                          SET Brand = @Brand, 
                                              Model = @Model, 
                                              UnitType = @UnitType, 
                                              Horsepower = @HP, 
                                              InverterStatus = @Inverter, 
                                              SerialNumber = @Serial, 
                                              CashPrice = @Cash, 
                                              InstallmentPrice = @Install, 
                                              StockQty = @Qty 
                                          WHERE ItemID = @ItemID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ItemID", selectedId);
                        cmd.Parameters.AddWithValue("@Brand", cmbBrand.Text.Trim());
                        cmd.Parameters.AddWithValue("@Model", txtModel.Text.Trim());
                        cmd.Parameters.AddWithValue("@UnitType", cmbUnitType.Text.Trim());
                        cmd.Parameters.AddWithValue("@HP", cmbHP.Text.Trim());
                        cmd.Parameters.AddWithValue("@Inverter", string.IsNullOrWhiteSpace(cmbInverter.Text) ? "Inverter" : cmbInverter.Text.Trim());
                        cmd.Parameters.AddWithValue("@Serial", string.IsNullOrWhiteSpace(txtSerialNo.Text) ? (object)DBNull.Value : txtSerialNo.Text.Trim());
                        cmd.Parameters.AddWithValue("@Cash", nudCashPrice.Value);
                        cmd.Parameters.AddWithValue("@Install", nudInstallPrice.Value);
                        cmd.Parameters.AddWithValue("@Qty", (int)nudStockQty.Value);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("AC Unit updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadInventoryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update unit: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void ClearInputFields()
        {
            cmbBrand.SelectedIndex = -1;
            txtModel.Clear();
            cmbUnitType.SelectedIndex = -1;
            cmbHP.SelectedIndex = -1;
            cmbInverter.SelectedIndex = -1;
            txtSerialNo.Clear();
            nudCashPrice.Value = 0;
            nudInstallPrice.Value = 0;
            nudStockQty.Value = 0;
        }
    }
}
