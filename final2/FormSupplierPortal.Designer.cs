namespace test1
{
    partial class FormSupplierPortal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblPortalTitle = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.tabSupplier = new System.Windows.Forms.TabControl();
            this.tabCatalog = new System.Windows.Forms.TabPage();
            this.dgvCatalog = new System.Windows.Forms.DataGridView();
            this.colCatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCatBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCatModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCatType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCatHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCatInverter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCatCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCatStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCatUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCatalogAction = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.lblStock = new System.Windows.Forms.Label();
            this.nudCost = new System.Windows.Forms.NumericUpDown();
            this.lblCost = new System.Windows.Forms.Label();
            this.cmbInverter = new System.Windows.Forms.ComboBox();
            this.lblInverter = new System.Windows.Forms.Label();
            this.cmbHP = new System.Windows.Forms.ComboBox();
            this.lblHP = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.tabPOs = new System.Windows.Forms.TabPage();
            this.btnDispatch = new System.Windows.Forms.Button();
            this.lblPOTitle = new System.Windows.Forms.Label();
            this.dgvIncomingPOs = new System.Windows.Forms.DataGridView();
            this.colPOID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPODate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPOItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPOQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPOTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPOStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPONotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            this.tabSupplier.SuspendLayout();
            this.tabCatalog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).BeginInit();
            this.grpCatalogAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).BeginInit();
            this.tabPOs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomingPOs)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            this.pnlTop.Controls.Add(this.btnSignOut);
            this.pnlTop.Controls.Add(this.lblUserInfo);
            this.pnlTop.Controls.Add(this.lblSub);
            this.pnlTop.Controls.Add(this.lblPortalTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1064, 80);
            this.pnlTop.TabIndex = 0;
            // 
            // lblPortalTitle
            // 
            this.lblPortalTitle.AutoSize = true;
            this.lblPortalTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortalTitle.ForeColor = System.Drawing.Color.White;
            this.lblPortalTitle.Location = new System.Drawing.Point(18, 14);
            this.lblPortalTitle.Name = "lblPortalTitle";
            this.lblPortalTitle.Size = new System.Drawing.Size(365, 30);
            this.lblPortalTitle.TabIndex = 0;
            this.lblPortalTitle.Text = "🏢 Supplier B2B Portal - COLLAINE";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(250)))));
            this.lblSub.Location = new System.Drawing.Point(23, 49);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(380, 15);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Manage your company warehouse stock and view purchase orders";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInfo.ForeColor = System.Drawing.Color.White;
            this.lblUserInfo.Location = new System.Drawing.Point(620, 25);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(330, 25);
            this.lblUserInfo.TabIndex = 2;
            this.lblUserInfo.Text = "👤 Supplier Rep";
            this.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Location = new System.Drawing.Point(960, 20);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(90, 35);
            this.btnSignOut.TabIndex = 3;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // tabSupplier
            // 
            this.tabSupplier.Controls.Add(this.tabCatalog);
            this.tabSupplier.Controls.Add(this.tabPOs);
            this.tabSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSupplier.Location = new System.Drawing.Point(0, 80);
            this.tabSupplier.Name = "tabSupplier";
            this.tabSupplier.SelectedIndex = 0;
            this.tabSupplier.Size = new System.Drawing.Size(1064, 601);
            this.tabSupplier.TabIndex = 1;
            // 
            // tabCatalog
            // 
            this.tabCatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.tabCatalog.Controls.Add(this.grpCatalogAction);
            this.tabCatalog.Controls.Add(this.dgvCatalog);
            this.tabCatalog.Location = new System.Drawing.Point(4, 26);
            this.tabCatalog.Name = "tabCatalog";
            this.tabCatalog.Padding = new System.Windows.Forms.Padding(12);
            this.tabCatalog.Size = new System.Drawing.Size(1056, 571);
            this.tabCatalog.TabIndex = 0;
            this.tabCatalog.Text = "📦 Our Company Catalog & Available Stocks";
            // 
            // dgvCatalog
            // 
            this.dgvCatalog.AllowUserToAddRows = false;
            this.dgvCatalog.AllowUserToDeleteRows = false;
            this.dgvCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCatalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCatalog.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatalog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCatalog.ColumnHeadersHeight = 32;
            this.dgvCatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCatID,
            this.colCatBrand,
            this.colCatModel,
            this.colCatType,
            this.colCatHP,
            this.colCatInverter,
            this.colCatCost,
            this.colCatStock,
            this.colCatUpdated});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatalog.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCatalog.EnableHeadersVisualStyles = false;
            this.dgvCatalog.Location = new System.Drawing.Point(12, 12);
            this.dgvCatalog.MultiSelect = false;
            this.dgvCatalog.Name = "dgvCatalog";
            this.dgvCatalog.ReadOnly = true;
            this.dgvCatalog.RowHeadersVisible = false;
            this.dgvCatalog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalog.Size = new System.Drawing.Size(1032, 350);
            this.dgvCatalog.TabIndex = 0;
            this.dgvCatalog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalog_CellClick);
            // 
            // colCatID
            // 
            this.colCatID.FillWeight = 40F;
            this.colCatID.HeaderText = "ID";
            this.colCatID.Name = "colCatID";
            this.colCatID.ReadOnly = true;
            // 
            // colCatBrand
            // 
            this.colCatBrand.FillWeight = 80F;
            this.colCatBrand.HeaderText = "Brand";
            this.colCatBrand.Name = "colCatBrand";
            this.colCatBrand.ReadOnly = true;
            // 
            // colCatModel
            // 
            this.colCatModel.FillWeight = 160F;
            this.colCatModel.HeaderText = "Model Name";
            this.colCatModel.Name = "colCatModel";
            this.colCatModel.ReadOnly = true;
            // 
            // colCatType
            // 
            this.colCatType.FillWeight = 100F;
            this.colCatType.HeaderText = "Type";
            this.colCatType.Name = "colCatType";
            this.colCatType.ReadOnly = true;
            // 
            // colCatHP
            // 
            this.colCatHP.FillWeight = 70F;
            this.colCatHP.HeaderText = "HP";
            this.colCatHP.Name = "colCatHP";
            this.colCatHP.ReadOnly = true;
            // 
            // colCatInverter
            // 
            this.colCatInverter.FillWeight = 85F;
            this.colCatInverter.HeaderText = "Inverter";
            this.colCatInverter.Name = "colCatInverter";
            this.colCatInverter.ReadOnly = true;
            // 
            // colCatCost
            // 
            this.colCatCost.FillWeight = 95F;
            this.colCatCost.HeaderText = "Wholesale Price";
            this.colCatCost.Name = "colCatCost";
            this.colCatCost.ReadOnly = true;
            // 
            // colCatStock
            // 
            this.colCatStock.FillWeight = 85F;
            this.colCatStock.HeaderText = "Factory Stock";
            this.colCatStock.Name = "colCatStock";
            this.colCatStock.ReadOnly = true;
            // 
            // colCatUpdated
            // 
            this.colCatUpdated.FillWeight = 100F;
            this.colCatUpdated.HeaderText = "Last Updated";
            this.colCatUpdated.Name = "colCatUpdated";
            this.colCatUpdated.ReadOnly = true;
            // 
            // grpCatalogAction
            // 
            this.grpCatalogAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCatalogAction.BackColor = System.Drawing.Color.White;
            this.grpCatalogAction.Controls.Add(this.btnClear);
            this.grpCatalogAction.Controls.Add(this.btnUpdateItem);
            this.grpCatalogAction.Controls.Add(this.btnAddItem);
            this.grpCatalogAction.Controls.Add(this.nudStock);
            this.grpCatalogAction.Controls.Add(this.lblStock);
            this.grpCatalogAction.Controls.Add(this.nudCost);
            this.grpCatalogAction.Controls.Add(this.lblCost);
            this.grpCatalogAction.Controls.Add(this.cmbInverter);
            this.grpCatalogAction.Controls.Add(this.lblInverter);
            this.grpCatalogAction.Controls.Add(this.cmbHP);
            this.grpCatalogAction.Controls.Add(this.lblHP);
            this.grpCatalogAction.Controls.Add(this.cmbType);
            this.grpCatalogAction.Controls.Add(this.lblType);
            this.grpCatalogAction.Controls.Add(this.txtModel);
            this.grpCatalogAction.Controls.Add(this.lblModel);
            this.grpCatalogAction.Controls.Add(this.txtBrand);
            this.grpCatalogAction.Controls.Add(this.lblBrand);
            this.grpCatalogAction.Location = new System.Drawing.Point(12, 375);
            this.grpCatalogAction.Name = "grpCatalogAction";
            this.grpCatalogAction.Size = new System.Drawing.Size(1032, 185);
            this.grpCatalogAction.TabIndex = 1;
            this.grpCatalogAction.TabStop = false;
            this.grpCatalogAction.Text = "Manage Our Company Stock & Wholesale Prices";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(15, 35);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(48, 19);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Brand:";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(90, 32);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(180, 25);
            this.txtBrand.TabIndex = 1;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(300, 35);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(51, 19);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(370, 32);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(300, 25);
            this.txtModel.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(700, 35);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(41, 19);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type:";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Split Type",
            "Window Type",
            "Cassette Type",
            "Floor Mounted"});
            this.cmbType.Location = new System.Drawing.Point(760, 32);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(180, 25);
            this.cmbType.TabIndex = 5;
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(15, 80);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(30, 19);
            this.lblHP.TabIndex = 6;
            this.lblHP.Text = "HP:";
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
            this.cmbHP.Location = new System.Drawing.Point(90, 77);
            this.cmbHP.Name = "cmbHP";
            this.cmbHP.Size = new System.Drawing.Size(180, 25);
            this.cmbHP.TabIndex = 7;
            // 
            // lblInverter
            // 
            this.lblInverter.AutoSize = true;
            this.lblInverter.Location = new System.Drawing.Point(300, 80);
            this.lblInverter.Name = "lblInverter";
            this.lblInverter.Size = new System.Drawing.Size(59, 19);
            this.lblInverter.TabIndex = 8;
            this.lblInverter.Text = "Inverter:";
            // 
            // cmbInverter
            // 
            this.cmbInverter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInverter.FormattingEnabled = true;
            this.cmbInverter.Items.AddRange(new object[] {
            "Inverter",
            "Non-Inverter"});
            this.cmbInverter.Location = new System.Drawing.Point(370, 77);
            this.cmbInverter.Name = "cmbInverter";
            this.cmbInverter.Size = new System.Drawing.Size(140, 25);
            this.cmbInverter.TabIndex = 9;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(530, 80);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(107, 19);
            this.lblCost.TabIndex = 10;
            this.lblCost.Text = "Wholesale (PHP):";
            // 
            // nudCost
            // 
            this.nudCost.DecimalPlaces = 2;
            this.nudCost.Location = new System.Drawing.Point(645, 77);
            this.nudCost.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudCost.Name = "nudCost";
            this.nudCost.Size = new System.Drawing.Size(120, 25);
            this.nudCost.TabIndex = 11;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(790, 80);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(95, 19);
            this.lblStock.TabIndex = 12;
            this.lblStock.Text = "Factory Stock:";
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(895, 77);
            this.nudStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(90, 25);
            this.nudStock.TabIndex = 13;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(580, 130);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(185, 38);
            this.btnAddItem.TabIndex = 14;
            this.btnAddItem.Text = "➕ Add to Catalog";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.btnUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItem.ForeColor = System.Drawing.Color.White;
            this.btnUpdateItem.Location = new System.Drawing.Point(780, 130);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(150, 38);
            this.btnUpdateItem.TabIndex = 15;
            this.btnUpdateItem.Text = "💾 Save Stock";
            this.btnUpdateItem.UseVisualStyleBackColor = false;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            this.btnClear.Location = new System.Drawing.Point(940, 130);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 38);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tabPOs
            // 
            this.tabPOs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.tabPOs.Controls.Add(this.btnDispatch);
            this.tabPOs.Controls.Add(this.lblPOTitle);
            this.tabPOs.Controls.Add(this.dgvIncomingPOs);
            this.tabPOs.Location = new System.Drawing.Point(4, 26);
            this.tabPOs.Name = "tabPOs";
            this.tabPOs.Padding = new System.Windows.Forms.Padding(12);
            this.tabPOs.Size = new System.Drawing.Size(1056, 571);
            this.tabPOs.TabIndex = 1;
            this.tabPOs.Text = "📋 Purchase Orders from COLLAINE RAC";
            // 
            // lblPOTitle
            // 
            this.lblPOTitle.AutoSize = true;
            this.lblPOTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            this.lblPOTitle.Location = new System.Drawing.Point(12, 15);
            this.lblPOTitle.Name = "lblPOTitle";
            this.lblPOTitle.Size = new System.Drawing.Size(350, 21);
            this.lblPOTitle.TabIndex = 0;
            this.lblPOTitle.Text = "Purchase Orders Placed by COLLAINE to Us";
            // 
            // dgvIncomingPOs
            // 
            this.dgvIncomingPOs.AllowUserToAddRows = false;
            this.dgvIncomingPOs.AllowUserToDeleteRows = false;
            this.dgvIncomingPOs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIncomingPOs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIncomingPOs.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIncomingPOs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIncomingPOs.ColumnHeadersHeight = 32;
            this.dgvIncomingPOs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPOID,
            this.colPODate,
            this.colPOItem,
            this.colPOQty,
            this.colPOTotal,
            this.colPOStatus,
            this.colPONotes});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIncomingPOs.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIncomingPOs.EnableHeadersVisualStyles = false;
            this.dgvIncomingPOs.Location = new System.Drawing.Point(12, 45);
            this.dgvIncomingPOs.MultiSelect = false;
            this.dgvIncomingPOs.Name = "dgvIncomingPOs";
            this.dgvIncomingPOs.ReadOnly = true;
            this.dgvIncomingPOs.RowHeadersVisible = false;
            this.dgvIncomingPOs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncomingPOs.Size = new System.Drawing.Size(1032, 460);
            this.dgvIncomingPOs.TabIndex = 1;
            // 
            // colPOID
            // 
            this.colPOID.FillWeight = 50F;
            this.colPOID.HeaderText = "PO #";
            this.colPOID.Name = "colPOID";
            this.colPOID.ReadOnly = true;
            // 
            // colPODate
            // 
            this.colPODate.FillWeight = 80F;
            this.colPODate.HeaderText = "Order Date";
            this.colPODate.Name = "colPODate";
            this.colPODate.ReadOnly = true;
            // 
            // colPOItem
            // 
            this.colPOItem.FillWeight = 160F;
            this.colPOItem.HeaderText = "Item Description";
            this.colPOItem.Name = "colPOItem";
            this.colPOItem.ReadOnly = true;
            // 
            // colPOQty
            // 
            this.colPOQty.FillWeight = 50F;
            this.colPOQty.HeaderText = "Qty";
            this.colPOQty.Name = "colPOQty";
            this.colPOQty.ReadOnly = true;
            // 
            // colPOTotal
            // 
            this.colPOTotal.FillWeight = 80F;
            this.colPOTotal.HeaderText = "Total Cost";
            this.colPOTotal.Name = "colPOTotal";
            this.colPOTotal.ReadOnly = true;
            // 
            // colPOStatus
            // 
            this.colPOStatus.FillWeight = 80F;
            this.colPOStatus.HeaderText = "Status";
            this.colPOStatus.Name = "colPOStatus";
            this.colPOStatus.ReadOnly = true;
            // 
            // colPONotes
            // 
            this.colPONotes.FillWeight = 110F;
            this.colPONotes.HeaderText = "Delivery Notes";
            this.colPONotes.Name = "colPONotes";
            this.colPONotes.ReadOnly = true;
            // 
            // btnDispatch
            // 
            this.btnDispatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDispatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            this.btnDispatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDispatch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispatch.ForeColor = System.Drawing.Color.White;
            this.btnDispatch.Location = new System.Drawing.Point(740, 515);
            this.btnDispatch.Name = "btnDispatch";
            this.btnDispatch.Size = new System.Drawing.Size(304, 42);
            this.btnDispatch.TabIndex = 2;
            this.btnDispatch.Text = "🚚 Mark as Dispatched / In Transit";
            this.btnDispatch.UseVisualStyleBackColor = false;
            this.btnDispatch.Click += new System.EventHandler(this.btnDispatch_Click);
            // 
            // FormSupplierPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.tabSupplier);
            this.Controls.Add(this.pnlTop);
            this.Name = "FormSupplierPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier B2B Portal - COLLAINE";
            this.Load += new System.EventHandler(this.FormSupplierPortal_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tabSupplier.ResumeLayout(false);
            this.tabCatalog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).EndInit();
            this.grpCatalogAction.ResumeLayout(false);
            this.grpCatalogAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).EndInit();
            this.tabPOs.ResumeLayout(false);
            this.tabPOs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomingPOs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblPortalTitle;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.TabControl tabSupplier;
        private System.Windows.Forms.TabPage tabCatalog;
        private System.Windows.Forms.DataGridView dgvCatalog;
        private System.Windows.Forms.GroupBox grpCatalogAction;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.ComboBox cmbHP;
        private System.Windows.Forms.Label lblInverter;
        private System.Windows.Forms.ComboBox cmbInverter;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.NumericUpDown nudCost;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCatBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCatModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCatType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCatHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCatInverter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCatCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCatStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCatUpdated;
        private System.Windows.Forms.TabPage tabPOs;
        private System.Windows.Forms.Label lblPOTitle;
        private System.Windows.Forms.DataGridView dgvIncomingPOs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPOID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPODate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPOItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPOQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPOTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPOStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPONotes;
        private System.Windows.Forms.Button btnDispatch;
    }
}
