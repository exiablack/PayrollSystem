using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace PayrollSystem
{
    public partial class AddSSSForm : Form
    {
        public AddSSSForm()
        {
            InitializeComponent();
            setID();
        }

        private void setID()
        {
            string constring = "datasource=localhost;port=3306;username=root;password=toor";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("select MAX(sssID) as 'id' from db_payroll.tblsss;", conDataBase);
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
            txtSalCred.Text = "";
            txtTotal.Text = "";
            txtDCFrom.Text = "";
            txtDCTo.Text = "";
            txtDCEe.Text = "";
            txtDCEr.Text = "";
            txtDCSal.Text = "";
            txtDCTotal.Text = "";
            setID();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtID.Text);

            int firstFrom = Convert.ToInt32(txtFrom.Text);
            int secondFrom = Convert.ToInt32(txtDCFrom.Text);
            string fromSum = firstFrom + "." + secondFrom;
            float from = float.Parse(fromSum);

            int firstTo = Convert.ToInt32(txtTo.Text);
            int secondTo = Convert.ToInt32(txtDCTo.Text);
            string toSum = firstTo + "." + secondTo;
            float to = float.Parse(toSum);

            int firstEE = Convert.ToInt32(txtEE.Text);
            int secondEE = Convert.ToInt32(txtDCEe.Text);
            string eeSum = firstEE + "." + secondEE;
            float ee = float.Parse(eeSum);

            int firstER = Convert.ToInt32(txtER.Text);
            int secondER = Convert.ToInt32(txtDCEr.Text);
            string erSum = firstER + "." + secondER;
            float er = float.Parse(erSum);

            int firstSal = Convert.ToInt32(txtSalCred.Text);
            int secondSal = Convert.ToInt32(txtDCSal.Text);
            string salSum = firstSal + "." + secondSal;
            float salbase = float.Parse(salSum);

            int firstTotal = Convert.ToInt32(txtTotal.Text);
            int secondTotal = Convert.ToInt32(txtDCTotal.Text);
            string totalSum = firstTotal + "." + secondTotal;
            float total = float.Parse(totalSum);

            string constring = "datasource=localhost;port=3306;username=root;password=toor";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("insert into db_payroll.tblsss values('" + id + "', '" + from + "','" + to + "','" + salbase + "','" + ee + "','" + er + "','" + total + "')", conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                while (myReader.Read())
                {

                }
                clearTxt();
                MessageBox.Show("SSS Contribution successfully saved!");

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

        private void txtEE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtER_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtSalCred_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtER_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = e.KeyCode == Keys.Back && txtER.Text == ""; 
        }

        private void txtDCFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtDCTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtDCSal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtDCEe_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtDCEr_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtDCTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtDCEr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int firstEE = Convert.ToInt32(txtEE.Text);
                int secondEE = Convert.ToInt32(txtDCEe.Text);
                string eeSum = firstEE + "." + secondEE;
                float ee = float.Parse(eeSum);

                int firstER = Convert.ToInt32(txtER.Text);
                int secondER = Convert.ToInt32(txtDCEr.Text);
                string erSum = firstER + "." + secondER;
                float er = float.Parse(erSum);

                float sum = ee + er;

                string s = sum.ToString("0.00", CultureInfo.InvariantCulture);
                string[] parts = s.Split('.');
                int i1 = int.Parse(parts[0]);
                int i2 = int.Parse(parts[1]);

                txtTotal.Text = i1.ToString();
                txtDCTotal.Text = i2.ToString();
            }
        }

    }
}
