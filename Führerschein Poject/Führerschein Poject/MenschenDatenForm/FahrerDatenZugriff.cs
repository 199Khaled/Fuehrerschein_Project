using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenschenDatenForm
{
    public class clsFahrerDatenZugriff
    {
        public static bool GetDriverInfoByDriverID(int FahrerID,
    ref int PersonID, ref int ErstelltVonBenutzerID, ref DateTime ErstellungsDatum)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);

            string query = "SELECT * FROM Fahrer WHERE FahrerID = @FahrerID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FahrerID", FahrerID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    ErstelltVonBenutzerID= (int)reader["ErstelltVonBenutzerID"];
                    ErstellungsDatum = (DateTime)reader["ErstellungsDatum"];


                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetDriverInfoByPersonID(int PersonID, ref int FahrerID,
            ref int ErstelltVonBenutzerID, ref DateTime ErstellungsDatum)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);

            string query = "SELECT * FROM Fahrer WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    FahrerID = (int)reader["FahrerID"];
                    ErstelltVonBenutzerID = (int)reader["ErstelltVonBenutzerID"];
                    ErstellungsDatum = (DateTime)reader["ErstellungsDatum"];

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static DataTable GetAllDrivers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);

            string query = "SELECT * FROM Fahrer_View order by Vollname";

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
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static int AddNewDriver(int PersonID, int ErstelltVonBenutzerID)
        {
            int FahrerID = -1;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);

            string query = @"Insert Into Fahrer (PersonID,ErstelltVonBenutzerID,ErstellungsDatum)
                            Values (@PersonID,@ErstelltVonBenutzerID,@ErstellungsDatum);
                          
                            SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ErstelltVonBenutzerID", ErstelltVonBenutzerID);
            command.Parameters.AddWithValue("@ErstellungsDatum", DateTime.Now);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    FahrerID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return FahrerID;

        }

        public static bool UpdateDriver(int FahrerID, int PersonID, int ErstelltVonBenutzerID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            //we dont update the createddate for the driver.
            string query = @"Update  Fahrer 
                            set PersonID = @PersonID,
                                ErstelltVonBenutzerID = @ErstelltVonBenutzerID
                                where FahrerID = @FahrerID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FahrerID", FahrerID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ErstelltVonBenutzerID", ErstelltVonBenutzerID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

    }
}

