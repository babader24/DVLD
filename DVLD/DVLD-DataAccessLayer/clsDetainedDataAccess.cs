using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DVLD_DataAccessLayer
{
    public class clsDetainedDataAccess
    {
        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"select DetainID, DetainedLicenses.LicenseID, DetainDate, IsReleased, FineFees, ReleaseDate,
                NationalNo, FullName, ReleaseApplicationID from DetainedLicenses
                inner  join Licenses on Licenses.LicenseID = DetainedLicenses.LicenseID
                inner join Drivers_View on Drivers_View.DriverID = Licenses.DriverID;";

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

        public static int AddNewDetainedLicense(int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID,
            bool IsReleased, DateTime? ReleaseDate, int? ReleasedByUserID, int? ReleaseApplicationID)
        {
            int DetainID = -1;

            SqlConnection connerction = new SqlConnection(clsDataAccessSetting.ConnetionString);
            string query = @"insert into DetainedLicenses (LicenseID, DetainDate,FineFees,CreatedByUserID, IsReleased,
                ReleaseDate, ReleasedByUserID, ReleaseApplicationID )
                values (@LicenseID, @DetainDate,@FineFees,@CreatedByUserID, @IsReleased,  @ReleaseDate, @ReleasedByUserID,
                @ReleaseApplicationID);
                select SCOPE_IDENTITY();";
            SqlCommand commaned = new SqlCommand(query, connerction);

            commaned.Parameters.AddWithValue("@LicenseID", LicenseID);
            commaned.Parameters.AddWithValue("@DetainDate", DetainDate);
            commaned.Parameters.AddWithValue("@FineFees", FineFees);
            commaned.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            commaned.Parameters.AddWithValue("@IsReleased", IsReleased);
            commaned.Parameters.AddWithValue("@ReleaseDate", ReleaseDate == null ? (object)DBNull.Value : ReleaseDate);
            commaned.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID == null ? (object)DBNull.Value : ReleasedByUserID);
            commaned.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID == null ? (object)DBNull.Value : ReleaseApplicationID);

            try
            {
                connerction.Open();

                object result = commaned.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    DetainID = insertedID;
            }
            catch
            {
                //
            }
            finally
            {
                connerction.Close();
            }
            return DetainID;
        }

        public static bool UpdateDetainedLicense(int LicenseID,bool IsReleased, DateTime? ReleaseDate, 
            int? ReleasedByUserID, int? ReleaseApplicationID)
        {
            int rowEffected;

            SqlConnection connerction = new SqlConnection(clsDataAccessSetting.ConnetionString);
            string query = @"update DetainedLicenses 
                             set IsReleased = @IsReleased, ReleaseDate = @ReleaseDate,
                             ReleasedByUserID = @ReleasedByUserID,ReleaseApplicationID = @ReleaseApplicationID
                             where LicenseID = @LicenseID  ";
            SqlCommand commaned = new SqlCommand(query, connerction);

            commaned.Parameters.AddWithValue("@LicenseID", LicenseID);
            commaned.Parameters.AddWithValue("@IsReleased", IsReleased);
            commaned.Parameters.AddWithValue("@ReleaseDate", ReleaseDate == null ? (object)DBNull.Value : ReleaseDate);
            commaned.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID == null ? (object)DBNull.Value : ReleasedByUserID);
            commaned.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID == null ? (object)DBNull.Value : ReleaseApplicationID);

            try
            {
                connerction.Open();

                rowEffected = commaned.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                connerction.Close();
            }
            return (rowEffected > 0);
        }

        public static bool FindDetainedLicenseByLicenseID(ref int DetainID, int LicenseID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID,
           ref bool IsReleased, ref DateTime? ReleaseDate, ref int? ReleasedByUserID, ref int? ReleaseApplicationID)
        {
            bool IsFoend;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"Select * from DetainedLicenses WHERE LicenseID =@LicenseID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFoend = true;

                    DetainID = (int)reader["DetainID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (decimal)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];
                    ReleaseDate = (DateTime?)(reader["ReleaseDate"] == DBNull.Value ? null : reader["ReleaseDate"]);
                    ReleasedByUserID = (int?)(reader["ReleasedByUserID"] == DBNull.Value ? null : reader["ReleasedByUserID"]);
                    ReleaseApplicationID = (int?)(reader["ReleaseApplicationID"] == DBNull.Value ? null : reader["ReleaseApplicationID"]);
               
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

        public static bool IsLicenseDetained(int LicenseID)
        {
            bool isFound;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);
            string query = @"select Found=1 from DetainedLicenses where IsReleased = 0
                            and LicenseID = @LicenseID";

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

        public static bool ReleseDetainedLicenseByLicenseID(int LiceseID)
        {
            int rowsEffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"update DetainedLicenses 
                            set IsReleased = 1
                            where LicenseID = @LiceseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LiceseID", LiceseID);

            try
            {
                connection.Open();

                rowsEffected = command.ExecuteNonQuery();
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
            return (rowsEffected > 0);
        }
    }
}
