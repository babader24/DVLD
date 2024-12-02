using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class clsLicensesDataAccess
    {

        public static DataTable GitAllDrivers(int driverID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"Select LicenseID, ApplicationID, ClassName, IssueDate, ExpirationDate, IsActive from Licenses
                inner join LicenseClasses on Licenses.LicenseClass = LicenseClasses.LicenseClassID
                    WHERE DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", driverID);

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

        public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClass,DateTime IssueDate,
            DateTime ExpirationDate,string Notes,decimal PaidFees,bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            int LicenseID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"Insert INTO Licenses (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes,
                PaidFees,IsActive, IssueReason, CreatedByUserID)
                Values (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes,@PaidFees,@IsActive,
                @IssueReason, @CreatedByUserID);
                Select Scope_identity();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@Notes", Notes == null ? (object)DBNull.Value : Notes);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertID))
                {
                    LicenseID = insertID;
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
            return LicenseID;
        }


        public static bool FindLicenseByApplicationID(ref int LicenseID, int ApplicationID, ref int DriverID, ref int LicenseClass, ref DateTime IssueDate,
            ref DateTime ExpirationDate, ref string Notes, ref decimal PaidFees, ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID)
        {
            bool IsFoend;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"Select * from Licenses WHERE ApplicationID =@ApplicationID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFoend = true;

                    LicenseID = (int)reader["LicenseID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    Notes = (string)(reader["Notes"] == DBNull.Value ? null : reader["Notes"]);
                    PaidFees = (decimal)reader["PaidFees"];
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
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


        public static bool FindLicenseByLicenseID( int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClass, ref DateTime IssueDate,
            ref DateTime ExpirationDate, ref string Notes, ref decimal PaidFees, ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID)
        {
            bool IsFoend;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"Select * from Licenses WHERE LicenseID =@LicenseID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFoend = true;

                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    Notes = (string)(reader["Notes"] == DBNull.Value ? null : reader["Notes"]);
                    PaidFees = (decimal)reader["PaidFees"];
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
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

        public static int GetPersonNameByLicenseID(int LicenseID)
        {
            int PersonID;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);
            string query = @"select PersonID from Licenses inner join Drivers on Licenses.DriverID = Drivers.DriverID
                        where LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                }
                else
                    PersonID = -1;

                reader.Close();
            }
            catch
            {
                PersonID = -1;
            }
            finally
            {
                connection.Close();
            }
            return PersonID;
        }

        public static int GetLDLAIDByLocalLicense(int licenseId)
        {
            int LDLAID;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);
            string query = @"select LocalDrivingLicenseApplicationID from LocalDrivingLicenseApplications inner join Licenses
                on LocalDrivingLicenseApplications.ApplicationID = Licenses.ApplicationID
                where LicenseID = @licenseId";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@licenseId", licenseId);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    LDLAID = (int)reader["LocalDrivingLicenseApplicationID"];
                }
                else
                    LDLAID = 0;

                reader.Close();
            }
            catch
            {
                LDLAID = 0;
            }
            finally
            {
                connection.Close();
            }
            return LDLAID;
        }
    }
}
