using System;
using System.Windows.Forms;

namespace RAC_System.Forms
{
    public partial class FormMain : Form
    {
        private Form activeChildForm = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Initial view: show Dashboard cards and upcoming dues
            ShowDashboardView();
        }

        private void ShowDashboardView()
        {
            if (activeChildForm != null)
            {
                activeChildForm.Close();
                activeChildForm = null;
            }
            pnlDashboard.Visible = true;
            lblCurrentViewTitle.Text = "Dashboard Overview & Collections Summary";
        }

        private void LoadFormIntoPanel(Form childForm, string viewTitle)
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

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboardView();
        }

        private void btnNavInventory_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new FormInventory(), "AC Inventory & Stock Availability");
        }

        private void btnNavNewSale_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new FormNewSale(), "New Installment Sale & Contract Generator");
        }

        private void btnNavPayments_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new FormPaymentTracker(), "Payment Collections & Installment Ledger");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
