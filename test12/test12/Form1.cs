using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test12
{
    public partial class Form1 : Form
    {
        string constring = ConfigurationManager.ConnectionStrings["MyDb"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            con = new SqlConnection(constring);
            cmd = new SqlCommand(constring);
            cmd.Connection = con;
            LoadUsers();
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "INSERT INTO tblusersam (Username,Password) VALUES ('" + txbuser.Text + "', '" + txbpass.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Account Created", "Account Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUsers();
        }
        private void LoadUsers()
        {

            using (SqlConnection conn = new SqlConnection(constring))
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblusersam", conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            }
        }
    }
