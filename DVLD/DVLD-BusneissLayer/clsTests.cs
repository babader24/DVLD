using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusneissLayer
{
    public class clsTests
    {
        private enum enMode { addMode = 0, UpdateMode = 1 };
        enMode _Mode;

        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }


        public clsTests()
        {
            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.TestResult = false;
            this.Notes = "";
            this.CreatedByUserID = -1;

            _Mode = enMode.addMode;
        }

        public clsTests(int testID, int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {
            TestID = testID;
            TestAppointmentID = testAppointmentID;
            TestResult = testResult;
            Notes = notes;
            CreatedByUserID = createdByUserID;

            _Mode = enMode.UpdateMode;
        }

        private bool AddTest()
        {
            this.TestID = clsTestDataAccess.AddNewTest(this.TestAppointmentID,this.TestResult,this.Notes,this.CreatedByUserID);

            return (this.TestID != -1);
        }

        private bool UpdateTest()
        {
            return clsTestDataAccess.Updatetest(this.TestID,this.TestAppointmentID,this.TestResult,this.Notes,this.CreatedByUserID);
        }
        
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.addMode:
                    {
                        if(AddTest())
                        {
                            _Mode = enMode.UpdateMode;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.UpdateMode:
                    {
                        return UpdateTest();
                    }
            }
            return false;
        }

    }
}
