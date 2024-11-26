using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusneissLayer
{
    public class clsApplication
    {
        enum enMode { AddMode = 0, UpdateMode = 1 };
        enMode _Mode;

        public int ApplicationID { get; set; }

        public int ApplicantPersonID { get; set; }

        public DateTime ApplicationDate { get; set; }

        public int ApplicationTypeID { get; set; }

        public int ApplicationStatus { get; set; }

        public DateTime LastStatusDate { get; set; }

        public int CreatedByUserID { get; set; }

        public clsApplication()
        {
            ApplicationID = -1;
            ApplicantPersonID = -1;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = -1;
            ApplicationStatus = -1;
            LastStatusDate = DateTime.Now;
            CreatedByUserID = -1;

            _Mode = enMode.AddMode;
        }

        public clsApplication(int applicationID, int applicantPersonID, DateTime applicationDate, int applicationTypeID,
               int applicationStatus, DateTime lastStatusDate, int createdBuUserID)
        {
            ApplicationID = applicationID;
            ApplicantPersonID = applicantPersonID;
            ApplicationDate = applicationDate;
            ApplicationTypeID = applicationTypeID;
            ApplicationStatus = applicationStatus;
            LastStatusDate = lastStatusDate;            
            CreatedByUserID = createdBuUserID;

            _Mode = enMode.UpdateMode;
        }

        private bool _AddApplication()
        {
            this.ApplicationID = clsApplicationDataAccess.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate,
                this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.CreatedByUserID);

            return (ApplicationID != -1);
        }

        private bool _UpdateApplication()
        {
            return clsApplicationDataAccess.UpdateApplication(this.ApplicationID, this.ApplicantPersonID, this.ApplicationDate,
                this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.CreatedByUserID);
        }

        public static bool DeleteApplicaion(int applicionID)
        {
            return clsApplicationDataAccess.DeleteApplication(applicionID);
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddMode:
                    {
                        if(_AddApplication())
                        {
                            _Mode = enMode.UpdateMode;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.UpdateMode:
                    {
                        return _UpdateApplication();
                    }
            }
            return false;
        }


    }
}
