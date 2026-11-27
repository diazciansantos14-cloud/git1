using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace test1
{
    public partial class FormSupplierPortal : Form
    {
        private int selectedCatalogId = 0;

        public FormSupplierPortal()
        {
            InitializeComponent();
        }

        private void FormSupplierPortal_Load(object sender, EventArgs e)
        {
            if (!UserSession.IsSupplier || !UserSession.SupplierID.HasValue)
            {
                MessageBox.Show("Access Denied: This portal is exclusively for registered suppliers.", "Security Restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSignOut_Click(sender, e);
                return;
            }

            lblPortalTitle.Text = "🏢 " + (UserSession.SupplierName ?? "Supplier") + " - B2B Portal";
            lblUserInfo.Text = "👤 " + UserSession.FullName;

            // Setup DataGridView columns
            colCatID.DataPropertyName = "CatalogID";
            colCatBrand.DataPropertyName = "Brand";
            colCatModel.DataPropertyName = "ModelName";
            colCatType.DataPropertyName = "UnitType";
            colCatHP.DataPropertyName = "Horsepower";
            colCatInverter.DataPropertyName = "InverterStatus";
            colCatCost.DataPropertyName = "WholesaleCost";
            colCatStock.DataPropertyName = "AvailableStock";
            colCatUpdated.DataPropertyName = "UpdatedAt";

            colCatCost.DefaultCellStyle.Format = "₱#,##0.00";

            colPOID.DataPropertyName = "POID";
            colPODate.DataPropertyName = "OrderDate";
            colPOItem.DataPropertyName = "ItemDescription";
            colPOQty.DataPropertyName = "QuantityOrdered";
            colPOTotal.DataPropertyName = "TotalCost";
            colPOStatus.DataPropertyName = "Status";
            colPONotes.DataPropertyName = "Notes";

            colPOTotal.DefaultCellStyle.Format = "₱#,##0.00";

            if (cmbType.Items.Count > 0) cmbType.SelectedIndex = 0;
            if (cmbHP.Items.Count > 0) cmbHP.SelectedIndex = 2;
            if (cmbInverter.Items.Count > 0) cmbInverter.SelectedIndex = 0;

            LoadSupplierCatalog();
            LoadIncomingPOs();
        }

        public void LoadSupplierCatalog()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    // CRITICAL: Strictly filtered by the logged-in Supplier's ID!
                    string query = @"SELECT CatalogID, Brand, ModelName, UnitType, Horsepower, 
                                            InverterStatus, WholesaleCost, AvailableStock, UpdatedAt 
                                     FROM SupplierCatalog 
                                     WHERE SupplierID = @SupplierID 
                                     ORDER BY Brand, ModelName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierID", UserSession.SupplierID.Value);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvCatalog.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading company catalog: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadIncomingPOs()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    // Strictly loads POs placed to THIS supplier only!
                    string query = @"SELECT po.POID, po.OrderDate, 
                                            inv.Brand + ' ' + inv.Model + ' (' + inv.Horsepower + ')' AS ItemDescription, 
                                            poi.QuantityOrdered, poi.TotalCost, po.Status, po.Notes 
                                     FROM PurchaseOrders po 
                                     INNER JOIN PurchaseOrderItems poi ON po.POID = poi.POID 
                                     INNER JOIN Inventory inv ON poi.ItemID = inv.ItemID 
                                     WHERE po.SupplierID = @SupplierID 
                                     ORDER BY po.POID DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierID", UserSession.SupplierID.Value);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvIncomingPOs.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading incoming purchase orders: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCatalog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvCatalog.CurrentRow == null) return;

            try
            {
                DataGridViewRow row = dgvCatalog.CurrentRow;
                selectedCatalogId = Convert.ToInt32(row.Cells["colCatID"].Value);
                txtBrand.Text = row.Cells["colCatBrand"].Value?.ToString() ?? "";
                txtModel.Text = row.Cells["colCatModel"].Value?.ToString() ?? "";
                cmbType.Text = row.Cells["colCatType"].Value?.ToString() ?? "Split Type";
                cmbHP.Text = row.Cells["colCatHP"].Value?.ToString() ?? "1.0 HP";
                cmbInverter.Text = row.Cells["colCatInverter"].Value?.ToString() ?? "Inverter";

                if (decimal.TryParse(row.Cells["colCatCost"].Value?.ToString(), out decimal cost))
                    nudCost.Value = Math.Min(nudCost.Maximum, Math.Max(nudCost.Minimum, cost));

                if (int.TryParse(row.Cells["colCatStock"].Value?.ToString(), out int stock))
                    nudStock.Value = Math.Min(nudStock.Maximum, Math.Max(nudStock.Minimum, stock));
            }
            catch
            {
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrand.Text) || string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Please specify both Brand and Model name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudCost.Value <= 0)
            {
                MessageBox.Show("Please enter a valid wholesale unit price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO SupplierCatalog 
                                     (SupplierID, Brand, ModelName, UnitType, Horsepower, InverterStatus, WholesaleCost, AvailableStock, UpdatedAt)
                                     VALUES 
                                     (@SupplierID, @Brand, @ModelName, @UnitType, @Horsepower, @InverterStatus, @WholesaleCost, @AvailableStock, GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierID", UserSession.SupplierID.Value);
                        cmd.Parameters.AddWithValue("@Brand", txtBrand.Text.Trim());
                        cmd.Parameters.AddWithValue("@ModelName", txtModel.Text.Trim());
                        cmd.Parameters.AddWithValue("@UnitType", cmbType.Text);
                        cmd.Parameters.AddWithValue("@Horsepower", cmbHP.Text);
                        cmd.Parameters.AddWithValue("@InverterStatus", cmbInverter.Text);
                        cmd.Parameters.AddWithValue("@WholesaleCost", nudCost.Value);
                        cmd.Parameters.AddWithValue("@AvailableStock", (int)nudStock.Value);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("New AC model successfully added to your company catalog!", "Catalog Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear_Click(sender, e);
                LoadSupplierCatalog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add catalog item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            if (selectedCatalogId <= 0)
            {
                MessageBox.Show("Please select an item from your catalog table first.", "Select Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"UPDATE SupplierCatalog 
                                     SET Brand = @Brand, 
                                         ModelName = @ModelName, 
                                         UnitType = @UnitType, 
                                         Horsepower = @Horsepower, 
                                         InverterStatus = @InverterStatus, 
                                         WholesaleCost = @WholesaleCost, 
                                         AvailableStock = @AvailableStock, 
                                         UpdatedAt = GETDATE() 
                                     WHERE CatalogID = @CatalogID AND SupplierID = @SupplierID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CatalogID", selectedCatalogId);
                        cmd.Parameters.AddWithValue("@SupplierID", UserSession.SupplierID.Value);
                        cmd.Parameters.AddWithValue("@Brand", txtBrand.Text.Trim());
                        cmd.Parameters.AddWithValue("@ModelName", txtModel.Text.Trim());
                        cmd.Parameters.AddWithValue("@UnitType", cmbType.Text);
                        cmd.Parameters.AddWithValue("@Horsepower", cmbHP.Text);
                        cmd.Parameters.AddWithValue("@InverterStatus", cmbInverter.Text);
                        cmd.Parameters.AddWithValue("@WholesaleCost", nudCost.Value);
                        cmd.Parameters.AddWithValue("@AvailableStock", (int)nudStock.Value);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Catalog stock and pricing updated successfully!", "Stock Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSupplierCatalog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update catalog: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDispatch_Click(object sender, EventArgs e)
        {
            if (dgvIncomingPOs.CurrentRow == null)
            {
                MessageBox.Show("Please select a Purchase Order from the table first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                DataGridViewRow row = dgvIncomingPOs.CurrentRow;
                int poId = Convert.ToInt32(row.Cells["colPOID"].Value);
                string currentStatus = row.Cells["colPOStatus"].Value?.ToString() ?? "";

                if (currentStatus == "Received")
                {
                    MessageBox.Show("This order has already been received and finalized by COLLAINE RAC.", "Order Finalized", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (currentStatus.StartsWith("Dispatched", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("This purchase order has ALREADY been dispatched and is currently in transit!", "Already Dispatched", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult dr = MessageBox.Show(
                    $"Notify COLLAINE RAC that PO #{poId} has been dispatched and is currently in transit?\n\nThis will automatically deduct the ordered units from your Factory Available Stock.",
                    "Confirm Dispatch", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        using (SqlTransaction trans = conn.BeginTransaction())
                        {
                            try
                            {
                                // 1. Automatically decrease factory stocks in SupplierCatalog
                                string deductStockQuery = @"
                                    UPDATE cat
                                    SET cat.AvailableStock = CASE 
                                                                WHEN cat.AvailableStock >= poi.QuantityOrdered 
                                                                THEN cat.AvailableStock - poi.QuantityOrdered 
                                                                ELSE 0 
                                                             END,
                                        cat.UpdatedAt = GETDATE()
                                    FROM SupplierCatalog cat
                                    INNER JOIN Inventory inv 
                                        ON inv.Brand = cat.Brand 
                                       AND inv.Model = cat.ModelName 
                                       AND inv.UnitType = cat.UnitType 
                                       AND inv.Horsepower = cat.Horsepower
                                    INNER JOIN PurchaseOrderItems poi 
                                        ON poi.ItemID = inv.ItemID
                                    WHERE poi.POID = @POID AND cat.SupplierID = @SupplierID";

                                using (SqlCommand cmdDeduct = new SqlCommand(deductStockQuery, conn, trans))
                                {
                                    cmdDeduct.Parameters.AddWithValue("@POID", poId);
                                    cmdDeduct.Parameters.AddWithValue("@SupplierID", UserSession.SupplierID.Value);
                                    cmdDeduct.ExecuteNonQuery();
                                }

                                // 2. Update PO status to Dispatched
                                string updateQuery = @"
                                    UPDATE PurchaseOrders 
                                    SET Status = 'Dispatched / In Transit', 
                                        Notes = ISNULL(Notes, '') + ' [Dispatched by supplier on ' + CONVERT(NVARCHAR, GETDATE(), 120) + ']' 
                                    WHERE POID = @POID AND SupplierID = @SupplierID";

                                using (SqlCommand cmd = new SqlCommand(updateQuery, conn, trans))
                                {
                                    cmd.Parameters.AddWithValue("@POID", poId);
                                    cmd.Parameters.AddWithValue("@SupplierID", UserSession.SupplierID.Value);
                                    cmd.ExecuteNonQuery();
                                }

                                trans.Commit();

                                MessageBox.Show(
                                    "Status updated to 'Dispatched / In Transit'!\nFactory stock has been automatically deducted.\nCOLLAINE RAC can now receive the goods.",
                                    "Dispatched & Stock Deducted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LoadIncomingPOs();
                                LoadSupplierCatalog();
                            }
                            catch (Exception exInner)
                            {
                                trans.Rollback();
                                throw exInner;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error dispatching order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            selectedCatalogId = 0;
            txtBrand.Clear();
            txtModel.Clear();
            if (cmbType.Items.Count > 0) cmbType.SelectedIndex = 0;
            if (cmbHP.Items.Count > 0) cmbHP.SelectedIndex = 2;
            if (cmbInverter.Items.Count > 0) cmbInverter.SelectedIndex = 0;
            nudCost.Value = 0;
            nudStock.Value = 0;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            UserSession.Clear();
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }
    }
}
