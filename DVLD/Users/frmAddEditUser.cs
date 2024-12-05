using DVLD_BusneissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmAddEditUser : Form
    {
        private enum enMode {addMode = 0, updatMode = 1}
        enMode _Mode = enMode.addMode;
        public int thisID;
        private bool allowTabChange = false;
        clsUser _User;

        public frmAddEditUser(int ID)
        {
            InitializeComponent();
            
            thisID = ID;
            Config();

        }

        private void Config()
        {
            if(thisID == -1)
            {
                GetIdFromFilter();
                _User = new clsUser();
                return;
            }
            _User = clsUser.Find(thisID);
            if(_User == null)
            {
                MessageBox.Show("Error The User Data Is Null","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            //Set Form Config
            _Mode = enMode.updatMode;
            lTitle.Text = "Update New User";

            //set Filter Config
            filter1.Enabled = false;

            //set Personal details 
            personInfoUser._ID = _User.personID;
            personInfoUser._LaodData();

            //set User Details
            lUserID.Text = _User.userID.ToString();
            tbUserName.Text = _User.userName.ToString();
            tbPAssword.Text = _User.password.ToString();
            tbConfirmPassword.Text = _User.password.ToString();
            cbUserActive.Checked = _User.IsAcive;

        }

        private void GetIdFromFilter()
        {
            filter1.dataBack += Filter1_dataBack;
        }

        private void Filter1_dataBack(object sender, int PersonID)
        {
            SendIDToShowDetails(PersonID);
        }

        private void SendIDToShowDetails(int PersonID)
        {
            personInfoUser._ID = PersonID;
            //thisID = PersonID;
            _User.personID = PersonID;
            personInfoUser._LaodData();
            
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_User.personID != -1)
            { 
                if (!clsUser.IsExsist(thisID))
                {
                    allowTabChange = true;
                    tabControl1.SelectedTab = tabPage2;
                }
                else if (_Mode == enMode.updatMode)
                {
                    allowTabChange = true;
                    tabControl1.SelectedTab = tabPage2;
                }
                else
                    MessageBox.Show("This Person is already a User","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Please select a Person To Make It a User","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);




        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = !allowTabChange;

            allowTabChange=false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            allowTabChange = true;
            tabControl1.SelectedTab = tabPage1;
        }

        private bool ValidateTextBox(TextBox textBox, string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider1.SetError(textBox, errorMessage);
                return false;
            }
            return true;
        }

        private bool ValidateNumericBox(TextBox textBox)
        {
            if (!int.TryParse(textBox.Text, out _))
            {
                errorProvider1.SetError(textBox, "Please Enter a Valid Number");
                return false;
            }
            return true;
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

        private bool ValidateAllFields()
        {
            errorProvider1.Clear();
            bool IsValid = true;

            IsValid &= ValidateTextBox(tbUserName, "Please Enter a Text");
            IsValid &= ValidateNumericBox(tbPAssword);
            IsValid &= ValidateConfirmPassword(tbPAssword, tbConfirmPassword);
            

            return IsValid;
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbUserName.Text))
                errorProvider1.SetError(tbUserName, string.Empty);
        }

        private void tbPAssword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbPAssword.Text))
                errorProvider1.SetError(tbPAssword, string.Empty);
        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbUserName.Text))
                errorProvider1.SetError(tbUserName, string.Empty);
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (ValidateAllFields())
                MessageBox.Show("Validate All","Saved", MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Error Not Validate All Feilds","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            _User.userName = tbUserName.Text;
            _User.password = tbPAssword.Text;
            _User.IsAcive = cbUserActive.Checked;

            if(_User.Save())
            {
                MessageBox.Show("Data Saved Successfully :-)", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.updatMode;
                lUserID.Text = _User.userID.ToString();
                lTitle.Text = "Edit User ID = " + _User.userID;
            }
            else
                MessageBox.Show("Data Is not Saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
