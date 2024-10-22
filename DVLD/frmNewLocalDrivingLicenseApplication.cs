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
    public partial class frmNewLocalDrivingLicenseApplication : Form
    {
        private enum enMode { addMode = 0, updatMode = 1 }
        enMode _Mode = enMode.addMode;

        public int thisID;
        private bool allowTabChange = false;
        clsUser _User;

        public frmNewLocalDrivingLicenseApplication(int ID)
        {
            InitializeComponent();

            thisID = ID;
            Config();
        }

        private void Config()
        {
            if (thisID == -1)
            {
                GetIdFromFilter();
                _User = new clsUser();
                return;
            }
            _User = clsUser.Find(thisID);
            if (_User == null)
            {
                MessageBox.Show("Error The User Data Is Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //set Filter Config
            filter1.Enabled = false;

            //set Personal details 
            personInfoUser1._ID = _User.personID;
            personInfoUser1._LaodData();

            //set User Details
            _Mode = enMode.updatMode;
            lApplicationDate.Text = DateTime.Now.ToString("dd/M/yyyy");
            _LoadLicensesClassNames();
            lApplicationFees.Text = "15";
            lApplicationUser.Text = _User.userName;
           

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
            //thisID = PersonID;
            _User.personID = PersonID;
            personInfoUser1._LaodData();


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_User.personID != -1)
            {
                if (!clsUser.IsExsist(thisID))
                {
                    allowTabChange = true;
                    tabControl1.SelectedTab = tabPage2;
                }
                else if (_Mode == enMode.updatMode)
                {
                    allowTabChange = true;
                    tabControl1.SelectedTab = tabPage2;
                }
                else
                    MessageBox.Show("This Person is already a User", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Please select a Person To Make It a User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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


    }
}
