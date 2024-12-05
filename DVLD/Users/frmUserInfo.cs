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
    public partial class frmUserInfo : Form
    {
        private int _thisID;
        clsUser _User;
        public frmUserInfo(int ID)
        {
            InitializeComponent();
            _thisID = ID;
            Config();
        }

        private void Config()
        {
            _User = clsUser.Find(_thisID);
            if (_User == null)
            {
                MessageBox.Show("Error The User Data Is Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //set Personal details 
            personInfo1._ID = _User.personID;
            personInfo1._LaodData();

            ucLoginInfo1._User = _User;
            ucLoginInfo1.Config();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
