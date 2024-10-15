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
    public partial class Filter : UserControl
    {

        public delegate void DataBackEventHaandler(object sender, int NationalNo);
        public event DataBackEventHaandler dataBack;
        clsPerson _Person;
        public Filter()
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
            return clsPerson.FindByNationalNo(nationalNo) != null;
        }

        private void picFindPerson_Click(object sender, EventArgs e)
        {
            if(GetPersonByNationalNo(tbFindPerson.Text))
            {
                //PersonInfo._ID = _Person.PersonID;
                
            }
            else
                MessageBox.Show("The Person Not Exists","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
