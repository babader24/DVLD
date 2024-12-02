using DVLD_BusneissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD.frmDVLD;
using System.Xml.Linq;

namespace DVLD
{
    public partial class ucInternationalDriverInfo : UserControl
    {
        public int _ID { get; set; }
        public ucInternationalDriverInfo()
        {
            InitializeComponent();
        }

        public void _LoadData()
        {
            string man = TheDefualtImg.ManPhotoPath;
            string woman = TheDefualtImg.WomanPhotoPath;
            string defualtIMG;
            
            clsInterNationalLicense IntLicense = clsInterNationalLicense.FindByLicenseID(_ID);

            if (IntLicense == null)
            {
                MessageBox.Show("The Person maybe deleted or corrupted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsLicenses License = clsLicenses.FindByLicenseID(IntLicense.IssuedUsingLocalLicenseID);
            clsPerson person = clsPerson.Find(clsLicenses.GetPersonID(License.LicenseID));



            lIDLicenseID.Text = IntLicense.InternationalLicenseID.ToString();
            lIntApplicationID.Text = IntLicense.ApplicationID.ToString();
            lFullName.Text = clsPerson.GetFullName(person.PersonID);
            lLicenseID.Text = License.LicenseID.ToString();
            lNational.Text = person.NationalNo;
            lIssueDate.Text = License.IssueDate.ToString("dd/MM/yyyy");
            lIsActive.Text = (License.IsActive ? "Yes" : "No");
            lDateOfBirth.Text = person.BirthDate.ToString("dd/MM/yyyy");
            lDriverID.Text = License.DriverID.ToString();
            lExpairationDate.Text = License.ExpirationDate.ToString("dd/MM/yyyy");

            if (person.Gendor == 0)
            {
                lGendor.Text = "Male";
                defualtIMG = man;
            }
            else
            {
                lGendor.Text = "Female";
                defualtIMG = woman;
            }


            try
            {
                picPhoto.Load(person.ImagePath);

            }
            catch
            {
                picPhoto.Load(defualtIMG);
            }


        }
    }
}
