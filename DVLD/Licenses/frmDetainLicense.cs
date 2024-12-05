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
    public partial class frmDetainLicense : Form
    {
        clsLicenses _licenses;

        public frmDetainLicense()
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
            lDetainDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lCreatedBy.Text = Globals._gUser.userName;
           

        }

        private void loadAfterCheckData()
        {
            lLicenseID.Text = _licenses.LicenseID.ToString();
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
                if(!clsDetainedLicenses.IsLicenseDetained(_licenses.LicenseID))
                    return true;
                else
                    MessageBox.Show("This License Already Detained", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);


            else
                MessageBox.Show("The Local License already Not  Active, You Can't Reblace an Old License! Give us the lastest license", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        private bool AddDetainedLicense()
        {
        
            clsDetainedLicenses DetainedLicenses = new clsDetainedLicenses();

            DetainedLicenses.LicenseID = _licenses.LicenseID;
            DetainedLicenses.DetainDate = DateTime.Now;
            DetainedLicenses.FineFees = Convert.ToDecimal(FineFees.Text);
            DetainedLicenses.CreatedByUserID = Globals._gUser.userID;
            DetainedLicenses.IsReleased = false;
            DetainedLicenses.ReleaseDate = null;
            DetainedLicenses.ReleasedByUserID = null;
            DetainedLicenses.ReleaseApplicationID = null;

            DetainedLicenses.Save();

            lDetainID.Text = DetainedLicenses.DetainedID.ToString();

            return (DetainedLicenses.DetainedID != -1);                        
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

            if (AddDetainedLicense())
            {
                MessageBox.Show(@"Application Save and This License Detained Successfully your Detained
                            ID = " + lDetainID.Text + " (-: ", "Save",
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
            Form frm = new frmLicenseHistory(Convert.ToInt32(lLicenseID.Text));
            frm.ShowDialog();
        }
    }
}
