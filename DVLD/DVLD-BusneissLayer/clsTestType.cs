using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusneissLayer
{
    public class clsTestType
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Fees { get; set; }


        public clsTestType(int iD, string title, string description, decimal fees)
        {
            ID = iD;
            Title = title;
            Description = description;
            Fees = fees;
        }

        public static DataTable GetAllTests()
        {
            return clsTestTypeDataAccess.GetAllTestsTypes();
        }

        public static clsTestType Find(int testID)
        {
            string title = "", description = "";
            decimal fees = 0;

            if (clsTestTypeDataAccess.FindTest(testID, ref title, ref description, ref fees))
                return new clsTestType(testID, title, description, fees);
            else
                return null;

        }

        private bool _Update()
        {
            return clsTestTypeDataAccess.UpdateTest(this.ID, this.Title, this.Description, this.Fees);
        }

        public bool Save()
        {
            return _Update();
        }

    }
}
