namespace test1
{
    partial class FormFullSale
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
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.txtValidID = new System.Windows.Forms.TextBox();
            this.lblValidID = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.cmbCustomerList = new System.Windows.Forms.ComboBox();
            this.lblExistingCust = new System.Windows.Forms.Label();
            this.grpACUnit = new System.Windows.Forms.GroupBox();
            this.cmbBrandFilter = new System.Windows.Forms.ComboBox();
            this.lblBrandFilter = new System.Windows.Forms.Label();
            this.lblPriceDisplay = new System.Windows.Forms.Label();
            this.lblPriceTag = new System.Windows.Forms.Label();
            this.lblSerialDisplay = new System.Windows.Forms.Label();
            this.lblSerialTag = new System.Windows.Forms.Label();
            this.lblHPDisplay = new System.Windows.Forms.Label();
            this.lblHPTag = new System.Windows.Forms.Label();
            this.lblBrandDisplay = new System.Windows.Forms.Label();
            this.lblBrandTag = new System.Windows.Forms.Label();
            this.cmbSelectACUnit = new System.Windows.Forms.ComboBox();
            this.lblSelectAC = new System.Windows.Forms.Label();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.lblTotalDueDisplay = new System.Windows.Forms.Label();
            this.lblTotalDueTag = new System.Windows.Forms.Label();
            this.txtReceiptRef = new System.Windows.Forms.TextBox();
            this.lblReceipt = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.dtpContractDate = new System.Windows.Forms.DateTimePicker();
            this.lblSaleDate = new System.Windows.Forms.Label();
            this.grpInstallInfo = new System.Windows.Forms.GroupBox();
            this.cmbTechnician = new System.Windows.Forms.ComboBox();
            this.lblTechnician = new System.Windows.Forms.Label();
            this.txtInstallationNotes = new System.Windows.Forms.TextBox();
            this.lblInstallNotes = new System.Windows.Forms.Label();
            this.btnCompleteSale = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpCustomer.SuspendLayout();
            this.grpACUnit.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.grpInstallInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.txtValidID);
            this.grpCustomer.Controls.Add(this.lblValidID);
            this.grpCustomer.Controls.Add(this.txtAddress);
            this.grpCustomer.Controls.Add(this.lblAddress);
            this.grpCustomer.Controls.Add(this.txtContactNumber);
            this.grpCustomer.Controls.Add(this.lblContact);
            this.grpCustomer.Controls.Add(this.txtCustomerName);
            this.grpCustomer.Controls.Add(this.lblCustName);
            this.grpCustomer.Controls.Add(this.cmbCustomerList);
            this.grpCustomer.Controls.Add(this.lblExistingCust);
            this.grpCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpCustomer.Location = new System.Drawing.Point(17, 45);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(465, 230);
            this.grpCustomer.TabIndex = 1;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "1. Customer Information";
            // 
            // txtValidID
            // 
            this.txtValidID.Location = new System.Drawing.Point(135, 185);
            this.txtValidID.Name = "txtValidID";
            this.txtValidID.Size = new System.Drawing.Size(315, 23);
            this.txtValidID.TabIndex = 9;
            // 
            // lblValidID
            // 
            this.lblValidID.AutoSize = true;
            this.lblValidID.Location = new System.Drawing.Point(15, 188);
            this.lblValidID.Name = "lblValidID";
            this.lblValidID.Size = new System.Drawing.Size(87, 15);
            this.lblValidID.TabIndex = 10;
            this.lblValidID.Text = "Valid ID Details:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(135, 125);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(315, 50);
            this.txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(15, 128);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(97, 15);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Installation Addr:";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(135, 92);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(315, 23);
            this.txtContactNumber.TabIndex = 5;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(15, 95);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(99, 15);
            this.lblContact.TabIndex = 12;
            this.lblContact.Text = "Contact Number:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(135, 60);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(315, 23);
            this.txtCustomerName.TabIndex = 3;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(15, 63);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(64, 15);
            this.lblCustName.TabIndex = 13;
            this.lblCustName.Text = "Full Name:";
            // 
            // cmbCustomerList
            // 
            this.cmbCustomerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerList.FormattingEnabled = true;
            this.cmbCustomerList.Location = new System.Drawing.Point(135, 27);
            this.cmbCustomerList.Name = "cmbCustomerList";
            this.cmbCustomerList.Size = new System.Drawing.Size(315, 23);
            this.cmbCustomerList.TabIndex = 1;
            this.cmbCustomerList.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerList_SelectedIndexChanged);
            // 
            // lblExistingCust
            // 
            this.lblExistingCust.AutoSize = true;
            this.lblExistingCust.Location = new System.Drawing.Point(15, 30);
            this.lblExistingCust.Name = "lblExistingCust";
            this.lblExistingCust.Size = new System.Drawing.Size(85, 15);
            this.lblExistingCust.TabIndex = 14;
            this.lblExistingCust.Text = "Select Existing:";
            // 
            // grpACUnit
            // 
            this.grpACUnit.Controls.Add(this.cmbBrandFilter);
            this.grpACUnit.Controls.Add(this.lblBrandFilter);
            this.grpACUnit.Controls.Add(this.lblPriceDisplay);
            this.grpACUnit.Controls.Add(this.lblPriceTag);
            this.grpACUnit.Controls.Add(this.lblSerialDisplay);
            this.grpACUnit.Controls.Add(this.lblSerialTag);
            this.grpACUnit.Controls.Add(this.lblHPDisplay);
            this.grpACUnit.Controls.Add(this.lblHPTag);
            this.grpACUnit.Controls.Add(this.lblBrandDisplay);
            this.grpACUnit.Controls.Add(this.lblBrandTag);
            this.grpACUnit.Controls.Add(this.cmbSelectACUnit);
            this.grpACUnit.Controls.Add(this.lblSelectAC);
            this.grpACUnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpACUnit.Location = new System.Drawing.Point(500, 45);
            this.grpACUnit.Name = "grpACUnit";
            this.grpACUnit.Size = new System.Drawing.Size(465, 230);
            this.grpACUnit.TabIndex = 2;
            this.grpACUnit.TabStop = false;
            this.grpACUnit.Text = "2. Select AC Unit from Stock";
            // 
            // cmbBrandFilter
            // 
            this.cmbBrandFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrandFilter.FormattingEnabled = true;
            this.cmbBrandFilter.Location = new System.Drawing.Point(140, 24);
            this.cmbBrandFilter.Name = "cmbBrandFilter";
            this.cmbBrandFilter.Size = new System.Drawing.Size(310, 23);
            this.cmbBrandFilter.TabIndex = 1;
            this.cmbBrandFilter.SelectedIndexChanged += new System.EventHandler(this.cmbBrandFilter_SelectedIndexChanged);
            // 
            // lblBrandFilter
            // 
            this.lblBrandFilter.AutoSize = true;
            this.lblBrandFilter.Location = new System.Drawing.Point(15, 27);
            this.lblBrandFilter.Name = "lblBrandFilter";
            this.lblBrandFilter.Size = new System.Drawing.Size(70, 15);
            this.lblBrandFilter.TabIndex = 2;
            this.lblBrandFilter.Text = "Filter Brand:";
            // 
            // lblPriceDisplay
            // 
            this.lblPriceDisplay.AutoSize = true;
            this.lblPriceDisplay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPriceDisplay.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPriceDisplay.Location = new System.Drawing.Point(140, 188);
            this.lblPriceDisplay.Name = "lblPriceDisplay";
            this.lblPriceDisplay.Size = new System.Drawing.Size(51, 21);
            this.lblPriceDisplay.TabIndex = 3;
            this.lblPriceDisplay.Text = "₱0.00";
            // 
            // lblPriceTag
            // 
            this.lblPriceTag.AutoSize = true;
            this.lblPriceTag.Location = new System.Drawing.Point(15, 192);
            this.lblPriceTag.Name = "lblPriceTag";
            this.lblPriceTag.Size = new System.Drawing.Size(95, 15);
            this.lblPriceTag.TabIndex = 4;
            this.lblPriceTag.Text = "Cash / Full Price:";
            // 
            // lblSerialDisplay
            // 
            this.lblSerialDisplay.AutoSize = true;
            this.lblSerialDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSerialDisplay.Location = new System.Drawing.Point(140, 158);
            this.lblSerialDisplay.Name = "lblSerialDisplay";
            this.lblSerialDisplay.Size = new System.Drawing.Size(13, 17);
            this.lblSerialDisplay.TabIndex = 5;
            this.lblSerialDisplay.Text = "-";
            // 
            // lblSerialTag
            // 
            this.lblSerialTag.AutoSize = true;
            this.lblSerialTag.Location = new System.Drawing.Point(15, 160);
            this.lblSerialTag.Name = "lblSerialTag";
            this.lblSerialTag.Size = new System.Drawing.Size(85, 15);
            this.lblSerialTag.TabIndex = 6;
            this.lblSerialTag.Text = "Serial Number:";
            // 
            // lblHPDisplay
            // 
            this.lblHPDisplay.AutoSize = true;
            this.lblHPDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHPDisplay.Location = new System.Drawing.Point(140, 126);
            this.lblHPDisplay.Name = "lblHPDisplay";
            this.lblHPDisplay.Size = new System.Drawing.Size(13, 17);
            this.lblHPDisplay.TabIndex = 7;
            this.lblHPDisplay.Text = "-";
            // 
            // lblHPTag
            // 
            this.lblHPTag.AutoSize = true;
            this.lblHPTag.Location = new System.Drawing.Point(15, 128);
            this.lblHPTag.Name = "lblHPTag";
            this.lblHPTag.Size = new System.Drawing.Size(74, 15);
            this.lblHPTag.TabIndex = 8;
            this.lblHPTag.Text = "Horsepower:";
            // 
            // lblBrandDisplay
            // 
            this.lblBrandDisplay.AutoSize = true;
            this.lblBrandDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBrandDisplay.Location = new System.Drawing.Point(140, 94);
            this.lblBrandDisplay.Name = "lblBrandDisplay";
            this.lblBrandDisplay.Size = new System.Drawing.Size(13, 17);
            this.lblBrandDisplay.TabIndex = 9;
            this.lblBrandDisplay.Text = "-";
            // 
            // lblBrandTag
            // 
            this.lblBrandTag.AutoSize = true;
            this.lblBrandTag.Location = new System.Drawing.Point(15, 96);
            this.lblBrandTag.Name = "lblBrandTag";
            this.lblBrandTag.Size = new System.Drawing.Size(41, 15);
            this.lblBrandTag.TabIndex = 10;
            this.lblBrandTag.Text = "Brand:";
            // 
            // cmbSelectACUnit
            // 
            this.cmbSelectACUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectACUnit.FormattingEnabled = true;
            this.cmbSelectACUnit.Location = new System.Drawing.Point(140, 58);
            this.cmbSelectACUnit.Name = "cmbSelectACUnit";
            this.cmbSelectACUnit.Size = new System.Drawing.Size(310, 23);
            this.cmbSelectACUnit.TabIndex = 3;
            this.cmbSelectACUnit.SelectedIndexChanged += new System.EventHandler(this.cmbSelectACUnit_SelectedIndexChanged);
            // 
            // lblSelectAC
            // 
            this.lblSelectAC.AutoSize = true;
            this.lblSelectAC.Location = new System.Drawing.Point(15, 61);
            this.lblSelectAC.Name = "lblSelectAC";
            this.lblSelectAC.Size = new System.Drawing.Size(88, 15);
            this.lblSelectAC.TabIndex = 11;
            this.lblSelectAC.Text = "Available Units:";
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.lblTotalDueDisplay);
            this.grpPayment.Controls.Add(this.lblTotalDueTag);
            this.grpPayment.Controls.Add(this.txtReceiptRef);
            this.grpPayment.Controls.Add(this.lblReceipt);
            this.grpPayment.Controls.Add(this.cmbPaymentMethod);
            this.grpPayment.Controls.Add(this.lblMethod);
            this.grpPayment.Controls.Add(this.dtpContractDate);
            this.grpPayment.Controls.Add(this.lblSaleDate);
            this.grpPayment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpPayment.Location = new System.Drawing.Point(17, 290);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(948, 120);
            this.grpPayment.TabIndex = 3;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "3. Full Payment Details (No Monthly Schedule - Goes Straight to Transaction Log)";
            // 
            // lblTotalDueDisplay
            // 
            this.lblTotalDueDisplay.AutoSize = true;
            this.lblTotalDueDisplay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalDueDisplay.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotalDueDisplay.Location = new System.Drawing.Point(755, 42);
            this.lblTotalDueDisplay.Name = "lblTotalDueDisplay";
            this.lblTotalDueDisplay.Size = new System.Drawing.Size(62, 25);
            this.lblTotalDueDisplay.TabIndex = 0;
            this.lblTotalDueDisplay.Text = "₱0.00";
            // 
            // lblTotalDueTag
            // 
            this.lblTotalDueTag.AutoSize = true;
            this.lblTotalDueTag.Location = new System.Drawing.Point(650, 48);
            this.lblTotalDueTag.Name = "lblTotalDueTag";
            this.lblTotalDueTag.Size = new System.Drawing.Size(107, 15);
            this.lblTotalDueTag.TabIndex = 1;
            this.lblTotalDueTag.Text = "Total Full Payment:";
            // 
            // txtReceiptRef
            // 
            this.txtReceiptRef.Location = new System.Drawing.Point(430, 72);
            this.txtReceiptRef.Name = "txtReceiptRef";
            this.txtReceiptRef.Size = new System.Drawing.Size(185, 23);
            this.txtReceiptRef.TabIndex = 5;
            // 
            // lblReceipt
            // 
            this.lblReceipt.AutoSize = true;
            this.lblReceipt.Location = new System.Drawing.Point(320, 75);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(87, 15);
            this.lblReceipt.TabIndex = 6;
            this.lblReceipt.Text = "Receipt / Ref #:";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(430, 30);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(185, 23);
            this.cmbPaymentMethod.TabIndex = 3;
            this.cmbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMethod_SelectedIndexChanged);
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(320, 33);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(102, 15);
            this.lblMethod.TabIndex = 7;
            this.lblMethod.Text = "Payment Method:";
            // 
            // dtpContractDate
            // 
            this.dtpContractDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpContractDate.Location = new System.Drawing.Point(120, 30);
            this.dtpContractDate.Name = "dtpContractDate";
            this.dtpContractDate.Size = new System.Drawing.Size(165, 23);
            this.dtpContractDate.TabIndex = 1;
            // 
            // lblSaleDate
            // 
            this.lblSaleDate.AutoSize = true;
            this.lblSaleDate.Location = new System.Drawing.Point(15, 33);
            this.lblSaleDate.Name = "lblSaleDate";
            this.lblSaleDate.Size = new System.Drawing.Size(58, 15);
            this.lblSaleDate.TabIndex = 8;
            this.lblSaleDate.Text = "Sale Date:";
            // 
            // grpInstallInfo
            // 
            this.grpInstallInfo.Controls.Add(this.cmbTechnician);
            this.grpInstallInfo.Controls.Add(this.lblTechnician);
            this.grpInstallInfo.Controls.Add(this.txtInstallationNotes);
            this.grpInstallInfo.Controls.Add(this.lblInstallNotes);
            this.grpInstallInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpInstallInfo.Location = new System.Drawing.Point(17, 425);
            this.grpInstallInfo.Name = "grpInstallInfo";
            this.grpInstallInfo.Size = new System.Drawing.Size(948, 80);
            this.grpInstallInfo.TabIndex = 4;
            this.grpInstallInfo.TabStop = false;
            this.grpInstallInfo.Text = "4. Installation Assignment & Notes";
            // 
            // cmbTechnician
            // 
            this.cmbTechnician.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTechnician.FormattingEnabled = true;
            this.cmbTechnician.Location = new System.Drawing.Point(710, 32);
            this.cmbTechnician.Name = "cmbTechnician";
            this.cmbTechnician.Size = new System.Drawing.Size(220, 23);
            this.cmbTechnician.TabIndex = 1;
            // 
            // lblTechnician
            // 
            this.lblTechnician.AutoSize = true;
            this.lblTechnician.Location = new System.Drawing.Point(600, 35);
            this.lblTechnician.Name = "lblTechnician";
            this.lblTechnician.Size = new System.Drawing.Size(94, 15);
            this.lblTechnician.TabIndex = 2;
            this.lblTechnician.Text = "Lead Technician:";
            // 
            // txtInstallationNotes
            // 
            this.txtInstallationNotes.Location = new System.Drawing.Point(130, 32);
            this.txtInstallationNotes.Name = "txtInstallationNotes";
            this.txtInstallationNotes.Size = new System.Drawing.Size(450, 23);
            this.txtInstallationNotes.TabIndex = 0;
            // 
            // lblInstallNotes
            // 
            this.lblInstallNotes.AutoSize = true;
            this.lblInstallNotes.Location = new System.Drawing.Point(15, 35);
            this.lblInstallNotes.Name = "lblInstallNotes";
            this.lblInstallNotes.Size = new System.Drawing.Size(102, 15);
            this.lblInstallNotes.TabIndex = 3;
            this.lblInstallNotes.Text = "Installation Notes:";
            // 
            // btnCompleteSale
            // 
            this.btnCompleteSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompleteSale.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCompleteSale.Location = new System.Drawing.Point(595, 592);
            this.btnCompleteSale.Name = "btnCompleteSale";
            this.btnCompleteSale.Size = new System.Drawing.Size(255, 32);
            this.btnCompleteSale.TabIndex = 4;
            this.btnCompleteSale.Text = "Complete Full Payment Sale";
            this.btnCompleteSale.UseVisualStyleBackColor = true;
            this.btnCompleteSale.Click += new System.EventHandler(this.btnCompleteSale_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.Location = new System.Drawing.Point(865, 592);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormFullSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 635);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCompleteSale);
            this.Controls.Add(this.grpInstallInfo);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.grpACUnit);
            this.Controls.Add(this.grpCustomer);
            this.Name = "FormFullSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Full Payment / Cash Sale & Installation";
            this.Load += new System.EventHandler(this.FormFullSale_Load);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpACUnit.ResumeLayout(false);
            this.grpACUnit.PerformLayout();
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.grpInstallInfo.ResumeLayout(false);
            this.grpInstallInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.TextBox txtValidID;
        private System.Windows.Forms.Label lblValidID;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.ComboBox cmbCustomerList;
        private System.Windows.Forms.Label lblExistingCust;
        private System.Windows.Forms.GroupBox grpACUnit;
        private System.Windows.Forms.Label lblBrandFilter;
        private System.Windows.Forms.ComboBox cmbBrandFilter;
        private System.Windows.Forms.Label lblPriceDisplay;
        private System.Windows.Forms.Label lblPriceTag;
        private System.Windows.Forms.Label lblSerialDisplay;
        private System.Windows.Forms.Label lblSerialTag;
        private System.Windows.Forms.Label lblHPDisplay;
        private System.Windows.Forms.Label lblHPTag;
        private System.Windows.Forms.Label lblBrandDisplay;
        private System.Windows.Forms.Label lblBrandTag;
        private System.Windows.Forms.ComboBox cmbSelectACUnit;
        private System.Windows.Forms.Label lblSelectAC;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.Label lblTotalDueDisplay;
        private System.Windows.Forms.Label lblTotalDueTag;
        private System.Windows.Forms.TextBox txtReceiptRef;
        private System.Windows.Forms.Label lblReceipt;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.DateTimePicker dtpContractDate;
        private System.Windows.Forms.Label lblSaleDate;
        private System.Windows.Forms.GroupBox grpInstallInfo;
        private System.Windows.Forms.Label lblInstallNotes;
        private System.Windows.Forms.TextBox txtInstallationNotes;
        private System.Windows.Forms.Label lblTechnician;
        private System.Windows.Forms.ComboBox cmbTechnician;
        private System.Windows.Forms.Button btnCompleteSale;
        private System.Windows.Forms.Button btnCancel;
    }
}
