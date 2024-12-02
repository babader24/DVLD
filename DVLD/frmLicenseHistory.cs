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
            localDLA = clsLocalDLA.Find(ID);
            clsPerson person = clsPerson.Find(localDLA.ApplicantPersonID);

            if(person != null)
            {                              

                filterLicense.tbFindPerson.Text = person.NationalNo;
                filterLicense.Enabled = false;

                personInfoLicense._ID = person.PersonID;
                personInfoLicense._LaodData();
            }
            else
                MessageBox.Show("The Person maybe deleted or corrupted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            clsLicenses license = clsLicenses.Find(localDLA.ApplicationID);
            LoadLocalLicenses(license.DriverID);
           
            dgvLocal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLocal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            lRecordCountLocal.Text =  RecordesCount();

        }

        private void LoadLocalLicenses(int driverID)
        {
            dgvLocal.DataSource = clsLicenses.GatAllLicense(driverID);
        }

        private string RecordesCount()
        {
            int count = dgvLocal.Rows.Count;
            string Records = "#Records: " + count.ToString();
            return Records;
        }



    }
}
