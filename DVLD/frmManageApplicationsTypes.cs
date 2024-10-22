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
    public partial class frmManageApplicationsTypes : Form
    {
        public frmManageApplicationsTypes()
        {
            InitializeComponent();
            config();
        }

        private void _LoadApplications()
        {
            dgvApplicationsTypes.DataSource = clsApplicationTypes.GetAllApplications();
        }

        private string _CountRecoreds()
        {
            int count = dgvApplicationsTypes.RowCount;
            string records = "#Records: " + count;
            return records;
        }

        private void config()
        {
            _LoadApplications();
            lRecordCount.Text = _CountRecoreds();

            dgvApplicationsTypes.Columns[1].Width = 250;
            dgvApplicationsTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplicationsTypes.MultiSelect = false;
            dgvApplicationsTypes.Columns[2].DefaultCellStyle.Format = "N5";
        }

        private void Refresh()
        {
            dgvApplicationsTypes.DataSource = null;
            config();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmEditApplicationTypecs((int)dgvApplicationsTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            Refresh();
        }
    }
}
