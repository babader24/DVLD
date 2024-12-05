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
    public partial class frmRenewLicenseApplication : Form
    {
        clsLicenses _licenses;

        public frmRenewLicenseApplication()
        {
            InitializeComponent();
            Config();
        }

        private void Config()
        {
            LoadApplicationInfo();
            LoadFormData();

        }

        private void LoadApplicationInfo()
        {
            lApplicationID.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lIssueDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lApplicationFees.Text = Convert.ToInt32(clsApplicationTypes.GetFees(2)).ToString();            
            lCreatedBy.Text = Globals._gUser.userName;

        }

        private void loadAfterCheckData()
        {
            lExiprationDate.Text = DateTime.Now.AddYears(1).ToString("dd/MM/yyyy");
            lOldLicenseID.Text = _licenses.LicenseID.ToString();
            lLicenseFees.Text = Convert.ToInt32(clsLicenClasses.GetLicenseFees(_licenses.LicenseClass)).ToString();
            lTotalFees.Text = (Convert.ToInt32(lLicenseFees.Text) + Convert.ToInt32(lApplicationFees.Text)).ToString();
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
            {
                if (_licenses.ExpirationDate < DateTime.Now)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("The Local License Is Not Expiard, Please Wait until locale License Expiard!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("The Local License already Not  Active, You Can't Renew an Old License! Give us the lastest license", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return false;
        }

        private bool deActiveOldLicense()
        {
            _licenses.IsActive = false;

            return clsLicenses.DeActive(_licenses.LicenseID);
        }

        private bool Addapplication()
        {         
            clsLocalDLA LDLA = new clsLocalDLA();

            LDLA.ApplicantPersonID = clsLicenses.GetPersonID(_licenses.LicenseID);
            LDLA.ApplicationDate = DateTime.Now;
            LDLA.ApplicationTypeID = 2;
            LDLA.ApplicationStatus = 3;
            LDLA.LastStatusDate = DateTime.Now;
            LDLA.CreatedByUserID = Globals._gUser.userID;
            LDLA.LicenceID = _licenses.LicenseClass;

            LDLA.Save();

            lIDApplicationID.Text = LDLA.ApplicationID.ToString();

            return (LDLA.ApplicationID != -1);

        }

        private bool AddLicense()
        {

            clsLicenses newLicense = new clsLicenses();

            newLicense.ApplicationID = Convert.ToInt32(lIDApplicationID.Text);
            newLicense.DriverID = _licenses.DriverID;
            newLicense.LicenseClass = _licenses.LicenseClass;
            newLicense.IssueDate = DateTime.Now;
            newLicense.ExpirationDate = DateTime.Now.AddYears(clsLicenClasses.GetValidateLingth(_licenses.LicenseClass));
            newLicense.Notes = tbNotes.Text == string.Empty ? null : tbNotes.Text;
            newLicense.PaidFees = Convert.ToDecimal(lTotalFees.Text);
            newLicense.IsActive = true;
            newLicense.IssueReason = 2;
            newLicense.CreatedByUserID = Globals._gUser.userID;

            newLicense.Save();

            lRenewLicenseID.Text = newLicense.LicenseID.ToString();

            return (newLicense.LicenseID != -1);
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

            if(!deActiveOldLicense())
            {
                MessageBox.Show("Can't deactive old license!", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Addapplication())
            {
                if (AddLicense())
                {
                    MessageBox.Show(@"Application Save and International Issued Successfully your International
                           License Id = " + lRenewLicenseID.Text + " (-: ", "Save",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ShowLicenseInfo.Enabled = true;
                    Savebtn.Enabled = false;
                }
                else
                {
                    MessageBox.Show("International Save Failed!", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Application Save Failed!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmDrivingLicenseInfo(Convert.ToInt32(lRenewLicenseID.Text));
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
