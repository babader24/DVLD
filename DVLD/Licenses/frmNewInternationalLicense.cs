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
    public partial class frmNewInternationalLicense : Form
    {
        clsLicenses _licenses;
        public frmNewInternationalLicense()
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
            lFees.Text =Convert.ToInt32(clsLicenClasses.GetLicenseFees(6)).ToString();
            lExiprationDate.Text = DateTime.Now.AddYears(1).ToString("dd/MM/yyyy");
            lCreatedBy.Text = Globals._gUser.userName;

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
            ucDriverlicenseInfo1._LoadData();
            lLocalLicenseID.Text = LicenseID.ToString();

        }

        private bool checkLocalLicense()
        {
            if(_licenses.IsActive == true)
            {
                if(_licenses.ExpirationDate > DateTime.Now)
                {
                    if(clsInterNationalLicense.IsExsist(_licenses.LicenseID))
                    {
                        MessageBox.Show("this person Have alreadey an International License!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("The Local License Is Expiard, Please Issue Another locale License!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            else
            {
                MessageBox.Show("The Local License Is Not Active, Please Issue Another locale License!","Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            return false;
        }

        private bool Addapplication()
        {
            clsApplication application = new clsApplication();

            application.ApplicantPersonID = clsLicenses.GetPersonID(_licenses.LicenseID);
            application.ApplicationDate = DateTime.Now;
            application.ApplicationTypeID = 6;
            application.ApplicationStatus = 3;
            application.LastStatusDate = DateTime.Now;
            application.CreatedByUserID = Globals._gUser.userID;

            application.Save();

            lIDApplicationID.Text = application.ApplicationID.ToString();

            return (application.ApplicationID != -1); 

        }

        private bool AddInternationalLicense()
        {
            clsInterNationalLicense Inernational = new clsInterNationalLicense();

            Inernational.ApplicationID = Convert.ToInt32(lIDApplicationID.Text);
            Inernational.DriverID  = _licenses.DriverID;
            Inernational.IssuedUsingLocalLicenseID = _licenses.LicenseID;
            Inernational.IssueDate = DateTime.Now;
            Inernational.ExpirationDate = DateTime.Now.AddYears(1);
            Inernational.IsActive = true;
            Inernational.CreatedByUserID = Globals._gUser.userID;

            Inernational.Save();

            lIDLicenseID.Text = Inernational.InternationalLicenseID.ToString();

            return (Inernational.InternationalLicenseID != -1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (_licenses == null)
            {
                MessageBox.Show(@"Please Enter a License First!", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkLocalLicense())
            {
                if(Addapplication())
                {
                    if(AddInternationalLicense())
                    {
                        MessageBox.Show(@"Application Save and International Issued Successfully your International
                           License Id = "+lIDLicenseID.Text+" (-: ", "Save",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ShowLicenseInfo.Enabled = true;
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
        }

        private void ShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmInternationalDriverInfo(Convert.ToInt32(lIDLicenseID.Text));
            frm.ShowDialog();
        }

        private void ShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_licenses == null)
            {
                MessageBox.Show(@"Please Enter a License First!" , "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form frm = new frmLicenseHistory(_licenses.LicenseID);
            frm.ShowDialog();
        }
    }
}
