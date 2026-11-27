namespace test1
{
    partial class FormInstallations
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
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.dgvInstallations = new System.Windows.Forms.DataGridView();
            this.colContractID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInstallDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnConfirmInstalled = new System.Windows.Forms.Button();
            this.cmbTechnician = new System.Windows.Forms.ComboBox();
            this.lblTech = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallations)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.btnRefresh);
            this.pnlTop.Controls.Add(this.cmbFilterStatus);
            this.pnlTop.Controls.Add(this.lblFilter);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.lblSearch);
            this.pnlTop.Controls.Add(this.lblSub);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1020, 80);
            this.pnlTop.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(920, 42);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 25);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbFilterStatus
            // 
            this.cmbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterStatus.FormattingEnabled = true;
            this.cmbFilterStatus.Items.AddRange(new object[] {
            "Pending Installation (Not yet deducted)",
            "Installed / Completed",
            "All Records"});
            this.cmbFilterStatus.Location = new System.Drawing.Point(490, 44);
            this.cmbFilterStatus.Name = "cmbFilterStatus";
            this.cmbFilterStatus.Size = new System.Drawing.Size(240, 21);
            this.cmbFilterStatus.TabIndex = 5;
            this.cmbFilterStatus.SelectedIndexChanged += new System.EventHandler(this.cmbFilterStatus_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(440, 47);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(40, 13);
            this.lblFilter.TabIndex = 4;
            this.lblFilter.Text = "Status:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(125, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 20);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(14, 47);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(108, 13);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search Name / Addr:";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.ForeColor = System.Drawing.Color.Gray;
            this.lblSub.Location = new System.Drawing.Point(14, 28);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(0, 13);
            this.lblSub.TabIndex = 1;
            // 
            // dgvInstallations
            // 
            this.dgvInstallations.AllowUserToAddRows = false;
            this.dgvInstallations.AllowUserToDeleteRows = false;
            this.dgvInstallations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInstallations.BackgroundColor = System.Drawing.Color.White;
            this.dgvInstallations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstallations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colContractID,
            this.colCustomer,
            this.colContact,
            this.colAddress,
            this.colItemID,
            this.colUnit,
            this.colSerial,
            this.colSaleDate,
            this.colStatus,
            this.colInstallDate,
            this.colTech});
            this.dgvInstallations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInstallations.Location = new System.Drawing.Point(0, 80);
            this.dgvInstallations.MultiSelect = false;
            this.dgvInstallations.Name = "dgvInstallations";
            this.dgvInstallations.ReadOnly = true;
            this.dgvInstallations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInstallations.Size = new System.Drawing.Size(1020, 465);
            this.dgvInstallations.TabIndex = 1;
            this.dgvInstallations.SelectionChanged += new System.EventHandler(this.dgvInstallations_SelectionChanged);
            // 
            // colContractID
            // 
            this.colContractID.FillWeight = 45F;
            this.colContractID.HeaderText = "Contract #";
            this.colContractID.Name = "colContractID";
            this.colContractID.ReadOnly = true;
            // 
            // colCustomer
            // 
            this.colCustomer.HeaderText = "Customer Name";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.ReadOnly = true;
            // 
            // colContact
            // 
            this.colContact.FillWeight = 75F;
            this.colContact.HeaderText = "Contact #";
            this.colContact.Name = "colContact";
            this.colContact.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.FillWeight = 120F;
            this.colAddress.HeaderText = "Installation Site Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colItemID
            // 
            this.colItemID.HeaderText = "ItemID";
            this.colItemID.Name = "colItemID";
            this.colItemID.ReadOnly = true;
            this.colItemID.Visible = false;
            // 
            // colUnit
            // 
            this.colUnit.FillWeight = 110F;
            this.colUnit.HeaderText = "AC Unit Model";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            // 
            // colSerial
            // 
            this.colSerial.FillWeight = 75F;
            this.colSerial.HeaderText = "Serial #";
            this.colSerial.Name = "colSerial";
            this.colSerial.ReadOnly = true;
            // 
            // colSaleDate
            // 
            this.colSaleDate.FillWeight = 65F;
            this.colSaleDate.HeaderText = "Order Date";
            this.colSaleDate.Name = "colSaleDate";
            this.colSaleDate.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.FillWeight = 85F;
            this.colStatus.HeaderText = "Install Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colInstallDate
            // 
            this.colInstallDate.FillWeight = 75F;
            this.colInstallDate.HeaderText = "Date Installed";
            this.colInstallDate.Name = "colInstallDate";
            this.colInstallDate.ReadOnly = true;
            // 
            // colTech
            // 
            this.colTech.FillWeight = 80F;
            this.colTech.HeaderText = "Technician";
            this.colTech.Name = "colTech";
            this.colTech.ReadOnly = true;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.btnConfirmInstalled);
            this.pnlBottom.Controls.Add(this.cmbTechnician);
            this.pnlBottom.Controls.Add(this.lblTech);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 545);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1020, 70);
            this.pnlBottom.TabIndex = 2;
            // 
            // btnConfirmInstalled
            // 
            this.btnConfirmInstalled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmInstalled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.btnConfirmInstalled.FlatAppearance.BorderSize = 0;
            this.btnConfirmInstalled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmInstalled.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmInstalled.ForeColor = System.Drawing.Color.White;
            this.btnConfirmInstalled.Location = new System.Drawing.Point(620, 15);
            this.btnConfirmInstalled.Name = "btnConfirmInstalled";
            this.btnConfirmInstalled.Size = new System.Drawing.Size(385, 42);
            this.btnConfirmInstalled.TabIndex = 2;
            this.btnConfirmInstalled.Text = "🔧  Confirm Installation && Deduct 1 Unit From Stock";
            this.btnConfirmInstalled.UseVisualStyleBackColor = false;
            this.btnConfirmInstalled.Click += new System.EventHandler(this.btnConfirmInstalled_Click);
            // 
            // cmbTechnician
            // 
            this.cmbTechnician.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTechnician.FormattingEnabled = true;
            this.cmbTechnician.Location = new System.Drawing.Point(165, 24);
            this.cmbTechnician.Name = "cmbTechnician";
            this.cmbTechnician.Size = new System.Drawing.Size(260, 21);
            this.cmbTechnician.TabIndex = 1;
            // 
            // lblTech
            // 
            this.lblTech.AutoSize = true;
            this.lblTech.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTech.Location = new System.Drawing.Point(20, 28);
            this.lblTech.Name = "lblTech";
            this.lblTech.Size = new System.Drawing.Size(130, 15);
            this.lblTech.TabIndex = 0;
            this.lblTech.Text = "Lead Technician Name:";
            // 
            // FormInstallations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1020, 615);
            this.Controls.Add(this.dgvInstallations);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "FormInstallations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AC Job Orders & Installations";
            this.Load += new System.EventHandler(this.FormInstallations_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallations)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvInstallations;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTech;
        private System.Windows.Forms.ComboBox cmbTechnician;
        private System.Windows.Forms.Button btnConfirmInstalled;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContractID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInstallDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTech;
    }
}
