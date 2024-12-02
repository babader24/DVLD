using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusneissLayer
{
    public class clsLicenses
    {

        public int LicenseID {  get; set; }

        public int ApplicationID {  get; set; }

        public int DriverID {  get; set; }

        public int LicenseClass {  get; set; }

        public DateTime IssueDate {  get; set; }

        public DateTime ExpirationDate {  get; set; }

        public string Notes {  get; set; }

        public decimal PaidFees {  get; set; }

        public bool IsActive {  get; set; }

        public byte IssueReason {  get; set; }

        public int CreatedByUserID {  get; set; }


        public clsLicenses()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClass = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.IsActive = true;
            this.IssueReason = 0;
            this.CreatedByUserID = -1;
        }

        public clsLicenses(int licenseID, int applicationID, int driverID, int licenseClass, DateTime issueDate,
            DateTime expirationDate, string notes, decimal paidFees, bool isActive, byte issueReason, int createdByUserID)
        {
            LicenseID = licenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            LicenseClass = licenseClass;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
            CreatedByUserID = createdByUserID;
        }


        public static DataTable GatAllLicense(int driverID)
        {
            return clsLicensesDataAccess.GitAllDrivers(driverID);
        }

        private bool AddLicense()
        {
            this.LicenseID = clsLicensesDataAccess.AddNewLicense(this.ApplicationID, this.DriverID, this.LicenseClass,
                this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
            return (LicenseID != -1);
        }

        public bool Save()
        {
            return AddLicense();
        }


        public static clsLicenses Find(int applicationID)
        {
            int licenseID = -1, licenseClass = -1, driverID = -1, createByUser = -1;
            DateTime issueDate = DateTime.Now, expirationDate = DateTime.Now;
            string notes = "";
            bool isActive = false;
            byte issueReason = 0;
            decimal paidFees = 0;

            if (clsLicensesDataAccess.FindLicenseByApplicationID(ref licenseID, applicationID, ref driverID, ref licenseClass, ref issueDate,
               ref expirationDate, ref notes, ref paidFees, ref isActive, ref issueReason, ref createByUser))
                return new clsLicenses(licenseID, applicationID,  driverID,  licenseClass,  issueDate,
                expirationDate,  notes,  paidFees,  isActive,  issueReason,  createByUser);
            else 
                return null;    

        }

        public static clsLicenses FindByLicenseID(int licenseID)
        {
            int applicationID = -1, licenseClass = -1, driverID = -1, createByUser = -1;
            DateTime issueDate = DateTime.Now, expirationDate = DateTime.Now;
            string notes = "";
            bool isActive = false;
            byte issueReason = 0;
            decimal paidFees = 0;

            if (clsLicensesDataAccess.FindLicenseByLicenseID( licenseID, ref applicationID, ref driverID, ref licenseClass, ref issueDate,
               ref expirationDate, ref notes, ref paidFees, ref isActive, ref issueReason, ref createByUser))
                return new clsLicenses(licenseID, applicationID, driverID, licenseClass, issueDate,
                expirationDate, notes, paidFees, isActive, issueReason, createByUser);
            else
                return null;

        }


        public static int GetPersonID(int LicenseID)
        {
            return clsLicensesDataAccess.GetPersonNameByLicenseID(LicenseID);
        }

        public static int GetLDLA(int LicenseID)
        {
            return clsLicensesDataAccess.GetLDLAIDByLocalLicense(LicenseID);
        }

    }
}
