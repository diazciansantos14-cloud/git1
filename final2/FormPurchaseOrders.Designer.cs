namespace test1
{
    partial class FormPurchaseOrders
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpCreatePO = new System.Windows.Forms.GroupBox();
            this.btnCreatePO = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.dtpExpectedDelivery = new System.Windows.Forms.DateTimePicker();
            this.lblExpected = new System.Windows.Forms.Label();
            this.nudUnitCost = new System.Windows.Forms.NumericUpDown();
            this.lblUnitCost = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQty = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.grpPOHistory = new System.Windows.Forms.GroupBox();
            this.dgvPOs = new System.Windows.Forms.DataGridView();
            this.colPOID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPONumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colACUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPOActions = new System.Windows.Forms.Panel();
            this.btnReceiveGoods = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.grpCreatePO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.grpPOHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOs)).BeginInit();
            this.pnlPOActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1020, 70);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 25);
            this.lblTitle.TabIndex = 0;
            // 
            // grpCreatePO
            // 
            this.grpCreatePO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpCreatePO.BackColor = System.Drawing.Color.White;
            this.grpCreatePO.Controls.Add(this.btnCreatePO);
            this.grpCreatePO.Controls.Add(this.txtNotes);
            this.grpCreatePO.Controls.Add(this.lblNotes);
            this.grpCreatePO.Controls.Add(this.dtpExpectedDelivery);
            this.grpCreatePO.Controls.Add(this.lblExpected);
            this.grpCreatePO.Controls.Add(this.nudUnitCost);
            this.grpCreatePO.Controls.Add(this.lblUnitCost);
            this.grpCreatePO.Controls.Add(this.nudQuantity);
            this.grpCreatePO.Controls.Add(this.lblQty);
            this.grpCreatePO.Controls.Add(this.cmbItem);
            this.grpCreatePO.Controls.Add(this.lblItem);
            this.grpCreatePO.Controls.Add(this.cmbSupplier);
            this.grpCreatePO.Controls.Add(this.lblSupplier);
            this.grpCreatePO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCreatePO.Location = new System.Drawing.Point(12, 80);
            this.grpCreatePO.Name = "grpCreatePO";
            this.grpCreatePO.Size = new System.Drawing.Size(350, 520);
            this.grpCreatePO.TabIndex = 1;
            this.grpCreatePO.TabStop = false;
            this.grpCreatePO.Text = "Step 1: Create Purchase Order (P.O.)";
            // 
            // btnCreatePO
            // 
            this.btnCreatePO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            this.btnCreatePO.FlatAppearance.BorderSize = 0;
            this.btnCreatePO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePO.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePO.ForeColor = System.Drawing.Color.White;
            this.btnCreatePO.Location = new System.Drawing.Point(20, 390);
            this.btnCreatePO.Name = "btnCreatePO";
            this.btnCreatePO.Size = new System.Drawing.Size(310, 42);
            this.btnCreatePO.TabIndex = 12;
            this.btnCreatePO.Text = "📑  Create Purchase Order";
            this.btnCreatePO.UseVisualStyleBackColor = false;
            this.btnCreatePO.Click += new System.EventHandler(this.btnCreatePO_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(20, 310);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(310, 60);
            this.txtNotes.TabIndex = 11;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(20, 290);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(116, 15);
            this.lblNotes.TabIndex = 10;
            this.lblNotes.Text = "PO Terms / Remarks:";
            // 
            // dtpExpectedDelivery
            // 
            this.dtpExpectedDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpectedDelivery.Location = new System.Drawing.Point(20, 250);
            this.dtpExpectedDelivery.Name = "dtpExpectedDelivery";
            this.dtpExpectedDelivery.Size = new System.Drawing.Size(310, 23);
            this.dtpExpectedDelivery.TabIndex = 9;
            // 
            // lblExpected
            // 
            this.lblExpected.AutoSize = true;
            this.lblExpected.Location = new System.Drawing.Point(20, 230);
            this.lblExpected.Name = "lblExpected";
            this.lblExpected.Size = new System.Drawing.Size(130, 15);
            this.lblExpected.TabIndex = 8;
            this.lblExpected.Text = "Expected Delivery Date:";
            // 
            // nudUnitCost
            // 
            this.nudUnitCost.DecimalPlaces = 2;
            this.nudUnitCost.Location = new System.Drawing.Point(180, 185);
            this.nudUnitCost.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudUnitCost.Name = "nudUnitCost";
            this.nudUnitCost.Size = new System.Drawing.Size(150, 23);
            this.nudUnitCost.TabIndex = 7;
            this.nudUnitCost.ThousandsSeparator = true;
            // 
            // lblUnitCost
            // 
            this.lblUnitCost.AutoSize = true;
            this.lblUnitCost.Location = new System.Drawing.Point(180, 165);
            this.lblUnitCost.Name = "lblUnitCost";
            this.lblUnitCost.Size = new System.Drawing.Size(77, 15);
            this.lblUnitCost.TabIndex = 6;
            this.lblUnitCost.Text = "Unit Cost (₱):";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(20, 185);
            this.nudQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(140, 23);
            this.nudQuantity.TabIndex = 5;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(20, 165);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(89, 15);
            this.lblQty.TabIndex = 4;
            this.lblQty.Text = "Order Quantity:";
            // 
            // cmbItem
            // 
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(20, 120);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(310, 23);
            this.cmbItem.TabIndex = 3;
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(20, 100);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(130, 15);
            this.lblItem.TabIndex = 2;
            this.lblItem.Text = "Select AC Unit / Model:";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(20, 55);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(310, 23);
            this.cmbSupplier.TabIndex = 1;
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(20, 35);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(87, 15);
            this.lblSupplier.TabIndex = 0;
            this.lblSupplier.Text = "Select Supplier:";
            // 
            // grpPOHistory
            // 
            this.grpPOHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPOHistory.BackColor = System.Drawing.Color.White;
            this.grpPOHistory.Controls.Add(this.dgvPOs);
            this.grpPOHistory.Controls.Add(this.pnlPOActions);
            this.grpPOHistory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPOHistory.Location = new System.Drawing.Point(375, 80);
            this.grpPOHistory.Name = "grpPOHistory";
            this.grpPOHistory.Size = new System.Drawing.Size(633, 520);
            this.grpPOHistory.TabIndex = 2;
            this.grpPOHistory.TabStop = false;
            this.grpPOHistory.Text = "Step 2: Purchase Orders & Goods Receipt (Stock Arrival)";
            // 
            // dgvPOs
            // 
            this.dgvPOs.AllowUserToAddRows = false;
            this.dgvPOs.AllowUserToDeleteRows = false;
            this.dgvPOs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPOs.BackgroundColor = System.Drawing.Color.White;
            this.dgvPOs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPOs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPOID,
            this.colPONumber,
            this.colSupplier,
            this.colACUnit,
            this.colQty,
            this.colCost,
            this.colTotal,
            this.colDate,
            this.colStatus,
            this.colReceived});
            this.dgvPOs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPOs.Location = new System.Drawing.Point(3, 19);
            this.dgvPOs.MultiSelect = false;
            this.dgvPOs.Name = "dgvPOs";
            this.dgvPOs.ReadOnly = true;
            this.dgvPOs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPOs.Size = new System.Drawing.Size(627, 438);
            this.dgvPOs.TabIndex = 0;
            // 
            // colPOID
            // 
            this.colPOID.FillWeight = 40F;
            this.colPOID.HeaderText = "ID";
            this.colPOID.Name = "colPOID";
            this.colPOID.ReadOnly = true;
            // 
            // colPONumber
            // 
            this.colPONumber.FillWeight = 85F;
            this.colPONumber.HeaderText = "PO #";
            this.colPONumber.Name = "colPONumber";
            this.colPONumber.ReadOnly = true;
            // 
            // colSupplier
            // 
            this.colSupplier.HeaderText = "Supplier";
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.ReadOnly = true;
            // 
            // colACUnit
            // 
            this.colACUnit.HeaderText = "AC Unit Ordered";
            this.colACUnit.Name = "colACUnit";
            this.colACUnit.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.FillWeight = 50F;
            this.colQty.HeaderText = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // colCost
            // 
            this.colCost.FillWeight = 70F;
            this.colCost.HeaderText = "Cost (₱)";
            this.colCost.Name = "colCost";
            this.colCost.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.FillWeight = 75F;
            this.colTotal.HeaderText = "Total (₱)";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.FillWeight = 70F;
            this.colDate.HeaderText = "Order Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.FillWeight = 70F;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colReceived
            // 
            this.colReceived.HeaderText = "Received Date";
            this.colReceived.Name = "colReceived";
            this.colReceived.ReadOnly = true;
            // 
            // pnlPOActions
            // 
            this.pnlPOActions.Controls.Add(this.btnReceiveGoods);
            this.pnlPOActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPOActions.Location = new System.Drawing.Point(3, 457);
            this.pnlPOActions.Name = "pnlPOActions";
            this.pnlPOActions.Size = new System.Drawing.Size(627, 60);
            this.pnlPOActions.TabIndex = 1;
            // 
            // btnReceiveGoods
            // 
            this.btnReceiveGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReceiveGoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.btnReceiveGoods.FlatAppearance.BorderSize = 0;
            this.btnReceiveGoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceiveGoods.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceiveGoods.ForeColor = System.Drawing.Color.White;
            this.btnReceiveGoods.Location = new System.Drawing.Point(205, 10);
            this.btnReceiveGoods.Name = "btnReceiveGoods";
            this.btnReceiveGoods.Size = new System.Drawing.Size(412, 40);
            this.btnReceiveGoods.TabIndex = 0;
            this.btnReceiveGoods.Text = "📥  Confirm Delivery Arrival and Update Stock (Goods Receipt)";
            this.btnReceiveGoods.UseVisualStyleBackColor = false;
            this.btnReceiveGoods.Click += new System.EventHandler(this.btnReceiveGoods_Click);
            // 
            // FormPurchaseOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1020, 615);
            this.Controls.Add(this.grpPOHistory);
            this.Controls.Add(this.grpCreatePO);
            this.Controls.Add(this.pnlTop);
            this.Name = "FormPurchaseOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procurement & Purchase Orders";
            this.Load += new System.EventHandler(this.FormPurchaseOrders_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpCreatePO.ResumeLayout(false);
            this.grpCreatePO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.grpPOHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOs)).EndInit();
            this.pnlPOActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpCreatePO;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblUnitCost;
        private System.Windows.Forms.NumericUpDown nudUnitCost;
        private System.Windows.Forms.Label lblExpected;
        private System.Windows.Forms.DateTimePicker dtpExpectedDelivery;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnCreatePO;
        private System.Windows.Forms.GroupBox grpPOHistory;
        private System.Windows.Forms.DataGridView dgvPOs;
        private System.Windows.Forms.Panel pnlPOActions;
        private System.Windows.Forms.Button btnReceiveGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPOID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPONumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colACUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceived;
    }
}
