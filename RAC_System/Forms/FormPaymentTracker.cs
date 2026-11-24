using System;
using System.Windows.Forms;

namespace RAC_System.Forms
{
    public partial class FormPaymentTracker : Form
    {
        public FormPaymentTracker()
        {
            InitializeComponent();
        }

        private void FormPaymentTracker_Load(object sender, EventArgs e)
        {
            // Placeholder: Load active customer contracts list
            cmbPaymentMethod.SelectedIndex = 0; // Default to Cash
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Placeholder: Filter contracts list by customer name or contract ID
        }

        private void dgvContractsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Placeholder: Load the selected customer's month-by-month schedule into dgvInstallmentSchedule
        }

        private void btnRecordPayment_Click(object sender, EventArgs e)
        {
            // Placeholder: Pay the selected month row, mark as PAID
        }

        private void btnPayFullSettlement_Click(object sender, EventArgs e)
        {
            // Placeholder: Early payoff - prompt confirmation, mark all remaining rows as PAID
        }

        private void btnExtendDueDate_Click(object sender, EventArgs e)
        {
            // Placeholder: Customer delay/extension - prompt for new due date and reason
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            // Placeholder: Print receipt or statement of account
        }
    }
}
