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
    public partial class ucFilter : UserControl
    {

        public delegate void DataBackEventHaandler(object sender, int PersonID);
        public event DataBackEventHaandler dataBack;

        clsPerson _Person;
        
        public ucFilter()
        {
            InitializeComponent();
            Config();
        }

        private void Config()
        {
            cbFindPerson.SelectedIndex = 0;
        }

        private bool GetPersonByNationalNo(string nationalNo)
        {
            _Person = clsPerson.FindByNationalNo(nationalNo);
            return _Person != null;
        }

        private void picFindPerson_Click(object sender, EventArgs e)
        {
            if(GetPersonByNationalNo(tbFindPerson.Text))
            {
                dataBack?.Invoke(this,_Person.PersonID);
                
                
            }
            else
                MessageBox.Show("The Person Not Exists","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void picAddPerson_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEdit(-1);
            
            frm.ShowDialog();
        }
    }
}
