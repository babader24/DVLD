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
    public partial class frmNewLocalDrivingLicenseApplication : Form
    {
        private enum enMode { addMode = 0, updatMode = 1 }
        enMode _Mode = enMode.addMode;

        public int thisID;
        private bool allowTabChange = false;
        //clsUser _User;
        clsLocalDLA _LDLA;

        public frmNewLocalDrivingLicenseApplication(int ID)
        {
            InitializeComponent();
 
            thisID = ID;
            Config();
        }

        private void Config()
        {
            _Mode = enMode.updatMode;
            lApplicationDate.Text = DateTime.Now.ToString("dd/M/yyyy");
            _LoadLicensesClassNames();
            lApplicationFees.Text = "15";
            lApplicationUser.Text = Globals._gUser.userName;
            if (thisID == -1)
            {
                GetIdFromFilter();
               // _User = new clsUser();
                _LDLA = new clsLocalDLA();
                return;
            }

             _LDLA = clsLocalDLA.Find(thisID);
            if (_LDLA == null)
            {
                MessageBox.Show("Error The Local Driving License Aplication Data Is Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //set Filter Config
            filter1.Enabled = false;


            personInfoUser1._ID = _LDLA.ApplicantPersonID;
            personInfoUser1._LaodData();

            //set Form Config
            _Mode = enMode.updatMode;
            lApplicationID.Text = _LDLA.LDLAID.ToString();
            lTitle.Text = "Update Local Driving License Application ";

            //Set Member License
            cbClassNames.SelectedIndex = _LDLA.LicenceID - 1;


        }

        private void _LoadLicensesClassNames()
        {
            DataTable dt = clsLicenClasses.GetAllLicenseNames();

            foreach (DataRow dr in dt.Rows)
            {
                cbClassNames.Items.Add(dr[0]);
            }
            cbClassNames.SelectedIndex = 2;
        }

        private void GetIdFromFilter()
        {
            filter1.dataBack += Filter1_dataBack;
        }

        private void Filter1_dataBack(object sender, int PersonID)
        {
            SendIDToShowDetails(PersonID);
        }

        private void SendIDToShowDetails(int PersonID)
        {
            personInfoUser1._ID = PersonID;
            _LDLA.ApplicantPersonID = PersonID;
            personInfoUser1._LaodData();


        }


        private bool CheckStatus()
        {
            return (_LDLA.checkLincenseStatus(personInfoUser1._NationalNo, cbClassNames.SelectedIndex + 1));

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_LDLA.ApplicantPersonID != -1 && _Mode == enMode.updatMode)
            {

                allowTabChange = true;
                tabControl1.SelectedTab = tabPage2;
            }
            else
                MessageBox.Show("Please select a Person First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            allowTabChange = true;
            tabControl1.SelectedTab = tabPage1;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = !allowTabChange;

            allowTabChange = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if(CheckStatus())
            { MessageBox.Show(@"Choes another licenseClass, The selected Person already have an Active 
                       applicatio for the selected licenseclass", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LDLA.ApplicationDate = Convert.ToDateTime(lApplicationDate.Text);
            _LDLA.ApplicationStatus = 1;
            _LDLA.ApplicantPersonID = personInfoUser1._ID;
            _LDLA.ApplicationTypeID = 1;
            _LDLA.CreatedByUserID = Globals._gUser.userID;
            _LDLA.LastStatusDate = Convert.ToDateTime(lApplicationDate.Text);
            _LDLA.LicenceID = cbClassNames.SelectedIndex + 1;
            
            if(_LDLA.Save())
            {
                MessageBox.Show("Data Saved Successfully :-)", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.updatMode;
                lApplicationID.Text = _LDLA.LDLAID.ToString();
                lTitle.Text = "Update Local Driving License Application ";
            }
            else
                MessageBox.Show("Data Is not Saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }
}
