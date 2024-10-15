using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusneissLayer
{
    public class clsPerson
    {

        public enum enMode{ AddMode=0, UpdateMode = 1 };
        enMode _Mode = enMode.AddMode;

        public int PersonID { get; set; }

        public string NationalNo { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string ThirdName {  get; set; }
        
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public byte Gendor {  get; set; }
        
        public string Address { get; set; }

        public string Country { get; set; }

        public string Phone  { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }

       public clsPerson()
        {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.BirthDate = DateTime.Now.AddYears(-18);
            this.Gendor = 0;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.ImagePath = "";
            //this.NationalityCountryID = 0;
            this.Country = "";

            _Mode = enMode.AddMode;
        }

        public clsPerson(int personID, string NationalNo, string FirstName,
            string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gendor,
            string Address, string Phone, string Email, string ImagePath, string country)
        {
            this.PersonID = personID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.BirthDate = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.ImagePath = ImagePath;
            this.Country = country;

            _Mode = enMode.UpdateMode;
            Country = country;
        }

        public static DataTable GetAllPeople()
        {
            return clsPersonDataAccess.GetAllPeople();
        }

        public static DataTable GetAllCountries()
        {
            return clsPersonDataAccess.GetAllCountries();
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonDataAccess.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName,
                this.ThirdName, this.LastName, this.BirthDate, this.Gendor,this.Address,this.Phone,
                this.Email, this.NationalityCountryID, this.ImagePath);

            return (PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return clsPersonDataAccess.UpdatePersonInfo(this.PersonID, this.NationalNo, this.FirstName, this.SecondName,
                this.ThirdName, this.LastName, this.BirthDate, this.Gendor, this.Address, this.Phone,
                this.Email,this.NationalityCountryID, this.ImagePath);
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddMode:
                 
                    if(_AddNewPerson())
                    {
                        _Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                        return false;
                case enMode.UpdateMode:

                    return _UpdatePerson();        
            }
            return false;
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonDataAccess.DeletePerson(PersonID);
        }

        public static clsPerson Find(int  PersonID)
        {
            string NationalNo = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", 
             Address = "", Phone = "", Email = "", ImagePath = "", Country = "";
             DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;

            if (clsPersonDataAccess.GetPersonInfoByID(PersonID, ref NationalNo, ref FirstName, ref SecondName,
                ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref ImagePath, ref Country))
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName,
                    DateOfBirth, Gendor, Address, Phone, Email, ImagePath, Country);
            else return null;
        }

        public static clsPerson FindByNationalNo(string NationalNo)
        {
            int PersonID = 0;
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "",
             Address = "", Phone = "", Email = "", ImagePath = "", Country = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;

            if (clsPersonDataAccess.GetPersonInfoByNationalNo(ref PersonID, NationalNo, ref FirstName, ref SecondName,
                ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref ImagePath, ref Country))
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName,
                    DateOfBirth, Gendor, Address, Phone, Email, ImagePath, Country);
            else return null;
        }

        public static int GetCountryIDByname(string Name)
        {
            int ID = 0;

            if(clsPersonDataAccess.GetCountryInfoByName(Name, ref ID))
                return ID;

            else return 0;
        }
        
    }
}
