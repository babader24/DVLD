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
    public partial class frmDrivers : Form
    {
        public frmDrivers()
        {
            InitializeComponent();
            Config();
        }


        private void Config()
        {
            DisplayAllDeivers();

            dgvDrivers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgvDrivers.Columns[3].Width = 300;
            tbFilter.Visible = false;
            lRecordCount.Text = RecordesCount();
            FillFiltersBox();
        }

        private string RecordesCount()
        {
            int count = dgvDrivers.Rows.Count;
            string Records = "#Records: " + count.ToString();
            return Records;
        }

        private void FillFiltersBox()
        {
            cbFilters.Items.Add("None");
            cbFilters.SelectedIndex = 0;

            foreach (DataGridViewColumn column in dgvDrivers.Columns)
            {
                cbFilters.Items.Add(column.HeaderText);
            }
        }

        private void DisplayAllDeivers()
        {
            dgvDrivers.DataSource = clsDrivers.GetDrivers();

        }

        private void SearchBySearchBar(string sentenceToSearch)
        {
            if (!string.IsNullOrWhiteSpace(sentenceToSearch))
            {
                foreach (DataGridViewRow row in dgvDrivers.Rows)
                {
                    CurrencyManager currencyManager1 =
                        (CurrencyManager)BindingContext[dgvDrivers.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }

                foreach (DataGridViewRow row in dgvDrivers.Rows)
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

                foreach (DataGridViewRow row in dgvDrivers.Rows)
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
            if (cbFilters.SelectedItem.ToString() == "Person ID")
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
    }
}
