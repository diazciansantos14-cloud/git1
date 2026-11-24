using System;
using System.Windows.Forms;

namespace RAC_System.Forms
{
    public partial class FormInventory : Form
    {
        public FormInventory()
        {
            InitializeComponent();
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            // Designer placeholder - will load database stock rows here later
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            // Placeholder: Add new AC unit to inventory
        }

        private void btnUpdateUnit_Click(object sender, EventArgs e)
        {
            // Placeholder: Update selected AC unit
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            // Placeholder: Reset input fields
        }

        private void btnDeleteUnit_Click(object sender, EventArgs e)
        {
            // Placeholder: Delete selected AC unit
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Placeholder: Populate input fields when clicking a row in the table
        }
    }
}
