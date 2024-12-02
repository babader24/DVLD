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

namespace DVLD
{
    public partial class frmLicenseHistory : Form
    {
        clsLocalDLA localDLA;
        public frmLicenseHistory(int ID)
        {
            InitializeComponent();
            Config(ID);
        }

        private void Config(int ID)
        {
            laodLocalData(ID);

        }

        private void laodLocalData(int ID)
        {
            localDLA = clsLocalDLA.Find(ID);
            if (localDLA == null)
            {
                int LDLAID = clsLicenses.GetLDLA(ID);
                localDLA = clsLocalDLA.Find(LDLAID);
            }

            try
            {
                clsPerson person = clsPerson.Find(localDLA.ApplicantPersonID);

                if (person != null)
                {

                    filterLicense.tbFindPerson.Text = person.NationalNo;
                    filterLicense.Enabled = false;

                    personInfoLicense._ID = person.PersonID;
                    personInfoLicense._LaodData();
                }
            }
            catch
            {
                MessageBox.Show("The Person maybe deleted or corrupted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
                           

           
            try
            {
                clsLicenses license = clsLicenses.Find(localDLA.ApplicationID);
                LoadLocalLicenses(license.DriverID);
                LoadInternationalLicenses(license.LicenseID);
            }
            catch
            {
                MessageBox.Show("This Person Filed in this License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

          

        }

        private void LoadLocalLicenses(int driverID)
        {
            dgvLocal.DataSource = clsLicenses.GatAllLicense(driverID);

            dgvLocal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLocal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lRecordCountLocal.Text = LocalRecordesCount();
        }
        
        private string LocalRecordesCount()
        {
            int count = dgvLocal.Rows.Count;
            string Records = "#Records: " + count.ToString();
            return Records;
        }


        private void LoadInternationalData(int IntLicenseID)
        {
            //clsLicenses licenses = clsLicenses.FindByLicenseID(IntLicenseID);
            //if(licenses == null)
            //{
            //    int licenseID = clsLocalDLA.GetLicenseID(IntLicenseID);
            //    licenses = clsLicenses.FindByLicenseID(licenseID);

            //}

            //LoadInternationalLicenses(licenses.LicenseID);
        }

        private void LoadInternationalLicenses(int IntLicenseID)
        {
            dgvInternational.DataSource = clsInterNationalLicense.GetAllIntLicenses(IntLicenseID);

            dgvInternational.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInternational.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lRecordCountInternational.Text = InternationalRecordesCount();
        }


        private string InternationalRecordesCount()
        {
            int count = dgvInternational.Rows.Count;
            string Records = "#Records: " + count.ToString();
            return Records;
        }


    }
}
