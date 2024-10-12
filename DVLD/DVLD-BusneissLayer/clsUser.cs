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
        public int personID { get; set; }

        public int userID { get; set; }

        public string userName { get; set; }

        public string password { get; set; }

        public bool IsAcive { get; set; }

        public clsUser()
        {
            this.personID = -1;
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
    }
}
