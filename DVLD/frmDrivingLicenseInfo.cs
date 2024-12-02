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
    public partial class frmDrivingLicenseInfo : Form
    {
       
        public frmDrivingLicenseInfo(int lDLAID)
        {
            InitializeComponent();
            Config(lDLAID);
        }

        private void Config(int ID)
        {
            ucDriverlicenseInfo1._ID = ID;
            ucDriverlicenseInfo1._LoadData();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
