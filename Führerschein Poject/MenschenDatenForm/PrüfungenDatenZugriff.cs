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
    public class clsPrüfungenDatenZugriff
    {
        public static bool GetTestInfosByID(int PrüfungID, ref int TestTerminID, ref bool TestErgebnis,
                             ref string Notizen, ref int ErstelltVonBenutzerID)
        {
            bool isfound = false;

            SqlConnection connectin = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);

            string query = @"Select * From Prüfungen   Where PrüfungID = @PrüfungID";
            SqlCommand command = new SqlCommand(query, connectin);
            command.Parameters.AddWithValue("@PrüfungID", PrüfungID);

            try
            {
                connectin.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    isfound = true;

                    TestTerminID = (int)reader["TestTerminID"];
                    TestErgebnis = (bool)reader["TestErgebnis"];
                    Notizen = (string)reader["Notizen"];
                    ErstelltVonBenutzerID = (int)reader["ErstelltVonBenutzerID"];
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                isfound = false;
            }
            finally
            {
                connectin.Close();
            }
            return isfound;
        }

        public static bool GetLastTestByPersonAndTestTypeAndLicenseClsse(int PersonID, int LicenseKlasseID, int TestTypeID,
          ref int PrüfungsID , ref int TestTerminID, ref bool TestErgebnis, ref string Notizen, ref int ErstelltVonBenutzerID)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);

            string query = @"SELECT TOP 1 Prüfungen.PrüfungID, Prüfungen.TestTerminID, Prüfungen.TestErgebnis,
                                 Prüfungen.Notizen, Prüfungen.ErstelltVonBenutzerID, Anträge.AntragsPersonID
                             FROM     LokalerFührerscheinAnträge INNER JOIN 
                                       Prüfungen INNER JOIN
                                       TestTermine ON Prüfungen.TestTerminID = TestTermine.TestTerminID ON
                                        LokalerFührerscheinAnträge.LokalerFührerscheinAntragsID = TestTermine.LokalerFührerscheinAntragsID
                                       INNER JOIN Anträge ON LokalerFührerscheinAnträge.AntragsID = Anträge.AntragsID
                            WHERE  
                                    Anträge.AntragsPersonID = @PersonID
                            AND     LokalerFührerscheinAnträge.LicenseKlasseID = @LicenseKlasseID
                            AND     TestTermine.TestTypeID = @TestTypeID
                            ORDER BY Prüfungen.TestTerminID DESC";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseKlasseID",LicenseKlasseID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isfound = true;

                    PrüfungsID = (int)reader["PrüfungID"];
                    TestTerminID = (int)reader["TestTerminID"];
                    TestErgebnis = (bool)reader["TestErgebnis"];

                    if (reader["Notizen"] == DBNull.Value)
                        Notizen = "";
                    else
                       Notizen = (string)reader["Notizen"];

                    ErstelltVonBenutzerID = (int)reader["ErstelltVonBenutzerID"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                isfound = false;
            }
            finally
            {
                connection.Close();
            }
            return isfound;
        }

        public static DataTable GetAllTests()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select * From Prüfungen Order by PrüfungID";
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
                //isfound = false;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static int AddNewTest(int TestTerminID, bool TestErgebnis,
                             string Notizen, int ErstelltVonBenutzerID)
        {
            int PrüfungID = -1;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            //wir aktualisieren isgeperrt von 0 zu 1 wenn die Person an dem test teilgenommen hat 
            // egal ,ob er die prüfung bestanden hat oder nicht  der Termin nach der Prüfung wird gesperrt.
            string query = @"INSERT INTO Prüfungen (TestTerminID, TestErgebnis, Notizen, ErstelltVonBenutzerID)
                                   VALUES  (@TestTerminID,@TestErgebnis,@Notizen,@ErstelltVonBenutzerID);
                         
                                    Update TestTermine 
                                         Set istGesperrt = 1 
                                                Where TestTerminID = @TestTerminID;

                           SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTerminID",TestTerminID);
            command.Parameters.AddWithValue("@TestErgebnis",TestErgebnis);

            if (Notizen == null)
                command.Parameters.AddWithValue("@Notizen", DBNull.Value);
            else
               command.Parameters.AddWithValue("@Notizen",Notizen);

            command.Parameters.AddWithValue("@ErstelltVonBenutzerID",ErstelltVonBenutzerID);
           
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                    PrüfungID = InsertedID;
              
            }
            catch (Exception ex)
            {
                //isfound = false;
            }
            finally
            {
                connection.Close();
            }
            return PrüfungID;
        }


        public static bool UpdateTest(int PrüfungID, int TestTerminID, bool TestErgebnis,
                             string Notizen, int ErstelltVonBenutzerID)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"UPDATE Prüfungen
                                    SET    TestTerminID          = @TestTerminID,
                                           TestErgebnis          = @TestErgebnis,
                                           Notizen               = @Notizen,
                                           ErstelltVonBenutzerID =  @ErstelltVonBenutzerID
                                   WHERE   PrüfungID             = @PrüfungID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PrüfungID", PrüfungID);
            command.Parameters.AddWithValue("@TestTerminID", TestTerminID);
            command.Parameters.AddWithValue("@TestErgebnis", TestErgebnis);

            if (Notizen == null)
                command.Parameters.AddWithValue("@Notizen", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Notizen", Notizen);

            command.Parameters.AddWithValue("@ErstelltVonBenutzerID", ErstelltVonBenutzerID);

            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //isfound = false;
            }
            finally
            {
                connection.Close();
            }
            return rowAffected > 0;
        }

        public static byte GetPassedTestCount(int LokalerFührerscheinAntragsID)
        {
            byte BestandenePrüfungenZahl = 0;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"SELECT BestandenePrüfungenZahl  = Count(TestTypeID)
                               From Prüfungen INNER JOIN TestTermine  ON
                               Prüfungen.TestTerminID = TestTermine.TestTerminID 
                          Where  LokalerFührerscheinAntragsID = @LokalerFührerscheinAntragsID
                          And    TestErgebnis = 1";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LokalerFührerscheinAntragsID", LokalerFührerscheinAntragsID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && byte.TryParse(result.ToString(), out byte bestandenePrüfungen))
                    BestandenePrüfungenZahl = bestandenePrüfungen;
            }
            catch (Exception ex)
            {
                //isfound = false;
            }
            finally
            {
                connection.Close();
            }
            return BestandenePrüfungenZahl;
        }
    }
}
