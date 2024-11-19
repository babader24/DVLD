using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;
using System.ComponentModel;

namespace DVLD_DataAccessLayer
{
    public class clsPersonDataAccess
    {

        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"SELECT PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName,DateOfBirth,
                   CASE WHEN Gendor = 0 THEN 'Male' ELSE 'Female' END AS Gendor, Address,CountryName, Phone, Email 
                             FROM People
                            inner join Countries on People.NationalityCountryID = Countries.CountryID";

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

        public static int AddNewPerson( string NationalNo, string FirstName,
           string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gendor,
           string Address, string Phone, string Email,int NationalityCountryID, string ImagePath)
        {
            int personID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"Insert Into People (NationalNo, FirstName, SecondName, ThirdName, LastName,DateOfBirth,
                            Gendor, Address, Phone, Email,NationalityCountryID, ImagePath)
                            Values (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName,@DateOfBirth,
                            @Gendor, @Address, @Phone, @Email,@NationalityCountryID, @ImagePath);
                            Select Scope_identity();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(),out int insertID))
                {
                    personID = insertID;
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

            return personID;
        }


        public static bool UpdatePersonInfo(int personID, string NationalNo,  string FirstName,
            string SecondName,  string ThirdName,  string LastName,  DateTime DateOfBirth,  byte Gendor,
            string Address,  string Phone,  string Email,int NationalityCountryID,  string ImagePath)
        {
            int rowsEffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"Update People 
                           set NationalNo = @NationalNo, FirstName = @FirstName,SecondName = @SecondName,
                               ThirdName = @ThirdName,LastName = @LastName, DateOfBirth = @DateOfBirth,
                               Gendor = @Gendor, Address = @Address, Phone = @Phone, Email = @Email,
                               NationalityCountryID = @NationalityCountryID, ImagePath = @ImagePath
                               where PersonID = @PersonID;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@personID", personID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);

            try
            {
                connection.Open();

                rowsEffected = command.ExecuteNonQuery();
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
            return (rowsEffected > 0);
        }

        public static bool DeletePerson(int PersonID)
        {
            int rowsEffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"DELETE  From People
                            Where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                rowsEffected = command.ExecuteNonQuery();
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
            return (rowsEffected > 0);
        }

        public static bool GetPersonInfoByID(int PersonID, ref string NationalNo, ref string FirstName,
         ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth,
         ref byte Gendor, ref string Address, ref string Phone, ref string Email, ref string ImagePath, ref string Country) 
        {
            bool IsFound;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"SELECT PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName,DateOfBirth, Gendor, Address,CountryName, Phone, Email,ImagePath 
                             FROM People
                            inner join Countries on People.NationalityCountryID = Countries.CountryID
                            where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    IsFound = true;

                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];               
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    Country = (string)reader["CountryName"];
                    Gendor = (byte)reader["Gendor"];

                    //if ( == 0)
                    //    Gendor = "Male";
                    //else
                    //    Gendor = "Female";


                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";
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

        public static bool GetPersonInfoByNationalNo(ref int PersonID, string NationalNo, ref string FirstName,
        ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth,
        ref byte Gendor, ref string Address, ref string Phone, ref string Email, ref string ImagePath, ref string Country)
        {
            bool IsFound;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = @"SELECT PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName,DateOfBirth, Gendor, Address,CountryName, Phone, Email,ImagePath 
                             FROM People
                            inner join Countries on People.NationalityCountryID = Countries.CountryID
                            where NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    Country = (string)reader["CountryName"];
                    Gendor = (byte)reader["Gendor"];

                    //if ( == 0)
                    //    Gendor = "Male";
                    //else
                    //    Gendor = "Female";


                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";
                }
                else
                {
                    IsFound = false;
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            return IsFound;
        }

        public static string GetFullNameByID(int ID)
        {
            string fullname;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);
            string query = @"Select FirstName +' ' +SecondName +' '+ ThirdName +' '+ LastName 
                  as FullName from People where PersonID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    fullname = (string)reader["FullName"];
                }
                else
                    fullname = "False";

                reader.Close();
            }
            catch
            {
                fullname = "False";
            }
            finally
            {
                connection.Close();
            }
            return fullname;

        }

        public static DataTable GetAllCountries( )
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = "SELECT CountryName FROM Countries";

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

        public static bool GetCountryInfoByName(string countryName, ref int CountryID)
        {
            bool isFound;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnetionString);

            string query = "SELECT * FROM Countries Where CountryName = @CountryName ;";

            SqlCommand command = new SqlCommand(query,connection);

            command.Parameters.AddWithValue("@CountryName", countryName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    CountryID = (int)reader["CountryID"];
                }
                else
                    isFound = false;
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

        //public static int GetPersonInfo() 
    }
}
