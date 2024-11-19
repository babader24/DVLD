using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DataAccessLayer
{
    public class clsLocalDLA_DataAccess
    {
        public static DataTable GetAllLDLA_View()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = "select * from LocalDrivingLicenseApplications_View";

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
                //
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static int AddNewLDLA(int applicationID, int licenceID)
        {
            int lDLAID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"Insert INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID)
                           Values (@applicationID, @licenceID);
                             Select Scope_identity();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@applicationID", applicationID);
            command.Parameters.AddWithValue("@licenceID", licenceID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertID))
                {
                    lDLAID = insertID;
                }
            }
            catch (Exception ex)
            {
                //Write Exception Code
            }
            finally
            {
                connection.Close();
            }
            return lDLAID;
        }

        public static bool UpdateLDLA(int lDLAID, int applicationID, int licenceID)
        {
            int rowEffected;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"update LocalDrivingLicenseApplications
                set  ApplicationID = @ApplicationID , LicenseClassID = @LicenseClassID
                where LocalDrivingLicenseApplicationID = @lDLAID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", applicationID);
            command.Parameters.AddWithValue("@LicenseClassID", licenceID);
            command.Parameters.AddWithValue("@lDLAID", lDLAID);

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

        public static bool checkLicense(string NationalNo,int LicenseID)
        {
            bool IsFound;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"select Found = 1 from LocalDrivingLicenseApplications_View WHere NationalNo = @NationalNo and
                            ClassName = (select ClassName from LicenseClasses where LicenseClassID = @LicenseID)
                            and Status = 'New'";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                IsFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static bool CancelLicense(int LDLAID)
        {
            int rowEffected;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"update Applications
                set  ApplicationStatus = 2
                Where Applications.ApplicationID =  (select Applications.ApplicationID from Applications inner join LocalDrivingLicenseApplications on 
            	Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID 
	            where LocalDrivingLicenseApplicationID = @lDLAID)";

            SqlCommand command = new SqlCommand(query, connection);
          
            command.Parameters.AddWithValue("@lDLAID", LDLAID);

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

        public static bool GetLDLAByID(int lDLAID, ref int licenceID, ref int applicationID, ref int applicantPersonID, ref DateTime applicationDate, ref int applicationTypeID,
              ref byte applicationStatus, ref DateTime lastStatusDate, ref int createdBuUserID)
        {
            bool IsFound;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"select LocalDrivingLicenseApplications.ApplicationID,LicenseClassID,ApplicantPersonID,ApplicationDate,ApplicationTypeID,ApplicationStatus,
	                 LastStatusDate,CreatedByUserID from LocalDrivingLicenseApplications inner join Applications 
	                 on LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID 
	                 WHere LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LDLAID";

            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@LDLAID", lDLAID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound=true;

                    licenceID = (int)reader["LicenseClassID"];
                    applicationID = (int)reader["ApplicationID"];
                    applicantPersonID = (int)reader["ApplicantPersonID"];
                    applicationDate = (DateTime)reader["ApplicationDate"];
                    applicationTypeID = (int)reader["ApplicationTypeID"];
                    applicationStatus = (byte)reader["ApplicationStatus"];
                    lastStatusDate = (DateTime)reader["LastStatusDate"];
                    createdBuUserID = (int)reader["CreatedByUserID"];
                    
                }
                else
                {
                    IsFound = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();  
            }
            return IsFound;
        }

        public static bool DeleteLDLA(int lDLAID)
        {
            int rowEffected;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"delete LocalDrivingLicenseApplications 
                Where LocalDrivingLicenseApplicationID =  @lDLAID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@lDLAID", lDLAID);

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

        public static int GetPassedTestCountByLDLAID(int lDLAID)
        {
            int PassedTestCount;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);
            string query = @"select PassedTestCount from
                   LocalDrivingLicenseApplications_View where LocalDrivingLicenseApplicationID = @lDLAID";

            SqlCommand command = new SqlCommand(query,connection);

            command.Parameters.AddWithValue("@lDLAID", lDLAID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PassedTestCount = (int)reader["PassedTestCount"];
                }
                else
                    PassedTestCount = 1000;

                reader.Close();
            }
            catch
            {
                return 1000;
            }
            finally
            {
                connection.Close();
            }
            return PassedTestCount;
        }
    }
}
