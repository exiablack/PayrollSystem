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
    public partial class TaxTableForm : Form
    {
        
        public TaxTableForm()
        {
            InitializeComponent();
            //loadTable();
        }

        private void TaxTableForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenuForm main = new MainMenuForm();
            main.Show();
        }

        private void setColumnName1()
        {
            dataGridView1.Columns[0].HeaderText = "STATUS";
            dataGridView1.Columns[1].HeaderText = "TAX 0";
            dataGridView1.Columns[2].HeaderText = "TAX 5";
            dataGridView1.Columns[3].HeaderText = "TAX 10";
            dataGridView1.Columns[4].HeaderText = "TAX 15";
            dataGridView1.Columns[5].HeaderText = "TAX 20";
            dataGridView1.Columns[6].HeaderText = "TAX 25";
            dataGridView1.Columns[7].HeaderText = "TAX 30";
            dataGridView1.Columns[8].HeaderText = "TAX 32";
        }

        private void setColumnName2()
        {
            dataGridView2.Columns[0].HeaderText = "TAX_ID";
            dataGridView2.Columns[1].HeaderText = "PERCENT OVER";
            dataGridView2.Columns[2].HeaderText = "BASE TAX";
        }

        private void loadTable1()
        {
            string type = cmbType1.Text;
            switch (type)
            { 
                case "DAILY":
                    type = "daily";
                    break;
                case "WEEKLY":
                    type = "weekly";
                    break;
                case "SEMI-MONTHLY":
                    type = "semi_monthly";
                    break;
                case "MONTHLY":
                    type = "monthly";
                    break;
            }

            string constring = "datasource=localhost;port=3306;username=root;password=toor";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("select wtstatus, tax_0, tax_5, tax_10, tax_15, tax_20, tax_25, tax_30, tax_32 from db_payroll.tblwtax where payment_type= '"+ type +"';", conDataBase);

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
                setColumnName1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadTable2()
        {
            string type = cmbType2.Text;
            switch (type)
            {
                case "DAILY":
                    type = "daily";
                    break;
                case "WEEKLY":
                    type = "weekly";
                    break;
                case "SEMI-MONTHLY":
                    type = "semi_monthly";
                    break;
                case "MONTHLY":
                    type = "monthly";
                    break;
            }

            string constring = "datasource=localhost;port=3306;username=root;password=toor";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("select btaxID, percent_over, base_tax from db_payroll.tblbtax where payment_type= '" + type + "';", conDataBase);

            try
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                dataAdapter.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView2.DataSource = bSource;
                dataAdapter.Update(dbdataset);
                setColumnName2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cmbType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTable1();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txtStatus.Text = row.Cells[0].Value.ToString();
                txt0.Text = row.Cells[1].Value.ToString();
                txt5.Text = row.Cells[2].Value.ToString();
                txt10.Text = row.Cells[3].Value.ToString();
                txt15.Text = row.Cells[4].Value.ToString();
                txt20.Text = row.Cells[5].Value.ToString();
                txt25.Text = row.Cells[6].Value.ToString();
                txt30.Text = row.Cells[7].Value.ToString();
                txt32.Text = row.Cells[8].Value.ToString();
            }
        }

        private void cmbType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTable2();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                string hold = row.Cells[0].Value.ToString();
                txtPercent.Text = row.Cells[1].Value.ToString();
                txtBaseTax.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to save the changes?", "Withholdingtax Table Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                

                string constring = "datasource=localhost;port=3306;username=root;password=toor";
                string query = "update db_payroll.tblwtax set tax_0='" + txt0.Text + "',tax_5='" + txt5.Text + "',tax_10='" + txt10.Text + "',tax_15='" + txt15.Text + "',tax_20='" + txt20.Text + "',tax_25='" + txt25.Text + "',tax_30='" + txt30.Text + "',tax_32='" + txt32.Text + "' where wtstatus='" + txtStatus.Text + "' && payment_type='" + cmbType1.Text + "';";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
                MySqlDataReader myReader;

                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();

                //do something
                MessageBox.Show("Withholdingtax Table has successfully updated!");
                while (myReader.Read())
                {

                }
                    loadTable1();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnUpdateTax_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to save the changes?", "Tax Table Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
              string constring = "datasource=localhost;port=3306;username=root;password=toor";
                string query = "update db_payroll.tblbtax set base_tax='" + txtBaseTax.Text + "' where payment_type='" + cmbType2.Text + "' && percent_over='" + txtPercent.Text + "';";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
                MySqlDataReader myReader;

                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();

                //do something
                MessageBox.Show("Tax Table has successfully updated!");
                while (myReader.Read())
                {

                }
                loadTable2();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
           
        }

     
    }
}
