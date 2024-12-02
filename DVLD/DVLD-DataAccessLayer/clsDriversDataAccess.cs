using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class clsDriversDataAccess
    {

        public static DataTable GitAllDrivers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"select  DriverID as 'Driver ID', PersonID as 'Person ID', NationalNo as 'National No',
                FullName as 'Full Name',CreatedDate as 'Date', NumberOfActiveLicenses as 'Active Licenses'
                from Drivers_View";

            SqlCommand command = new SqlCommand(query, connection);

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

        public static bool IsDriverExsist(int PersonID)
        {
            bool isFound;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);
            string query = "SELECT Found = 1 from Drivers WHere PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch 
            {
                //
                return false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static int AddNewDriver(int PersonID, int UserID, DateTime createDate)
        {
            int DriverID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"Insert INTO Drivers (PersonID, CreatedByUserID, CreatedDate)
                           Values (@PersonID, @UserID, @createDate);
                             Select Scope_identity();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@createDate", createDate);            

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertID))
                {
                    DriverID = insertID;
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
            return DriverID;
        }

        public static bool FindDriver(ref int driverID, int personID, ref int createByUser, ref DateTime createDate)
        {
            bool IsFoend;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"select DriverID,CreatedByUserID, CreatedDate  from Drivers where PersonID = @personID";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFoend = true;

                    driverID = (int)reader["DriverID"];
                    createByUser = (int)reader["CreatedByUserID"];
                    createDate = (DateTime)reader["CreatedDate"];
                   
                }
                else
                    IsFoend = false;

                reader.Close();
            }
            catch
            {
                IsFoend = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFoend;
        }



    }
}
