using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class clsInternationalLicenseDataAccess
    {



        public static DataTable GitAllInternational()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

                string query = @"select InternationalLicenseID as 'Int.LicenseID', InternationalLicenses.ApplicationID,DriverID, 
                    IssuedUsingLocalLicenseID as 'L.LicenseID', InternationalLicenses.IssueDate,
                    InternationalLicenses.ExpirationDate, InternationalLicenses.IsActive from InternationalLicenses ";

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

        public static DataTable GitAllIntLicenses(int IntLicenseID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"select InternationalLicenseID as 'Int.LicenseID', InternationalLicenses.ApplicationID, IssuedUsingLocalLicenseID as 'L.LicenseID', 
                InternationalLicenses.IssueDate,InternationalLicenses.ExpirationDate, InternationalLicenses.IsActive from InternationalLicenses 
                inner join Licenses
                on InternationalLicenses.DriverID = Licenses.DriverID
                where LicenseID = @IntLicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@IntLicenseID", IntLicenseID);

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

        public static bool IsExsist(int LicenseID)
        {
            bool isFound;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);
            string query = "select Found = 1 from InternationalLicenses where IssuedUsingLocalLicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

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
        
        public static bool FindLicenseByLicenseID(int InternationalLicenseID, ref int ApplicationID, ref int DriverID, ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate,
            ref DateTime ExpirationDate,ref bool IsActive, ref int CreatedByUserID)
        {
            bool IsFoend;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"Select * from InternationalLicenses
                WHERE InternationalLicenseID =@LicenseID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", InternationalLicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFoend = true;
                   
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];     
                    CreatedByUserID = (int)reader["CreatedByUserID"];


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

        public static int AddNewLicense(int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate,
            DateTime ExpirationDate, bool IsActive,  int CreatedByUserID)
        {
            int InternationalLicenseID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);
           
            string query = @"Insert INTO InternationalLicenses (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate,
                IsActive, CreatedByUserID)
                Values (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @IsActive,
                @CreatedByUserID);
                Select Scope_identity();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertID))
                {
                    InternationalLicenseID = insertID;
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
            return InternationalLicenseID;
        }
    }
}
