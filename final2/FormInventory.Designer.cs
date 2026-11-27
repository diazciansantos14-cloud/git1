namespace test1
{
    partial class FormInventory
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.chkInStockOnly = new System.Windows.Forms.CheckBox();
            this.cmbTypeFilter = new System.Windows.Forms.ComboBox();
            this.lblTypeFilter = new System.Windows.Forms.Label();
            this.cmbBrandFilter = new System.Windows.Forms.ComboBox();
            this.lblBrandFilter = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.colItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInverter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCashPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInstallPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpUnitDetails = new System.Windows.Forms.GroupBox();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnUpdateUnit = new System.Windows.Forms.Button();
            this.btnAddUnit = new System.Windows.Forms.Button();
            this.nudStockQty = new System.Windows.Forms.NumericUpDown();
            this.lblStockQty = new System.Windows.Forms.Label();
            this.nudInstallPrice = new System.Windows.Forms.NumericUpDown();
            this.lblInstallPrice = new System.Windows.Forms.Label();
            this.nudCashPrice = new System.Windows.Forms.NumericUpDown();
            this.lblCashPrice = new System.Windows.Forms.Label();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.lblSerial = new System.Windows.Forms.Label();
            this.cmbInverter = new System.Windows.Forms.ComboBox();
            this.lblInverter = new System.Windows.Forms.Label();
            this.cmbHP = new System.Windows.Forms.ComboBox();
            this.lblHP = new System.Windows.Forms.Label();
            this.cmbUnitType = new System.Windows.Forms.ComboBox();
            this.lblUnitType = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.grpUnitDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInstallPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCashPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnRefresh);
            this.pnlTop.Controls.Add(this.chkInStockOnly);
            this.pnlTop.Controls.Add(this.cmbTypeFilter);
            this.pnlTop.Controls.Add(this.lblTypeFilter);
            this.pnlTop.Controls.Add(this.cmbBrandFilter);
            this.pnlTop.Controls.Add(this.lblBrandFilter);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.lblSearch);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1076, 80);
            this.pnlTop.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(974, 43);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 25);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // chkInStockOnly
            // 
            this.chkInStockOnly.AutoSize = true;
            this.chkInStockOnly.Location = new System.Drawing.Point(600, 47);
            this.chkInStockOnly.Name = "chkInStockOnly";
            this.chkInStockOnly.Size = new System.Drawing.Size(120, 17);
            this.chkInStockOnly.TabIndex = 7;
            this.chkInStockOnly.Text = "Show In-Stock Only";
            this.chkInStockOnly.UseVisualStyleBackColor = true;
            // 
            // cmbTypeFilter
            // 
            this.cmbTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeFilter.FormattingEnabled = true;
            this.cmbTypeFilter.Items.AddRange(new object[] {
            "All Types",
            "Split Type",
            "Window Type",
            "Floor Mounted"});
            this.cmbTypeFilter.Location = new System.Drawing.Point(460, 45);
            this.cmbTypeFilter.Name = "cmbTypeFilter";
            this.cmbTypeFilter.Size = new System.Drawing.Size(120, 21);
            this.cmbTypeFilter.TabIndex = 6;
            // 
            // lblTypeFilter
            // 
            this.lblTypeFilter.AutoSize = true;
            this.lblTypeFilter.Location = new System.Drawing.Point(420, 48);
            this.lblTypeFilter.Name = "lblTypeFilter";
            this.lblTypeFilter.Size = new System.Drawing.Size(34, 13);
            this.lblTypeFilter.TabIndex = 5;
            this.lblTypeFilter.Text = "Type:";
            // 
            // cmbBrandFilter
            // 
            this.cmbBrandFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrandFilter.FormattingEnabled = true;
            this.cmbBrandFilter.Items.AddRange(new object[] {
            "All Brands",
            "Carrier",
            "Daikin",
            "Panasonic",
            "TCL",
            "Condura"});
            this.cmbBrandFilter.Location = new System.Drawing.Point(284, 45);
            this.cmbBrandFilter.Name = "cmbBrandFilter";
            this.cmbBrandFilter.Size = new System.Drawing.Size(120, 21);
            this.cmbBrandFilter.TabIndex = 4;
            // 
            // lblBrandFilter
            // 
            this.lblBrandFilter.AutoSize = true;
            this.lblBrandFilter.Location = new System.Drawing.Point(240, 48);
            this.lblBrandFilter.Name = "lblBrandFilter";
            this.lblBrandFilter.Size = new System.Drawing.Size(38, 13);
            this.lblBrandFilter.TabIndex = 3;
            this.lblBrandFilter.Text = "Brand:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(65, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(14, 48);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search:";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemID,
            this.colBrand,
            this.colModel,
            this.colUnitType,
            this.colHP,
            this.colInverter,
            this.colSerial,
            this.colCashPrice,
            this.colInstallPrice,
            this.colStockQty});
            this.dgvInventory.Location = new System.Drawing.Point(12, 86);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(1052, 280);
            this.dgvInventory.TabIndex = 1;
            this.dgvInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellClick);
            // 
            // colItemID
            // 
            this.colItemID.FillWeight = 40F;
            this.colItemID.HeaderText = "ID";
            this.colItemID.Name = "colItemID";
            this.colItemID.ReadOnly = true;
            // 
            // colBrand
            // 
            this.colBrand.HeaderText = "Brand";
            this.colBrand.Name = "colBrand";
            this.colBrand.ReadOnly = true;
            // 
            // colModel
            // 
            this.colModel.HeaderText = "Model";
            this.colModel.Name = "colModel";
            this.colModel.ReadOnly = true;
            // 
            // colUnitType
            // 
            this.colUnitType.HeaderText = "Type";
            this.colUnitType.Name = "colUnitType";
            this.colUnitType.ReadOnly = true;
            // 
            // colHP
            // 
            this.colHP.FillWeight = 60F;
            this.colHP.HeaderText = "HP";
            this.colHP.Name = "colHP";
            this.colHP.ReadOnly = true;
            // 
            // colInverter
            // 
            this.colInverter.FillWeight = 80F;
            this.colInverter.HeaderText = "Inverter";
            this.colInverter.Name = "colInverter";
            this.colInverter.ReadOnly = true;
            // 
            // colSerial
            // 
            this.colSerial.HeaderText = "Serial Number";
            this.colSerial.Name = "colSerial";
            this.colSerial.ReadOnly = true;
            // 
            // colCashPrice
            // 
            this.colCashPrice.HeaderText = "Cash Price (₱)";
            this.colCashPrice.Name = "colCashPrice";
            this.colCashPrice.ReadOnly = true;
            // 
            // colInstallPrice
            // 
            this.colInstallPrice.HeaderText = "Installment (₱)";
            this.colInstallPrice.Name = "colInstallPrice";
            this.colInstallPrice.ReadOnly = true;
            // 
            // colStockQty
            // 
            this.colStockQty.FillWeight = 50F;
            this.colStockQty.HeaderText = "Stock";
            this.colStockQty.Name = "colStockQty";
            this.colStockQty.ReadOnly = true;
            // 
            // grpUnitDetails
            // 
            this.grpUnitDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpUnitDetails.Controls.Add(this.btnClearFields);
            this.grpUnitDetails.Controls.Add(this.btnUpdateUnit);
            this.grpUnitDetails.Controls.Add(this.btnAddUnit);
            this.grpUnitDetails.Controls.Add(this.nudStockQty);
            this.grpUnitDetails.Controls.Add(this.lblStockQty);
            this.grpUnitDetails.Controls.Add(this.nudInstallPrice);
            this.grpUnitDetails.Controls.Add(this.lblInstallPrice);
            this.grpUnitDetails.Controls.Add(this.nudCashPrice);
            this.grpUnitDetails.Controls.Add(this.lblCashPrice);
            this.grpUnitDetails.Controls.Add(this.txtSerialNo);
            this.grpUnitDetails.Controls.Add(this.lblSerial);
            this.grpUnitDetails.Controls.Add(this.cmbInverter);
            this.grpUnitDetails.Controls.Add(this.lblInverter);
            this.grpUnitDetails.Controls.Add(this.cmbHP);
            this.grpUnitDetails.Controls.Add(this.lblHP);
            this.grpUnitDetails.Controls.Add(this.cmbUnitType);
            this.grpUnitDetails.Controls.Add(this.lblUnitType);
            this.grpUnitDetails.Controls.Add(this.txtModel);
            this.grpUnitDetails.Controls.Add(this.lblModel);
            this.grpUnitDetails.Controls.Add(this.cmbBrand);
            this.grpUnitDetails.Controls.Add(this.lblBrand);
            this.grpUnitDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUnitDetails.Location = new System.Drawing.Point(12, 380);
            this.grpUnitDetails.Name = "grpUnitDetails";
            this.grpUnitDetails.Size = new System.Drawing.Size(1052, 208);
            this.grpUnitDetails.TabIndex = 2;
            this.grpUnitDetails.TabStop = false;
            this.grpUnitDetails.Text = "AC Unit Details / Stock In";
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(411, 151);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(130, 32);
            this.btnClearFields.TabIndex = 22;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnUpdateUnit
            // 
            this.btnUpdateUnit.Location = new System.Drawing.Point(254, 151);
            this.btnUpdateUnit.Name = "btnUpdateUnit";
            this.btnUpdateUnit.Size = new System.Drawing.Size(130, 32);
            this.btnUpdateUnit.TabIndex = 21;
            this.btnUpdateUnit.Text = " Update Selected";
            this.btnUpdateUnit.UseVisualStyleBackColor = true;
            this.btnUpdateUnit.Click += new System.EventHandler(this.btnUpdateUnit_Click);
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.Location = new System.Drawing.Point(90, 151);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(130, 32);
            this.btnAddUnit.TabIndex = 20;
            this.btnAddUnit.Text = "➕ Add New Unit";
            this.btnAddUnit.UseVisualStyleBackColor = true;
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // nudStockQty
            // 
            this.nudStockQty.Location = new System.Drawing.Point(743, 97);
            this.nudStockQty.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudStockQty.Name = "nudStockQty";
            this.nudStockQty.Size = new System.Drawing.Size(160, 23);
            this.nudStockQty.TabIndex = 19;
            // 
            // lblStockQty
            // 
            this.lblStockQty.AutoSize = true;
            this.lblStockQty.Location = new System.Drawing.Point(625, 100);
            this.lblStockQty.Name = "lblStockQty";
            this.lblStockQty.Size = new System.Drawing.Size(88, 15);
            this.lblStockQty.TabIndex = 18;
            this.lblStockQty.Text = "Stock Quantity:";
            // 
            // nudInstallPrice
            // 
            this.nudInstallPrice.DecimalPlaces = 2;
            this.nudInstallPrice.Location = new System.Drawing.Point(743, 62);
            this.nudInstallPrice.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.nudInstallPrice.Name = "nudInstallPrice";
            this.nudInstallPrice.Size = new System.Drawing.Size(160, 23);
            this.nudInstallPrice.TabIndex = 17;
            this.nudInstallPrice.ThousandsSeparator = true;
            // 
            // lblInstallPrice
            // 
            this.lblInstallPrice.AutoSize = true;
            this.lblInstallPrice.Location = new System.Drawing.Point(625, 65);
            this.lblInstallPrice.Name = "lblInstallPrice";
            this.lblInstallPrice.Size = new System.Drawing.Size(115, 15);
            this.lblInstallPrice.TabIndex = 16;
            this.lblInstallPrice.Text = "Installment ₱ (Total):";
            // 
            // nudCashPrice
            // 
            this.nudCashPrice.DecimalPlaces = 2;
            this.nudCashPrice.Location = new System.Drawing.Point(743, 27);
            this.nudCashPrice.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.nudCashPrice.Name = "nudCashPrice";
            this.nudCashPrice.Size = new System.Drawing.Size(160, 23);
            this.nudCashPrice.TabIndex = 15;
            this.nudCashPrice.ThousandsSeparator = true;
            // 
            // lblCashPrice
            // 
            this.lblCashPrice.AutoSize = true;
            this.lblCashPrice.Location = new System.Drawing.Point(625, 30);
            this.lblCashPrice.Name = "lblCashPrice";
            this.lblCashPrice.Size = new System.Drawing.Size(83, 15);
            this.lblCashPrice.TabIndex = 14;
            this.lblCashPrice.Text = "Cash Price (₱):";
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Location = new System.Drawing.Point(395, 97);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(180, 23);
            this.txtSerialNo.TabIndex = 11;
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(310, 100);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(57, 15);
            this.lblSerial.TabIndex = 10;
            this.lblSerial.Text = "Serial No:";
            // 
            // cmbInverter
            // 
            this.cmbInverter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInverter.FormattingEnabled = true;
            this.cmbInverter.Items.AddRange(new object[] {
            "Inverter",
            "Non-Inverter"});
            this.cmbInverter.Location = new System.Drawing.Point(395, 62);
            this.cmbInverter.Name = "cmbInverter";
            this.cmbInverter.Size = new System.Drawing.Size(180, 23);
            this.cmbInverter.TabIndex = 9;
            // 
            // lblInverter
            // 
            this.lblInverter.AutoSize = true;
            this.lblInverter.Location = new System.Drawing.Point(310, 65);
            this.lblInverter.Name = "lblInverter";
            this.lblInverter.Size = new System.Drawing.Size(50, 15);
            this.lblInverter.TabIndex = 8;
            this.lblInverter.Text = "Inverter:";
            // 
            // cmbHP
            // 
            this.cmbHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHP.FormattingEnabled = true;
            this.cmbHP.Items.AddRange(new object[] {
            "0.5 HP",
            "0.75 HP",
            "1.0 HP",
            "1.5 HP",
            "2.0 HP",
            "2.5 HP",
            "3.0 HP"});
            this.cmbHP.Location = new System.Drawing.Point(395, 27);
            this.cmbHP.Name = "cmbHP";
            this.cmbHP.Size = new System.Drawing.Size(180, 23);
            this.cmbHP.TabIndex = 7;
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(310, 30);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(74, 15);
            this.lblHP.TabIndex = 6;
            this.lblHP.Text = "Horsepower:";
            // 
            // cmbUnitType
            // 
            this.cmbUnitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitType.FormattingEnabled = true;
            this.cmbUnitType.Items.AddRange(new object[] {
            "Split Type",
            "Window Type",
            "Floor Mounted"});
            this.cmbUnitType.Location = new System.Drawing.Point(90, 97);
            this.cmbUnitType.Name = "cmbUnitType";
            this.cmbUnitType.Size = new System.Drawing.Size(180, 23);
            this.cmbUnitType.TabIndex = 5;
            // 
            // lblUnitType
            // 
            this.lblUnitType.AutoSize = true;
            this.lblUnitType.Location = new System.Drawing.Point(15, 100);
            this.lblUnitType.Name = "lblUnitType";
            this.lblUnitType.Size = new System.Drawing.Size(59, 15);
            this.lblUnitType.TabIndex = 4;
            this.lblUnitType.Text = "Unit Type:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(90, 62);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(180, 23);
            this.txtModel.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(15, 65);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(44, 15);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model:";
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Items.AddRange(new object[] {
            "Carrier",
            "Daikin",
            "Panasonic",
            "TCL",
            "Condura",
            "Midea"});
            this.cmbBrand.Location = new System.Drawing.Point(90, 27);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(180, 23);
            this.cmbBrand.TabIndex = 1;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(15, 30);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(41, 15);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Brand:";
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 600);
            this.Controls.Add(this.grpUnitDetails);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.pnlTop);
            this.Name = "FormInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RAC AC Inventory & Stock Management";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.grpUnitDetails.ResumeLayout(false);
            this.grpUnitDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInstallPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCashPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblBrandFilter;
        private System.Windows.Forms.ComboBox cmbBrandFilter;
        private System.Windows.Forms.Label lblTypeFilter;
        private System.Windows.Forms.ComboBox cmbTypeFilter;
        private System.Windows.Forms.CheckBox chkInStockOnly;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInverter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCashPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInstallPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockQty;
        private System.Windows.Forms.GroupBox grpUnitDetails;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblUnitType;
        private System.Windows.Forms.ComboBox cmbUnitType;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.ComboBox cmbHP;
        private System.Windows.Forms.Label lblInverter;
        private System.Windows.Forms.ComboBox cmbInverter;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.Label lblCashPrice;
        private System.Windows.Forms.NumericUpDown nudCashPrice;
        private System.Windows.Forms.Label lblInstallPrice;
        private System.Windows.Forms.NumericUpDown nudInstallPrice;
        private System.Windows.Forms.Label lblStockQty;
        private System.Windows.Forms.NumericUpDown nudStockQty;
        private System.Windows.Forms.Button btnAddUnit;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnUpdateUnit;
    }
}
