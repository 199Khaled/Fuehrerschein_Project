using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenschenDatenForm
{
    public class clsAnträgeKategorieZugriff
    {
        public static DataTable GetAllApplication()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select * From AntragsKategorien ";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);

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

        public static bool UpdateApplication(int ID, string Titel,
                                                   decimal Gebühren)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Update AntragsKategorien 
                              Set AntragsKategorieTitel = @AntragsKategorie,
                                  AntragsGebühren   = @AntragsGebühren
                            Where AntragsKategorieID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID",ID);
            command.Parameters.AddWithValue("@AntragsKategorie", Titel);
            command.Parameters.AddWithValue("@AntragsGebühren", Gebühren);

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

        public static int AddNewApplication(string Titel, decimal Gebühren)
        {
            int AntragsID = -1;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"INSERT INTO AntragsKategorien (AntragsKategorieTitel,AntragsGebühren)
                                         Values(@Titel, @Gebühren);
                            SElECT SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Titel", Titel);
            command.Parameters.AddWithValue("@Gebühren", Gebühren);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(),out int InsertedID))
                {
                    AntragsID = InsertedID;
                }
            }
            catch (Exception ex)
            {
               
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return AntragsID;
        }
        public static bool FindApplicationByID(int id, ref string titel, ref decimal Gebühren)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select * From AntragsKategorien 
                                Where AntragsKategorieID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    titel = (string)reader["AntragsKategorieTitel"];
                    Gebühren = (decimal)reader["AntragsGebühren"];
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
    }
}
