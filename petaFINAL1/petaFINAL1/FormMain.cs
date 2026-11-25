using System;
using System.Windows.Forms;
using test1;

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

        private void btnInventory_Click(object sender, EventArgs e)
        {
            FormInventory inv = new FormInventory();
            inv.Show(); 
        }

        private void pnlDashboard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
