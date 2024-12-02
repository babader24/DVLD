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
    public partial class frmTakeTest : Form
    {
        int _LDLAID, _TestType, _ID;


        clsAppointments _Appointment;
        clsLocalDLA _LocalDLA;
        public frmTakeTest(int id, int LDLAID, int testType)
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
            lDate.Text = _Appointment.AppointmentDate.ToString();
        
            lFees.Text = _Appointment.Fees.ToString();          


        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            clsTests _Test = new clsTests();

            _Test.TestAppointmentID = _ID;
            _Test.TestResult = (rbPass.Checked ? true : false);
            _Test.Notes = (tbNotes.Text != string.Empty ? tbNotes.Text : null);
            _Test.CreatedByUserID = Globals._gUser.userID;

            _Appointment.IsLocked = true;

            
                         
            if (_Test.Save())
            {
                _Appointment.Save();
                MessageBox.Show("Save Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("NOOOOOOOOOOOOOOOOOO", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
