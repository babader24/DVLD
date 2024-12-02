using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusneissLayer
{
    public class clsDrivers
    {
        public int DriverID { get; set; }

        public int PersonID { get; set; }

        public int createByUser { get; set; }

        public DateTime CreateDate { get; set; }

        public clsDrivers()
        {
            DriverID = -1;
            PersonID = -1;
            createByUser = -1;
            CreateDate = DateTime.Now;

        }

        public clsDrivers(int driverID, int personID, int createByUser, DateTime createDate)
        {
            DriverID = driverID;
            PersonID = personID;
            this.createByUser = createByUser;
            CreateDate = createDate;
        }

        public static DataTable GetDrivers()
        {
            return clsDriversDataAccess.GitAllDrivers();
        }

        private  bool AddDriver()
        {
            this.DriverID  = clsDriversDataAccess.AddNewDriver(this.PersonID,this.createByUser,this.CreateDate);

            return (this.DriverID != -1);
        }

        public bool Save()
        {
            return AddDriver();
        }

        public static bool IsExsist(int personID)
        {
            return clsDriversDataAccess.IsDriverExsist(personID);
        }

        public static clsDrivers Find(int personID)
        {
            int userID = -1, deriverID = -1;
            DateTime createDate = DateTime.Now;
            
            if(clsDriversDataAccess.FindDriver(ref deriverID,personID, ref userID, ref createDate))
                return new clsDrivers(deriverID,personID,userID,createDate);
            else
                return null;
        }

    }
}
