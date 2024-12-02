using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusneissLayer
{
    public class clsInterNationalLicense
    {

        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }


        public clsInterNationalLicense()
        {
            InternationalLicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            IssuedUsingLocalLicenseID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            IsActive = false;
            CreatedByUserID = -1;


        }

        public clsInterNationalLicense(int internationalLicenseID, int applicationID, int driverID, int issuedUsingLocalLicenseID, DateTime issueDate, DateTime expirationDate, bool isActive, int createdByUserID)
        {
            InternationalLicenseID = internationalLicenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            CreatedByUserID = createdByUserID;
        }


        public static DataTable GetAllInternational()
        {
            return clsInternationalLicenseDataAccess.GitAllInternational();
        }

        public static DataTable GetAllIntLicenses(int IntLicenseID)
        {
            return clsInternationalLicenseDataAccess.GitAllIntLicenses(IntLicenseID);
        }

        public static bool IsExsist(int LocalLicense)
        {
            return clsInternationalLicenseDataAccess.IsExsist(LocalLicense);
        }

        public static clsInterNationalLicense FindByLicenseID(int licenseID)
        {
            int applicationID = -1, licenseClass = -1, driverID = -1, createByUser = -1;
            DateTime issueDate = DateTime.Now, expirationDate = DateTime.Now;
            bool isActive = false;

            if (clsInternationalLicenseDataAccess.FindLicenseByLicenseID(licenseID, ref applicationID, ref driverID, ref licenseClass, ref issueDate,
               ref expirationDate, ref isActive, ref createByUser))
                return new clsInterNationalLicense(licenseID, applicationID, driverID, licenseClass, issueDate,
                expirationDate, isActive, createByUser);
            else
                return null;

        }

        private bool AddLicense()
        {
            this.InternationalLicenseID = clsInternationalLicenseDataAccess.AddNewLicense(this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID,
                this.IssueDate, this.ExpirationDate,this.IsActive, this.CreatedByUserID);
            return (InternationalLicenseID != -1);
        }

        public bool Save()
        {
            return AddLicense();
        }


    }
}
