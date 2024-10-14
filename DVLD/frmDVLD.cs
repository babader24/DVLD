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
    public partial class frmDVLD : Form
    {
        public static class TheDefualtImg
        {
            public const string WomanPhotoPath = "F:\\تاسيس ابو هدهود\\كورس رقم 19 مشروع رخص السيارات\\img\\woman400px.png";
            public const string ManPhotoPath = "F:\\تاسيس ابو هدهود\\كورس رقم 19 مشروع رخص السيارات\\img\\man400px.png";
            
            
        }

        public frmDVLD()
        {
            InitializeComponent();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmPeople = new frmManage_People();
            frmPeople.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form frm = new FrmLoginScreen();
            frm.Show();

        }

        private void frmDVLD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManage_Users();
            frm.ShowDialog();
        }
    }
}
