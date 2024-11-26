using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusneissLayer
{
    public class clsAppointments
    {
        public enum enMode { AddMode=0, UpdateMode=1};
        enMode _Mode;

        public int TestAppointmentID {  get; set; }

        public int TestType { get; set; }

        public int LDLA_ID { get; set; }

        public DateTime AppointmentDate { get; set; }

        public decimal Fees { get; set; }

        public int UserID { get; set; }

        public bool IsLocked { get; set; }

        public clsAppointments()
        {
            this.TestAppointmentID = -1;
            this.TestType = 0;
            this.LDLA_ID = 0;
            this.AppointmentDate = DateTime.Now;
            this.Fees = 0;
            this.UserID = -1;
            this.IsLocked = false;

            _Mode = enMode.AddMode;

        }

        public clsAppointments(int testAppointmentID, int testType, DateTime appointmentDate, int lDLA_ID, decimal fees,
            int userID, bool isLocked)
        {
            this.TestAppointmentID = testAppointmentID;
            this.TestType = testType;
            this.AppointmentDate = appointmentDate;
            this.LDLA_ID = lDLA_ID;
            this.Fees = fees;
            this.UserID = userID;
            this.IsLocked = isLocked;

            _Mode= enMode.UpdateMode;
        }


        public static DataTable GetAllAppointments(int LDLAID, int TestType)
        {
            return clsAppointmentDataAccess.GetAllAppointmentByDLAppIDAndTestType(LDLAID, TestType);
        }

        private bool AddAppointment()
        {
            this.TestAppointmentID = clsAppointmentDataAccess.AddNewAppointment(this.TestType, this.LDLA_ID, this.AppointmentDate,
                this.Fees, this.UserID, this.IsLocked);

            return (TestAppointmentID != -1);

        }

        private bool UpdateAppointment()
        {
            return clsAppointmentDataAccess.UpdateAppointment(this.TestAppointmentID, this.TestType, this.LDLA_ID, this.AppointmentDate,
                this.Fees, this.UserID, this.IsLocked);
        }


        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddMode:
                    {
                        if(AddAppointment())
                        {
                            _Mode = enMode.UpdateMode;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.UpdateMode:
                    {
                        return UpdateAppointment();
                    }
            }
            return false;            
        } 


    }
}
