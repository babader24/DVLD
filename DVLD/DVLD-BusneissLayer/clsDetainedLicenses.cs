using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusneissLayer
{
    public class clsDetainedLicenses
    {
        public int DetainedID { get; set; }

        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? ReleasedByUserID { get; set; }
        public int? ReleaseApplicationID { get; set; }

        public clsDetainedLicenses()
        {
            DetainedID = -1;
            LicenseID = -1;
            DetainDate = DateTime.Now;
            FineFees = -1;
            CreatedByUserID = -1;
            IsReleased = false;
            ReleaseDate = DateTime.Now;
            ReleasedByUserID = -1;
            ReleaseApplicationID = -1;
        }

        public clsDetainedLicenses(int detainedID, int licenseID, DateTime detainDate, decimal fineFees, int createdByUserID, bool isReleased, DateTime? releaseDate, int? releasedByUserID, int? releaseApplicationID)
        {
            DetainedID = detainedID;
            LicenseID = licenseID;
            DetainDate = detainDate;
            FineFees = fineFees;
            CreatedByUserID = createdByUserID;
            IsReleased = isReleased;
            ReleaseDate = releaseDate;
            ReleasedByUserID = releasedByUserID;
            ReleaseApplicationID = releaseApplicationID;
        }

        public static DataTable AllDetainedLicenses()
        {
            return clsDetainedDataAccess.GetAllDetainedLicenses();
        }

        public static clsDetainedLicenses FindByLicnseID(int licenseID)
        {
            int detainedID = -1, createdByUserID = -1;
            int? releaseApplicationID = -1, releasedByUserID = -1;
            DateTime detainDate = DateTime.Now;
            DateTime? releaseDate = DateTime.Now;
            decimal fineFees = 0;
            bool isReleased = false;

            if (clsDetainedDataAccess.FindDetainedLicenseByLicenseID(ref detainedID, licenseID, ref detainDate, ref fineFees, ref createdByUserID,
               ref isReleased, ref releaseDate, ref releasedByUserID, ref releaseApplicationID))
                return new clsDetainedLicenses(detainedID, licenseID, detainDate, fineFees, createdByUserID,
                isReleased, releaseDate, releasedByUserID, releaseApplicationID);
            
            else
                return null;
        }

        public static bool ReleseDetainedLicense(int licenseID)
        {
            return clsDetainedDataAccess.ReleseDetainedLicenseByLicenseID(licenseID);
        }

        private bool AddDetainedLicense()
        {
            this.DetainedID = clsDetainedDataAccess.AddNewDetainedLicense(this.LicenseID, this.DetainDate, this.FineFees,
                this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);

            return (this.DetainedID != -1);
        }

        public  bool Update()
        {
            return clsDetainedDataAccess.UpdateDetainedLicense(this.LicenseID, this.IsReleased, this.ReleaseDate,
                this.CreatedByUserID, this.ReleaseApplicationID);
        }
        public bool Save()
        {
            return AddDetainedLicense();
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsDetainedDataAccess.IsLicenseDetained(LicenseID);
        }



    }
}
