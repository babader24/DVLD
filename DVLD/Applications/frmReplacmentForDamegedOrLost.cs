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
    public partial class frmReplacmentForDamegedOrLost : Form
    {
        clsLicenses _licenses;

        public frmReplacmentForDamegedOrLost()
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
            lCreatedBy.Text = Globals._gUser.userName;
            lApplicationFees.Text = "5";

        }

        private void loadAfterCheckData()
        {
            lOldLicenseID.Text = _licenses.LicenseID.ToString();
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
                return true;
                            
            else            
                MessageBox.Show("The Local License already Not  Active, You Can't Reblace an Old License! Give us the lastest license", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            
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
            LDLA.ApplicationTypeID = (rbDamagedLicense.Checked ? 4 : 3);
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
            newLicense.Notes = null;
            newLicense.PaidFees = Convert.ToDecimal(lApplicationFees.Text);
            newLicense.IsActive = true;
            newLicense.IssueReason =(byte)(rbDamagedLicense.Checked ? 4 : 3);
            newLicense.CreatedByUserID = Globals._gUser.userID;

            newLicense.Save();

            ReplacedLicenseID.Text = newLicense.LicenseID.ToString();

            return (newLicense.LicenseID != -1);
        }

        private void DamagedLicenseSettings()
        {
            lApplicationFees.Text = Convert.ToInt32(clsApplicationTypes.GetFees(4)).ToString();            
            lTitle.Text = "Replacement For Damaged License";
            this.Text = "frm Replacement For Damaged License";
        }

        private void LostLicenseSettings()
        {
            lApplicationFees.Text = Convert.ToInt32(clsApplicationTypes.GetFees(3)).ToString();
            lTitle.Text = "Replacement For Lost License";
            this.Text = "frm Replacement For Lost License";
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDamagedLicense.Checked)
                DamagedLicenseSettings();
            else
                LostLicenseSettings();

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

            if (!deActiveOldLicense())
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
                           License Id = " + ReplacedLicenseID.Text + " (-: ", "Save",
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
            Form frm = new frmDrivingLicenseInfo(Convert.ToInt32(ReplacedLicenseID.Text));
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
            Form frm = new frmLicenseHistory(Convert.ToInt32(ReplacedLicenseID.Text));
            frm.ShowDialog();
        }
    }
}
