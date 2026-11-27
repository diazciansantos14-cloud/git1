using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace test1
{
    public partial class FormPurchaseOrders : Form
    {
        public FormPurchaseOrders()
        {
            InitializeComponent();
        }

        private void FormPurchaseOrders_Load(object sender, EventArgs e)
        {
            LoadSuppliersDropdown();
            LoadPurchaseOrders();
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
                    cmbSupplier.SelectedIndex = 0; // Trigger selection of first supplier
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // CASCADING DROPDOWN: Filters AC items specifically to the selected supplier!
        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSupplier.SelectedValue != null && int.TryParse(cmbSupplier.SelectedValue.ToString(), out int supplierId))
            {
                LoadItemsBySupplier(supplierId);
            }
        }

        private void LoadItemsBySupplier(int supplierId)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // PRIMARY: Pull directly from SupplierCatalog so ALL models the supplier offers
                    // are shown — even ones not yet in Inventory (that's the whole point of a PO).
                    // LEFT JOIN Inventory so we can still get the ItemID if it exists, and show
                    // catalog items that have no Inventory row yet (ItemID will be NULL for those).
                    string query = @"
                        SELECT  cat.CatalogID,
                                ISNULL(inv.ItemID, -1)                                   AS ItemID,
                                cat.Brand + ' ' + cat.ModelName
                                    + ' (' + cat.Horsepower + ' ' + cat.UnitType + ')'  AS DisplayName,
                                cat.WholesaleCost                                        AS CostPrice
                        FROM    SupplierCatalog cat
                        OUTER APPLY (
                            SELECT TOP 1 i.ItemID
                            FROM Inventory i
                            WHERE i.Brand = cat.Brand 
                              AND i.Model = cat.ModelName
                              AND i.UnitType = cat.UnitType
                              AND i.Horsepower = cat.Horsepower
                        ) inv
                        WHERE   cat.SupplierID = @SupplierID
                        ORDER BY cat.Brand, cat.ModelName, cat.Horsepower";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierID", supplierId);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Fallback: if SupplierCatalog has nothing for this supplier,
                        // fall back to Inventory filtered by brand.
                        if (dt.Rows.Count == 0)
                        {
                            string fallback = @"
                                SELECT  ItemID AS CatalogID,
                                        ItemID,
                                        Brand + ' ' + Model + ' (' + Horsepower + ' ' + UnitType + ')' AS DisplayName,
                                        CostPrice
                                FROM    Inventory
                                WHERE   Brand IN (SELECT DISTINCT Brand FROM SupplierCatalog WHERE SupplierID = @SupplierID)
                                ORDER BY Brand, Model";
                            using (SqlCommand cmdFb = new SqlCommand(fallback, conn))
                            {
                                cmdFb.Parameters.AddWithValue("@SupplierID", supplierId);
                                SqlDataAdapter daFb = new SqlDataAdapter(cmdFb);
                                daFb.Fill(dt);
                            }
                        }

                        cmbItem.DataSource = dt;
                        cmbItem.DisplayMember = "DisplayName";
                        cmbItem.ValueMember = "CatalogID";
                        if (dt.Rows.Count > 0)
                        {
                            cmbItem.SelectedIndex = 0;
                            cmbItem_SelectedIndexChanged(null, null);
                        }
                        else
                        {
                            cmbItem.SelectedIndex = -1;
                            nudUnitCost.Value = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading supplier models: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadPurchaseOrders()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT po.POID, po.PONumber, s.SupplierName, 
                                            inv.Brand + ' ' + inv.Model + ' (' + inv.Horsepower + ')' AS ACUnit,
                                            poi.QuantityOrdered, poi.UnitCost, poi.TotalCost,
                                            po.OrderDate, po.Status, po.ReceivedDate
                                     FROM PurchaseOrders po
                                     INNER JOIN Suppliers s ON po.SupplierID = s.SupplierID
                                     INNER JOIN PurchaseOrderItems poi ON po.POID = poi.POID
                                     INNER JOIN Inventory inv ON poi.ItemID = inv.ItemID
                                     ORDER BY po.POID DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    colPOID.DataPropertyName = "POID";
                    colPONumber.DataPropertyName = "PONumber";
                    colSupplier.DataPropertyName = "SupplierName";
                    colACUnit.DataPropertyName = "ACUnit";
                    colQty.DataPropertyName = "QuantityOrdered";
                    colCost.DataPropertyName = "UnitCost";
                    colTotal.DataPropertyName = "TotalCost";
                    colDate.DataPropertyName = "OrderDate";
                    colStatus.DataPropertyName = "Status";
                    colReceived.DataPropertyName = "ReceivedDate";

                    colCost.DefaultCellStyle.Format = "₱#,##0.00";
                    colTotal.DefaultCellStyle.Format = "₱#,##0.00";

                    dgvPOs.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading POs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbItem.SelectedItem is DataRowView drv)
            {
                if (decimal.TryParse(drv["CostPrice"].ToString(), out decimal cost))
                {
                    nudUnitCost.Value = cost;
                }
            }
        }

        // 1. CREATE PURCHASE ORDER (Status = 'Ordered' -> Stock does NOT increase yet!)
        private void btnCreatePO_Click(object sender, EventArgs e)
        {
            if (cmbSupplier.SelectedIndex == -1 || cmbItem.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both a Supplier and an AC Model to order!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView drv = cmbItem.SelectedItem as DataRowView;
            if (drv == null)
            {
                MessageBox.Show("Please select an AC Model to order!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int supplierId = Convert.ToInt32(cmbSupplier.SelectedValue);
            int itemId = Convert.ToInt32(drv["ItemID"]);
            int catalogId = Convert.ToInt32(drv["CatalogID"]);
            int qty = (int)nudQuantity.Value;
            decimal unitCost = nudUnitCost.Value;
            decimal totalCost = qty * unitCost;
            string poNumber = "PO-" + DateTime.Now.ToString("yyyyMMdd-HHmm");

            // If the selected item came from SupplierCatalog only (no Inventory row yet),
            // ItemID will be -1. We auto-create an Inventory row at 0 stock so the FK is satisfied.
            // Stock will be added when Goods Receipt is confirmed.
            if (itemId == -1)
            {
                try
                {
                    using (SqlConnection connCheck = DatabaseHelper.GetConnection())
                    {
                        connCheck.Open();
                        // Get catalog info for this entry
                        string getCat = @"SELECT cat.Brand, cat.ModelName, cat.UnitType, cat.Horsepower, cat.InverterStatus, cat.WholesaleCost
                                          FROM SupplierCatalog cat
                                          WHERE cat.CatalogID = @CatalogID";
                        using (SqlCommand cmdCat = new SqlCommand(getCat, connCheck))
                        {
                            cmdCat.Parameters.AddWithValue("@CatalogID", catalogId);
                            using (SqlDataReader r = cmdCat.ExecuteReader())
                            {
                                if (r.Read())
                                {
                                    string brand = r["Brand"].ToString();
                                    string model = r["ModelName"].ToString();
                                    string utype = r["UnitType"].ToString();
                                    string hp    = r["Horsepower"].ToString();
                                    string inv   = r["InverterStatus"].ToString();
                                    decimal cost = r["WholesaleCost"] == DBNull.Value ? 0m : Convert.ToDecimal(r["WholesaleCost"]);

                                    r.Close();

                                    string brandCode = brand.Length >= 3 ? brand.Substring(0, 3).ToUpper() : brand.ToUpper();
                                    string hpClean = hp.Replace(" ", "").Replace("HP", "").Replace(".", "");
                                    string autoSerial = $"{brandCode}-{hpClean}-{new Random().Next(1000, 9999)}";

                                    // Insert a new Inventory row with 0 stock
                                    string insertInv = @"
    INSERT INTO Inventory
    (
        Brand,
        Model,
        UnitType,
        Horsepower,
        InverterStatus,
        SerialNumber,
        StockQty,
        CostPrice,
        CashPrice,
        InstallmentPrice
    )
    OUTPUT INSERTED.ItemID
    VALUES
    (
        @Brand,
        @Model,
        @UnitType,
        @HP,
        @Inv,
        @Serial,
        0,
        @Cost,
        @Cost,
        @Cost
    )";
                                    using (SqlCommand cmdInv = new SqlCommand(insertInv, connCheck))
                                    {
                                        cmdInv.Parameters.AddWithValue("@Brand", brand);
                                        cmdInv.Parameters.AddWithValue("@Model", model);
                                        cmdInv.Parameters.AddWithValue("@UnitType", utype);
                                        cmdInv.Parameters.AddWithValue("@HP", hp);
                                        cmdInv.Parameters.AddWithValue("@Inv", inv);
                                        cmdInv.Parameters.AddWithValue("@Serial", autoSerial);
                                        cmdInv.Parameters.AddWithValue("@Cost", cost);
                                        itemId = (int)cmdInv.ExecuteScalar();
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to create inventory entry for new catalog item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (SqlTransaction trans = conn.BeginTransaction())
                    {
                        try
                        {
                            // Insert PO Header
                            string insertPO = @"INSERT INTO PurchaseOrders (PONumber, SupplierID, OrderDate, ExpectedDelivery, TotalAmount, Status, Notes, CreatedBy)
                                                OUTPUT INSERTED.POID
                                                VALUES (@PONumber, @SupplierID, GETDATE(), @ExpectedDelivery, @TotalAmount, 'Ordered', @Notes, @CreatedBy)";

                            int poId;
                            using (SqlCommand cmdPO = new SqlCommand(insertPO, conn, trans))
                            {
                                cmdPO.Parameters.AddWithValue("@PONumber", poNumber);
                                cmdPO.Parameters.AddWithValue("@SupplierID", supplierId);
                                cmdPO.Parameters.AddWithValue("@ExpectedDelivery", dtpExpectedDelivery.Value.Date);
                                cmdPO.Parameters.AddWithValue("@TotalAmount", totalCost);
                                cmdPO.Parameters.AddWithValue("@Notes", string.IsNullOrWhiteSpace(txtNotes.Text) ? (object)DBNull.Value : txtNotes.Text.Trim());
                                cmdPO.Parameters.AddWithValue("@CreatedBy", UserSession.FullName ?? "Admin");
                                poId = (int)cmdPO.ExecuteScalar();
                            }

                            // Insert PO Item
                            string insertItem = @"INSERT INTO PurchaseOrderItems
                      (POID, ItemID, QuantityOrdered, QuantityReceived, UnitCost)
                      VALUES (@POID, @ItemID, @Qty, 0, @UnitCost)";

                            using (SqlCommand cmdItem = new SqlCommand(insertItem, conn, trans))
                            {
                                cmdItem.Parameters.AddWithValue("@POID", poId);
                                cmdItem.Parameters.AddWithValue("@ItemID", itemId);
                                cmdItem.Parameters.AddWithValue("@Qty", qty);
                                cmdItem.Parameters.AddWithValue("@UnitCost", unitCost);

                                cmdItem.ExecuteNonQuery();
                            }

                            trans.Commit();

                            MessageBox.Show(
                                $"Purchase Order {poNumber} successfully placed!\n\nSupplier: {cmbSupplier.Text}\nTotal: ₱{totalCost:N2}\n\nNotice: Physical inventory stock has NOT increased yet.\nStock will increase when you click 'Confirm Delivery / Goods Receipt' once the supplier arrives.",
                                "PO Placed (SAP MM Integration)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtNotes.Clear();
                            LoadPurchaseOrders();
                            LoadItemsBySupplier(supplierId);
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
                MessageBox.Show("Failed to create PO: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. GOODS RECEIPT (THIS IS WHERE PHYSICAL STOCK INCREASES!)
        private void btnReceiveGoods_Click(object sender, EventArgs e)
        {
            if (dgvPOs.CurrentRow == null)
            {
                MessageBox.Show("Please select a Purchase Order from the table to receive goods!", "Select Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int poId = Convert.ToInt32(dgvPOs.CurrentRow.Cells["colPOID"].Value);
                string status = dgvPOs.CurrentRow.Cells["colStatus"].Value?.ToString() ?? "";

                if (status == "Received")
                {
                    MessageBox.Show("This shipment has ALREADY been received! Stock was already incremented.", "Already Received", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Business Rule: Can only receive if Supplier marked it as Dispatched
                if (!status.StartsWith("Dispatched", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        $"Cannot receive this shipment yet!\n\nCurrent Status: '{status}'\n\nThe supplier must first dispatch the order from their B2B Supplier Portal before COLLAINE RAC can confirm delivery arrival and receive goods into stock.",
                        "Shipment Not Dispatched", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    $"Confirm goods receipt for PO #{poId}?\n\nThis will increment the physical warehouse stock quantity in Inventory.",
                    "Confirm Goods Receipt (SAP MM)", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes) return;

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (SqlTransaction trans = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Get PO Item details
                            string getItemQuery = "SELECT ItemID, QuantityOrdered FROM PurchaseOrderItems WHERE POID = @POID";
                            int itemId = 0, qty = 0;
                            using (SqlCommand cmdGet = new SqlCommand(getItemQuery, conn, trans))
                            {
                                cmdGet.Parameters.AddWithValue("@POID", poId);
                                using (SqlDataReader r = cmdGet.ExecuteReader())
                                {
                                    if (r.Read())
                                    {
                                        itemId = Convert.ToInt32(r["ItemID"]);
                                        qty = Convert.ToInt32(r["QuantityOrdered"]);
                                    }
                                }
                            }

                            // 2. INCREMENT PHYSICAL STOCK IN INVENTORY
                            string updateStock = "UPDATE Inventory SET StockQty = StockQty + @Qty WHERE ItemID = @ItemID";
                            using (SqlCommand cmdStock = new SqlCommand(updateStock, conn, trans))
                            {
                                cmdStock.Parameters.AddWithValue("@Qty", qty);
                                cmdStock.Parameters.AddWithValue("@ItemID", itemId);
                                cmdStock.ExecuteNonQuery();
                            }

                            // 3. Update PO Item received count
                            string updatePOItem = "UPDATE PurchaseOrderItems SET QuantityReceived = QuantityOrdered WHERE POID = @POID";
                            using (SqlCommand cmdItem = new SqlCommand(updatePOItem, conn, trans))
                            {
                                cmdItem.Parameters.AddWithValue("@POID", poId);
                                cmdItem.ExecuteNonQuery();
                            }

                            // 4. Update PO Header status to 'Received'
                            string updatePO = "UPDATE PurchaseOrders SET Status = 'Received', ReceivedDate = GETDATE() WHERE POID = @POID";
                            using (SqlCommand cmdPO = new SqlCommand(updatePO, conn, trans))
                            {
                                cmdPO.Parameters.AddWithValue("@POID", poId);
                                cmdPO.ExecuteNonQuery();
                            }

                            trans.Commit();

                            MessageBox.Show(
                                $"Goods Receipt Confirmed!\n\nAdded +{qty} units to Inventory Stock.\nPO Status updated to 'Received'.",
                                "Goods Receipt Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadPurchaseOrders();
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
                MessageBox.Show("Goods receipt failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
