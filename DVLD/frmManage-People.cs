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
    public partial class frmManage_People : Form
    {
        public frmManage_People()
        {
            InitializeComponent();
            Config();

        }

        private void Config()
        {
            DisplayAllPeople();

            dgvPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbFilter.Visible = false;
            lRecordCount.Text = RecordesCount();
            FillFiltersBox();
        }

        private string RecordesCount() 
        {
            int count = dgvPeople.Rows.Count;
            string Records = "#Records: " + count.ToString();
            return Records;
        }

        private void FillFiltersBox()
        {
            cbFilters.Items.Add("None");
            cbFilters.SelectedIndex = 0;
            
            foreach(DataGridViewColumn column in dgvPeople.Columns)
            {
                cbFilters.Items.Add(column.HeaderText);
            }
        }

        private void DisplayAllPeople()
        {           
            dgvPeople.DataSource = clsPerson.GetAllPeople();

        }

        private void RefreshData()
        {
            dgvPeople.DataSource = null;
            Config();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEdit(-1);
            frm.ShowDialog();
            RefreshData();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmPersonDetails((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshData();
        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEdit(-1);
            frm.ShowDialog();
            RefreshData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEdit((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshData ();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(clsPerson.DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value))
                MessageBox.Show("Person Deleted Successfully");
            else
                MessageBox.Show("Person Deleted Fail!\nMaybe It Connceted To Other Tables","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            RefreshData();
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

        private void SearchBySearchBar(string sentenceToSearch)
        {
            if (!string.IsNullOrWhiteSpace(sentenceToSearch))
            {
                foreach (DataGridViewRow row in dgvPeople.Rows)
                {
                    CurrencyManager currencyManager1 =
                        (CurrencyManager)BindingContext[dgvPeople.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }

                foreach (DataGridViewRow row in dgvPeople.Rows)
                {
                    if (row.Cells[cbFilters.SelectedIndex-1].Value != null &&
                        row.Cells[cbFilters.SelectedIndex-1].Value.ToString()
                        .IndexOf(sentenceToSearch, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        row.Visible = true;
                    }
                }
            }
            else
            {

                foreach (DataGridViewRow row in dgvPeople.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            SearchBySearchBar(tbFilter.Text);

        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilters.SelectedItem.ToString() == "PersonID")
            {
                if(char.IsControl(e.KeyChar))
                {
                    return;
                }

                if(!char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }
    }
}
