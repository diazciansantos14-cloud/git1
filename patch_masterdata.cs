using System;
using System.IO;
using System.Text;

class Patch {
    static void Main() {
        string file = @"D:\codeshi\final2\final2\FormMasterData.Designer.cs";
        string content = File.ReadAllText(file, new UTF8Encoding(true));

        // 1. Field declarations
        content = content.Replace(
            "        private System.Windows.Forms.TextBox txtSupAddress;",
            "        private System.Windows.Forms.TextBox txtSupAddress;\r\n        private System.Windows.Forms.TabPage tabPayMethods;\r\n        private System.Windows.Forms.DataGridView dgvPayMethods;\r\n        private System.Windows.Forms.Panel pnlPayMethodInput;\r\n        private System.Windows.Forms.Button btnAddPayMethod;\r\n        private System.Windows.Forms.TextBox txtPayMethodName;\r\n        private System.Windows.Forms.Label lblPayMethodName;"
        );

        // 2. Instantiate
        content = content.Replace(
            "            this.pnlTop.SuspendLayout();",
            "            this.tabPayMethods = new System.Windows.Forms.TabPage();\r\n            this.dgvPayMethods = new System.Windows.Forms.DataGridView();\r\n            this.pnlPayMethodInput = new System.Windows.Forms.Panel();\r\n            this.btnAddPayMethod = new System.Windows.Forms.Button();\r\n            this.txtPayMethodName = new System.Windows.Forms.TextBox();\r\n            this.lblPayMethodName = new System.Windows.Forms.Label();\r\n            this.pnlTop.SuspendLayout();"
        );

        // 3. Add to tabMaster
        content = content.Replace(
            "            this.tabMaster.Controls.Add(this.tabSuppliers);",
            "            this.tabMaster.Controls.Add(this.tabSuppliers);\r\n            this.tabMaster.Controls.Add(this.tabPayMethods);"
        );

        // 4. SuspendLayout
        content = content.Replace(
            "            this.tabSuppliers.SuspendLayout();",
            "            this.tabSuppliers.SuspendLayout();\r\n            this.tabPayMethods.SuspendLayout();\r\n            ((System.ComponentModel.ISupportInitialize)(this.dgvPayMethods)).BeginInit();\r\n            this.pnlPayMethodInput.SuspendLayout();"
        );

        // 5. ResumeLayout
        content = content.Replace(
            "            this.tabSuppliers.ResumeLayout(false);",
            "            this.tabSuppliers.ResumeLayout(false);\r\n            this.tabPayMethods.ResumeLayout(false);\r\n            ((System.ComponentModel.ISupportInitialize)(this.dgvPayMethods)).EndInit();\r\n            this.pnlPayMethodInput.ResumeLayout(false);\r\n            this.pnlPayMethodInput.PerformLayout();"
        );

        // 6. Control definitions
        string tabDef = "\r\n            // \r\n            // tabPayMethods\r\n            // \r\n            this.tabPayMethods.Controls.Add(this.dgvPayMethods);\r\n            this.tabPayMethods.Controls.Add(this.pnlPayMethodInput);\r\n            this.tabPayMethods.Location = new System.Drawing.Point(4, 26);\r\n            this.tabPayMethods.Name = \"tabPayMethods\";\r\n            this.tabPayMethods.Padding = new System.Windows.Forms.Padding(15);\r\n            this.tabPayMethods.Size = new System.Drawing.Size(992, 495);\r\n            this.tabPayMethods.TabIndex = 4;\r\n            this.tabPayMethods.Text = \"Payment Methods\";\r\n            this.tabPayMethods.UseVisualStyleBackColor = true;\r\n            // \r\n            // dgvPayMethods\r\n            // \r\n            this.dgvPayMethods.AllowUserToAddRows = false;\r\n            this.dgvPayMethods.AllowUserToDeleteRows = false;\r\n            this.dgvPayMethods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;\r\n            this.dgvPayMethods.BackgroundColor = System.Drawing.Color.White;\r\n            this.dgvPayMethods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;\r\n            this.dgvPayMethods.Dock = System.Windows.Forms.DockStyle.Fill;\r\n            this.dgvPayMethods.Location = new System.Drawing.Point(15, 75);\r\n            this.dgvPayMethods.Name = \"dgvPayMethods\";\r\n            this.dgvPayMethods.ReadOnly = true;\r\n            this.dgvPayMethods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;\r\n            this.dgvPayMethods.Size = new System.Drawing.Size(962, 405);\r\n            this.dgvPayMethods.TabIndex = 1;\r\n            // \r\n            // pnlPayMethodInput\r\n            // \r\n            this.pnlPayMethodInput.Controls.Add(this.btnAddPayMethod);\r\n            this.pnlPayMethodInput.Controls.Add(this.txtPayMethodName);\r\n            this.pnlPayMethodInput.Controls.Add(this.lblPayMethodName);\r\n            this.pnlPayMethodInput.Dock = System.Windows.Forms.DockStyle.Top;\r\n            this.pnlPayMethodInput.Location = new System.Drawing.Point(15, 15);\r\n            this.pnlPayMethodInput.Name = \"pnlPayMethodInput\";\r\n            this.pnlPayMethodInput.Size = new System.Drawing.Size(962, 60);\r\n            this.pnlPayMethodInput.TabIndex = 0;\r\n            // \r\n            // btnAddPayMethod\r\n            // \r\n            this.btnAddPayMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));\r\n            this.btnAddPayMethod.FlatAppearance.BorderSize = 0;\r\n            this.btnAddPayMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;\r\n            this.btnAddPayMethod.Font = new System.Drawing.Font(\"Segoe UI Semibold\", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));\r\n            this.btnAddPayMethod.ForeColor = System.Drawing.Color.White;\r\n            this.btnAddPayMethod.Location = new System.Drawing.Point(400, 12);\r\n            this.btnAddPayMethod.Name = \"btnAddPayMethod\";\r\n            this.btnAddPayMethod.Size = new System.Drawing.Size(200, 32);\r\n            this.btnAddPayMethod.TabIndex = 2;\r\n            this.btnAddPayMethod.Text = \"Add Payment Method\";\r\n            this.btnAddPayMethod.UseVisualStyleBackColor = false;\r\n            this.btnAddPayMethod.Click += new System.EventHandler(this.btnAddPayMethod_Click);\r\n            // \r\n            // txtPayMethodName\r\n            // \r\n            this.txtPayMethodName.Location = new System.Drawing.Point(145, 16);\r\n            this.txtPayMethodName.Name = \"txtPayMethodName\";\r\n            this.txtPayMethodName.Size = new System.Drawing.Size(235, 25);\r\n            this.txtPayMethodName.TabIndex = 1;\r\n            // \r\n            // lblPayMethodName\r\n            // \r\n            this.lblPayMethodName.AutoSize = true;\r\n            this.lblPayMethodName.Location = new System.Drawing.Point(15, 19);\r\n            this.lblPayMethodName.Name = \"lblPayMethodName\";\r\n            this.lblPayMethodName.Size = new System.Drawing.Size(120, 17);\r\n            this.lblPayMethodName.TabIndex = 0;\r\n            this.lblPayMethodName.Text = \"Method Name:\";\r\n";
        content = content.Replace("            // FormMasterData", tabDef + "\r\n            // FormMasterData");

        File.WriteAllText(file, content, new UTF8Encoding(true));
        Console.WriteLine("Done");
    }
}
