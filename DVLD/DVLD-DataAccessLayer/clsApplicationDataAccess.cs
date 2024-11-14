using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class clsApplicationDataAccess
    {
        public static int AddNewApplication(int applicantPersonID, DateTime applicationDate, int applicationTypeID,
               int applicationStatus, DateTime lastStatusDate, int createdBuUserID)
        {
            
            int applicationID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"Insert INTO Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID,
                            ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID)
                           Values (@applicantPersonID, @applicationDate, @applicationTypeID, @applicationStatus,
                            @lastStatusDate,(select ApplicationFees from ApplicationTypes where ApplicationTypeID =1),@createdBuUserID);
                             Select Scope_identity();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@applicantPersonID", applicantPersonID);
            command.Parameters.AddWithValue("@applicationDate", applicationDate);
            command.Parameters.AddWithValue("@applicationTypeID", applicationTypeID);
            command.Parameters.AddWithValue("@applicationStatus", applicationStatus);
            command.Parameters.AddWithValue("@lastStatusDate", lastStatusDate);
            //command.Parameters.AddWithValue("@paidFees", paidFees);
            command.Parameters.AddWithValue("@createdBuUserID", createdBuUserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertID))
                {
                    applicationID = insertID;
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
            return applicationID;
        }

        public static bool UpdateApplication(int applicationID,int applicantPersonID, DateTime applicationDate, int applicationTypeID,
               int applicationStatus, DateTime lastStatusDate, int createdBuUserID)
        {
            int rowEffected;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"Update Applications 
                set ApplicantPersonID = @ApplicantPersonID, ApplicationDate = @ApplicationDate, ApplicationTypeID = @ApplicationTypeID,
                ApplicationStatus = @ApplicationStatus,LastStatusDate = @LastStatusDate,PaidFees = (select ApplicationFees from ApplicationTypes where ApplicationTypeID =1),
                CreatedByUserID = @CreatedByUserID
                where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", applicationID);
            command.Parameters.AddWithValue("@ApplicantPersonID", applicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", applicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
            command.Parameters.AddWithValue("@CreatedByUserID", createdBuUserID);

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

        public static bool DeleteApplication(int ApplicationID)
        {
            int rowEffected;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"delete Applications 
                where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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
