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
    public partial class SSSForm : Form
    {
        public SSSForm()
        {
            InitializeComponent();
            loadTable();   
        }

        private void loadTable() 
        {
            string constring = "datasource=localhost;port=3306;username=root;password=toor";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("select * from db_payroll.tblsss;", conDataBase);

            try{
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                dataAdapter.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                dataAdapter.Update(dbdataset);
                setColumnName();
            }catch(Exception ex)
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
            dataGridView1.Columns[6].HeaderText = "Monthly Contribution";
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void SSSForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenuForm main = new MainMenuForm();
            main.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txtID.Text = row.Cells[0].Value.ToString();
                txtFrom.Text = row.Cells["sssFrom"].Value.ToString();
                txtTo.Text = row.Cells["sssTo"].Value.ToString();
                txtSalCred.Text = row.Cells["sssSalCred"].Value.ToString();
                txtEE.Text = row.Cells["eeShare"].Value.ToString();
                txtER.Text = row.Cells["erShare"].Value.ToString();
                txtTotalCont.Text = row.Cells["totalContrib"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=toor";
            string query = "update db_payroll.tblsss set sssID='" + txtID.Text + "',sssFrom='" + txtFrom.Text + "',sssTo='" + txtTo.Text + "',sssSalCred='" + txtSalCred.Text + "',eeShare='" + txtEE.Text + "',erShare='" + txtER.Text + "',totalContrib='" + txtTotalCont.Text + "' where sssID='"+ txtID.Text +"';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("SSS Table Updated!");
                while (myReader.Read())
                { 
                    
                }
                loadTable();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void txtSalCred_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTotalCont_KeyPress(object sender, KeyPressEventArgs e)
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
