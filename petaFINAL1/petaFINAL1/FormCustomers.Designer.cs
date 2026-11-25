namespace petaFINAL1
{
    partial class FormCustomers
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValidID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCustomerDetails = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtValidID = new System.Windows.Forms.TextBox();
            this.lblValidID = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.grpCustomerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnRefresh);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.lblSearch);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(984, 70);
            this.pnlTop.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(882, 38);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 25);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(125, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(14, 44);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(108, 13);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search Name / Addr:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(268, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Customer Directory & Records";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colContact,
            this.colAddress,
            this.colValidID,
            this.colDateReg,
            this.colStatus});
            this.dgvCustomers.Location = new System.Drawing.Point(12, 76);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(960, 310);
            this.dgvCustomers.TabIndex = 1;
            // 
            // colID
            // 
            this.colID.FillWeight = 40F;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Full Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colContact
            // 
            this.colContact.FillWeight = 80F;
            this.colContact.HeaderText = "Contact #";
            this.colContact.Name = "colContact";
            this.colContact.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.FillWeight = 130F;
            this.colAddress.HeaderText = "Installation Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colValidID
            // 
            this.colValidID.HeaderText = "Valid ID Info";
            this.colValidID.Name = "colValidID";
            this.colValidID.ReadOnly = true;
            // 
            // colDateReg
            // 
            this.colDateReg.FillWeight = 70F;
            this.colDateReg.HeaderText = "Date Registered";
            this.colDateReg.Name = "colDateReg";
            this.colDateReg.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.FillWeight = 60F;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // grpCustomerDetails
            // 
            this.grpCustomerDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCustomerDetails.Controls.Add(this.btnUpdate);
            this.grpCustomerDetails.Controls.Add(this.btnAdd);
            this.grpCustomerDetails.Controls.Add(this.cmbStatus);
            this.grpCustomerDetails.Controls.Add(this.lblStatus);
            this.grpCustomerDetails.Controls.Add(this.txtValidID);
            this.grpCustomerDetails.Controls.Add(this.lblValidID);
            this.grpCustomerDetails.Controls.Add(this.txtAddress);
            this.grpCustomerDetails.Controls.Add(this.lblAddress);
            this.grpCustomerDetails.Controls.Add(this.txtContact);
            this.grpCustomerDetails.Controls.Add(this.lblContact);
            this.grpCustomerDetails.Controls.Add(this.txtName);
            this.grpCustomerDetails.Controls.Add(this.lblName);
            this.grpCustomerDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerDetails.Location = new System.Drawing.Point(12, 395);
            this.grpCustomerDetails.Name = "grpCustomerDetails";
            this.grpCustomerDetails.Size = new System.Drawing.Size(960, 193);
            this.grpCustomerDetails.TabIndex = 2;
            this.grpCustomerDetails.TabStop = false;
            this.grpCustomerDetails.Text = "Customer Details / Register Client";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(215, 145);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 32);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update Client";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(90, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 32);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "➕ Add Customer";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Good Standing",
            "Blacklisted"});
            this.cmbStatus.Location = new System.Drawing.Point(620, 65);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(180, 23);
            this.cmbStatus.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(530, 68);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 15);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status:";
            // 
            // txtValidID
            // 
            this.txtValidID.Location = new System.Drawing.Point(620, 27);
            this.txtValidID.Name = "txtValidID";
            this.txtValidID.Size = new System.Drawing.Size(315, 23);
            this.txtValidID.TabIndex = 7;
            // 
            // lblValidID
            // 
            this.lblValidID.AutoSize = true;
            this.lblValidID.Location = new System.Drawing.Point(530, 30);
            this.lblValidID.Name = "lblValidID";
            this.lblValidID.Size = new System.Drawing.Size(73, 15);
            this.lblValidID.TabIndex = 6;
            this.lblValidID.Text = "Valid ID Info:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(90, 97);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(390, 40);
            this.txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(15, 100);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 15);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address:";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(90, 62);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(260, 23);
            this.txtContact.TabIndex = 3;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(15, 65);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(62, 15);
            this.lblContact.TabIndex = 2;
            this.lblContact.Text = "Contact #:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 23);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Full Name:";
            // 
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 600);
            this.Controls.Add(this.grpCustomerDetails);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.pnlTop);
            this.Name = "FormCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Directory & Records";
            this.Load += new System.EventHandler(this.FormCustomers_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.grpCustomerDetails.ResumeLayout(false);
            this.grpCustomerDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValidID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.GroupBox grpCustomerDetails;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblValidID;
        private System.Windows.Forms.TextBox txtValidID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
    }
}