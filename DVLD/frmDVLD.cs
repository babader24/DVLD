﻿using DVLD_BusneissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD.FrmLoginScreen;

namespace DVLD
{
    public partial class frmDVLD : Form
    {
        public static class TheDefualtImg
        {
            public const string WomanPhotoPath = "F:\\تاسيس ابو هدهود\\كورس رقم 19 مشروع رخص السيارات\\img\\woman400px.png";
            public const string ManPhotoPath = "F:\\تاسيس ابو هدهود\\كورس رقم 19 مشروع رخص السيارات\\img\\man400px.png";
                     
        }
        public static class Globals
        {
            public static clsPerson _gPerson { get; set; }
            public static clsUser _gUser { get; set; }
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

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUserInfo(Globals._gUser.userID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangePassword(Globals._gUser.userID);
            frm.ShowDialog();
        }

        private void manageApplicationsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageApplicationsTypes();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageTestType();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmNewLocalDrivingLicenseApplication(-1);
            frm.ShowDialog();
        }

        private void localDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmDrivers();
            frm.ShowDialog();
        }

        private void interNationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmNewInternationalLicense();
            frm.ShowDialog();
        }

        private void interNationalLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frm = new frmInternationalLicenseApplication();
            frm.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmRenewLicenseApplication();
            frm.ShowDialog();
        }

        private void replacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmReplacmentForDamegedOrLost();
            frm.ShowDialog();
            
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmDetainLicense();
            frm.ShowDialog();
            
        }

        private void relaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmReleseDetainedLicense(-1);
            frm.ShowDialog();
            
        }

        private void manageDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageDetainedLicenses();
            frm.ShowDialog();
        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmReleseDetainedLicense(-1);
            frm.ShowDialog();
        }


    }
}
