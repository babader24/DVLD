using DVLD_BusneissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmChangePassword : Form
    {
        private clsUser _User;
        private int _thisID;
        
        public frmChangePassword(int ID)
        {
            InitializeComponent();
            _thisID = ID;
            config();
        }

        private void config()
        {
            _User = clsUser.Find(_thisID);
            if (_User == null)
            {
                MessageBox.Show("Error The User Data Is Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //set Personal details 
            personInfo1._ID = _User.personID;
            personInfo1._LaodData();

            ucLoginInfo1._User = _User;
            ucLoginInfo1.Config();
        }




        private bool ValidateConfirmPassword(TextBox textBox, TextBox textBox2)
        {
            if (textBox.Text != textBox2.Text)
            {
                errorProvider1.SetError(textBox2, "Password Don't Match");
                return false;
            }
            return true;
        }

        private bool ValidateCurrentPassword(TextBox textBox, string textBox2)
        {
            if (textBox.Text != textBox2)
            {
                errorProvider1.SetError(textBox, "Password Don't Match");
                return false;
            }
            return true;
        }

        private bool ValidateAllFields()
        {
            errorProvider1.Clear();
            bool IsValid = true;

            
            IsValid &= ValidateCurrentPassword(tbCurrentPassword,_User.password);
            IsValid &= ValidateConfirmPassword(tbNewPassword, tbConfirmPassword);


            return IsValid;
        }








        private void btnClose_Click(object sender, EventArgs e)
        {
            this .Close();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if(ValidateAllFields())
                MessageBox.Show("Validate All", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Error Not Validate All Feilds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.password = tbNewPassword.Text;

            if (_User.Save())            
                MessageBox.Show("Data Saved Successfully :-)", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);           
            else
                MessageBox.Show("Data Is not Saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tbCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbCurrentPassword.Text))
                errorProvider1.SetError(tbCurrentPassword, string.Empty);
        }

        private void tbNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbNewPassword.Text))
                errorProvider1.SetError(tbNewPassword, string.Empty);
        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbConfirmPassword.Text))
                errorProvider1.SetError(tbConfirmPassword, string.Empty);
        }
    }
}
