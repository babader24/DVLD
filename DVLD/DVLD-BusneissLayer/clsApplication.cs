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
        }

        public static bool DeleteApplicaion(int applicionID)
        {
            return clsApplicationDataAccess.DeleteApplication(applicionID);
        }


    }
}
