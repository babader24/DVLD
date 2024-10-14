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
        public static int _ID { get; set; }
        public PersonInfo()
        {
            InitializeComponent();
           
            _LaodData();
        }

        //public delegate void CloseFormEventHandlar(object sender);

        //public event CloseFormEventHandlar CloseFormRequest;


        

        public void _LaodData()
        {
            string man = TheDefualtImg.ManPhotoPath;
            string woman = TheDefualtImg.WomanPhotoPath;
            string defualtIMG;

            clsPerson _Person = clsPerson.Find(_ID);
            lpersonID.Text = _Person.PersonID.ToString();
            lFullName.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
            lNational.Text = _Person.NationalNo;
            lEmail.Text = _Person.Email;
            lAddress.Text = _Person.Address;
            lDateOfBirth.Text = _Person.BirthDate.ToString("dd/MM/yyyy");
            lPhone.Text = _Person.Phone;
            lCountry.Text = _Person.Country;

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

        private void Closebtn_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void linkLabelEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmAddEdit(_ID);
            ((Form)this.TopLevelControl).Close();
            frm.ShowDialog();
            
        }
    }
}
