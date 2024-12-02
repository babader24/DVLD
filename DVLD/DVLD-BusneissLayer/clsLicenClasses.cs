using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusneissLayer
{
    public class clsLicenClasses
    {
        public static DataTable GetAllLicenseNames()
        {
            return clsLicenseClassesDataAccess.GatAllLicenseClassesNames();
        }

        public static string GetClassName(int licenseID)
        {
            return clsLicenseClassesDataAccess.GetLicenseClassName(licenseID);
        }

        public static byte GetValidateLingth(int licenseID)
        {
            return clsLicenseClassesDataAccess.GetLicenseValidityLength(licenseID);
        }

        public static decimal GetLicenseFees(int licenseID)
        {
            return clsLicenseClassesDataAccess.GetLicenseClassFess(licenseID);
        }
    }
}
