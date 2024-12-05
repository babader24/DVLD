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
    public partial class frmManageDetainedLicenses : Form
    {
        public frmManageDetainedLicenses()
        {
            InitializeComponent();
            Config();
        }

        private void Config()
        {
            DisplayDetainedLicense();

            dgvDetained.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetained.Columns[7].Width = 300;
            tbFilter.Visible = false;
            lRecordCount.Text = RecordesCount();
            FillFiltersBox();
        }

        private string RecordesCount()
        {
            int count = dgvDetained.Rows.Count;
            string Records = "#Records: " + count.ToString();
            return Records;
        }

        private void FillFiltersBox()
        {
            cbFilters.Items.Add("None");
            cbFilters.SelectedIndex = 0;

            foreach (DataGridViewColumn column in dgvDetained.Columns)
            {
                cbFilters.Items.Add(column.HeaderText);
            }
        }

        private void DisplayDetainedLicense()
        {
            dgvDetained.DataSource = clsDetainedLicenses.AllDetainedLicenses();

        }

        private void RefreshData()
        {
            dgvDetained.DataSource = null;
            Config();
        }

        private void SearchBySearchBar(string sentenceToSearch)
        {
            if (!string.IsNullOrWhiteSpace(sentenceToSearch))
            {
                foreach (DataGridViewRow row in dgvDetained.Rows)
                {
                    CurrencyManager currencyManager1 =
                        (CurrencyManager)BindingContext[dgvDetained.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }

                foreach (DataGridViewRow row in dgvDetained.Rows)
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

                foreach (DataGridViewRow row in dgvDetained.Rows)
                {
                    row.Visible = true;
                }
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

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            SearchBySearchBar(tbFilter.Text);
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.SelectedItem.ToString() == "DetainID")
            {
                if (char.IsControl(e.KeyChar))
                {
                    return;
                }

                if (!char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();                   
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            Form frm = new frmDetainLicense();
            frm.ShowDialog();

            RefreshData();
        }

        private void btnRelese_Click(object sender, EventArgs e)
        {
            Form frm = new frmReleseDetainedLicense(-1);
            frm.ShowDialog();

            RefreshData();
        }

        private void showApplicationDeatailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = clsLicenses.GetPersonID((int)dgvDetained.CurrentRow.Cells[1].Value);

            Form frm = new frmPersonDetails(PersonID);
            frm.ShowDialog();

            RefreshData();
        }

        private void showPersonLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmDrivingLicenseInfo((int)dgvDetained.CurrentRow.Cells[1].Value);
            frm.ShowDialog();

            RefreshData();
        }

        private void showPersonLicensesHistoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmLicenseHistory((int)dgvDetained.CurrentRow.Cells[1].Value);
            frm.ShowDialog();

            RefreshData();
        }

        private void reaseDeitanedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmReleseDetainedLicense((int)dgvDetained.CurrentRow.Cells[1].Value);
            frm.ShowDialog();

            RefreshData();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (Convert.ToBoolean(dgvDetained.CurrentRow.Cells[3].Value))
                reaseDeitanedLicenseToolStripMenuItem.Enabled = false;
            else
                reaseDeitanedLicenseToolStripMenuItem.Enabled = true;
        }
    }
}
