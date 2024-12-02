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
    public partial class frmInternationalLicenseApplication : Form
    {
        public frmInternationalLicenseApplication()
        {
            InitializeComponent();
            Config();
        }


        private void Config()
        {
            DisplayAllLDLA();

            dgvApplication.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplication.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbFilter.Visible = false;
            lRecordCount.Text = RecordesCount();
            FillFiltersBox();


        }

        private void DisplayAllLDLA()
        {
            dgvApplication.DataSource = clsInterNationalLicense.GetAllInternational();
        }

        private string RecordesCount()
        {
            int count = dgvApplication.Rows.Count;
            string Records = "#Records: " + count.ToString();
            return Records;
        }

        private void FillFiltersBox()
        {
            cbFilters.Items.Add("None");
            cbFilters.SelectedIndex = 0;


            cbFilters.Items.Add("Int.LicenseID");
            cbFilters.Items.Add("ApplicationID");
            cbFilters.Items.Add("DriverID");
            cbFilters.Items.Add("L.LicenseID");
            cbFilters.Items.Add("IssueDate");
            cbFilters.Items.Add("ExpirationDate");
            cbFilters.Items.Add("IsActive");
        }

        private void SearchBySearchBar(string sentenceToSearch)
        {
            if (!string.IsNullOrWhiteSpace(sentenceToSearch))
            {
                foreach (DataGridViewRow row in dgvApplication.Rows)
                {
                    CurrencyManager currencyManager1 =
                        (CurrencyManager)BindingContext[dgvApplication.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }

                foreach (DataGridViewRow row in dgvApplication.Rows)
                {
                    if (row.Cells[cbFilters.SelectedItem.ToString()].Value != null &&
                        row.Cells[cbFilters.SelectedItem.ToString()].Value.ToString()
                        .IndexOf(sentenceToSearch, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        row.Visible = true;
                    }
                }
            }
            else
            {

                foreach (DataGridViewRow row in dgvApplication.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void RefreshData()
        {
            dgvApplication.DataSource = null;
            Config();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            SearchBySearchBar(tbFilter.Text);
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.SelectedItem.ToString() == "Int.LicenseID")
            {
                if (char.IsControl(e.KeyChar))
                {
                    return;
                }

                if (!char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.SelectedItem.ToString() == "None")
            {
                tbFilter.Visible = false;
                tbFilter.Text = "";
            }
            else
            {
                tbFilter.Visible = true;
                tbFilter.Focus();
            }
        }

        private void showPersonDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int licenseID = (int)dgvApplication.CurrentRow.Cells[3].Value;

            Form frm = new frmPersonDetails(clsLicenses.GetPersonID(licenseID));
            frm.ShowDialog();
        }

        private void showLicenseDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmDrivingLicenseInfo((int)dgvApplication.CurrentRow.Cells[3].Value);
            frm.ShowDialog();
        }

        private void showPersonLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmLicenseHistory((int)dgvApplication.CurrentRow.Cells[3].Value);
            frm.ShowDialog();
        }

        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            Form frm = new frmNewInternationalLicense();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
