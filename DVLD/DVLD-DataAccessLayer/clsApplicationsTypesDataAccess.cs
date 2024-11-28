using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class clsApplicationsTypesDataAccess
    {
        public static DataTable GetAllApplicationsTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);
            string query = @"select ApplicationTypeID as ID, ApplicationTypeTitle as Title,
                            ApplicationFees as Fees from ApplicationTypes ";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static bool UpdateApplication(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            int roweffected;

            SqlConnection connection = new SqlConnection( clsDataAccessSetting.ConnetionString);
            string query = @"Update ApplicationTypes
                            set ApplicationTypeTitle = @ApplicationTypeTitle,  ApplicationFees = @ApplicationFees 
                            Where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();

                roweffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                roweffected = 0;
            }
            finally
            {
                connection.Close();
            }
            return roweffected > 0;
        }

        public static bool GetApplicationType(int ID, ref string Title, ref decimal Fees)
        {
            bool isFound;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"Select * from ApplicationTypes WHere ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    Title = (string)reader["ApplicationTypeTitle"];
                    Fees = (decimal)reader["ApplicationFees"];
                }
                else
                    isFound = false;

                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static decimal GetApplicationFeesByID(int ID)
        {
            decimal fees = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"select ApplicationFees from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                    fees = (decimal)reader["ApplicationFees"];
                


                reader.Close();
            }
            catch 
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
            return fees;
        }
    }
}
