using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PayrollSystem
{
    public partial class AddPhilHealthForm : Form
    {
        public AddPhilHealthForm()
        {
            InitializeComponent();
            setID();
        }

        private void setID()
        {
            string constring = "datasource=localhost;port=3306;username=root;password=toor";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("select MAX(phID) as 'id' from db_payroll.tblphilhealth;", conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    int getID = myReader.GetInt32("id");
                    getID++;
                    txtID.Text = getID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clearTxt()
        {
            txtFrom.Text = "";
            txtTo.Text = "";
            txtEE.Text = "";
            txtER.Text = "";
            txtSalBase.Text = "";
            txtMonthly.Text = "";
            setID();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=toor";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("insert into db_payroll.tblphilhealth values('"+ txtID.Text +"', '"+ txtFrom.Text +"','"+ txtTo.Text +"','"+ txtEE.Text +"','"+ txtER.Text +"','"+ txtSalBase.Text +"','"+ txtMonthly.Text +"')", conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    
                }
                clearTxt();
                MessageBox.Show("Philhealth Contribution successfully saved!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtSalBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
            float ee = Convert.ToInt32(txtEE.Text);
            float er = Convert.ToInt32(txtER.Text);
            float sum = ee + er;
            txtMonthly.Text = sum.ToString();
        }

        private void AddPhilHealthForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PhilHealthForm philForm = new PhilHealthForm();
            philForm.Hide();
            philForm.Show();
        }

        private void txtFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.';
        }

        private void txtTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.';
        }

        private void txtEE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.';
        }

        private void txtER_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.';
        }

        private void txtMonthly_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.';
        }

    }
}
