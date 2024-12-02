using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class clsAppointmentDataAccess
    {
        public static DataTable GetAllAppointmentByDLAppIDAndTestType(int DLApp, int testType)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);
            string query = @"select TestAppointmentID as AppointmentID, AppointmentDate, PaidFees, IsLocked
            from TestAppointments where LocalDrivingLicenseApplicationID = @DLApp and TestTypeID = @testType
            order by TestAppointmentID  DESC";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DLApp", DLApp);
            command.Parameters.AddWithValue("@testType", testType);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch
            {
                //
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }


        public static int AddNewAppointment(int testType, int LDAD_ID, DateTime AppointmentDate, decimal Fees,
            int UserID, bool IsLocked)
        {
            int TestAppointmentID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);
            string query = @"insert into TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,CreatedByUserID,IsLocked)
            values (@testType,@LDAD_ID,@AppointmentDate,@Fees,@UserID,@IsLocked);
                Select Scope_identity();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@testType", testType);
            command.Parameters.AddWithValue("@LDAD_ID", LDAD_ID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@Fees", Fees);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int resultID))
                {
                    TestAppointmentID = resultID;
                }

            }
            catch
            {
                //
            }
            finally
            {
                connection.Close();
            }
            return TestAppointmentID;
        }


        public static bool UpdateAppointment(int TestAppointmentID, int testType, int LDAD_ID, DateTime AppointmentDate, decimal Fees,
            int UserID, bool IsLocked)
        {
            int rowEffected;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);
            string query = @"Update TestAppointments Set TestTypeID = @testType, LocalDrivingLicenseApplicationID = @LDAD_ID,
                AppointmentDate = @AppointmentDate,PaidFees = @Fees,CreatedByUserID = @UserID,IsLocked =@IsLocked 
                where TestAppointmentID = @TestAppointmentID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@testType", testType);
            command.Parameters.AddWithValue("@LDAD_ID", LDAD_ID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@Fees", Fees);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);

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

        public static bool IsLocked(int TestAppointmentID)
        {
            bool IsLocked;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);
            string query = "select Found=1  from TestAppointments where IsLocked = 1 and TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                IsLocked = reader.HasRows;

                reader.Close();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return IsLocked;

        }

        public static bool FindAppointment(int TestAppointmentID, ref int testType, ref int LDAD_ID, ref DateTime AppointmentDate, ref decimal Fees,
            ref int UserID, ref bool IsLocked)
        {
            bool isFound;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);
            string query = @"select TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees,CreatedByUserID,
                IsLocked from TestAppointments where TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    testType = (int)reader["TestTypeID"];
                    LDAD_ID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    Fees = (decimal)reader["PaidFees"];
                    UserID = (int)reader["CreatedByUserID"];
                    IsLocked = (bool)reader["IsLocked"];
                }
                else
                    isFound = false;

                reader.Close();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;

        }

         public static bool IsRetakeTest(int TestAppointmentID)
         {
             bool rowEffected;

             SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);
             string query = "select found = 1  from Tests where TestAppointmentID =@testAppointmentID";

             SqlCommand command = new SqlCommand(query, connection);

             command.Parameters.AddWithValue("@testAppointmentID", TestAppointmentID);

             try
             {
                 connection.Open();

                 SqlDataReader reader = command.ExecuteReader();

                rowEffected = reader.HasRows;

                 reader.Close();
             }
             catch
             {
                 return false;
             }
             finally
             {
                 connection.Close();
             }
             return rowEffected;

         } 


        public static bool IsPassTest(int TestAppointmentID)
        {
            bool IsPassed;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);
            string query = "select Found=1  from Tests where TestAppointmentID =@TestAppointmentID and TestResult = 1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                IsPassed = reader.HasRows;

                reader.Close();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return IsPassed;
        }
    }
}
