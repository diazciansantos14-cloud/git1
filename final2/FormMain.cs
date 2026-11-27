using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace test1
{
    public partial class FormMain : Form
    {
        private Form activeChildForm = null;

        public FormMain()
        {
            InitializeComponent();
            InitializeSubmenus();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Bind Dashboard DataGridView columns
            colCustomer.DataPropertyName = "CustomerName";
            colUnit.DataPropertyName = "UnitPurchased";
            colDueDate.DataPropertyName = "DueDate";
            colAmountDue.DataPropertyName = "AmountDue";
            colContact.DataPropertyName = "ContactNumber";

            colAmountDue.DefaultCellStyle.Format = "₱#,##0.00";

            // Display user info from session
            lblUserInfo.Text = $"👤 {UserSession.FullName} ({UserSession.Role})";

            // Enforce Role-Based Access Control
            if (!UserSession.IsAdmin)
            {
                btnSubUsers.Enabled = false;
                btnSubUsers.Text += " 🔒";
                btnSubMasterData.Enabled = false;
                btnSubMasterData.Text += " 🔒";
            }

            ShowDashboardView();
        }

        // Hide all submenus initially
        private void InitializeSubmenus()
        {
            pnlSubSales.Visible = false;
            pnlSubInventory.Visible = false;
            pnlSubProcurement.Visible = false;
            pnlSubAdmin.Visible = false;
        }

        private void HideSubmenus()
        {
            if (pnlSubSales.Visible) pnlSubSales.Visible = false;
            if (pnlSubInventory.Visible) pnlSubInventory.Visible = false;
            if (pnlSubProcurement.Visible) pnlSubProcurement.Visible = false;
            if (pnlSubAdmin.Visible) pnlSubAdmin.Visible = false;
        }

        private void ToggleSubmenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubmenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        public void ShowDashboardView()
        {
            if (activeChildForm != null)
            {
                activeChildForm.Close();
                activeChildForm = null;
            }
            pnlDashboard.Visible = true;
            lblCurrentViewTitle.Text = "Dashboard Overview & Operations Summary";

            LoadDashboardMetrics();
        }

        public void LoadDashboardMetrics()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Total Physical Units in Stock
                    using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(SUM(StockQty), 0) FROM Inventory", conn))
                    {
                        lblCountStock.Text = cmd.ExecuteScalar()?.ToString() ?? "0";
                    }

                    // Active Installment Contracts
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM SalesContracts WHERE ContractStatus = 'Active'", conn))
                    {
                        lblCountContracts.Text = cmd.ExecuteScalar()?.ToString() ?? "0";
                    }

                    // Overdue Collections (past due date and still unpaid)
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM InstallmentSchedule WHERE DueDate < CAST(GETDATE() AS DATE) AND Status <> 'PAID'", conn))
                    {
                        lblCountOverdue.Text = cmd.ExecuteScalar()?.ToString() ?? "0";
                    }

                    // Upcoming Collections Due schedule grid
                    string schedQuery = @"SELECT c.FullName AS CustomerName,
                                                 inv.Brand + ' ' + inv.Model AS UnitPurchased,
                                                 s.DueDate,
                                                 s.AmountDue - s.AmountPaid AS AmountDue,
                                                 c.ContactNumber
                                          FROM InstallmentSchedule s
                                          INNER JOIN SalesContracts sc ON s.ContractID = sc.ContractID
                                          INNER JOIN Customers c ON sc.CustomerID = c.CustomerID
                                          INNER JOIN Inventory inv ON sc.ItemID = inv.ItemID
                                          WHERE s.Status <> 'PAID'
                                          ORDER BY s.DueDate ASC";

                    using (SqlCommand cmd = new SqlCommand(schedQuery, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvUpcomingDues.DataSource = dt;
                    }
                }
            }
            catch
            {
                // Fallback gracefully if database is busy
            }
        }

        public void LoadFormIntoPanel(Form childForm, string viewTitle)
        {
            if (activeChildForm != null)
            {
                activeChildForm.Close();
            }

            pnlDashboard.Visible = false;
            activeChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            lblCurrentViewTitle.Text = viewTitle;

            childForm.BringToFront();
            childForm.Show();
        }

        // Top-Level Nav Clicks (Accordion Toggles)
        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            HideSubmenus();
            ShowDashboardView();
        }

        private void btnNavSales_Click(object sender, EventArgs e)
        {
            ToggleSubmenu(pnlSubSales);
        }

        private void btnNavInventory_Click(object sender, EventArgs e)
        {
            ToggleSubmenu(pnlSubInventory);
        }

        private void btnNavProcurement_Click(object sender, EventArgs e)
        {
            ToggleSubmenu(pnlSubProcurement);
        }

        private void btnNavAdmin_Click(object sender, EventArgs e)
        {
            ToggleSubmenu(pnlSubAdmin);
        }

        // Submenu Action Clicks
        private void btnSubNewSale_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new FormNewSale(), "New Installment Sale and Contract Generator");
        }

        private void btnSubFullSale_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new FormFullSale(), "Full Payment / Cash Sale and Installation");
        }

        private void btnSubPayments_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new FormPaymentTracker(), "Payment Collections and Installment Ledger");
        }

        private void btnSubTransactionLog_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new FormPaymentLog(), "Payment Transaction Log and History");
        }

        private void btnSubInstallations_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new FormInstallations(), "Job Orders, Deliveries and Physical Stock Deduction");
        }

        private void btnSubCustomers_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new FormCustomers(), "Customer Directory and Credit Records");
        }

        private void btnSubStocks_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new FormInventory(), "AC Inventory and Stock Availability");
        }

        private void btnSubPOs_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new FormPurchaseOrders(), "Procurement and Purchase Orders");
        }

        private void btnSubMasterData_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new FormMasterData(), "Master Data Maintenance");
        }

        private void btnSubUsers_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new FormUsers(), "User Account and Role Access Management");
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to sign out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UserSession.Clear();
                FormLogin login = new FormLogin();
                login.Show();
                this.Hide();
            }
        }

        private void pnlDashboard_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
