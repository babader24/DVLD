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
    public partial class frmReleseDetainedLicense : Form
    {
        clsLicenses _licenses;
        clsDetainedLicenses _detainedLicenses;

        public frmReleseDetainedLicense(int LicenseID)
        {
            InitializeComponent();
            Config(LicenseID);
        }

        private void Config(int LicenseID)
        {          
            if(LicenseID != -1 )
            {
                SendIDToShowDetails(LicenseID);
                ucLicenseFilter1.Enabled = false;
            }

            LoadFormData();

        }



        private void loadAfterCheckData()
        {
            _detainedLicenses = clsDetainedLicenses.FindByLicnseID(_licenses.LicenseID);

            lDetainID.Text = _detainedLicenses.DetainedID.ToString();
            lDetainDate.Text = _detainedLicenses.DetainDate.ToString("dd/MM/yyyy");
            lCreatedBy.Text = _detainedLicenses.CreatedByUserID.ToString();
            lLicenseID.Text = _licenses.LicenseID.ToString();
            lFineFees.Text = Convert.ToInt32(_detainedLicenses.FineFees).ToString();
            lApplicationFees.Text = Convert.ToInt32(clsApplicationTypes.GetFees(5)).ToString();
            lTotalFees.Text = (Convert.ToInt32(lFineFees.Text) + Convert.ToInt32(lApplicationFees.Text)).ToString();
        }

        private void LoadFormData()
        {
            ucLicenseFilter1.dataBack += Filter1_dataBack;
        }

        private void Filter1_dataBack(object sender, int LicenseID)
        {
            SendIDToShowDetails(LicenseID);
        }

        private void SendIDToShowDetails(int LicenseID)
        {
            ucDriverlicenseInfo1._ID = LicenseID;

            _licenses = clsLicenses.FindByLicenseID(LicenseID);
            if (!checkLocalLicense())
            {
                Savebtn.Enabled = false;
                return;
            }
            else
            {
                Savebtn.Enabled = true;
               
            }
            loadAfterCheckData();
            ucDriverlicenseInfo1._LoadData();


        }

        private bool checkLocalLicense()
        {
            if (_licenses.IsActive == true)
                if (clsDetainedLicenses.IsLicenseDetained(_licenses.LicenseID))
                    return true;
                else
                    MessageBox.Show("This License Already Relesed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            else
                MessageBox.Show("The Local License already Not  Active, You Can't Reblace an Old License! Give us the lastest license", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        private bool AddReleseApplication()
        {
            clsApplication application = new clsLocalDLA();

            application.ApplicantPersonID = clsLicenses.GetPersonID(_licenses.LicenseID);
            application.ApplicationDate = DateTime.Now;
            application.ApplicationTypeID = 5;
            application.ApplicationStatus = 3;
            application.LastStatusDate = DateTime.Now;
            application.CreatedByUserID = Globals._gUser.userID;
            

            application.Save();

            lRApplicationID.Text = application.ApplicationID.ToString();
            _detainedLicenses.ReleaseApplicationID = application.ApplicationID;

            return (application.ApplicationID != -1);

        } 

        private bool UpdateDetainedLicense()
        {
            _detainedLicenses.ReleaseDate = DateTime.Now;
            _detainedLicenses.ReleasedByUserID = Globals._gUser.userID;
            _detainedLicenses.IsReleased = true;

           return  _detainedLicenses.Update();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (_licenses == null)
            {
                MessageBox.Show("Please Enter a License First!", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (AddReleseApplication())
            {
                if (UpdateDetainedLicense())
                {
                    MessageBox.Show(@"Application Save and License Relesed Successfully your Application
                           License Id = " + lRApplicationID.Text + " (-: ", "Save",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ShowLicenseInfo.Enabled = true;
                    Savebtn.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Relesed License Failed!", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Relese Application Failed!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void ShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmDrivingLicenseInfo(Convert.ToInt32(lLicenseID.Text));
            frm.ShowDialog();
        }

        private void ShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_licenses == null)
            {
                MessageBox.Show(@"Please Enter a License First!", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form frm = new frmLicenseHistory(_licenses.LicenseID);
            frm.ShowDialog();
        }
    }
}
