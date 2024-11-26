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
    public partial class frmSchduleTest : Form
    {
        int _LDLAID, _TestType, _ID;
        public frmSchduleTest(int id, int LDLAID, int testType)
        {
            InitializeComponent();
            _LDLAID = LDLAID;
            _TestType = testType;
            _ID = id;
            Config();
        }

        private void Config()
        {
            selectTest(_TestType);
            loadData();
        }

        private void loadData()
        {
            clsLocalDLA _LocalDLA = clsLocalDLA.Find(_LDLAID);
            
            if (_LocalDLA != null)
            {


                lLDLAID.Text = _LocalDLA.LDLAID.ToString();
                lLicenseClass.Text = clsLicenClasses.GetClassName(_LocalDLA.LicenceID);
                lApplicant.Text = clsPerson.GetFullName(_LocalDLA.ApplicantPersonID);
                lTrails.Text = clsAppointments.GetAllAppointments(_LDLAID,_TestType).Rows.Count.ToString();
                dtpDate.Text = DateTime.Now.ToString();
                
                //get the Test Cost From TestType Table 
                lFees.Text = Convert.ToInt32(clsTestType.GetAllTests().Rows[_TestType - 1][3]).ToString();

                lReFees.Text = (Convert.ToInt32(lTrails.Text) == 0 ? 0 : 5).ToString();
                lTotalFees.Text = (Convert.ToInt32(lFees.Text) + Convert.ToInt32(lReFees.Text)).ToString();

                lReTestID.Text = _ID == -1 ?"N/A" : _ID.ToString();
            }
        }

        private void selectTest(int testType)
        {
            switch (testType)
            {
                case 1:
                    {
                        gbTestName.Text = "Vision Test";
                        pbMainPhoto.Load("F:\\تاسيس ابو هدهود\\كورس رقم 19 مشروع رخص السيارات\\DVLD\\Resources\\eye_480px.png");
                        return;
                    }
                case 2:
                    {
                        gbTestName.Text = "Written Test";
                        pbMainPhoto.Load("F:\\تاسيس ابو هدهود\\كورس رقم 19 مشروع رخص السيارات\\DVLD\\Resources\\edit_property_480px.png");
                        return;
                    }
                case 3:
                    {
                        gbTestName.Text = "Street Test";
                        pbMainPhoto.Load("F:\\تاسيس ابو هدهود\\كورس رقم 19 مشروع رخص السيارات\\DVLD\\Resources\\car_400px.png");
                        return;
                    }
            }

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

        }

    }
}
