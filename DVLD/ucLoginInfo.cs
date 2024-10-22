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
    public partial class ucLoginInfo1 : UserControl
    {
        //public int ID {  get; set; }

        public clsUser _User;
        public ucLoginInfo1()
        {
            InitializeComponent();
            //Config();
        }

        public void Config()
        {
            lUserID.Text = _User.userID.ToString();
            lUserNAme.Text = _User.userName.ToString();

            if (_User.IsAcive == true)
                lIsActive.Text = "Yes";
            else
                lIsActive.Text = "No";
        }


    }
}
