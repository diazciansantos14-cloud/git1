using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace test1
{
    public partial class FormMasterData : Form
    {
        private string connectionString = @"Server=.\SQLEXPRESS;Database=RAC_DB;Integrated Security=True;TrustServerCertificate=True;";

        public FormMasterData()
        {
            InitializeComponent();
        }

        private void FormMasterData_Load(object sender, EventArgs e)
        {
            LoadBrands();
            LoadUnitTypes();
            LoadHorsepowers();
            LoadSuppliers();
            EnsurePaymentMethodsTable();
            LoadPaymentMethods();
        }

        // ===================== BRANDS TAB =====================
        public void LoadBrands()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT BrandID, BrandName, IsActive FROM Brands ORDER BY BrandName", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvBrands.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading brands: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            string brandName = txtBrandName.Text.Trim();
            if (string.IsNullOrWhiteSpace(brandName))
            {
                MessageBox.Show("Please type a Brand Name!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Brands (BrandName, IsActive) VALUES (@Name, 1)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", brandName);
                        cmd.ExecuteNonQuery();
                    }
                }
                txtBrandName.Clear();
                LoadBrands();
                MessageBox.Show($"Brand '{brandName}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brand already exists or database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===================== UNIT TYPES TAB =====================
        public void LoadUnitTypes()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT TypeID, TypeName FROM UnitTypes ORDER BY TypeName", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvTypes.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading unit types: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            string typeName = txtTypeName.Text.Trim();
            if (string.IsNullOrWhiteSpace(typeName))
            {
                MessageBox.Show("Please type a Unit Type name!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO UnitTypes (TypeName) VALUES (@Name)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", typeName);
                        cmd.ExecuteNonQuery();
                    }
                }
                txtTypeName.Clear();
                LoadUnitTypes();
                MessageBox.Show($"Unit Type '{typeName}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unit Type already exists or database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===================== HORSEPOWER TAB =====================
        public void LoadHorsepowers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT HPID, HPRating FROM HorsepowerOptions ORDER BY HPID", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvHP.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading HP options: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddHP_Click(object sender, EventArgs e)
        {
            string hpRating = txtHPRating.Text.Trim();
            if (string.IsNullOrWhiteSpace(hpRating))
            {
                MessageBox.Show("Please type an HP rating (e.g. '3.5 HP')!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO HorsepowerOptions (HPRating) VALUES (@Rating)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Rating", hpRating);
                        cmd.ExecuteNonQuery();
                    }
                }
                txtHPRating.Clear();
                LoadHorsepowers();
                MessageBox.Show($"HP Rating '{hpRating}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("HP Rating already exists or database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===================== SUPPLIERS TAB =====================
        public void LoadSuppliers()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT SupplierID, SupplierName, ContactPerson, ContactNumber, Address, CreatedAt FROM Suppliers ORDER BY SupplierName", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvSuppliers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            string supName = txtSupName.Text.Trim();
            string supPerson = txtSupPerson.Text.Trim();
            string supContact = txtSupContact.Text.Trim();
            string supAddress = txtSupAddress.Text.Trim();

            if (string.IsNullOrWhiteSpace(supName) || string.IsNullOrWhiteSpace(supContact) || string.IsNullOrWhiteSpace(supAddress))
            {
                MessageBox.Show("Please enter Supplier Company Name, Contact No., and Address!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Suppliers (SupplierName, ContactPerson, ContactNumber, Address) VALUES (@Name, @Person, @Contact, @Address)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", supName);
                        cmd.Parameters.AddWithValue("@Person", string.IsNullOrWhiteSpace(supPerson) ? (object)DBNull.Value : supPerson);
                        cmd.Parameters.AddWithValue("@Contact", supContact);
                        cmd.Parameters.AddWithValue("@Address", supAddress);
                        cmd.ExecuteNonQuery();
                    }
                }
                txtSupName.Clear();
                txtSupPerson.Clear();
                txtSupContact.Clear();
                txtSupAddress.Clear();
                LoadSuppliers();
                MessageBox.Show($"Supplier '{supName}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add supplier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===================== PAYMENT METHODS TAB =====================
        private void EnsurePaymentMethodsTable()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string createTable = @"
                        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='PaymentMethods' AND xtype='U')
                        BEGIN
                            CREATE TABLE PaymentMethods (
                                MethodID INT IDENTITY(1,1) PRIMARY KEY,
                                MethodName NVARCHAR(100) NOT NULL UNIQUE,
                                IsActive BIT NOT NULL DEFAULT 1,
                                SortOrder INT NOT NULL DEFAULT 99
                            );
                            INSERT INTO PaymentMethods (MethodName, IsActive, SortOrder) VALUES
                                ('Cash', 1, 1),
                                ('GCash', 1, 2),
                                ('Bank Transfer', 1, 3),
                                ('Check', 1, 4);
                        END";
                    using (SqlCommand cmd = new SqlCommand(createTable, conn))
                        cmd.ExecuteNonQuery();
                }
            }
            catch { }
        }

        public void LoadPaymentMethods()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT MethodID, MethodName, IsActive, SortOrder FROM PaymentMethods ORDER BY SortOrder, MethodName", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPayMethods.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payment methods: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddPayMethod_Click(object sender, EventArgs e)
        {
            string methodName = txtPayMethodName.Text.Trim();
            if (string.IsNullOrWhiteSpace(methodName))
            {
                MessageBox.Show("Please enter a payment method name (e.g. 'GCash', 'Maya', 'Bank Transfer').",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO PaymentMethods (MethodName, IsActive, SortOrder) VALUES (@Name, 1, 99)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", methodName);
                        cmd.ExecuteNonQuery();
                    }
                }
                txtPayMethodName.Clear();
                LoadPaymentMethods();
                MessageBox.Show($"Payment method '{methodName}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add payment method: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
