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
    public partial class frmManage_Users : Form
    {
        public frmManage_Users()
        {
            InitializeComponent();
            Config();
        }

        private void Config()
        {
            DisplayAllPeople();

            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbFilter.Visible = false;
            cbIsActive.SelectedIndex = 0;
            lRecordCount.Text = RecordesCount();
            FillFiltersBox();
        }

        private string RecordesCount()
        {
            int count = dgvUsers.Rows.Count;
            string Records = "#Records: " + count.ToString();
            return Records;
        }

        private void FillFiltersBox()
        {
            cbFilters.Items.Add("None");
            cbFilters.SelectedIndex = 0;

            foreach (DataGridViewColumn column in dgvUsers.Columns)
            {
                cbFilters.Items.Add(column.HeaderText);
            }
        }

        private void DisplayAllPeople()
        {
            dgvUsers.DataSource = clsUser.GetAllUsers();

        }

        private void RefreshData()
        {
            dgvUsers.DataSource = null;
            Config();
        }

        private void SearchBySearchBar(string sentenceToSearch)
        {
            if (!string.IsNullOrWhiteSpace(sentenceToSearch))
            {
                foreach (DataGridViewRow row in dgvUsers.Rows)
                {
                    CurrencyManager currencyManager1 =
                        (CurrencyManager)BindingContext[dgvUsers.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }

                foreach (DataGridViewRow row in dgvUsers.Rows)
                {
                    if (row.Cells[cbFilters.SelectedIndex - 1].Value != null &&
                        row.Cells[cbFilters.SelectedIndex - 1].Value.ToString()
                        .IndexOf(sentenceToSearch, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        row.Visible = true;
                    }
                }
            }
            else
            {

                foreach (DataGridViewRow row in dgvUsers.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void SearchByIsActive(bool theValue)
        {
            
                foreach (DataGridViewRow row in dgvUsers.Rows)
                {
                    CurrencyManager currencyManager1 =
                        (CurrencyManager)BindingContext[dgvUsers.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }

                foreach (DataGridViewRow row in dgvUsers.Rows)
                {
                    if (row.Cells[cbFilters.SelectedIndex - 1].Value != null &&
                        (bool)row.Cells[cbFilters.SelectedIndex - 1].Value == theValue)
                    {
                        row.Visible = true;
                    }
                }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {

        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.SelectedItem.ToString() == "Password" || cbFilters.SelectedItem.ToString() == "UserID" 
                || cbFilters.SelectedItem.ToString() == "PersonID")
            {
                if (char.IsControl(e.KeyChar))
                {
                    return;
                }

                if (!char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void cbUserFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.SelectedItem.ToString() == "None")
            {
                tbFilter.Visible = false;
                cbIsActive.Visible = false;
                tbFilter.Text = "";
            }
            else
            {
                tbFilter.Visible = true;
                cbIsActive.Visible = false;
                tbFilter.Focus();
            }
            if(cbFilters.SelectedItem.ToString() == "IsActive")
            {
                cbIsActive.Visible = true;
                tbFilter.Visible = false;
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            SearchBySearchBar(tbFilter.Text);
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbIsActive.SelectedItem.ToString() == "Yes")
            {
                SearchByIsActive(true);
            }
            else if (cbIsActive.SelectedItem.ToString() == "No")
            {
                SearchByIsActive(false);
            }
            else
            {
                foreach (DataGridViewRow row in dgvUsers.Rows)
                {
                   
                    row.Visible = true;
                    
                }

            }
        }
    }
}
