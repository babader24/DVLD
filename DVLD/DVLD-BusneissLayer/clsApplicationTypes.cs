using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusneissLayer
{
    public class clsApplicationTypes
    {

        public int ID {  get; set; }

        public string Title { get; set; }

        public decimal Fees { get; set; }

        public clsApplicationTypes(int  id, string title, decimal fees)
        {
            this.ID = id;
            this.Title = title;
            this.Fees = fees;
        }

        public static DataTable GetAllApplications()
        {
            return clsApplicationsTypesDataAccess.GetAllApplicationsTypes();
        }

        public static clsApplicationTypes Find(int id)
        {
            string title = "";
            decimal fees = 0;

            if(clsApplicationsTypesDataAccess.GetApplicationType(id, ref title, ref fees))
                return new clsApplicationTypes(id, title, fees);
            else
                return null;
        }

        private bool _Update()
        {
            return clsApplicationsTypesDataAccess.UpdateApplication(this.ID, this.Title, this.Fees);
        }

        public bool Save()
        {
            return _Update();
        }

        public static decimal GetFees(int id)
        {
            return clsApplicationsTypesDataAccess.GetApplicationFeesByID(id);
        }
    }
}
