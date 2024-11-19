using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class clsLicenseClassesDataAccess
    {
        public static DataTable GatAllLicenseClassesNames()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);
            string query = "select ClassName from LicenseClasses";

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

        public static string GetLicenseClassName(int  licenseId)
        {
            string licenseClassName;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);
            string query = "select ClassName from LicenseClasses where LicenseClassID = @licenseId";

            SqlCommand command = new SqlCommand(query,connection);

            command.Parameters.AddWithValue("@licenseId", licenseId);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    licenseClassName = (string)reader["ClassName"];
                }
                else
                    licenseClassName = "False";

                reader.Close();
            }
            catch
            {
                licenseClassName = "False";
            }
            finally
            {
                connection.Close();
            }
            return licenseClassName;
        }
        
    }
}
