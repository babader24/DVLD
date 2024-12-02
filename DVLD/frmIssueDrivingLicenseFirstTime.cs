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
    public partial class frmIssueDrivingLicenseFirstTime : Form
    {
        private int _LDLA_ID;

        public frmIssueDrivingLicenseFirstTime(int ID)
        {
            InitializeComponent();
            _LDLA_ID = ID;
            Config(ID);
        }



        public void Config(int ID)
        {

            //load Driving license Application Info
            ucDrivinglicenseApplicationInfo1._ID = ID;
            ucDrivinglicenseApplicationInfo1._LoadData();

            //load Application Basic Info
            ucApplicationBasicInfo1._ID = ID;
            ucApplicationBasicInfo1._LoadDate();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            clsDrivers Driver;
            clsLocalDLA LDLA = clsLocalDLA.Find(_LDLA_ID);

            if(!clsDrivers.IsExsist(LDLA.ApplicantPersonID))
            {
                Driver = new clsDrivers();

                Driver.PersonID = LDLA.ApplicantPersonID;
                Driver.CreateDate = DateTime.Now;
                Driver.createByUser = Globals._gUser.userID;

                if (Driver.Save())
                {
                    MessageBox.Show("Driver Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                }
                else
                    MessageBox.Show("Driver Faild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                Driver = clsDrivers.Find(LDLA.ApplicantPersonID);   

            clsLicenses MyLicense = new clsLicenses();

            MyLicense.ApplicationID = LDLA.ApplicationID;
            MyLicense.DriverID = Driver.DriverID;
            MyLicense.LicenseClass = LDLA.LicenceID;
            MyLicense.IssueDate = DateTime.Now;
            MyLicense.ExpirationDate = DateTime.Now.AddYears(clsLicenClasses.GetValidateLingth(LDLA.LicenceID));
            MyLicense.Notes = tbNotes.Text != string.Empty ? tbNotes.Text : null;
            MyLicense.PaidFees = clsLicenClasses.GetLicenseFees(LDLA.LicenceID);
            MyLicense.IsActive = true;
            MyLicense.IssueReason = 1;
            MyLicense.CreatedByUserID = Globals._gUser.userID;

            if(MyLicense.Save())
            {
                MessageBox.Show("Save Successfully The License ID = "+MyLicense.LicenseID+" Now You Are a Driver -:)", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LDLA.ApplicationStatus = 3;
                LDLA.Save();
                   
                this.Close();
            }
            else
                MessageBox.Show("Driver Faild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        
    }
}
