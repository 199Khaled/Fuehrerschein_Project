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
    public class clsLokalerFührerscheinAntragZugriff
    {
        public static bool GetLocalDrivingLicenseApplicationInfoByID(int LokalerFührerscheinAntragsID,
                  ref int AntragsID, ref int LicenseKlasseID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"SELECT * FROM LokalerFührerscheinAnträge
                                Where LokalerFührerscheinAntragsID =@LokalerFührerscheinAntragsID ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LokalerFührerscheinAntragsID", LokalerFührerscheinAntragsID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    AntragsID = (int)reader["AntragsID"];
                    LicenseKlasseID = (int)reader["LicenseKlasseID"];
                }
            }
            catch (Exception ex)
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

        public static bool GetLocalDrivingLicenseApplicationInfoByApplicationID(ref int LokalerFührerscheinAntragsID,
               int AntragsID, ref int LicenseKlasseID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"SELECT * FROM LokalerFührerscheinAnträge
                                Where AntragsID =@AntragsID ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AntragsID", AntragsID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    LokalerFührerscheinAntragsID = (int)reader["LokalerFührerscheinAntragsID"];
                    LicenseKlasseID = (int)reader["LicenseKlasseID"];
                }
                reader.Close();
            }
            catch (Exception ex)
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

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select * From LokalerFührerscheinAnträge_View
                                Order by AntragsDatum";

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
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static int AddNewLocalDrivingLicenseApplication(int AntragsID, int LicenseKlasseID)
        {
            int LocalDrivingLicenseID = -1;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Insert Into LokalerFührerscheinAnträge (AntragsID,LicenseKlasseID)
                                      Values(@AntragsID, @LicenseKlasseID);
                            Select Scope_Identity()";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AntragsID", AntragsID);
            command.Parameters.AddWithValue("@LicenseKlasseID", LicenseKlasseID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    LocalDrivingLicenseID = InsertedID;
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
            return LocalDrivingLicenseID;
        }

        public static bool UpdateLocalDrivingLicenseApplication(int LokalerFührerscheinAntragsID, int AntragsID, int LicenseKlasseID)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Update LokalerFührerscheinAnträge
                             Set   AntragsID      = @AntragsID,
                                   LicenseKlasseID = @LicenseKlasseID
                             Where LokalerFührerscheinAntragsID = @LokalerFührerscheinAntragsID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LokalerFührerscheinAntragsID", LokalerFührerscheinAntragsID);
            command.Parameters.AddWithValue("@AntragsID", AntragsID);
            command.Parameters.AddWithValue("@LicenseKlasseID", LicenseKlasseID);

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
            return rowAffected >  0;
        }

        public static bool DeleteLocalDrivingLicenseApplication(int LokalerFührerscheinAntragsID)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Delete From LokalerFührerscheinAnträge
                             Where LokalerFührerscheinAntragsID = @LokalerFührerscheinAntragsID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LokalerFührerscheinAntragsID", LokalerFührerscheinAntragsID);

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
            return rowAffected >  0;
        }

        public static bool DoesPassTestType(int LokalerFührerscheinAtnragsID, int TestTypeID)
        {
            bool Result = false;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select Top 1 TestErgebnis 
             From LokalerFührerscheinAnträge INNER JOIN
             TestTermine ON LokalerFührerscheinAnträge.LokalerFührerscheinAntragsID = TestTermine.LokalerFührerscheinAntragsID  
             INNER JOIN Prüfungen ON TestTermine.TestTerminID = Prüfungen.TestTerminID
             WHERE
              LokalerFührerscheinAnträge.LokalerFührerscheinAntragsID = @LokalerFührerscheinAntragsID
              And 
              TestTermine.TestTypeID = @TestTypeID
              ORDER BY TestTermine.TestTerminID Desc";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LokalerFührerscheinAntragsID", LokalerFührerscheinAtnragsID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && bool.TryParse(result.ToString(), out bool returnedResult))
                    Result = returnedResult;
            }
            catch (Exception ex)
            {
                Result = false;
            }
            finally
            {
                connection.Close();
            }
            return Result;
        }

        public static bool DoesAttendTestType(int LokalerFührerscheinAntragsID, int TestTypeID)
        {
            bool Result = false;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"SELECT Top 1 Find=1
              FROM LokalerFührerscheinAnträge INNER JOIN 
              TestTermine ON LokalerFührerscheinAnträge.LokalerFührerscheinAntragsID = TestTermine.LokalerFührerscheinAntragsID
              INNER JOIN Prüfungen ON TestTermine.TestTerminID = Prüfungen.TestTerminID
              WHERE
              LokalerFührerscheinAnträge.LokalerFührerscheinAntragsID = @LokalerFührerscheinAntragsID
              AND
              TestTermine.TestTypeID                                  = @TestTypeID
              ORDER BY TestTermine.TestTerminID DESC";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LokalerFührerscheinAntragsID", LokalerFührerscheinAntragsID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                    Result = true;
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return Result;
        }

        public static byte TotalTrialsPerTest(int LokalerFührerscheinAntragsID, int TestTypeID)
        {
            byte InsgesamteVersucheProTest = 0;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"SELECT InsgesamteVersuchePerTest = Count(PrüfungID)
              FROM LokalerFührerscheinAnträge INNER JOIN 
              TestTermine ON LokalerFührerscheinAnträge.LokalerFührerscheinAntragsID = TestTermine.LokalerFührerscheinAntragsID
              INNER JOIN Prüfungen ON TestTermine.TestTerminID = Prüfungen.TestTerminID
              WHERE
              LokalerFührerscheinAnträge.LokalerFührerscheinAntragsID = @LokalerFührerscheinAntragsID
              AND
              TestTermine.TestTypeID                                  = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LokalerFührerscheinAntragsID", LokalerFührerscheinAntragsID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && byte.TryParse(result.ToString(), out byte Versuche))
                    InsgesamteVersucheProTest = Versuche;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                connection.Close();
            }
            return InsgesamteVersucheProTest;
        }

        public static bool IsThereAnActiveScheduledTest(int LokalerFührerscheinAntragsID, int TestTypeID)
        {
            // Methode bedeutet gibt es einen aktiven geplanten Test
            bool Result = false;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"SELECT Top 1 Find=1
              FROM LokalerFührerscheinAnträge INNER JOIN 
              TestTermine ON LokalerFührerscheinAnträge.LokalerFührerscheinAntragsID = TestTermine.LokalerFührerscheinAntragsID
              WHERE
              LokalerFührerscheinAnträge.LokalerFührerscheinAntragsID = @LokalerFührerscheinAntragsID
              AND
              TestTermine.TestTypeID              = @TestTypeID AND istGesperrt = 0
              ORDER BY TestTermine.TestTerminID DESC";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LokalerFührerscheinAntragsID", LokalerFührerscheinAntragsID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                    Result = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return Result;
        }
    }
}