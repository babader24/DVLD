using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class clsTestDataAccess
    {

        public static int AddNewTest(int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {
            int testID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"Insert INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID )
                           Values ( @TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
                             Select Scope_identity();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
            command.Parameters.AddWithValue("@TestResult", testResult);
            command.Parameters.AddWithValue("@Notes", notes == null ? (object)DBNull.Value : notes);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);           
            

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertID))
                {
                    testID = insertID;
                }
            }
            catch
            {
                //Write Exception Code
            }
            finally
            {
                connection.Close();
            }
            return testID;
        }

        public static bool Updatetest(int testID, int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {
            int rowEffected;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);
    
            string query = @"Update Applications 
                set TestAppointmentID = @TestAppointmentID, TestResult = @TestResult, Notes = @Notes,
                CreatedByUserID = @CreatedByUserID
                where TestID = @TestID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", testID);
            command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
            command.Parameters.AddWithValue("@TestResult", testResult);
            command.Parameters.AddWithValue("@Notes", notes == null ? (object)DBNull.Value : notes);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

            try
            {
                connection.Open();

                rowEffected = command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return (rowEffected > 0);
        }


    }
}
