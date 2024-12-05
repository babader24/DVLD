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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    public partial class frmEditTestType : Form
    {
        int thisID;
        clsTestType _TestType;
        public frmEditTestType(int ID)
        {
            InitializeComponent();
            thisID = ID;
            Config();
        }

        private void Config()
        {
            _TestType = clsTestType.Find(thisID);
            if (_TestType == null)
            {
                MessageBox.Show("The Application Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lUserID.Text = _TestType.ID.ToString();
            tbTitle.Text = _TestType.Title;
            tbDescription.Text = _TestType.Description;
            tbFees.Text = _TestType.Fees.ToString();

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

        private bool ValidateAllFields()
        {
            errorProvider1.Clear();
            bool IsValid = true;

            IsValid &= ValidateTextBox(tbTitle, "Please Enter a Text");
            IsValid &= ValidateTextBox(tbDescription, "Please Enter a Text");
            IsValid &= ValidateNumericBox(tbFees);



            return IsValid;
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbTitle.Text))
                errorProvider1.SetError(tbTitle, string.Empty);
        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbDescription.Text))
                errorProvider1.SetError(tbDescription, string.Empty);
        }

        private void tbFees_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbFees.Text))
                errorProvider1.SetError(tbFees, string.Empty);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (ValidateAllFields())
                MessageBox.Show("Validate All", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Error Not Validate All Feilds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _TestType.Title = tbTitle.Text;
            _TestType.Description = tbDescription.Text;
            _TestType.Fees = Convert.ToDecimal(tbFees.Text);

            if (_TestType.Save())
            {
                MessageBox.Show("Data Saved Successfully :-)", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
                MessageBox.Show("Data Is not Saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
