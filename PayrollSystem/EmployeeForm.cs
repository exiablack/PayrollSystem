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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
            setDate();
        }

        private void setDate()
        {
            dtpBday.Format = DateTimePickerFormat.Custom;
            dtpBday.CustomFormat = "MM-dd-yyyy";
            dtpBday.MaxDate = DateTime.Now;

            dtpDateHired.Format = DateTimePickerFormat.Custom;
            dtpDateHired.CustomFormat = "MM-dd-yyyy";
            dtpDateHired.MaxDate = DateTime.Today;
        }

        private void EnableEdit()
        {
            // Personal Info
            txtLName.Enabled = true;
            txtFName.Enabled = true;
            txtMName.Enabled = true;
            dtpBday.Enabled = true;
            cmbCivilStat.Enabled = true;
            radioMale.Enabled = true;
            radioFemale.Enabled = true;
            txtDependent.Enabled = true;
            txtConatctNo.Enabled = true;
            txtAddress.Enabled = true;
            txtEmail.Enabled = true;

            // Employment Details
            cmbDepartment.Enabled = true;
            cmbPosition.Enabled = true;
            cmbEmpStat.Enabled = true;
            dtpDateHired.Enabled = true;
            txtBasicSal.Enabled = true;
            cmbPayType.Enabled = true;

            // Other Info
            txtSSS.Enabled = true;
            txtTIN.Enabled = true;
            txtPhilHealth.Enabled = true;

            // Buttons
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnImage.Enabled = true;
            btnRFID.Enabled = true;
        }

        private void DisableEdit()
        {
            // Personal Info
            txtLName.Enabled = false;
            txtFName.Enabled = false;
            txtMName.Enabled = false;
            dtpBday.Enabled = false;
            cmbCivilStat.Enabled = false;
            radioMale.Enabled = false;
            radioFemale.Enabled = false;
            txtDependent.Enabled = false;
            txtConatctNo.Enabled = false;
            txtAddress.Enabled = false;
            txtEmail.Enabled = false;

            // Employment Details
            cmbDepartment.Enabled = false;
            cmbPosition.Enabled = false;
            cmbEmpStat.Enabled = false;
            dtpDateHired.Enabled = false;
            txtBasicSal.Enabled = false;
            cmbPayType.Enabled = false;

            // Other Info
            txtSSS.Enabled = false;
            txtTIN.Enabled = false;
            txtPhilHealth.Enabled = false;

            // Buttons
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnImage.Enabled = false;
            btnRFID.Enabled = false;
        }

        private void EmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenuForm main = new MainMenuForm();
            main.Show();
            this.Hide();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                pictureBox1.ImageLocation = picPath;
            }
        }

        private void txtSSS_KeyDown(object sender, KeyEventArgs e)
        {

            bool isValid = txtSSS.Text.Length < 11;

            lblSSS.Visible = isValid;
            //AcceptButton.Visible = isValid;
        }

        private void txtTIN_KeyDown(object sender, KeyEventArgs e)
        {
            bool isValid = txtTIN.Text.Length < 11;

            lblTIN.Visible = isValid;
            //AcceptButton.Visible = isValid;
        }

        private void txtPhilHealth_KeyDown(object sender, KeyEventArgs e)
        {
            bool isValid = txtPhilHealth.Text.Length < 12;

            lblPhilHealth.Visible = isValid;
            //AcceptButton.Visible = isValid;
        }

        private void txtSSS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtTIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtPhilHealth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnableEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisableEdit();
        }

        private void txtDependent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtConatctNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtBasicSal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.';
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

        private void txtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

        private void txtMName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

        private void txtConatctNo_KeyDown(object sender, KeyEventArgs e)
        {
            bool isValid = txtSSS.Text.Length < 11;

            lblContact.Visible = isValid;
        }

        private void txtSSS_TextChanged(object sender, EventArgs e)
        {
            if (txtSSS.Text == "")
                lblSSS.Visible = false;
        }

        private void txtTIN_TextChanged(object sender, EventArgs e)
        {
            if (txtTIN.Text == "")
                lblTIN.Visible = false;
        }

        private void txtPhilHealth_TextChanged(object sender, EventArgs e)
        {
            if (txtPhilHealth.Text == "")
                lblPhilHealth.Visible = false;
        }

        private void txtConatctNo_TextChanged(object sender, EventArgs e)
        {
            if (txtConatctNo.Text == "")
                lblContact.Visible = false;
        }
       
    }
}
