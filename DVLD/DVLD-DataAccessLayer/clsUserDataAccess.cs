using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class clsUserDataAccess
    {
        public static DataTable GetAllUsersFromDatabase()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"select UserID, Users.PersonID, FullName = FirstName +' '+ SecondName +' '+ ThirdName +' '+
                            LastName , UserName, IsActive  from People inner join Users on 
                            Users.PersonID = People.PersonID";

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
               //
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static bool checkLogin(string UserName, string Password)
        {
            bool IsFound;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = "select Found = 1 from Users WHERE UserName = @User AND Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@User", UserName);
            command.Parameters.AddWithValue("@Password", Password);

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

        public static bool IsAcvive(string UserName)
        {
            bool IsFound;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = "select Found = 1 from Users WHERE UserName = @User AND IsActive = 1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@User", UserName);

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

        public static bool IsExsist(int PersonID)
        {
            bool isFound;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);
            string query = "SELECT Found = 1 from Users WHere PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
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

        public static int AddNewUser( int PersonID,  string UserName, string Password, bool isActive)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"Insert INTO Users (PersonID, UserName, Password, IsActive)
                           Values (@PersonID, @UserName, @Password, @IsActive);
                             Select Scope_identity();";

            SqlCommand command = new SqlCommand(query,connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", isActive);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertID))
                {
                    UserID = insertID;
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
            return UserID;
        }

        public static bool UpdateUser(int UserID, int PersonID, string UserName, string Password, bool isActive)
        {
            int rowEffected;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);
            string query = @"Update Users
                             Set UserName = @UserName, Password = @Password,  IsActive = @IsActive
                             WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query,connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", isActive);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                rowEffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return (rowEffected > 0);
        }

        public static bool DeleteUser(int UserID)
        {
            int roweffected;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"DELETE FROM USERS 
                             WHERE UserID = @UserID;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                roweffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                return false; 
            }
            finally
            {
                connection.Close();
            }
            return (roweffected > 0);
        }

        public static bool FindUser(int UserID, ref int PersonID, ref string UserName,ref string Password,ref bool isActive)
        {
            bool IsFoend;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"Select PersonID, UserName, Password, IsActive From Users
                             Where UserID = @UserID";

            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    IsFoend = true;

                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    isActive = (bool)reader["IsActive"];
                }
                else
                    IsFoend=false;

                reader.Close();
            }
            catch (Exception ex)
            {
                IsFoend=false;
            }
            finally
            {
                connection.Close(); 
            }
            return IsFoend;
        }



    }
}
