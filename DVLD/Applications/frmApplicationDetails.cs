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
    public partial class frmApplicationDetails : Form
    {
        public frmApplicationDetails(int ID)
        {
            InitializeComponent();
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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
