using System;
using System.Data;
using System.Windows.Forms;

namespace RAC_System.Forms
{
    public partial class FormNewSale : Form
    {
        public FormNewSale()
        {
            InitializeComponent();
        }

        private void FormNewSale_Load(object sender, EventArgs e)
        {
            // Set default presets
            cmbTerms.SelectedIndex = 2; // Default to 6 Months
            dtpContractDate.Value = DateTime.Now;
        }

        private void cmbSelectACUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Placeholder: Auto-fill brand, HP, serial, price labels when user selects an AC
        }

        private void btnPreviewSchedule_Click(object sender, EventArgs e)
        {
            // Basic UI math preview for testing the table visually
            try
            {
                decimal total = decimal.TryParse(lblPriceDisplay.Text.Replace("₱", "").Replace(",", "").Trim(), out decimal p) ? p : 36000m;
                decimal downPayment = nudDownPayment.Value;
                decimal balance = total - downPayment;

                int months = 6;
                if (cmbTerms.SelectedItem != null)
                {
                    string selected = cmbTerms.SelectedItem.ToString();
                    int.TryParse(selected.Split(' ')[0], out months);
                    if (months <= 0) months = 6;
                }

                lblRemainingBalance.Text = "₱" + balance.ToString("N2");
                decimal monthlyDue = Math.Round(balance / months, 2);
                lblMonthlyDue.Text = "₱" + monthlyDue.ToString("N2") + " / month";

                // Populate preview table
                DataTable dt = new DataTable();
                dt.Columns.Add("Month #", typeof(string));
                dt.Columns.Add("Due Date", typeof(string));
                dt.Columns.Add("Amount Due", typeof(string));
                dt.Columns.Add("Status", typeof(string));

                DateTime startDate = dtpContractDate.Value;
                for (int i = 1; i <= months; i++)
                {
                    DateTime dueDate = startDate.AddMonths(i);
                    dt.Rows.Add("Month " + i, dueDate.ToString("MMM dd, yyyy"), "₱" + monthlyDue.ToString("N2"), "Scheduled");
                }

                dgvSchedulePreview.DataSource = dt;
            }
            catch
            {
                // Soft preview catch
            }
        }

        private void btnSaveContract_Click(object sender, EventArgs e)
        {
            // Placeholder: Will insert into Customers, SalesContracts, InstallmentSchedule, and deduct Inventory
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
