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
    public partial class frmLocalDrivingLicenseApplication : Form
    {
        public frmLocalDrivingLicenseApplication()
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
            dgvApplication.DataSource = clsLocalDLA.GetAllLDLA();
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
            

            cbFilters.Items.Add("LocalDrivingLicenseApplicationID");
            cbFilters.Items.Add("NationalNo");
            cbFilters.Items.Add("FullName");
            cbFilters.Items.Add("Status");
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            SearchBySearchBar(tbFilter.Text);
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

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.SelectedItem.ToString() == "LocalDrivingLicenseApplicationID")
            {
                if (char.IsControl(e.KeyChar))
                {
                    return;
                }

                if (!char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            Form frm = new frmNewLocalDrivingLicenseApplication(-1);
            frm.ShowDialog();
            RefreshData();

        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmNewLocalDrivingLicenseApplication((int)dgvApplication.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshData();
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(clsLocalDLA.Cancel((int)dgvApplication.CurrentRow.Cells[0].Value))
                MessageBox.Show("Canceled Successfully","Delete",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            else
                MessageBox.Show("Cancel Failed", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            RefreshData();
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLocalDLA _LDLA = clsLocalDLA.Find((int)dgvApplication.CurrentRow.Cells[0].Value);

            if(_LDLA != null)
            {
                if (clsLocalDLA.DeleteLDLA(_LDLA.LDLAID))
                {
                    if (clsApplication.DeleteApplicaion(_LDLA.ApplicationID))
                    {
                        MessageBox.Show("Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Application Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
                else
                    MessageBox.Show("LDLA Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            MessageBox.Show("The Person Is Empty","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            RefreshData() ;
        }

        private void sechduleVisonTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmTestAppointment((int)dgvApplication.CurrentRow.Cells[0].Value,1);
            frm.ShowDialog();
        }

        private void showApplicationDeatailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmApplicationDetails((int)dgvApplication.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

            if(dgvApplication.CurrentRow.Cells[6].Value.ToString() == "Cancelled")
            {
                sechduleVisonTestToolStripMenuItem.Enabled = false;
                sechduleVisonTestToolStripMenuItem1.Enabled = false;
                sechduleVisonTestToolStripMenuItem2.Enabled = false;
                return;
            }
        

            if ((int)dgvApplication.CurrentRow.Cells[5].Value == 0 )
            {
                sechduleVisonTestToolStripMenuItem.Enabled = true;
                sechduleVisonTestToolStripMenuItem1.Enabled = false;
                sechduleVisonTestToolStripMenuItem2.Enabled = false;
            }
            else if ((int)dgvApplication.CurrentRow.Cells[5].Value == 1)
            {
                sechduleVisonTestToolStripMenuItem.Enabled = false;
                sechduleVisonTestToolStripMenuItem1.Enabled = true;
                sechduleVisonTestToolStripMenuItem2.Enabled = false;
            }
            else if ((int)dgvApplication.CurrentRow.Cells[5].Value == 2)
            {
                sechduleVisonTestToolStripMenuItem.Enabled = false;
                sechduleVisonTestToolStripMenuItem1.Enabled = false;
                sechduleVisonTestToolStripMenuItem2.Enabled = true;
            }
            else if ((int)dgvApplication.CurrentRow.Cells[5].Value == 3)
            {
                sechduleVisonTestToolStripMenuItem.Enabled = false;
                sechduleVisonTestToolStripMenuItem1.Enabled = false;
                sechduleVisonTestToolStripMenuItem2.Enabled = false;
            }
        }
    }
}
