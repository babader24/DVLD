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
    public partial class frmInternationalDriverInfo : Form
    {
        public frmInternationalDriverInfo(int ID)
        {
            InitializeComponent();
            config(ID);
        }

        private void config(int id)
        {
            clsInterNationalLicense intLicense = clsInterNationalLicense.FindByLicenseID(id);
            if (intLicense != null)
            {
                ucInternationalDriverInfo1._ID = intLicense.InternationalLicenseID;
                ucInternationalDriverInfo1._LoadData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
