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
using static DVLD.frmDVLD;

namespace DVLD
{
    public partial class PersonInfo : UserControl
    {
        public delegate void DataBackEventHaandler(object sender, int ID);
        public event DataBackEventHaandler DataBack;
        public  int _ID { get; set; }

        public string _NationalNo { get; set; }

        public PersonInfo()
        {
            InitializeComponent();  
        }

        //public delegate void CloseFormEventHandlar(object sender);

        //public event CloseFormEventHandlar CloseFormRequest;


        

        public void _LaodData()
        {
            string man = TheDefualtImg.ManPhotoPath;
            string woman = TheDefualtImg.WomanPhotoPath;
            string defualtIMG;

            clsPerson _Person = clsPerson.Find(_ID);
            if (_Person != null)
            {
                lpersonID.Text = _Person.PersonID.ToString();
                lFullName.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;

                lEmail.Text = _Person.Email;
                lAddress.Text = _Person.Address;
                lDateOfBirth.Text = _Person.BirthDate.ToString("dd/MM/yyyy");
                lPhone.Text = _Person.Phone;
                lCountry.Text = _Person.Country;
                lNational.Text = _Person.NationalNo;
                _NationalNo = _Person.NationalNo;

                if (_Person.Gendor == 0)
                {
                    lGendor.Text = "Male";
                    defualtIMG = man;
                }
                else
                {
                    lGendor.Text = "Female";
                    defualtIMG = woman;
                }


                try
                {
                    picPhoto.Load(_Person.ImagePath);

                }
                catch /*(Exception ex)*/
                {
                    picPhoto.Load(defualtIMG);
                }
            }
            else
                MessageBox.Show("The Person maybe deleted or corrupted","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void linkLabelEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_ID >0)
            {
                Form frm = new frmAddEdit(_ID);
                ((Form)this.TopLevelControl).Close();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Select a Person First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void PersonInfo_Load(object sender, EventArgs e)
        {
            //_LaodData();
        }
    }
}
