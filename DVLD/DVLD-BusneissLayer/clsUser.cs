using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusneissLayer
{
    public class clsUser
    {
        private enum enMode { addMode = 0, updateMpde = 1 }
        enMode _Mode = enMode.addMode;

        public int personID { get; set; }

        public int userID { get; set; }

        public string userName { get; set; }

        public string password { get; set; }

        public bool IsAcive { get; set; }

        public clsUser()
        {
            this.personID = -1;
            this.userID = -1;
            this.userName = "";
            this.password = "";
            this.IsAcive = false;

            _Mode = enMode.addMode;
            
        }
        public clsUser(int UserID, int PersonID, string UserName, string Password, bool isActive)
        {
            this.userID=UserID;
            this.personID= PersonID;
            this.userName=UserName;
            this.password=Password;
            this.IsAcive=isActive;

            _Mode=enMode.updateMpde;
        }

        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsersFromDatabase();
        }


        public static bool chekLogin(string UserName, string Password)
        {
            return clsUserDataAccess.checkLogin(UserName, Password);
        }

        public static bool IsActive(string UserName)
        {
            return clsUserDataAccess.IsAcvive(UserName);
        }

        public static bool IsExsist(int PersonID)
        {
            return clsUserDataAccess.IsExsist(PersonID);
        } 

        public static clsUser Find(int UserID)
        {
            string UserName = "", Password = "";
            int PersonID = -1;
            bool isActive= false;

           if(clsUserDataAccess.FindUser(UserID, ref PersonID, ref UserName,ref Password,ref isActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, isActive);
            }
           else
                return null;

        }

        public static clsUser FindByName( string UserName)
        {
             string Password = "";
            int PersonID = -1, UserID = -1;
            bool isActive = false;

            if (clsUserDataAccess.FindUserByName(ref UserID, ref PersonID,  UserName, ref Password, ref isActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, isActive);
            }
            else
                return null;

        }

        private bool _AddNewUser()
        {
            this.userID = clsUserDataAccess.AddNewUser(this.personID, this.userName, this.password, this.IsAcive);

            return (this.userID != -1);

        }

        private bool _UpdateUser()
        {
            return clsUserDataAccess.UpdateUser(this.userID, this.personID, this.userName, this.password, this.IsAcive);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.addMode:
                    {
                        if(_AddNewUser())
                        {
                            _Mode = enMode.updateMpde;
                            return true;
                        }
                        else
                            return false;   
                    }
                case enMode.updateMpde:
                    {
                       return _UpdateUser();
                    }   
            }
            return false;
        }
        public static bool DeleteUser(int UserID)
        {
            return clsUserDataAccess.DeleteUser(UserID);
        }


    }
}
