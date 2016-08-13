using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PayrollSystem
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void sSSMaintenanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SSSForm sss = new SSSForm();
            sss.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void philHlealthMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhilHealthForm philhealth = new PhilHealthForm();
            philhealth.Show();
            this.Hide();
        }

        private void taxTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaxTableForm tax = new TaxTableForm();
            tax.Show();
            this.Hide();
        }

        private void employeeMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm emp = new EmployeeForm();
            emp.Show();
            this.Hide();
        }
    }
}
