using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_BusneissLayer
{
    public class clsLocalDLA : clsApplication
    {

        private enum enMode { AddMode = 0, UpdateMode = 1 }
        enMode _Mode = enMode.AddMode;

        public int LDLAID { get; set; }
        public int LicenceID { get; set; }


        public clsLocalDLA() : base()
        {
            LDLAID = -1;
            LicenceID = -1;

            _Mode = enMode.AddMode;
        }

        public clsLocalDLA(int lDLAID, int licenceID, int applicationID, int applicantPersonID, DateTime applicationDate, int applicationTypeID,
               int applicationStatus, DateTime lastStatusDate, int createdBuUserID) : base(applicationID,  applicantPersonID,  applicationDate,  applicationTypeID,
                applicationStatus,  lastStatusDate,  createdBuUserID)
        {
            LDLAID = lDLAID;
            LicenceID = licenceID;

            _Mode = enMode.UpdateMode;
        }

        public static DataTable GetAllLDLA()
        {
            return clsLocalDLA_DataAccess.GetAllLDLA_View();
        }

        private bool AddNewDLDA()
        {
            this.ApplicationID = clsApplicationDataAccess.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID,
                this.ApplicationStatus,this.LastStatusDate, this.CreatedByUserID);
            

            this.LDLAID = clsLocalDLA_DataAccess.AddNewLDLA(this.ApplicationID, this.LicenceID);

            return (this.LDLAID != -1);
                
        }

        private bool UpdateDLDA()
        {
            if (clsApplicationDataAccess.UpdateApplication(this.ApplicationID, this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID,
                this.ApplicationStatus, this.LastStatusDate, this.CreatedByUserID))

                return clsLocalDLA_DataAccess.UpdateLDLA(this.LDLAID, this.ApplicationID, this.LicenceID);
            else
                return false;
        }

        public bool checkLincenseStatus(string NationalNo,int lincenseID)
        {
            return clsLocalDLA_DataAccess.checkLicense(NationalNo, lincenseID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddMode:
                    {
                        if (AddNewDLDA())
                        {
                            _Mode = enMode.UpdateMode;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.UpdateMode:
                    return UpdateDLDA();
            }
            return false;

            
        }

        public static bool Cancel(int LALDID)
        {
            return clsLocalDLA_DataAccess.CancelLicense(LALDID);
        }

        public static clsLocalDLA Find(int LDLAID)
        {
            int licenceID = 0, applicationID = 0, applicantPersonID = 0, applicationTypeID = 0,
                 createdBuUserID = 0;
            byte applicationStatus = 0;
            DateTime lastStatusDate = DateTime.Now, applicationDate = DateTime.Now;

            if(clsLocalDLA_DataAccess.GetLDLAByID(LDLAID, ref licenceID, ref applicationID, ref applicantPersonID, ref applicationDate, ref applicationTypeID,
               ref applicationStatus, ref lastStatusDate, ref createdBuUserID))            
                
                return new clsLocalDLA(LDLAID, licenceID, applicationID, applicantPersonID, applicationDate, applicationTypeID,
                    applicationStatus, lastStatusDate, createdBuUserID); 
             
            else return null;
            
        }

        public static bool DeleteLDLA(int LDLAID)
        {
            return clsLocalDLA_DataAccess.DeleteLDLA(LDLAID);
        }

        public static int PassedTests(int LDLAID)
        {
            return clsLocalDLA_DataAccess.GetPassedTestCountByLDLAID(LDLAID);
        }

        public static int GetLicenseID(int LDLAID)
        {
            return clsLocalDLA_DataAccess.GetLicenseIdByLDLA(LDLAID);
        }

    }
}
