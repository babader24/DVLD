using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class clsTestTypeDataAccess
    {
        public static DataTable GetAllTestsTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);
            string query = @"select TestTypeID as ID, TestTypeTitle as Title,TestTypeDescription as Description,
                            TestTypeFees as Fees from TestTypes ";

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
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static bool UpdateTest(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            int roweffected;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);
            string query = @"Update TestTypes
                            set TestTypeTitle = @TestTypeTitle,  TestTypeFees = @TestTypeFees ,
                           TestTypeDescription = @TestTypeDescription Where TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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

        public static bool FindTest(int ID, ref string Title, ref string Descriptoin, ref decimal Fees)
        {
            bool isFound;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"Select * from TestTypes WHere TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Title = (string)reader["TestTypeTitle"];
                    Descriptoin = (string)reader["TestTypeDescription"];
                    Fees = (decimal)reader["TestTypeFees"];
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
    }
}
