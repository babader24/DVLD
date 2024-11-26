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
    public partial class frmTestAppointment : Form
    {

        private int _LDLA_ID;
        private int _TestTypeID;
        public frmTestAppointment(int ID, int testTypeID)
        {
            InitializeComponent();
            _LDLA_ID = ID;            
            _TestTypeID = testTypeID;
            Config(ID);
        }

        public void Config(int ID)
        {

            //load Driving license Application Info
            ucDrivinglicenseApplicationInfo1._ID = ID;
            ucDrivinglicenseApplicationInfo1._LoadData();

            //load Application Basic Info
            ucApplicationBasicInfo1._ID = ID;
            ucApplicationBasicInfo1._LoadDate();

            //frmAppointment Configrations 
            selectTest(_TestTypeID);
            laodAppointments(_LDLA_ID,_TestTypeID);
            lRecordCount.Text = RecordesCount();
        }

        private void laodAppointments(int LDLA_ID, int testType)
        {
            dgvAppointment.DataSource = clsAppointments.GetAllAppointments(LDLA_ID, testType);
        }

        private void RefrishData(int LDLA_ID, int testType)
        {
            dgvAppointment.DataSource = null;
            dgvAppointment.DataSource = clsAppointments.GetAllAppointments(LDLA_ID, testType);
        }

        private string RecordesCount()
        {
            int count = dgvAppointment.Rows.Count;
            string Records = "#Records: " + count.ToString();
            return Records;
        }

        private void selectTest(int testType)
        {
            switch (testType)
            {
                case 1:
                    {
                        lMainTitle.Text = "Vision Test Appointment";
                        pbMainPhoto.Load("F:\\تاسيس ابو هدهود\\كورس رقم 19 مشروع رخص السيارات\\DVLD\\Resources\\eye_480px.png");
                        return;
                    }
                case 2:
                    {
                        lMainTitle.Text = "Written Test Appointment";
                        pbMainPhoto.Load("F:\\تاسيس ابو هدهود\\كورس رقم 19 مشروع رخص السيارات\\DVLD\\Resources\\edit_property_480px.png");
                        return;
                    }
                case 3:
                    {
                        lMainTitle.Text = "Street Test Appointment";
                        pbMainPhoto.Load("F:\\تاسيس ابو هدهود\\كورس رقم 19 مشروع رخص السيارات\\DVLD\\Resources\\car_400px.png");
                        return;
                    }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAppintment_Click(object sender, EventArgs e)
        {
            Form frm = new frmSchduleTest(-1, _LDLA_ID, _TestTypeID);
            frm.ShowDialog();

            RefrishData(_LDLA_ID,_TestTypeID);
        }
    }
}
