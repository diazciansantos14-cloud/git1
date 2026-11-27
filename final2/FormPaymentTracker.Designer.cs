namespace test1
{
    partial class FormPaymentTracker
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
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.lblStatusFilter = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchContract = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvContractsList = new System.Windows.Forms.DataGridView();
            this.colContractID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPurchased = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalanceLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNextDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAccountSummary = new System.Windows.Forms.GroupBox();
            this.lblBalanceDisplay = new System.Windows.Forms.Label();
            this.lblBalTag = new System.Windows.Forms.Label();
            this.lblPaidDisplay = new System.Windows.Forms.Label();
            this.lblPaidTag = new System.Windows.Forms.Label();
            this.lblTotalDisplay = new System.Windows.Forms.Label();
            this.lblTotalTag = new System.Windows.Forms.Label();
            this.lblUnitDisplay = new System.Windows.Forms.Label();
            this.lblUnitTag = new System.Windows.Forms.Label();
            this.lblCustNameDisplay = new System.Windows.Forms.Label();
            this.lblCustTag = new System.Windows.Forms.Label();
            this.grpSchedule = new System.Windows.Forms.GroupBox();
            this.dgvInstallmentSchedule = new System.Windows.Forms.DataGridView();
            this.colMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmountDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.btnExtendDueDate = new System.Windows.Forms.Button();
            this.btnPayFullSettlement = new System.Windows.Forms.Button();
            this.btnRecordPayment = new System.Windows.Forms.Button();
            this.txtReceiptRef = new System.Windows.Forms.TextBox();
            this.lblReceipt = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.nudPaymentAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractsList)).BeginInit();
            this.grpAccountSummary.SuspendLayout();
            this.grpSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallmentSchedule)).BeginInit();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaymentAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.cmbStatusFilter);
            this.pnlTop.Controls.Add(this.lblStatusFilter);
            this.pnlTop.Controls.Add(this.btnSearch);
            this.pnlTop.Controls.Add(this.txtSearchContract);
            this.pnlTop.Controls.Add(this.lblSearch);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(984, 70);
            this.pnlTop.TabIndex = 0;
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Items.AddRange(new object[] {
            "All Accounts",
            "Active Only",
            "Fully Paid"});
            this.cmbStatusFilter.Location = new System.Drawing.Point(540, 40);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(130, 21);
            this.cmbStatusFilter.TabIndex = 5;
            this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStatusFilter_SelectedIndexChanged);
            // 
            // lblStatusFilter
            // 
            this.lblStatusFilter.AutoSize = true;
            this.lblStatusFilter.Location = new System.Drawing.Point(495, 43);
            this.lblStatusFilter.Name = "lblStatusFilter";
            this.lblStatusFilter.Size = new System.Drawing.Size(40, 13);
            this.lblStatusFilter.TabIndex = 4;
            this.lblStatusFilter.Text = "Status:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(375, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 25);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "🔍 Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchContract
            // 
            this.txtSearchContract.Location = new System.Drawing.Point(145, 40);
            this.txtSearchContract.Name = "txtSearchContract";
            this.txtSearchContract.Size = new System.Drawing.Size(220, 20);
            this.txtSearchContract.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(14, 43);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(126, 13);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search Name / Contract:";
            // 
            // dgvContractsList
            // 
            this.dgvContractsList.AllowUserToAddRows = false;
            this.dgvContractsList.AllowUserToDeleteRows = false;
            this.dgvContractsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContractsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContractsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContractsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colContractID,
            this.colCustomer,
            this.colContact,
            this.colUnitPurchased,
            this.colTotalAmount,
            this.colBalanceLeft,
            this.colNextDue});
            this.dgvContractsList.Location = new System.Drawing.Point(12, 76);
            this.dgvContractsList.MultiSelect = false;
            this.dgvContractsList.Name = "dgvContractsList";
            this.dgvContractsList.ReadOnly = true;
            this.dgvContractsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContractsList.Size = new System.Drawing.Size(960, 140);
            this.dgvContractsList.TabIndex = 1;
            this.dgvContractsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContractsList_CellClick);
            // 
            // colContractID
            // 
            this.colContractID.FillWeight = 50F;
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
            this.colContact.FillWeight = 80F;
            this.colContact.HeaderText = "Contact #";
            this.colContact.Name = "colContact";
            this.colContact.ReadOnly = true;
            // 
            // colUnitPurchased
            // 
            this.colUnitPurchased.FillWeight = 110F;
            this.colUnitPurchased.HeaderText = "Unit Purchased";
            this.colUnitPurchased.Name = "colUnitPurchased";
            this.colUnitPurchased.ReadOnly = true;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.FillWeight = 70F;
            this.colTotalAmount.HeaderText = "Total Price";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.ReadOnly = true;
            // 
            // colBalanceLeft
            // 
            this.colBalanceLeft.FillWeight = 70F;
            this.colBalanceLeft.HeaderText = "Balance Left";
            this.colBalanceLeft.Name = "colBalanceLeft";
            this.colBalanceLeft.ReadOnly = true;
            // 
            // colNextDue
            // 
            this.colNextDue.FillWeight = 70F;
            this.colNextDue.HeaderText = "Next Due Date";
            this.colNextDue.Name = "colNextDue";
            this.colNextDue.ReadOnly = true;
            // 
            // grpAccountSummary
            // 
            this.grpAccountSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAccountSummary.Controls.Add(this.lblBalanceDisplay);
            this.grpAccountSummary.Controls.Add(this.lblBalTag);
            this.grpAccountSummary.Controls.Add(this.lblPaidDisplay);
            this.grpAccountSummary.Controls.Add(this.lblPaidTag);
            this.grpAccountSummary.Controls.Add(this.lblTotalDisplay);
            this.grpAccountSummary.Controls.Add(this.lblTotalTag);
            this.grpAccountSummary.Controls.Add(this.lblUnitDisplay);
            this.grpAccountSummary.Controls.Add(this.lblUnitTag);
            this.grpAccountSummary.Controls.Add(this.lblCustNameDisplay);
            this.grpAccountSummary.Controls.Add(this.lblCustTag);
            this.grpAccountSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAccountSummary.Location = new System.Drawing.Point(12, 222);
            this.grpAccountSummary.Name = "grpAccountSummary";
            this.grpAccountSummary.Size = new System.Drawing.Size(960, 65);
            this.grpAccountSummary.TabIndex = 2;
            this.grpAccountSummary.TabStop = false;
            this.grpAccountSummary.Text = "Selected Account Summary";
            // 
            // lblBalanceDisplay
            // 
            this.lblBalanceDisplay.AutoSize = true;
            this.lblBalanceDisplay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceDisplay.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBalanceDisplay.Location = new System.Drawing.Point(835, 27);
            this.lblBalanceDisplay.Name = "lblBalanceDisplay";
            this.lblBalanceDisplay.Size = new System.Drawing.Size(90, 20);
            this.lblBalanceDisplay.TabIndex = 9;
            this.lblBalanceDisplay.Text = "₱25,000.00";
            // 
            // lblBalTag
            // 
            this.lblBalTag.AutoSize = true;
            this.lblBalTag.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalTag.Location = new System.Drawing.Point(745, 31);
            this.lblBalTag.Name = "lblBalTag";
            this.lblBalTag.Size = new System.Drawing.Size(87, 15);
            this.lblBalTag.TabIndex = 8;
            this.lblBalTag.Text = "BALANCE DUE:";
            // 
            // lblPaidDisplay
            // 
            this.lblPaidDisplay.AutoSize = true;
            this.lblPaidDisplay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidDisplay.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPaidDisplay.Location = new System.Drawing.Point(625, 29);
            this.lblPaidDisplay.Name = "lblPaidDisplay";
            this.lblPaidDisplay.Size = new System.Drawing.Size(73, 17);
            this.lblPaidDisplay.TabIndex = 7;
            this.lblPaidDisplay.Text = "₱11,000.00";
            // 
            // lblPaidTag
            // 
            this.lblPaidTag.AutoSize = true;
            this.lblPaidTag.Location = new System.Drawing.Point(545, 31);
            this.lblPaidTag.Name = "lblPaidTag";
            this.lblPaidTag.Size = new System.Drawing.Size(75, 15);
            this.lblPaidTag.TabIndex = 6;
            this.lblPaidTag.Text = "Paid To Date:";
            // 
            // lblTotalDisplay
            // 
            this.lblTotalDisplay.AutoSize = true;
            this.lblTotalDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDisplay.Location = new System.Drawing.Point(440, 29);
            this.lblTotalDisplay.Name = "lblTotalDisplay";
            this.lblTotalDisplay.Size = new System.Drawing.Size(71, 17);
            this.lblTotalDisplay.TabIndex = 5;
            this.lblTotalDisplay.Text = "₱36,000.00";
            // 
            // lblTotalTag
            // 
            this.lblTotalTag.AutoSize = true;
            this.lblTotalTag.Location = new System.Drawing.Point(370, 31);
            this.lblTotalTag.Name = "lblTotalTag";
            this.lblTotalTag.Size = new System.Drawing.Size(64, 15);
            this.lblTotalTag.TabIndex = 4;
            this.lblTotalTag.Text = "Total Price:";
            // 
            // lblUnitDisplay
            // 
            this.lblUnitDisplay.AutoSize = true;
            this.lblUnitDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitDisplay.Location = new System.Drawing.Point(235, 29);
            this.lblUnitDisplay.Name = "lblUnitDisplay";
            this.lblUnitDisplay.Size = new System.Drawing.Size(89, 17);
            this.lblUnitDisplay.TabIndex = 3;
            this.lblUnitDisplay.Text = "Carrier 1.5 HP";
            // 
            // lblUnitTag
            // 
            this.lblUnitTag.AutoSize = true;
            this.lblUnitTag.Location = new System.Drawing.Point(175, 31);
            this.lblUnitTag.Name = "lblUnitTag";
            this.lblUnitTag.Size = new System.Drawing.Size(51, 15);
            this.lblUnitTag.TabIndex = 2;
            this.lblUnitTag.Text = "AC Unit:";
            // 
            // lblCustNameDisplay
            // 
            this.lblCustNameDisplay.AutoSize = true;
            this.lblCustNameDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustNameDisplay.Location = new System.Drawing.Point(75, 29);
            this.lblCustNameDisplay.Name = "lblCustNameDisplay";
            this.lblCustNameDisplay.Size = new System.Drawing.Size(87, 17);
            this.lblCustNameDisplay.TabIndex = 1;
            this.lblCustNameDisplay.Text = "Maria Santos";
            // 
            // lblCustTag
            // 
            this.lblCustTag.AutoSize = true;
            this.lblCustTag.Location = new System.Drawing.Point(10, 31);
            this.lblCustTag.Name = "lblCustTag";
            this.lblCustTag.Size = new System.Drawing.Size(62, 15);
            this.lblCustTag.TabIndex = 0;
            this.lblCustTag.Text = "Customer:";
            // 
            // grpSchedule
            // 
            this.grpSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSchedule.Controls.Add(this.dgvInstallmentSchedule);
            this.grpSchedule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSchedule.Location = new System.Drawing.Point(12, 293);
            this.grpSchedule.Name = "grpSchedule";
            this.grpSchedule.Size = new System.Drawing.Size(960, 210);
            this.grpSchedule.TabIndex = 3;
            this.grpSchedule.TabStop = false;
            this.grpSchedule.Text = "Month-by-Month Installment Amortization Schedule";
            // 
            // dgvInstallmentSchedule
            // 
            this.dgvInstallmentSchedule.AllowUserToAddRows = false;
            this.dgvInstallmentSchedule.AllowUserToDeleteRows = false;
            this.dgvInstallmentSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInstallmentSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstallmentSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMonth,
            this.colDueDate,
            this.colAmountDue,
            this.colAmountPaid,
            this.colDatePaid,
            this.colStatus,
            this.colRemarks});
            this.dgvInstallmentSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInstallmentSchedule.Location = new System.Drawing.Point(3, 19);
            this.dgvInstallmentSchedule.MultiSelect = false;
            this.dgvInstallmentSchedule.Name = "dgvInstallmentSchedule";
            this.dgvInstallmentSchedule.ReadOnly = true;
            this.dgvInstallmentSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInstallmentSchedule.Size = new System.Drawing.Size(954, 188);
            this.dgvInstallmentSchedule.TabIndex = 0;
            // 
            // colMonth
            // 
            this.colMonth.FillWeight = 50F;
            this.colMonth.HeaderText = "Month #";
            this.colMonth.Name = "colMonth";
            this.colMonth.ReadOnly = true;
            // 
            // colDueDate
            // 
            this.colDueDate.FillWeight = 75F;
            this.colDueDate.HeaderText = "Due Date";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;
            // 
            // colAmountDue
            // 
            this.colAmountDue.FillWeight = 75F;
            this.colAmountDue.HeaderText = "Amount Due";
            this.colAmountDue.Name = "colAmountDue";
            this.colAmountDue.ReadOnly = true;
            // 
            // colAmountPaid
            // 
            this.colAmountPaid.FillWeight = 75F;
            this.colAmountPaid.HeaderText = "Amount Paid";
            this.colAmountPaid.Name = "colAmountPaid";
            this.colAmountPaid.ReadOnly = true;
            // 
            // colDatePaid
            // 
            this.colDatePaid.FillWeight = 75F;
            this.colDatePaid.HeaderText = "Date Paid";
            this.colDatePaid.Name = "colDatePaid";
            this.colDatePaid.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.FillWeight = 60F;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colRemarks
            // 
            this.colRemarks.HeaderText = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.ReadOnly = true;
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnPrintReceipt);
            this.pnlActions.Controls.Add(this.btnExtendDueDate);
            this.pnlActions.Controls.Add(this.btnPayFullSettlement);
            this.pnlActions.Controls.Add(this.btnRecordPayment);
            this.pnlActions.Controls.Add(this.txtReceiptRef);
            this.pnlActions.Controls.Add(this.lblReceipt);
            this.pnlActions.Controls.Add(this.cmbPaymentMethod);
            this.pnlActions.Controls.Add(this.lblMethod);
            this.pnlActions.Controls.Add(this.nudPaymentAmount);
            this.pnlActions.Controls.Add(this.lblAmount);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActions.Location = new System.Drawing.Point(0, 509);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(984, 91);
            this.pnlActions.TabIndex = 4;
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReceipt.Location = new System.Drawing.Point(825, 48);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(147, 34);
            this.btnPrintReceipt.TabIndex = 9;
            this.btnPrintReceipt.Text = "🖨️ Print Receipt / SOA";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // btnExtendDueDate
            // 
            this.btnExtendDueDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtendDueDate.Location = new System.Drawing.Point(540, 48);
            this.btnExtendDueDate.Name = "btnExtendDueDate";
            this.btnExtendDueDate.Size = new System.Drawing.Size(185, 34);
            this.btnExtendDueDate.TabIndex = 8;
            this.btnExtendDueDate.Text = "⏱️ Extend / Delay Due Date";
            this.btnExtendDueDate.UseVisualStyleBackColor = true;
            this.btnExtendDueDate.Click += new System.EventHandler(this.btnExtendDueDate_Click);
            // 
            // btnPayFullSettlement
            // 
            this.btnPayFullSettlement.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayFullSettlement.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnPayFullSettlement.Location = new System.Drawing.Point(260, 48);
            this.btnPayFullSettlement.Name = "btnPayFullSettlement";
            this.btnPayFullSettlement.Size = new System.Drawing.Size(260, 34);
            this.btnPayFullSettlement.TabIndex = 7;
            this.btnPayFullSettlement.Text = "🏆 Pay Full Remaining Balance (1-Click)";
            this.btnPayFullSettlement.UseVisualStyleBackColor = true;
            this.btnPayFullSettlement.Click += new System.EventHandler(this.btnPayFullSettlement_Click);
            // 
            // btnRecordPayment
            // 
            this.btnRecordPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordPayment.Location = new System.Drawing.Point(12, 48);
            this.btnRecordPayment.Name = "btnRecordPayment";
            this.btnRecordPayment.Size = new System.Drawing.Size(230, 34);
            this.btnRecordPayment.TabIndex = 6;
            this.btnRecordPayment.Text = "💵 Record Monthly Payment";
            this.btnRecordPayment.UseVisualStyleBackColor = true;
            this.btnRecordPayment.Click += new System.EventHandler(this.btnRecordPayment_Click);
            // 
            // txtReceiptRef
            // 
            this.txtReceiptRef.Location = new System.Drawing.Point(575, 12);
            this.txtReceiptRef.Name = "txtReceiptRef";
            this.txtReceiptRef.Size = new System.Drawing.Size(180, 20);
            this.txtReceiptRef.TabIndex = 5;
            // 
            // lblReceipt
            // 
            this.lblReceipt.AutoSize = true;
            this.lblReceipt.Location = new System.Drawing.Point(490, 15);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(85, 13);
            this.lblReceipt.TabIndex = 4;
            this.lblReceipt.Text = "Receipt / Ref #:";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "GCash",
            "Bank Transfer",
            "Check"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(335, 12);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(130, 21);
            this.cmbPaymentMethod.TabIndex = 3;
            this.cmbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMethod_SelectedIndexChanged);
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(280, 15);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(46, 13);
            this.lblMethod.TabIndex = 2;
            this.lblMethod.Text = "Method:";
            // 
            // nudPaymentAmount
            // 
            this.nudPaymentAmount.DecimalPlaces = 2;
            this.nudPaymentAmount.Location = new System.Drawing.Point(105, 12);
            this.nudPaymentAmount.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.nudPaymentAmount.Name = "nudPaymentAmount";
            this.nudPaymentAmount.Size = new System.Drawing.Size(150, 20);
            this.nudPaymentAmount.TabIndex = 1;
            this.nudPaymentAmount.ThousandsSeparator = true;
            this.nudPaymentAmount.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(12, 15);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(90, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Payment Amount:";
            // 
            // FormPaymentTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 600);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.grpSchedule);
            this.Controls.Add(this.grpAccountSummary);
            this.Controls.Add(this.dgvContractsList);
            this.Controls.Add(this.pnlTop);
            this.Name = "FormPaymentTracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RAC Installment Collections & Ledger";
            this.Load += new System.EventHandler(this.FormPaymentTracker_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractsList)).EndInit();
            this.grpAccountSummary.ResumeLayout(false);
            this.grpAccountSummary.PerformLayout();
            this.grpSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallmentSchedule)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaymentAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchContract;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStatusFilter;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.DataGridView dgvContractsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContractID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPurchased;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalanceLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNextDue;
        private System.Windows.Forms.GroupBox grpAccountSummary;
        private System.Windows.Forms.Label lblCustTag;
        private System.Windows.Forms.Label lblCustNameDisplay;
        private System.Windows.Forms.Label lblUnitTag;
        private System.Windows.Forms.Label lblUnitDisplay;
        private System.Windows.Forms.Label lblTotalTag;
        private System.Windows.Forms.Label lblTotalDisplay;
        private System.Windows.Forms.Label lblPaidTag;
        private System.Windows.Forms.Label lblPaidDisplay;
        private System.Windows.Forms.Label lblBalTag;
        private System.Windows.Forms.Label lblBalanceDisplay;
        private System.Windows.Forms.GroupBox grpSchedule;
        private System.Windows.Forms.DataGridView dgvInstallmentSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmountDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmountPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatePaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemarks;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown nudPaymentAmount;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblReceipt;
        private System.Windows.Forms.TextBox txtReceiptRef;
        private System.Windows.Forms.Button btnRecordPayment;
        private System.Windows.Forms.Button btnPayFullSettlement;
        private System.Windows.Forms.Button btnExtendDueDate;
        private System.Windows.Forms.Button btnPrintReceipt;
    }
}
