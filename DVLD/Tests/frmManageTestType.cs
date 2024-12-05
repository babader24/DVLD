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
    public partial class frmManageTestType : Form
    {
        public frmManageTestType()
        {
            InitializeComponent();
            config();
        }

        private void _LoadApplications()
        {
            dgvTestTypes.DataSource = clsTestType.GetAllTests();
        }

        private string _CountRecoreds()
        {
            int count = dgvTestTypes.RowCount;
            string records = "#Records: " + count;
            return records;
        }

        private void config()
        {
            _LoadApplications();
            lRecordCount.Text = _CountRecoreds();

            dgvTestTypes.Columns[0].Width = 50;
            dgvTestTypes.Columns[1].Width = 150;
            dgvTestTypes.Columns[2].Width = 350;
            dgvTestTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTestTypes.MultiSelect = false;
            dgvTestTypes.Columns[2].DefaultCellStyle.Format = "N5";
        }

        private void Refresh()
        {
            dgvTestTypes.DataSource = null;
            config();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmEditTestType((int)dgvTestTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
