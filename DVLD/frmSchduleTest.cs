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
    public partial class frmSchduleTest : Form
    {
        int _LDLAID, _TestType, _ID;
        

        clsAppointments _Appointment;
        clsLocalDLA _LocalDLA;
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
            _LocalDLA = clsLocalDLA.Find(_LDLAID);
            _Appointment = clsAppointments.Find(_ID);

            lLDLAID.Text = _LocalDLA.LDLAID.ToString();
            lLicenseClass.Text = clsLicenClasses.GetClassName(_LocalDLA.LicenceID);
            lApplicant.Text = clsPerson.GetFullName(_LocalDLA.ApplicantPersonID);
            lTrails.Text = clsAppointments.GetAllAppointments(_LDLAID, _TestType).Rows.Count.ToString();
            dtpDate.Text = DateTime.Now.ToString();

            //get the Test Cost From TestType Table 
            lFees.Text = Convert.ToInt32(clsTestType.GetAllTests().Rows[_TestType - 1][3]).ToString();

            //lReFees.Text = (Convert.ToInt32(lTrails.Text) == 0 ? 0 : 5).ToString();
            lReFees.Text = "0";
            lTotalFees.Text = (Convert.ToInt32(lFees.Text) + Convert.ToInt32(lReFees.Text)).ToString();


            if (_ID == -2 || _Appointment != null)
            {
                lTitle.Text = "Schdule Retake Test";
                lReFees.Text = Convert.ToInt32(clsApplicationTypes.GetFees(8)).ToString();
                lTotalFees.Text = (Convert.ToInt32(lFees.Text) + Convert.ToInt32(lReFees.Text)).ToString();

                if(_ID != -1 && _ID != -2)
                    lReTestID.Text = _ID.ToString();

            }

            if (_Appointment == null)
            {
                _Appointment = new clsAppointments();
            }
            else
            {
                dtpDate.Text = _Appointment.AppointmentDate.ToString();

            }


            


            if (clsAppointments.IsTestLocked(_ID))
            {
                lLockedTitle.Visible = true;
                Savebtn.Enabled = false;
                dtpDate.Enabled = false;
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

            _Appointment.TestType = _TestType;
            _Appointment.LDLA_ID = _LDLAID;
            _Appointment.AppointmentDate = dtpDate.Value;
            _Appointment.Fees = Convert.ToDecimal(lTotalFees.Text);
            _Appointment.UserID = Globals._gUser.userID;
            _Appointment.IsLocked = false;

            if( _Appointment.Save())
            {
                MessageBox.Show("Save Successfully","Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Save Faild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
