using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MenschenDatenForm
{
    public class clsTestTypenZugriff
    {
        public static DataTable GetAllTestType()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select * From TestTypen";
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
                throw ex;
            }
            finally
            {
                connection.Close(); ;
            }
            return dt;
        }

        public static bool FindTestType(int ID, ref string Titel,
                                   ref string TestDescription, ref decimal TestGebühren)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select * From TestTypen
                                           Where TestTypeID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    isFound = true;

                    Titel = (string)reader["TestTypeTitel"];
                    TestDescription = (string)reader["TestTypeBeschreiben"];
                    TestGebühren = (decimal)reader["TestTypeGebühren"];
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

        public static bool UpdateTestType(int ID, string Titel,
                        string TestDescription, decimal TestGebühren)
        {
            int rowAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Update TestTypen
                                Set   TestTypeTitel       = @Titel,
                                      TestTypeBeschreiben = @TestBeschreiben,
                                      TestTypeGebühren    = @TestGebühren
                                Where TestTypeID          = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Titel", Titel);
            command.Parameters.AddWithValue("@TestBeschreiben", TestDescription);
            command.Parameters.AddWithValue("@TestGebühren", TestGebühren);
            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return (rowAffected > 0);
        }

        public static int AddNewTestType(string titel, string testBeschreiben, decimal Gebühren)
        {
            int TestTypeID = -1;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"INSERT INTO TestTypen (Titel,TestBeschreiben,TestGebühren)
                              VALUES(@Titel,@TestBeschreiben,@TestGebühren);
                            SELECT SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Titel",titel);
            command.Parameters.AddWithValue("@TestBeschreiben",testBeschreiben);
            command.Parameters.AddWithValue("@TestGebühren",Gebühren);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(), out int IsertedID))
                {
                    TestTypeID = IsertedID;
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
            return TestTypeID;
        }

    }
}
