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
    public partial class PhilHealthForm : Form
    {
        public PhilHealthForm()
        {
            InitializeComponent();
            loadTable();
        }

        private void loadTable()
        {
            string constring = "datasource=localhost;port=3306;username=root;password=toor";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("select * from db_payroll.tblPhilHealth;", conDataBase);

            try
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                dataAdapter.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                dataAdapter.Update(dbdataset);
                setColumnName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setColumnName()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Range From";
            dataGridView1.Columns[2].HeaderText = "Range To";
            dataGridView1.Columns[3].HeaderText = "Salary Credit";
            dataGridView1.Columns[4].HeaderText = "EE Share";
            dataGridView1.Columns[5].HeaderText = "ER Share";
            dataGridView1.Columns[6].HeaderText = "Monthly Premium";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to save the changes?", "PhilHealth Table Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string constring = "datasource=localhost;port=3306;username=root;password=toor";
                string query = "update db_payroll.tblPhilHealth set phID='" + txtID.Text + "',phFrom='" + txtFrom.Text + "',phTo='" + txtTo.Text + "',phEE='" + txtEE.Text + "',phER='" + txtER.Text + "',salBase='" + txtSalBase.Text + "',phMonthly='" + txtMonthly.Text + "' where phID='" + txtID.Text + "';";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
                MySqlDataReader myReader;

                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    MessageBox.Show("PhilHealth Table Updated!");
                    while (myReader.Read())
                    {

                    }
                    loadTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //do something
                MessageBox.Show("PhilHealth Table has successfully updated!");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
        }

        private void PhilHealthForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenuForm main = new MainMenuForm();
            main.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txtID.Text = row.Cells[0].Value.ToString();
                txtFrom.Text = row.Cells[1].Value.ToString();
                txtTo.Text = row.Cells[2].Value.ToString();
                txtSalBase.Text = row.Cells[3].Value.ToString();
                txtEE.Text = row.Cells[4].Value.ToString();
                txtER.Text = row.Cells[5].Value.ToString();
                txtMonthly.Text = row.Cells[6].Value.ToString();
            }
        }

        private void txtFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtEE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtER_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSalBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMonthly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
