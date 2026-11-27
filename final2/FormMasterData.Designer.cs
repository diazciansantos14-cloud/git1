namespace test1
{
    partial class FormMasterData
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
            this.tabMaster = new System.Windows.Forms.TabControl();
            this.tabBrands = new System.Windows.Forms.TabPage();
            this.dgvBrands = new System.Windows.Forms.DataGridView();
            this.pnlBrandInput = new System.Windows.Forms.Panel();
            this.btnAddBrand = new System.Windows.Forms.Button();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.tabTypes = new System.Windows.Forms.TabPage();
            this.dgvTypes = new System.Windows.Forms.DataGridView();
            this.pnlTypeInput = new System.Windows.Forms.Panel();
            this.btnAddType = new System.Windows.Forms.Button();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.tabHP = new System.Windows.Forms.TabPage();
            this.dgvHP = new System.Windows.Forms.DataGridView();
            this.pnlHPInput = new System.Windows.Forms.Panel();
            this.btnAddHP = new System.Windows.Forms.Button();
            this.txtHPRating = new System.Windows.Forms.TextBox();
            this.lblHP = new System.Windows.Forms.Label();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.pnlSupplierInput = new System.Windows.Forms.Panel();
            this.txtSupAddress = new System.Windows.Forms.TextBox();
            this.lblSupAddress = new System.Windows.Forms.Label();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.txtSupContact = new System.Windows.Forms.TextBox();
            this.lblSupContact = new System.Windows.Forms.Label();
            this.txtSupPerson = new System.Windows.Forms.TextBox();
            this.lblSupPerson = new System.Windows.Forms.Label();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.lblSupName = new System.Windows.Forms.Label();
            this.tabPayMethods = new System.Windows.Forms.TabPage();
            this.dgvPayMethods = new System.Windows.Forms.DataGridView();
            this.pnlPayMethodInput = new System.Windows.Forms.Panel();
            this.btnAddPayMethod = new System.Windows.Forms.Button();
            this.txtPayMethodName = new System.Windows.Forms.TextBox();
            this.lblPayMethodName = new System.Windows.Forms.Label();
            this.tabMaster.SuspendLayout();
            this.tabBrands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrands)).BeginInit();
            this.pnlBrandInput.SuspendLayout();
            this.tabTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).BeginInit();
            this.pnlTypeInput.SuspendLayout();
            this.tabHP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHP)).BeginInit();
            this.pnlHPInput.SuspendLayout();
            this.tabSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.pnlSupplierInput.SuspendLayout();
            this.tabPayMethods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayMethods)).BeginInit();
            this.pnlPayMethodInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1000, 75);
            this.pnlTop.TabIndex = 0;
            // 
            // tabMaster
            // 
            this.tabMaster.Controls.Add(this.tabBrands);
            this.tabMaster.Controls.Add(this.tabTypes);
            this.tabMaster.Controls.Add(this.tabHP);
            this.tabMaster.Controls.Add(this.tabSuppliers);
            this.tabMaster.Controls.Add(this.tabPayMethods);
            this.tabMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMaster.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMaster.Location = new System.Drawing.Point(0, 75);
            this.tabMaster.Name = "tabMaster";
            this.tabMaster.SelectedIndex = 0;
            this.tabMaster.Size = new System.Drawing.Size(1000, 525);
            this.tabMaster.TabIndex = 1;
            // 
            // tabBrands
            // 
            this.tabBrands.Controls.Add(this.dgvBrands);
            this.tabBrands.Controls.Add(this.pnlBrandInput);
            this.tabBrands.Location = new System.Drawing.Point(4, 26);
            this.tabBrands.Name = "tabBrands";
            this.tabBrands.Padding = new System.Windows.Forms.Padding(15);
            this.tabBrands.Size = new System.Drawing.Size(992, 495);
            this.tabBrands.TabIndex = 0;
            this.tabBrands.Text = "🏷️ AC Brands";
            this.tabBrands.UseVisualStyleBackColor = true;
            // 
            // dgvBrands
            // 
            this.dgvBrands.AllowUserToAddRows = false;
            this.dgvBrands.AllowUserToDeleteRows = false;
            this.dgvBrands.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBrands.BackgroundColor = System.Drawing.Color.White;
            this.dgvBrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBrands.Location = new System.Drawing.Point(15, 75);
            this.dgvBrands.Name = "dgvBrands";
            this.dgvBrands.ReadOnly = true;
            this.dgvBrands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBrands.Size = new System.Drawing.Size(962, 405);
            this.dgvBrands.TabIndex = 1;
            // 
            // pnlBrandInput
            // 
            this.pnlBrandInput.Controls.Add(this.btnAddBrand);
            this.pnlBrandInput.Controls.Add(this.txtBrandName);
            this.pnlBrandInput.Controls.Add(this.lblBrandName);
            this.pnlBrandInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBrandInput.Location = new System.Drawing.Point(15, 15);
            this.pnlBrandInput.Name = "pnlBrandInput";
            this.pnlBrandInput.Size = new System.Drawing.Size(962, 60);
            this.pnlBrandInput.TabIndex = 0;
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            this.btnAddBrand.FlatAppearance.BorderSize = 0;
            this.btnAddBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBrand.ForeColor = System.Drawing.Color.White;
            this.btnAddBrand.Location = new System.Drawing.Point(400, 12);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(160, 32);
            this.btnAddBrand.TabIndex = 2;
            this.btnAddBrand.Text = "➕  Add Brand";
            this.btnAddBrand.UseVisualStyleBackColor = false;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(145, 16);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(235, 25);
            this.txtBrandName.TabIndex = 1;
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Location = new System.Drawing.Point(15, 19);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(114, 17);
            this.lblBrandName.TabIndex = 0;
            this.lblBrandName.Text = "New Brand Name:";
            // 
            // tabTypes
            // 
            this.tabTypes.Controls.Add(this.dgvTypes);
            this.tabTypes.Controls.Add(this.pnlTypeInput);
            this.tabTypes.Location = new System.Drawing.Point(4, 26);
            this.tabTypes.Name = "tabTypes";
            this.tabTypes.Padding = new System.Windows.Forms.Padding(15);
            this.tabTypes.Size = new System.Drawing.Size(992, 495);
            this.tabTypes.TabIndex = 1;
            this.tabTypes.Text = "❄️ AC Unit Types";
            this.tabTypes.UseVisualStyleBackColor = true;
            // 
            // dgvTypes
            // 
            this.dgvTypes.AllowUserToAddRows = false;
            this.dgvTypes.AllowUserToDeleteRows = false;
            this.dgvTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTypes.Location = new System.Drawing.Point(15, 75);
            this.dgvTypes.Name = "dgvTypes";
            this.dgvTypes.ReadOnly = true;
            this.dgvTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTypes.Size = new System.Drawing.Size(962, 405);
            this.dgvTypes.TabIndex = 2;
            // 
            // pnlTypeInput
            // 
            this.pnlTypeInput.Controls.Add(this.btnAddType);
            this.pnlTypeInput.Controls.Add(this.txtTypeName);
            this.pnlTypeInput.Controls.Add(this.lblTypeName);
            this.pnlTypeInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTypeInput.Location = new System.Drawing.Point(15, 15);
            this.pnlTypeInput.Name = "pnlTypeInput";
            this.pnlTypeInput.Size = new System.Drawing.Size(962, 60);
            this.pnlTypeInput.TabIndex = 1;
            // 
            // btnAddType
            // 
            this.btnAddType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            this.btnAddType.FlatAppearance.BorderSize = 0;
            this.btnAddType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddType.ForeColor = System.Drawing.Color.White;
            this.btnAddType.Location = new System.Drawing.Point(400, 12);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(160, 32);
            this.btnAddType.TabIndex = 2;
            this.btnAddType.Text = "➕  Add Unit Type";
            this.btnAddType.UseVisualStyleBackColor = false;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(145, 16);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(235, 25);
            this.txtTypeName.TabIndex = 1;
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Location = new System.Drawing.Point(15, 19);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(104, 17);
            this.lblTypeName.TabIndex = 0;
            this.lblTypeName.Text = "Unit Type Name:";
            // 
            // tabHP
            // 
            this.tabHP.Controls.Add(this.dgvHP);
            this.tabHP.Controls.Add(this.pnlHPInput);
            this.tabHP.Location = new System.Drawing.Point(4, 26);
            this.tabHP.Name = "tabHP";
            this.tabHP.Padding = new System.Windows.Forms.Padding(15);
            this.tabHP.Size = new System.Drawing.Size(992, 495);
            this.tabHP.TabIndex = 2;
            this.tabHP.Text = "⚡ Horsepower (HP)";
            this.tabHP.UseVisualStyleBackColor = true;
            // 
            // dgvHP
            // 
            this.dgvHP.AllowUserToAddRows = false;
            this.dgvHP.AllowUserToDeleteRows = false;
            this.dgvHP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHP.BackgroundColor = System.Drawing.Color.White;
            this.dgvHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHP.Location = new System.Drawing.Point(15, 75);
            this.dgvHP.Name = "dgvHP";
            this.dgvHP.ReadOnly = true;
            this.dgvHP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHP.Size = new System.Drawing.Size(962, 405);
            this.dgvHP.TabIndex = 2;
            // 
            // pnlHPInput
            // 
            this.pnlHPInput.Controls.Add(this.btnAddHP);
            this.pnlHPInput.Controls.Add(this.txtHPRating);
            this.pnlHPInput.Controls.Add(this.lblHP);
            this.pnlHPInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHPInput.Location = new System.Drawing.Point(15, 15);
            this.pnlHPInput.Name = "pnlHPInput";
            this.pnlHPInput.Size = new System.Drawing.Size(962, 60);
            this.pnlHPInput.TabIndex = 1;
            // 
            // btnAddHP
            // 
            this.btnAddHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            this.btnAddHP.FlatAppearance.BorderSize = 0;
            this.btnAddHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHP.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHP.ForeColor = System.Drawing.Color.White;
            this.btnAddHP.Location = new System.Drawing.Point(400, 12);
            this.btnAddHP.Name = "btnAddHP";
            this.btnAddHP.Size = new System.Drawing.Size(160, 32);
            this.btnAddHP.TabIndex = 2;
            this.btnAddHP.Text = "➕  Add HP Rating";
            this.btnAddHP.UseVisualStyleBackColor = false;
            this.btnAddHP.Click += new System.EventHandler(this.btnAddHP_Click);
            // 
            // txtHPRating
            // 
            this.txtHPRating.Location = new System.Drawing.Point(145, 16);
            this.txtHPRating.Name = "txtHPRating";
            this.txtHPRating.Size = new System.Drawing.Size(235, 25);
            this.txtHPRating.TabIndex = 1;
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(15, 19);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(98, 17);
            this.lblHP.TabIndex = 0;
            this.lblHP.Text = "New HP Rating:";
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.Controls.Add(this.dgvSuppliers);
            this.tabSuppliers.Controls.Add(this.pnlSupplierInput);
            this.tabSuppliers.Location = new System.Drawing.Point(4, 26);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Padding = new System.Windows.Forms.Padding(15);
            this.tabSuppliers.Size = new System.Drawing.Size(992, 495);
            this.tabSuppliers.TabIndex = 3;
            this.tabSuppliers.Text = "🏢 Suppliers";
            this.tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuppliers.BackgroundColor = System.Drawing.Color.White;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuppliers.Location = new System.Drawing.Point(15, 140);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.Size = new System.Drawing.Size(962, 340);
            this.dgvSuppliers.TabIndex = 1;
            // 
            // pnlSupplierInput
            // 
            this.pnlSupplierInput.Controls.Add(this.txtSupAddress);
            this.pnlSupplierInput.Controls.Add(this.lblSupAddress);
            this.pnlSupplierInput.Controls.Add(this.btnAddSupplier);
            this.pnlSupplierInput.Controls.Add(this.txtSupContact);
            this.pnlSupplierInput.Controls.Add(this.lblSupContact);
            this.pnlSupplierInput.Controls.Add(this.txtSupPerson);
            this.pnlSupplierInput.Controls.Add(this.lblSupPerson);
            this.pnlSupplierInput.Controls.Add(this.txtSupName);
            this.pnlSupplierInput.Controls.Add(this.lblSupName);
            this.pnlSupplierInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSupplierInput.Location = new System.Drawing.Point(15, 15);
            this.pnlSupplierInput.Name = "pnlSupplierInput";
            this.pnlSupplierInput.Size = new System.Drawing.Size(962, 125);
            this.pnlSupplierInput.TabIndex = 0;
            // 
            // txtSupAddress
            // 
            this.txtSupAddress.Location = new System.Drawing.Point(145, 82);
            this.txtSupAddress.Name = "txtSupAddress";
            this.txtSupAddress.Size = new System.Drawing.Size(605, 25);
            this.txtSupAddress.TabIndex = 7;
            // 
            // lblSupAddress
            // 
            this.lblSupAddress.AutoSize = true;
            this.lblSupAddress.Location = new System.Drawing.Point(15, 85);
            this.lblSupAddress.Name = "lblSupAddress";
            this.lblSupAddress.Size = new System.Drawing.Size(59, 17);
            this.lblSupAddress.TabIndex = 6;
            this.lblSupAddress.Text = "Address:";
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            this.btnAddSupplier.FlatAppearance.BorderSize = 0;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.Location = new System.Drawing.Point(775, 78);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(170, 34);
            this.btnAddSupplier.TabIndex = 8;
            this.btnAddSupplier.Text = "➕  Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // txtSupContact
            // 
            this.txtSupContact.Location = new System.Drawing.Point(560, 46);
            this.txtSupContact.Name = "txtSupContact";
            this.txtSupContact.Size = new System.Drawing.Size(190, 25);
            this.txtSupContact.TabIndex = 5;
            // 
            // lblSupContact
            // 
            this.lblSupContact.AutoSize = true;
            this.lblSupContact.Location = new System.Drawing.Point(450, 49);
            this.lblSupContact.Name = "lblSupContact";
            this.lblSupContact.Size = new System.Drawing.Size(80, 17);
            this.lblSupContact.TabIndex = 4;
            this.lblSupContact.Text = "Contact No.:";
            // 
            // txtSupPerson
            // 
            this.txtSupPerson.Location = new System.Drawing.Point(145, 46);
            this.txtSupPerson.Name = "txtSupPerson";
            this.txtSupPerson.Size = new System.Drawing.Size(270, 25);
            this.txtSupPerson.TabIndex = 3;
            // 
            // lblSupPerson
            // 
            this.lblSupPerson.AutoSize = true;
            this.lblSupPerson.Location = new System.Drawing.Point(15, 49);
            this.lblSupPerson.Name = "lblSupPerson";
            this.lblSupPerson.Size = new System.Drawing.Size(99, 17);
            this.lblSupPerson.TabIndex = 2;
            this.lblSupPerson.Text = "Contact Person:";
            // 
            // txtSupName
            // 
            this.txtSupName.Location = new System.Drawing.Point(145, 10);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(605, 25);
            this.txtSupName.TabIndex = 1;
            // 
            // lblSupName
            // 
            this.lblSupName.AutoSize = true;
            this.lblSupName.Location = new System.Drawing.Point(15, 13);
            this.lblSupName.Name = "lblSupName";
            this.lblSupName.Size = new System.Drawing.Size(118, 17);
            this.lblSupName.TabIndex = 0;
            this.lblSupName.Text = "Supplier Company:";
            // 
            // tabPayMethods
            // 
            this.tabPayMethods.Controls.Add(this.dgvPayMethods);
            this.tabPayMethods.Controls.Add(this.pnlPayMethodInput);
            this.tabPayMethods.Location = new System.Drawing.Point(4, 26);
            this.tabPayMethods.Name = "tabPayMethods";
            this.tabPayMethods.Padding = new System.Windows.Forms.Padding(15);
            this.tabPayMethods.Size = new System.Drawing.Size(992, 495);
            this.tabPayMethods.TabIndex = 4;
            this.tabPayMethods.Text = "Payment Methods";
            this.tabPayMethods.UseVisualStyleBackColor = true;
            // 
            // dgvPayMethods
            // 
            this.dgvPayMethods.AllowUserToAddRows = false;
            this.dgvPayMethods.AllowUserToDeleteRows = false;
            this.dgvPayMethods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayMethods.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayMethods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayMethods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayMethods.Location = new System.Drawing.Point(15, 75);
            this.dgvPayMethods.Name = "dgvPayMethods";
            this.dgvPayMethods.ReadOnly = true;
            this.dgvPayMethods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayMethods.Size = new System.Drawing.Size(962, 405);
            this.dgvPayMethods.TabIndex = 1;
            // 
            // pnlPayMethodInput
            // 
            this.pnlPayMethodInput.Controls.Add(this.btnAddPayMethod);
            this.pnlPayMethodInput.Controls.Add(this.txtPayMethodName);
            this.pnlPayMethodInput.Controls.Add(this.lblPayMethodName);
            this.pnlPayMethodInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPayMethodInput.Location = new System.Drawing.Point(15, 15);
            this.pnlPayMethodInput.Name = "pnlPayMethodInput";
            this.pnlPayMethodInput.Size = new System.Drawing.Size(962, 60);
            this.pnlPayMethodInput.TabIndex = 0;
            // 
            // btnAddPayMethod
            // 
            this.btnAddPayMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            this.btnAddPayMethod.FlatAppearance.BorderSize = 0;
            this.btnAddPayMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPayMethod.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPayMethod.ForeColor = System.Drawing.Color.White;
            this.btnAddPayMethod.Location = new System.Drawing.Point(400, 12);
            this.btnAddPayMethod.Name = "btnAddPayMethod";
            this.btnAddPayMethod.Size = new System.Drawing.Size(200, 32);
            this.btnAddPayMethod.TabIndex = 2;
            this.btnAddPayMethod.Text = "Add Payment Method";
            this.btnAddPayMethod.UseVisualStyleBackColor = false;
            this.btnAddPayMethod.Click += new System.EventHandler(this.btnAddPayMethod_Click);
            // 
            // txtPayMethodName
            // 
            this.txtPayMethodName.Location = new System.Drawing.Point(145, 16);
            this.txtPayMethodName.Name = "txtPayMethodName";
            this.txtPayMethodName.Size = new System.Drawing.Size(235, 25);
            this.txtPayMethodName.TabIndex = 1;
            // 
            // lblPayMethodName
            // 
            this.lblPayMethodName.AutoSize = true;
            this.lblPayMethodName.Location = new System.Drawing.Point(15, 19);
            this.lblPayMethodName.Name = "lblPayMethodName";
            this.lblPayMethodName.Size = new System.Drawing.Size(96, 17);
            this.lblPayMethodName.TabIndex = 0;
            this.lblPayMethodName.Text = "Method Name:";
            // 
            // FormMasterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabMaster);
            this.Controls.Add(this.pnlTop);
            this.Name = "FormMasterData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Management & Master Data";
            this.Load += new System.EventHandler(this.FormMasterData_Load);
            this.tabMaster.ResumeLayout(false);
            this.tabBrands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrands)).EndInit();
            this.pnlBrandInput.ResumeLayout(false);
            this.pnlBrandInput.PerformLayout();
            this.tabTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).EndInit();
            this.pnlTypeInput.ResumeLayout(false);
            this.pnlTypeInput.PerformLayout();
            this.tabHP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHP)).EndInit();
            this.pnlHPInput.ResumeLayout(false);
            this.pnlHPInput.PerformLayout();
            this.tabSuppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.pnlSupplierInput.ResumeLayout(false);
            this.pnlSupplierInput.PerformLayout();
            this.tabPayMethods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayMethods)).EndInit();
            this.pnlPayMethodInput.ResumeLayout(false);
            this.pnlPayMethodInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TabControl tabMaster;
        private System.Windows.Forms.TabPage tabBrands;
        private System.Windows.Forms.DataGridView dgvBrands;
        private System.Windows.Forms.Panel pnlBrandInput;
        private System.Windows.Forms.Button btnAddBrand;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.TabPage tabTypes;
        private System.Windows.Forms.DataGridView dgvTypes;
        private System.Windows.Forms.Panel pnlTypeInput;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.TabPage tabHP;
        private System.Windows.Forms.DataGridView dgvHP;
        private System.Windows.Forms.Panel pnlHPInput;
        private System.Windows.Forms.Button btnAddHP;
        private System.Windows.Forms.TextBox txtHPRating;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.TabPage tabSuppliers;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.Panel pnlSupplierInput;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.TextBox txtSupContact;
        private System.Windows.Forms.Label lblSupContact;
        private System.Windows.Forms.TextBox txtSupPerson;
        private System.Windows.Forms.Label lblSupPerson;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.Label lblSupName;
        private System.Windows.Forms.TextBox txtSupAddress;
        private System.Windows.Forms.TabPage tabPayMethods;
        private System.Windows.Forms.DataGridView dgvPayMethods;
        private System.Windows.Forms.Panel pnlPayMethodInput;
        private System.Windows.Forms.Button btnAddPayMethod;
        private System.Windows.Forms.TextBox txtPayMethodName;
        private System.Windows.Forms.Label lblPayMethodName;
        private System.Windows.Forms.Label lblSupAddress;
    }
}
