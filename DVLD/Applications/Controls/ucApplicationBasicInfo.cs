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
    public partial class ucApplicationBasicInfo : UserControl
    {

        public int _ID;
        public int _ApplicantID;
        public ucApplicationBasicInfo()
        {
            InitializeComponent();
        }


        public void _LoadDate()
        {
            clsLocalDLA LDLA = clsLocalDLA.Find(_ID);

            if(LDLA != null)
            {
                clsApplicationTypes AppTypes = clsApplicationTypes.Find(LDLA.ApplicationTypeID);

                //Set UcApplication Info
                lID.Text = LDLA.ApplicationID.ToString();
                lStatus.Text = GetStatus(LDLA.ApplicationStatus);
                lFees.Text = AppTypes.Fees.ToString();
                lType.Text = AppTypes.Title;
                lApplicant.Text = clsPerson.GetFullName(LDLA.ApplicantPersonID); 
                lDate.Text = LDLA.ApplicationDate.ToString("dd/MM/yyyy");
                lStatusDate.Text = LDLA.LastStatusDate.ToString("dd/MM/yyyy");
                lCreatedBy.Text = clsUser.Find(LDLA.CreatedByUserID).userName;

                _ApplicantID = LDLA.ApplicantPersonID;
            }
            else
                MessageBox.Show("The Person maybe deleted or corrupted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string GetStatus(int status)
        {
            switch (status)
            {
                case 1: return "New";

                case 2: return "Canceled";

                case 3: return "Completed";
            }
            return "none";
        }

        private void linkViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmPersonDetails(_ApplicantID);
            frm.ShowDialog();
        }
    }
}
