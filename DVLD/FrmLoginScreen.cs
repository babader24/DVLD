using DVLD_BusneissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD.frmDVLD;

namespace DVLD
{
    public partial class FrmLoginScreen : Form
    {
        private const string remeberMeFile = "rememberMe.txt";
        private const string path = "F:\\تاسيس ابو هدهود\\كورس رقم 19 مشروع رخص السيارات\\DVLD\\bin\\Debug\\rememberMe.txt";



        public FrmLoginScreen()
        {
            InitializeComponent();
            
            loadUserInfo();
        }

        private void checkLogin()
        {
            if(clsUser.chekLogin(tbUserName.Text,tbPassword.Text))
            {
                if(clsUser.IsActive(tbUserName.Text))
                {

                    Globals._gUser = clsUser.FindByName(tbUserName.Text);
                    Globals._gPerson = clsPerson.Find(Globals._gUser.personID);

                    this.Hide();
                    Form frm = new frmDVLD();

                    frm.Closed += (s, arags) => this.Close();
                    frm.Show();
                    
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
            if (cbRemember.Checked)
            {
                saveUserInfo();
            }
            else if (File.Exists(remeberMeFile))
            {
                File.Delete(remeberMeFile);
            }
            checkLogin();
        }

        private void picCloseLoginScreen_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void loadUserInfo()
        {
            
            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                if (lines.Length == 2)
                {
                    tbUserName.Text = lines[0];
                    tbPassword.Text = lines[1];
                    cbRemember.Checked = true;
                    
                }
            }
           
                
        }

        private void saveUserInfo()
        {
            using (StreamWriter writer = new StreamWriter(remeberMeFile))
            {
                writer.WriteLine(tbUserName.Text);
                writer.WriteLine(tbPassword.Text);
            }
        }


    }
}
