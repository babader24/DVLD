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
            from TestAppointments where LocalDrivingLicenseApplicationID = @DLApp and TestTypeID = @testType";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DLApp", DLApp);
            command.Parameters.AddWithValue("@testType", testType);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
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
    }
}
