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
    public partial class FrmLoginScreen : Form
    {
        public FrmLoginScreen()
        {
            InitializeComponent();
        }

        private void checkLogin()
        {
            if(clsUser.chekLogin(tbUserName.Text,tbPassword.Text))
            {
                if(clsUser.IsActive(tbUserName.Text))
                {
                    Form frm = new frmDVLD();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This User Is Deactivate, Please contact admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            
            }
            else
            MessageBox.Show("UserName Or Pasword not Correct, Please retry","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            checkLogin();
        }

        private void picCloseLoginScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
