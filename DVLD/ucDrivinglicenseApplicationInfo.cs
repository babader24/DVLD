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
    public partial class ucDrivinglicenseApplicationInfo : UserControl
    {
        public int _ID;
        public ucDrivinglicenseApplicationInfo()
        {
            InitializeComponent();
            
        }

        public void _LoadData()
        {
            clsLocalDLA LDLA = clsLocalDLA.Find(_ID);

            if (LDLA != null)
            {
                DLAppID.Text = LDLA.LDLAID.ToString();
                lLisense.Text = DefineLicense(LDLA.LicenceID);
                lPassedTests.Text = clsLocalDLA.PassedTests(LDLA.LDLAID).ToString() + "/3";
            }
            else
                MessageBox.Show("The Person maybe deleted or corrupted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string DefineLicense(int LicenceID)
        {
            return clsLicenClasses.GetClassName(LicenceID);

        }


    }
}
