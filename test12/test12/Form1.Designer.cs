namespace test12
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbuser = new System.Windows.Forms.TextBox();
            this.txbpass = new System.Windows.Forms.TextBox();
            this.btnenter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbuser
            // 
            this.txbuser.Location = new System.Drawing.Point(18, 26);
            this.txbuser.Name = "txbuser";
            this.txbuser.Size = new System.Drawing.Size(245, 20);
            this.txbuser.TabIndex = 0;
            // 
            // txbpass
            // 
            this.txbpass.Location = new System.Drawing.Point(18, 69);
            this.txbpass.Name = "txbpass";
            this.txbpass.Size = new System.Drawing.Size(245, 20);
            this.txbpass.TabIndex = 1;
            // 
            // btnenter
            // 
            this.btnenter.Location = new System.Drawing.Point(20, 116);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(242, 27);
            this.btnenter.TabIndex = 2;
            this.btnenter.Text = "Enter";
            this.btnenter.UseVisualStyleBackColor = true;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(244, 228);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.txbpass);
            this.Controls.Add(this.txbuser);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbuser;
        private System.Windows.Forms.TextBox txbpass;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

