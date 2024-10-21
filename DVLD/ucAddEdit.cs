using DVLD_BusneissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD.frmDVLD;

namespace DVLD
{
    public partial class ucAddEdit : UserControl
    {
        public delegate void DataBackEventHaandler(object sender, int PersonID);
        public event DataBackEventHaandler dataBack;

        public enum enMode { AddNew = 0,Update = 1 };
        enMode _Mode = enMode.AddNew;
        clsPerson _Person;
        public  int ID {  get; set; }


        public ucAddEdit()
        {
            InitializeComponent();
            
        }

        private void LoadCountries()
        {
            DataTable dtCountries = clsPerson.GetAllCountries();
            foreach (DataRow dr in dtCountries.Rows)
            {
                cbCountries.Items.Add(dr["CountryName"]);
            }
        }

        public void _Loadata()
        {
            LoadCountries();

            //Set DATE TIME PICKUR
            dtp.MaxDate = DateTime.Now.AddYears(-18);

            //SET YOUR CURRENT COUNTRY IN COMBOBOX
            cbCountries.SelectedItem = "Yemen";

            if (ID == -1)
            {
                lTitle.Text = "Add New Person";
                _Person = new clsPerson();
                return;
            }

            _Person = clsPerson.Find(ID);

            if (_Person == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + ID);
                ((Form)this.TopLevelControl).Close();
                return;
            }

            lTitle.Text = "Update Person ID: " + ID;
            lPersonid.Text = _Person.PersonID.ToString();
            tbFirst.Text = _Person.FirstName;
            tbSecond.Text = _Person.SecondName;
            tbThird.Text = _Person.ThirdName;
            tbLast.Text = _Person.LastName;
            tbNational.Text = _Person.NationalNo;
            tbEmail.Text = _Person.Email;
            tbAddress.Text = _Person.Address;
            tbPhone.Text = _Person.Phone;
            dtp.Value = _Person.BirthDate;
            cbCountries.SelectedText = _Person.Country;

            string defaultImg;
            if (_Person.Gendor == 0)
            {
                rbMale.Checked = true;
                defaultImg = TheDefualtImg.ManPhotoPath;
            }
            else
            {
                rbFemale.Checked = true;
                defaultImg = TheDefualtImg.WomanPhotoPath;
            }


            try
            {
                picPhoto.Load(_Person.ImagePath);
            }
            catch
            {
                picPhoto.Load(defaultImg);
            }



            linkLabelRemove.Visible = (picPhoto.ImageLocation != null);



        }

        private void linkLabelRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picPhoto.ImageLocation = null;
            linkLabelRemove.Visible = false;
        }

        private void linkLabelSetImg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Select an image file";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string SelectedImahePath = openFileDialog1.FileName;
                string uniqueFileName = $"{Path.GetFileNameWithoutExtension(SelectedImahePath)}_{Guid.NewGuid()}{Path.GetExtension(SelectedImahePath)}";

                string newFilePath = Path.Combine("F:\\تاسيس ابو هدهود\\كورس رقم 19 مشروع رخص السيارات\\DVLD\\Images", uniqueFileName);

                try
                {
                    File.Copy(SelectedImahePath, newFilePath, true);
                    picPhoto.Load(newFilePath);
                    linkLabelRemove.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Copying File: {ex.Message} ");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            if (ValidateAllFields())
                MessageBox.Show("Validate All");
            else
            {
                MessageBox.Show("Error Not Validate All Feilds");
                return;
            }
            dataBack?.Invoke(this, _Person.PersonID);

            int countryId = clsPerson.GetCountryIDByname(cbCountries.Text);

            _Person.FirstName = tbFirst.Text;
            _Person.SecondName = tbSecond.Text;
            _Person.ThirdName = tbThird.Text;
            _Person.LastName = tbLast.Text;
            _Person.NationalNo = tbNational.Text;
            _Person.Email = tbEmail.Text;
            _Person.Address = tbAddress.Text;
            _Person.Phone = tbPhone.Text;
            _Person.BirthDate = dtp.Value;
            _Person.Country = cbCountries.SelectedText;
            _Person.NationalityCountryID = countryId;
            _Person.ImagePath = picPhoto.ImageLocation;

            if (rbFemale.Checked == true)
                _Person.Gendor = 1;
            else
                _Person.Gendor = 0;

            if (_Person.Save())
            {
                MessageBox.Show("Data Saved Successfully :-)","Saved", MessageBoxButtons.OK,MessageBoxIcon.Information);
                _Mode = enMode.Update;
                lPersonid.Text = _Person.PersonID.ToString();
                lTitle.Text = "Edit Person ID = " + _Person.PersonID;
            }
            else
                MessageBox.Show("Data Is not Saved Successfully!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

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

        private bool ValidateEmailBox(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text) || Regex.IsMatch(textBox.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider1.SetError(textBox, "Please Enter a Valid Email");
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

            IsValid &= ValidateTextBox(tbFirst, "Please Enter a Text");
            IsValid &= ValidateTextBox(tbSecond, "Please Enter a Text");
            IsValid &= ValidateTextBox(tbThird, "Please Enter a Text");
            IsValid &= ValidateTextBox(tbLast, "Please Enter a Text");
            IsValid &= ValidateTextBox(tbAddress, "Please Enter a Text");
            IsValid &= ValidateTextBox(tbNational, "Please Enter a Text");

            IsValid &= ValidateEmailBox(tbEmail);
            IsValid &= ValidateNumericBox(tbPhone);

            if (picPhoto.Image == null)
            {
                errorProvider1.SetError(picPhoto, "Error");
                IsValid = false;
            }

            return IsValid;
        }

        private void tbFirst_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbFirst.Text))
                errorProvider1.SetError(tbFirst, string.Empty);
        }

        private void tbSecond_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbSecond.Text))
                errorProvider1.SetError(tbSecond, string.Empty);
        }

        private void tbThird_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbThird.Text))
                errorProvider1.SetError(tbThird, string.Empty);
        }

        private void tbLast_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbLast.Text))
                errorProvider1.SetError(tbLast, string.Empty);
        }

        private void tbNational_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbNational.Text))
                errorProvider1.SetError(tbNational, string.Empty);
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbEmail.Text))
                errorProvider1.SetError(tbEmail, string.Empty);
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbAddress.Text))
                errorProvider1.SetError(tbAddress, string.Empty);
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbPhone.Text))
                errorProvider1.SetError(tbPhone, string.Empty);
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            picPhoto.Load(TheDefualtImg.ManPhotoPath);
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            picPhoto.Load(TheDefualtImg.WomanPhotoPath);
        }

        private void ucAddEdit_Load(object sender, EventArgs e)
        {
            //loadata();

        }
    }
}
