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
    public class clsTestTermineDatenZugriff
    {
        public static bool GetTestAppointmentInfosByID(int TestTerminID, ref int TestTypeID, ref int LokalerFührerscheinAntragsID,
                  ref DateTime TerminDatum, ref decimal BezahlteGebühren, ref int ErstelltVonBenutzerID,ref int WiederholungsTest_AntragsID, ref bool istGesperrt)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select * From TestTermine   Where TestTerminID = @TestTerminID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTerminID", TestTerminID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    IsFound = true;
                    TestTypeID = (int)reader["TestTypeID"];
                    LokalerFührerscheinAntragsID = (int)reader["LokalerFührerscheinAntragsID"];
                    TerminDatum = (DateTime)reader["TerminDatum"];
                    BezahlteGebühren = (decimal)reader["BezahlteGebühren"];
                    ErstelltVonBenutzerID = (int)reader["ErstelltVonBenutzerID"];

                    if (reader["WiederholungsTest_AntragsID"] == DBNull.Value)
                        WiederholungsTest_AntragsID = -1;
                    else
                        WiederholungsTest_AntragsID = (int)reader["WiederholungsTest_AntragsID"];

                    istGesperrt = (bool)reader["istGesperrt"];
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                IsFound =false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static DataTable GetAllTestAppointments()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select * From TestTermine
                             Order By TestTermine.TestDatum Desc";

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

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static DataTable GetApplicationTestAppointmentPerTestType(int LokalerFührerscheinAntragsID, int TestTypeID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select TestTerminID,TerminDatum,BezahlteGebühren, IstGesperrt 
                              From TestTermine
                             Where  TestTypeID                    = @TestTypeID 
                             And    LokalerFührerscheinAntragsID = @LokalerFührerscheinAntragsID
                             Order By  TestTerminID Desc";



            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LokalerFührerscheinAntragsID", LokalerFührerscheinAntragsID);

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
                
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static bool GetLastTestAppointment( ref int TestTerminID, int TestTypeID, int LokalerFührerscheinAntragsID,
      ref DateTime TerminDatum, ref decimal BezahlteGebühren, ref int ErstelltVonBenutzerID,ref int WiederholungsTest_AntragsID, ref bool istGesperrt)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select top 1 * From TestTermine
                             Where  TestTypeID                    = @TestTypeID 
                             And    LokalerFührerscheinAntragsID = @LokalerFührerscheinAntragsID
                             Order By  TestTerminID Desc";
                             


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID",TestTypeID) ;
            command.Parameters.AddWithValue("@LokalerFührerscheinAntragsID", LokalerFührerscheinAntragsID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    TestTerminID = (int)reader["TestTerminID"];
                    TestTypeID = (int)reader["TestTypeID"];
                    TerminDatum = (DateTime)reader["TerminDatum"];
                    BezahlteGebühren = (decimal)reader["BezahlteGebühren"];
                    ErstelltVonBenutzerID = (int)reader["ErstelltVonBenutzerID"];

                    if (reader["WiederholungsTest_AntragsID"] == DBNull.Value)
                        WiederholungsTest_AntragsID = -1;
                    else
                        WiederholungsTest_AntragsID = (int)reader["WiederholungsTest_AntragsID"];

                    istGesperrt = (bool)reader["istGesperrt"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound =false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static int AddNewTestAppointment(int TestTypeID, int LokalerFührerscheinAntragsID,
        DateTime TerminDatum,  decimal BezahlteGebühren, int ErstelltVonBenutzerID,int WiederholungsTest_AntragsID, bool istGesperrt)
        {
            int TestTerminID = -1;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"INSERT INTO TestTermine     (TestTypeID, LokalerFührerscheinAntragsID,TerminDatum,
                                  BezahlteGebühren, ErstelltVonBenutzerID, WiederholungsTest_AntragsID, istGesperrt)
                           VALUES
                                  (@TestTypeID, @LokalerFührerscheinAntragsID, @TerminDatum, @BezahlteGebühren,
                                  @ErstelltVonBenutzerID, @WiederholungsTest_AntragsID,@istGesperrt);
                         SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LokalerFührerscheinAntragsID", LokalerFührerscheinAntragsID);
            command.Parameters.AddWithValue("@TerminDatum", TerminDatum);
            command.Parameters.AddWithValue("@BezahlteGebühren", BezahlteGebühren);
            command.Parameters.AddWithValue("@ErstelltVonBenutzerID", ErstelltVonBenutzerID);

            if (WiederholungsTest_AntragsID == -1)
                command.Parameters.AddWithValue("@WiederholungsTest_AntragsID", DBNull.Value);
            else
                command.Parameters.AddWithValue("@WiederholungsTest_AntragsID", WiederholungsTest_AntragsID);

            command.Parameters.AddWithValue("@istGesperrt", istGesperrt);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                    TestTerminID = InsertedID;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return TestTerminID;
        }

        public static bool UpdateTestAppointment(int TestTerminID, int TestTypeID, int LokalerFührerscheinAntragsID,
        DateTime TerminDatum, decimal BezahlteGebühren, int ErstelltVonBenutzerID,int WiederholungsTest_AntragsID, bool istGesperrt)
        {
            int rowAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"UPDATE TestTermine
                                        SET   TestTypeID                    = @TestTypeID,
                                              LokalerFührerscheinAntragsID  = @LokalerFührerscheinAntragsID,  
                                               TerminDatum                  = @TerminDatum,
                                               BezahlteGebühren             = @BezahlteGebühren,
                                               ErstelltVonBenutzerID        = @ErstelltVonBenutzerID,
                                               WiederholungsTest_AntragsID  = @WiederholungsTest_AntragsID
                                       Where   TestTerminID = @TestTerminID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTerminID", TestTerminID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LokalerFührerscheinAntragsID", LokalerFührerscheinAntragsID);
            command.Parameters.AddWithValue("@TerminDatum", TerminDatum);
            command.Parameters.AddWithValue("@BezahlteGebühren", BezahlteGebühren);
            command.Parameters.AddWithValue("@ErstelltVonBenutzerID", ErstelltVonBenutzerID);

            if (WiederholungsTest_AntragsID == -1)
                command.Parameters.AddWithValue("@WiederholungsTest_AntragsID", DBNull.Value);
            else 
                command.Parameters.AddWithValue("@WiederholungsTest_AntragsID", WiederholungsTest_AntragsID);

            command.Parameters.AddWithValue("@istGesperrt", istGesperrt);

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
            return rowAffected > 0;
        }

        public static bool DeleteTestAppointment(int TestTerminID)
        {
            int rowAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Delete From TestTermine
                                       Where   TestTerminID = @TestTerminID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTerminID", TestTerminID);

            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return rowAffected > 0;
        }

        public static int GetTestID(int TestTerminID)
        {
            int TestID = -1;


            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select PrüfungID From Prüfungen     Where TestTerminID = @TestTerminID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTerminID", TestTerminID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                    TestID = InsertedID;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return TestID;
        }

    }
}
