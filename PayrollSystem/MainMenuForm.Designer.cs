namespace PayrollSystem
{
    partial class MainMenuForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.philHlealthMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sSSMaintenanceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.taxTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payslipTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutVillaSaludCateringPayrollSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.lblDateTime);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 570);
            this.panel1.TabIndex = 0;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(723, 545);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(81, 13);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "Date and Time";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMaintenanceToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMaintenanceToolStripMenuItem
            // 
            this.fileMaintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeMaintenanceToolStripMenuItem,
            this.philHlealthMaintenanceToolStripMenuItem,
            this.sSSMaintenanceToolStripMenuItem1,
            this.taxTableToolStripMenuItem});
            this.fileMaintenanceToolStripMenuItem.Name = "fileMaintenanceToolStripMenuItem";
            this.fileMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.fileMaintenanceToolStripMenuItem.Text = "File Maintenance";
            // 
            // employeeMaintenanceToolStripMenuItem
            // 
            this.employeeMaintenanceToolStripMenuItem.Name = "employeeMaintenanceToolStripMenuItem";
            this.employeeMaintenanceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.employeeMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.employeeMaintenanceToolStripMenuItem.Text = "Employee Maintenance";
            this.employeeMaintenanceToolStripMenuItem.Click += new System.EventHandler(this.employeeMaintenanceToolStripMenuItem_Click);
            // 
            // philHlealthMaintenanceToolStripMenuItem
            // 
            this.philHlealthMaintenanceToolStripMenuItem.Name = "philHlealthMaintenanceToolStripMenuItem";
            this.philHlealthMaintenanceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.philHlealthMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.philHlealthMaintenanceToolStripMenuItem.Text = "PhilHlealth Maintenance";
            this.philHlealthMaintenanceToolStripMenuItem.Click += new System.EventHandler(this.philHlealthMaintenanceToolStripMenuItem_Click);
            // 
            // sSSMaintenanceToolStripMenuItem1
            // 
            this.sSSMaintenanceToolStripMenuItem1.Name = "sSSMaintenanceToolStripMenuItem1";
            this.sSSMaintenanceToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sSSMaintenanceToolStripMenuItem1.Size = new System.Drawing.Size(245, 22);
            this.sSSMaintenanceToolStripMenuItem1.Text = "SSS Maintenance";
            this.sSSMaintenanceToolStripMenuItem1.Click += new System.EventHandler(this.sSSMaintenanceToolStripMenuItem1_Click);
            // 
            // taxTableToolStripMenuItem
            // 
            this.taxTableToolStripMenuItem.Name = "taxTableToolStripMenuItem";
            this.taxTableToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.taxTableToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.taxTableToolStripMenuItem.Text = "Tax Table";
            this.taxTableToolStripMenuItem.Click += new System.EventHandler(this.taxTableToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payrollTransactionToolStripMenuItem,
            this.payslipTransactionToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // payrollTransactionToolStripMenuItem
            // 
            this.payrollTransactionToolStripMenuItem.Name = "payrollTransactionToolStripMenuItem";
            this.payrollTransactionToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.payrollTransactionToolStripMenuItem.Text = "Payroll Transaction";
            // 
            // payslipTransactionToolStripMenuItem
            // 
            this.payslipTransactionToolStripMenuItem.Name = "payslipTransactionToolStripMenuItem";
            this.payslipTransactionToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.payslipTransactionToolStripMenuItem.Text = "Payslip Transaction";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutVillaSaludCateringPayrollSystemToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // aboutVillaSaludCateringPayrollSystemToolStripMenuItem
            // 
            this.aboutVillaSaludCateringPayrollSystemToolStripMenuItem.Name = "aboutVillaSaludCateringPayrollSystemToolStripMenuItem";
            this.aboutVillaSaludCateringPayrollSystemToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.aboutVillaSaludCateringPayrollSystemToolStripMenuItem.Text = "About Villa Salud Catering Payroll System";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 567);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenuForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeMaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem philHlealthMaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payslipTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutVillaSaludCateringPayrollSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sSSMaintenanceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem taxTableToolStripMenuItem;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
    }
}