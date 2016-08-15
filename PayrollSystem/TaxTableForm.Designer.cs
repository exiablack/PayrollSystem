namespace PayrollSystem
{
    partial class TaxTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaxTableForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbType1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txt32 = new System.Windows.Forms.TextBox();
            this.txt30 = new System.Windows.Forms.TextBox();
            this.txt25 = new System.Windows.Forms.TextBox();
            this.txt20 = new System.Windows.Forms.TextBox();
            this.txt15 = new System.Windows.Forms.TextBox();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt0 = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbType2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUpdateTax = new System.Windows.Forms.Button();
            this.txtBaseTax = new System.Windows.Forms.TextBox();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 521);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 505);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Withholding Tax Information";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(6, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(999, 475);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(991, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Withholding Tax";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(272, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(713, 434);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Withholding Tax Contribution Table";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(698, 407);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbType1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.txt32);
            this.groupBox2.Controls.Add(this.txt30);
            this.groupBox2.Controls.Add(this.txt25);
            this.groupBox2.Controls.Add(this.txt20);
            this.groupBox2.Controls.Add(this.txt15);
            this.groupBox2.Controls.Add(this.txt10);
            this.groupBox2.Controls.Add(this.txt5);
            this.groupBox2.Controls.Add(this.txt0);
            this.groupBox2.Controls.Add(this.txtStatus);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 434);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Withholding Tax Information";
            // 
            // cmbType1
            // 
            this.cmbType1.FormattingEnabled = true;
            this.cmbType1.Items.AddRange(new object[] {
            "DAILY",
            "WEEKLY",
            "SEMI-MONTHLY",
            "MONTHLY"});
            this.cmbType1.Location = new System.Drawing.Point(109, 39);
            this.cmbType1.Name = "cmbType1";
            this.cmbType1.Size = new System.Drawing.Size(121, 25);
            this.cmbType1.TabIndex = 19;
            this.cmbType1.SelectedIndexChanged += new System.EventHandler(this.cmbType1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Payment Type:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(86, 376);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 49);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "     Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txt32
            // 
            this.txt32.Location = new System.Drawing.Point(86, 345);
            this.txt32.Name = "txt32";
            this.txt32.Size = new System.Drawing.Size(144, 25);
            this.txt32.TabIndex = 16;
            this.txt32.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt32_KeyPress);
            // 
            // txt30
            // 
            this.txt30.Location = new System.Drawing.Point(86, 314);
            this.txt30.Name = "txt30";
            this.txt30.Size = new System.Drawing.Size(144, 25);
            this.txt30.TabIndex = 15;
            this.txt30.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt30_KeyPress);
            // 
            // txt25
            // 
            this.txt25.Location = new System.Drawing.Point(86, 283);
            this.txt25.Name = "txt25";
            this.txt25.Size = new System.Drawing.Size(144, 25);
            this.txt25.TabIndex = 14;
            this.txt25.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt25_KeyPress);
            // 
            // txt20
            // 
            this.txt20.Location = new System.Drawing.Point(86, 249);
            this.txt20.Name = "txt20";
            this.txt20.Size = new System.Drawing.Size(144, 25);
            this.txt20.TabIndex = 13;
            this.txt20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt20_KeyPress);
            // 
            // txt15
            // 
            this.txt15.Location = new System.Drawing.Point(86, 218);
            this.txt15.Name = "txt15";
            this.txt15.Size = new System.Drawing.Size(144, 25);
            this.txt15.TabIndex = 12;
            this.txt15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt15_KeyPress);
            // 
            // txt10
            // 
            this.txt10.Location = new System.Drawing.Point(86, 187);
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(144, 25);
            this.txt10.TabIndex = 11;
            this.txt10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt10_KeyPress);
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(86, 156);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(144, 25);
            this.txt5.TabIndex = 10;
            this.txt5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt5_KeyPress);
            // 
            // txt0
            // 
            this.txt0.Location = new System.Drawing.Point(86, 125);
            this.txt0.Name = "txt0";
            this.txt0.Size = new System.Drawing.Size(144, 25);
            this.txt0.TabIndex = 9;
            this.txt0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt0_KeyPress);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(86, 94);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(144, 25);
            this.txtStatus.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tax 32%:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tax 30%:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tax 25%:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tax 20%:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tax 15%:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tax 10%:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tax 5%:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tax 0%:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(991, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tax Table";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbType2);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.btnUpdateTax);
            this.groupBox4.Controls.Add(this.txtBaseTax);
            this.groupBox4.Controls.Add(this.txtPercent);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 434);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Withholding Tax Information";
            // 
            // cmbType2
            // 
            this.cmbType2.FormattingEnabled = true;
            this.cmbType2.Items.AddRange(new object[] {
            "DAILY",
            "WEEKLY",
            "SEMI-MONTHLY",
            "MONTHLY"});
            this.cmbType2.Location = new System.Drawing.Point(122, 45);
            this.cmbType2.Name = "cmbType2";
            this.cmbType2.Size = new System.Drawing.Size(129, 25);
            this.cmbType2.TabIndex = 21;
            this.cmbType2.SelectedIndexChanged += new System.EventHandler(this.cmbType2_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Payment Type:";
            // 
            // btnUpdateTax
            // 
            this.btnUpdateTax.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTax.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateTax.Image")));
            this.btnUpdateTax.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateTax.Location = new System.Drawing.Point(122, 180);
            this.btnUpdateTax.Name = "btnUpdateTax";
            this.btnUpdateTax.Size = new System.Drawing.Size(129, 49);
            this.btnUpdateTax.TabIndex = 17;
            this.btnUpdateTax.Text = "   Update";
            this.btnUpdateTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateTax.UseVisualStyleBackColor = false;
            this.btnUpdateTax.Click += new System.EventHandler(this.btnUpdateTax_Click);
            // 
            // txtBaseTax
            // 
            this.txtBaseTax.Location = new System.Drawing.Point(122, 141);
            this.txtBaseTax.Name = "txtBaseTax";
            this.txtBaseTax.Size = new System.Drawing.Size(129, 25);
            this.txtBaseTax.TabIndex = 9;
            this.txtBaseTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBaseTax_KeyPress);
            // 
            // txtPercent
            // 
            this.txtPercent.Enabled = false;
            this.txtPercent.Location = new System.Drawing.Point(122, 103);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(129, 25);
            this.txtPercent.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 141);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "Base Tax:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 103);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 17);
            this.label18.TabIndex = 0;
            this.label18.Text = "Percentage Over:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(272, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(713, 434);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Withholding Tax Contribution Table";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(698, 407);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // TaxTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 512);
            this.Controls.Add(this.panel1);
            this.Name = "TaxTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaxTableForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TaxTableForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txt32;
        private System.Windows.Forms.TextBox txt30;
        private System.Windows.Forms.TextBox txt25;
        private System.Windows.Forms.TextBox txt20;
        private System.Windows.Forms.TextBox txt15;
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt0;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUpdateTax;
        private System.Windows.Forms.TextBox txtBaseTax;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cmbType1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbType2;
        private System.Windows.Forms.Label label11;
    }
}