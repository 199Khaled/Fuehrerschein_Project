using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenschenDatenForm
{
    public class clsLänderDatenZugriff
    {
        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = "Select * From Länder";
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
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { connection.Close(); }

            return dt;
        }

        public static bool FindByName(ref int id, string name)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select * From Länder Where LandsName = @name";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", name);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    isFound = true;
                    id = (int)reader["LandID"];
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                isFound = false;
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static bool FindCountryInfoByID(int id, ref string name)
        {
            bool isFound = false; 

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select * From Länder Where LandID= @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                     name = (string)reader["LandsName"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
                //throw ex;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

      
        public static int AddNewCountry(string name)
        {
            int LandID = -1;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"INSERT INTO Länder (LandsName) 
                             VALUES (LandsName)
                             SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LandsName", name);
            try
            {
                connection.Open();
                object reader = command.ExecuteScalar();
                if(reader != null && int.TryParse(reader.ToString(), out int Inserted))
                {
                    LandID = Inserted;
                }
                    
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return LandID;
        }
    }
}
