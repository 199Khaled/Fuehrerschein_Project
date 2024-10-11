using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MenschenDatenForm
{
    public class clsBenutzerDatenZugriff
    {

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"SELECT Benutzer.BenutzerID, Benutzer.PersonID, 
                              VollName = Menschen.Vorname + ' ' + Menschen.Nachname,
                              Benutzer.BenutzerName, Benutzer.IsAktive 
                              FROM Benutzer INNER JOIN Menschen ON
                             Benutzer.PersonID = Menschen.PersonID";
            SqlCommand commnad = new SqlCommand(query, connection);

            try { connection.Open();
                SqlDataReader reader = commnad.ExecuteReader();
                if(reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
               }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static bool FindByUserID(int BenutzerID, ref string BenutzerName, ref string Password, 
                                       ref bool IsAktive,ref int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select * From Benutzer  Where BenutzerID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", BenutzerID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(); 
                if(reader.Read())
                {
                    isFound = true;
                    BenutzerName = (string)reader["BenutzerName"];
                    Password = (string)reader["Password"];
                    IsAktive = (bool)reader["IsAktive"];
                    PersonID = (int)reader["PersonID"];
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                isFound = false;
                throw;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static bool FindUserByPersonID(ref int BenutzerID, ref string BenutzerName, ref string Password,
                                       ref bool IsAktive,int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select * From Benutzer 
                                            WHERE PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    BenutzerID = (int)reader["BenutzerID"];
                    BenutzerName = (string)reader["BenutzerName"];
                    Password = (string)reader["Password"];
                    IsAktive = (bool)reader["IsAktive"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
               // throw;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static bool FindByUserNameAndPassword(ref int BenutzerID,string BenutzerName,string Password,
                                ref bool IsAktive, ref int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select * From Benutzer  WHERE BenutzerName = @BenutzerName And
                                                          Password     = @Password";
                                                          
                          
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BenutzerName", BenutzerName);
            command.Parameters.AddWithValue("@Password", Password); 

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    BenutzerID = (int)reader["BenutzerID"];
                    PersonID = (int)reader["PersonID"];
                    Password = (string)reader["Password"];
                    IsAktive = (bool)reader["IsAktive"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
                //throw;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static int AddNewUser(string BenutzerName, string Password, bool IsAktive, int PersoniD)
        {
            int BenutzerID = -1;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"INSERT INTO Benutzer (BenutzerName, Password, IsAktive, PersonID)
                             VALUES(@BenutzerName, @Password, @IsAktive, @PersonID);
                             SELECT SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BenutzerName", BenutzerName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsAktive", IsAktive);
            command.Parameters.AddWithValue("@PersonID", PersoniD);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(),out int InsertedID))
                {
                    BenutzerID = InsertedID;
                }
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return BenutzerID;               
        }

        public static bool UpdateUser(int BenutzerID,string BenutzerName,string Password, bool IsAktive, int PersonID )
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Update Benutzer
                                     Set   BenutzerName = @BenutzerName,
                                           Password     = @Password,
                                           IsAktive     = @IsAktive,
                                           PersonID     = @PersonID
                                    Where  BenutzerID   = @BenutzerID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BenutzerID", BenutzerID);
            command.Parameters.AddWithValue("@BenutzerName", BenutzerName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsAktive", IsAktive);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return (rowAffected > 0);
        }

        public static bool DeleteBenutzer(int BenutzerID)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Delete From Benutzer Where BenutzerID = @BenutzerID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BenutzerID", BenutzerID);
            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                //throw
            }
            finally
            {
                connection.Close();
            }
            return (rowAffected > 0);
        }
        public static bool IsUserExistByBenutzerName(string BenutzerName)
        {
            bool isFound = true;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select Find=1 From Benutzer Where BenutzerName = @BenutzerName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BenutzerName", BenutzerName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;
            }
            catch(Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static bool IsUserExistByBenutzerID(int BenutzerID)
        {
            bool isFound = true;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select Find=1 From Benutzer Where BenutzerID = @BenutzerID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BenutzerID", BenutzerID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;
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
        public static bool IsUserExistForPersonID(int PersonID)
        {
            bool isFound = true;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select Find=1 From Benutzer Where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;
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
