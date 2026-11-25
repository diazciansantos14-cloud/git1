namespace RAC_System.Forms
{
    partial class FormMain
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblCurrentViewTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.dgvUpcomingDues = new System.Windows.Forms.DataGridView();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmountDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUpcomingTitle = new System.Windows.Forms.Label();
            this.grpMetricOverdue = new System.Windows.Forms.GroupBox();
            this.lblCountOverdue = new System.Windows.Forms.Label();
            this.grpMetricContracts = new System.Windows.Forms.GroupBox();
            this.lblCountContracts = new System.Windows.Forms.Label();
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.lblBrandTitle = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblCountStock = new System.Windows.Forms.Label();
            this.grpMetricStock = new System.Windows.Forms.GroupBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnNewSale = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingDues)).BeginInit();
            this.grpMetricOverdue.SuspendLayout();
            this.grpMetricContracts.SuspendLayout();
            this.pnlBrand.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.grpMetricStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblCurrentViewTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(220, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1044, 60);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblCurrentViewTitle
            // 
            this.lblCurrentViewTitle.AutoSize = true;
            this.lblCurrentViewTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentViewTitle.Location = new System.Drawing.Point(15, 16);
            this.lblCurrentViewTitle.Name = "lblCurrentViewTitle";
            this.lblCurrentViewTitle.Size = new System.Drawing.Size(197, 25);
            this.lblCurrentViewTitle.TabIndex = 0;
            this.lblCurrentViewTitle.Text = "Dashboard Overview";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlDashboard);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(220, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1044, 621);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.dgvUpcomingDues);
            this.pnlDashboard.Controls.Add(this.lblUpcomingTitle);
            this.pnlDashboard.Controls.Add(this.grpMetricOverdue);
            this.pnlDashboard.Controls.Add(this.grpMetricContracts);
            this.pnlDashboard.Controls.Add(this.grpMetricStock);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Padding = new System.Windows.Forms.Padding(20);
            this.pnlDashboard.Size = new System.Drawing.Size(1044, 621);
            this.pnlDashboard.TabIndex = 0;
            this.pnlDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDashboard_Paint);
            // 
            // dgvUpcomingDues
            // 
            this.dgvUpcomingDues.AllowUserToAddRows = false;
            this.dgvUpcomingDues.AllowUserToDeleteRows = false;
            this.dgvUpcomingDues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUpcomingDues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUpcomingDues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpcomingDues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomer,
            this.colUnit,
            this.colDueDate,
            this.colAmountDue,
            this.colContact});
            this.dgvUpcomingDues.Location = new System.Drawing.Point(20, 185);
            this.dgvUpcomingDues.Name = "dgvUpcomingDues";
            this.dgvUpcomingDues.ReadOnly = true;
            this.dgvUpcomingDues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUpcomingDues.Size = new System.Drawing.Size(1004, 415);
            this.dgvUpcomingDues.TabIndex = 4;
            // 
            // colCustomer
            // 
            this.colCustomer.HeaderText = "Customer Name";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.ReadOnly = true;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "Unit Purchased";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            // 
            // colDueDate
            // 
            this.colDueDate.HeaderText = "Due Date";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;
            // 
            // colAmountDue
            // 
            this.colAmountDue.HeaderText = "Amount Due";
            this.colAmountDue.Name = "colAmountDue";
            this.colAmountDue.ReadOnly = true;
            // 
            // colContact
            // 
            this.colContact.HeaderText = "Contact #";
            this.colContact.Name = "colContact";
            this.colContact.ReadOnly = true;
            // 
            // lblUpcomingTitle
            // 
            this.lblUpcomingTitle.AutoSize = true;
            this.lblUpcomingTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpcomingTitle.Location = new System.Drawing.Point(16, 150);
            this.lblUpcomingTitle.Name = "lblUpcomingTitle";
            this.lblUpcomingTitle.Size = new System.Drawing.Size(214, 21);
            this.lblUpcomingTitle.TabIndex = 3;
            this.lblUpcomingTitle.Text = "Upcoming Collections Due";
            // 
            // grpMetricOverdue
            // 
            this.grpMetricOverdue.Controls.Add(this.lblCountOverdue);
            this.grpMetricOverdue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMetricOverdue.Location = new System.Drawing.Point(620, 20);
            this.grpMetricOverdue.Name = "grpMetricOverdue";
            this.grpMetricOverdue.Size = new System.Drawing.Size(280, 105);
            this.grpMetricOverdue.TabIndex = 2;
            this.grpMetricOverdue.TabStop = false;
            this.grpMetricOverdue.Text = "Overdue Collections";
            // 
            // lblCountOverdue
            // 
            this.lblCountOverdue.AutoSize = true;
            this.lblCountOverdue.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountOverdue.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCountOverdue.Location = new System.Drawing.Point(20, 35);
            this.lblCountOverdue.Name = "lblCountOverdue";
            this.lblCountOverdue.Size = new System.Drawing.Size(40, 47);
            this.lblCountOverdue.TabIndex = 0;
            this.lblCountOverdue.Text = "0";
            // 
            // grpMetricContracts
            // 
            this.grpMetricContracts.Controls.Add(this.lblCountContracts);
            this.grpMetricContracts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMetricContracts.Location = new System.Drawing.Point(320, 20);
            this.grpMetricContracts.Name = "grpMetricContracts";
            this.grpMetricContracts.Size = new System.Drawing.Size(280, 105);
            this.grpMetricContracts.TabIndex = 1;
            this.grpMetricContracts.TabStop = false;
            this.grpMetricContracts.Text = "Active Installment Contracts";
            // 
            // lblCountContracts
            // 
            this.lblCountContracts.AutoSize = true;
            this.lblCountContracts.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountContracts.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCountContracts.Location = new System.Drawing.Point(20, 35);
            this.lblCountContracts.Name = "lblCountContracts";
            this.lblCountContracts.Size = new System.Drawing.Size(40, 47);
            this.lblCountContracts.TabIndex = 0;
            this.lblCountContracts.Text = "0";
            // 
            // pnlBrand
            // 
            this.pnlBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.pnlBrand.Controls.Add(this.lblBrandTitle);
            this.pnlBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBrand.Location = new System.Drawing.Point(0, 0);
            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.Size = new System.Drawing.Size(220, 80);
            this.pnlBrand.TabIndex = 0;
            // 
            // lblBrandTitle
            // 
            this.lblBrandTitle.AutoSize = true;
            this.lblBrandTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblBrandTitle.Location = new System.Drawing.Point(12, 16);
            this.lblBrandTitle.Name = "lblBrandTitle";
            this.lblBrandTitle.Size = new System.Drawing.Size(197, 21);
            this.lblBrandTitle.TabIndex = 0;
            this.lblBrandTitle.Text = "COLLAINE RAC SERVICES";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.pnlSidebar.Controls.Add(this.btnPayment);
            this.pnlSidebar.Controls.Add(this.btnNewSale);
            this.pnlSidebar.Controls.Add(this.btnInventory);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.pnlBrand);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 681);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblCountStock
            // 
            this.lblCountStock.AutoSize = true;
            this.lblCountStock.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountStock.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCountStock.Location = new System.Drawing.Point(20, 35);
            this.lblCountStock.Name = "lblCountStock";
            this.lblCountStock.Size = new System.Drawing.Size(40, 47);
            this.lblCountStock.TabIndex = 0;
            this.lblCountStock.Text = "0";
            // 
            // grpMetricStock
            // 
            this.grpMetricStock.Controls.Add(this.lblCountStock);
            this.grpMetricStock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMetricStock.Location = new System.Drawing.Point(20, 20);
            this.grpMetricStock.Name = "grpMetricStock";
            this.grpMetricStock.Size = new System.Drawing.Size(280, 105);
            this.grpMetricStock.TabIndex = 0;
            this.grpMetricStock.TabStop = false;
            this.grpMetricStock.Text = "Total AC Units in Stock";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(16, 104);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(169, 46);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard Overview";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(16, 156);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(169, 46);
            this.btnInventory.TabIndex = 6;
            this.btnInventory.Text = "AC Inventory Stocks";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnNewSale
            // 
            this.btnNewSale.Location = new System.Drawing.Point(16, 208);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(169, 46);
            this.btnNewSale.TabIndex = 7;
            this.btnNewSale.Text = "New Sale Contract";
            this.btnNewSale.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(16, 260);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(169, 46);
            this.btnPayment.TabIndex = 8;
            this.btnPayment.Text = "Payment Collections";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingDues)).EndInit();
            this.grpMetricOverdue.ResumeLayout(false);
            this.grpMetricOverdue.PerformLayout();
            this.grpMetricContracts.ResumeLayout(false);
            this.grpMetricContracts.PerformLayout();
            this.pnlBrand.ResumeLayout(false);
            this.pnlBrand.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.grpMetricStock.ResumeLayout(false);
            this.grpMetricStock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblCurrentViewTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.GroupBox grpMetricContracts;
        private System.Windows.Forms.Label lblCountContracts;
        private System.Windows.Forms.GroupBox grpMetricOverdue;
        private System.Windows.Forms.Label lblCountOverdue;
        private System.Windows.Forms.Label lblUpcomingTitle;
        private System.Windows.Forms.DataGridView dgvUpcomingDues;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmountDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContact;
        private System.Windows.Forms.GroupBox grpMetricStock;
        private System.Windows.Forms.Label lblCountStock;
        private System.Windows.Forms.Panel pnlBrand;
        private System.Windows.Forms.Label lblBrandTitle;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnNewSale;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnDashboard;
    }
}
