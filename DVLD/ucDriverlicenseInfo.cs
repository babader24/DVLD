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
using static DVLD.frmDVLD;

namespace DVLD
{
    public partial class ucDriverlicenseInfo : UserControl
    {

        public int _ID {  get; set; }

        public ucDriverlicenseInfo()
        {
            InitializeComponent();
        }

        public void _LoadData()
        {
            string man = TheDefualtImg.ManPhotoPath;
            string woman = TheDefualtImg.WomanPhotoPath;
            string defualtIMG;

            clsPerson person;
            clsLicenses License;

            clsLocalDLA LDLA = clsLocalDLA.Find(_ID);
            if (LDLA != null)
            {
                 person = clsPerson.Find(LDLA.ApplicantPersonID);
                 License = clsLicenses.Find(LDLA.ApplicationID);
            }
            else
            {
                License = clsLicenses.FindByLicenseID(_ID);
                person = clsPerson.Find(clsLicenses.GetPersonID(_ID));

                if (License == null)
                {
                    MessageBox.Show("The Person maybe deleted or corrupted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }


               


                lClass.Text = clsLicenClasses.GetClassName(License.LicenseClass);
                lFullName.Text = clsPerson.GetFullName(person.PersonID);
                lLicenseID.Text = License.LicenseID.ToString();
                lNational.Text = person.NationalNo;
                lIssueDate.Text = License.IssueDate.ToString("dd/MM/yyyy");
                lIssuereason.Text = getIssueReason(License.IssueReason);
                lNote.Text = (License.Notes == null ? "No Notes" : License.Notes.ToString());
                lIsActive.Text = (License.IsActive ? "Yes" : "No");
                lDateOfBirth.Text = person.BirthDate.ToString("dd/MM/yyyy");
                lDriverID.Text = License.DriverID.ToString();
                lExpairationDate.Text = License.ExpirationDate.ToString("dd/MM/yyyy");
                lIsDetained.Text = (!License.IsActive ? "Yes" : "No");

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

        private string getIssueReason(byte issuereason)
        {
            switch (issuereason)
            {
                case 0: return "0 Faild";

                case 1: return "First Time";
            }
            return "All Faild";

        }

    }
}
