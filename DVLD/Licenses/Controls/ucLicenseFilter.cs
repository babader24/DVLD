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
    public partial class ucLicenseFilter : UserControl
    {
        public delegate void DataBackEventHaandler(object sender, int LicenseID);
        public event DataBackEventHaandler dataBack;

        clsLicenses _License;
        public ucLicenseFilter()
        {
            InitializeComponent();
        }

        private bool GetLicenseByID(int LicenseID)
        {
             _License = clsLicenses.FindByLicenseID(LicenseID);
            return _License != null;
        }


        private void picFindLicense_Click(object sender, EventArgs e)
        {
            if (GetLicenseByID(Convert.ToInt32(tbFindLicense.Text)))
            {

                dataBack?.Invoke(this, _License.LicenseID);


            }
            else
                MessageBox.Show("The Person Not Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
