using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace MenschenDatenForm
{
    public class clsAnträgeZugriff
    {
        public static bool GetApplicationInfoByID(int AntragsID, ref int AntragsPersonID,
         ref DateTime AntragsDatum, ref int AntragsKategorieID, ref byte AntragsStatus,
          ref DateTime LetztesStatusDatum, ref decimal BezahlteGebühren, ref int ErstelltVonBenutzerID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select * From Anträge
                                         Where AntragsID = @AntragsID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AntragsID", AntragsID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    IsFound = true;

                    AntragsPersonID = (int)reader["AntragsPersonID"];
                    AntragsDatum = (DateTime)reader["AntragsDatum"];
                    AntragsKategorieID = (int)reader["AntragsKategorieID"];
                    AntragsStatus = (byte)reader["AntragsStatus"];
                    LetztesStatusDatum = (DateTime)reader["LetztesStatusDatum"];
                    BezahlteGebühren = (decimal)reader["BezahlteGebühren"];
                    ErstelltVonBenutzerID = (int)reader["ErstelltVonBenutzerID"];
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                IsFound = false;
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static DataTable GetAllApplication()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select * From Anträge";
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
                //IsFound = false;
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static int AddNewApplication(int AntragsPersonID,
          DateTime AntragsDatum,  int AntragsKategorieID,  byte AntragsStatus,
          DateTime LetztesStatusDatum,  decimal BezahlteGebühren, int ErstelltVonBenutzerID)
        {
            int AntragsID = -1;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"INSERT INTO Anträge(AntragsPersonID, AntragsDatum,
                                                AntragsKategorieID, AntragsStatus,
                                                LetztesStatusDatum, BezahlteGebühren,
                                                 ErstelltVonBenutzerID)
                            VALUES (@AntragsPersonID,@AntragsDatum,@AntragsKategorieID,
                                    @AntragsStatus,@LetztesStatusDatum,@BezahlteGebühren,
                                     @ErstelltVonBenutzerID);
                            SELECT SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AntragsPersonID",AntragsPersonID);
            command.Parameters.AddWithValue("@AntragsDatum",AntragsDatum);
            command.Parameters.AddWithValue("@AntragsKategorieID",AntragsKategorieID);
            command.Parameters.AddWithValue("@AntragsStatus",AntragsStatus);
            command.Parameters.AddWithValue("@LetztesStatusDatum",LetztesStatusDatum);
            command.Parameters.AddWithValue("@BezahlteGebühren",BezahlteGebühren);
            command.Parameters.AddWithValue("@ErstelltVonBenutzerID",ErstelltVonBenutzerID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                int InsertedID;
                if (result != null && int.TryParse(result.ToString(), out InsertedID))
                {
                    AntragsID = InsertedID;
                }
            }
            catch (Exception ex)
            {
                //IsFound = false;
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return AntragsID;
        }

        public static bool UpdateApplication(int AntragsID, int AntragsPersonID,
          DateTime AntragsDatum, int AntragsKategorieID, byte AntragsStatus,
          DateTime LetztesStatusDatum, decimal BezahlteGebühren, int ErstelltVonBenutzerID)
        {
            int rowAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Update Anträge 
                                   Set   AntragsPersonID   = @AntragsPersonID,
                                         AntragsDatum      = @AntragsDatum,
                                         AntragsKategorieID = @AntragsKategorieID,
                                         AntragsStatus      = @AntragsStatus,
                                         LetztesStatusDatum = @LetztesStatusDatum,
                                         BezahlteGebühren   = @BezahlteGebühren,
                                         ErstelltVonBenutzerID = @ErstelltVonBenutzerID
                                   Where AntragsID = @AntragsID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AntragsID", AntragsID);
            command.Parameters.AddWithValue("@AntragsPersonID", AntragsPersonID);
            command.Parameters.AddWithValue("@AntragsDatum", AntragsDatum);
            command.Parameters.AddWithValue("@AntragsKategorieID", AntragsKategorieID);
            command.Parameters.AddWithValue("@AntragsStatus", AntragsStatus);
            command.Parameters.AddWithValue("@LetztesStatusDatum", LetztesStatusDatum);
            command.Parameters.AddWithValue("@BezahlteGebühren", BezahlteGebühren);
            command.Parameters.AddWithValue("@ErstelltVonBenutzerID", ErstelltVonBenutzerID);

            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //IsFound = false;
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return AntragsID > 1;
        }

        public static bool DeleteApplication(int AntragsID)
        {
            int rowAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Delete From Anträge 
                                      Where AntragsID = @AntragsID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AntragsID", AntragsID);

            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //IsFound = false;
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return AntragsID > 1;
        }

        public static bool IsApplicationExist(int AntragsID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select Find = 1 From Anträge Where AntragsID = @AntragsID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AntragsID", AntragsID);
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
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static bool DoesPersonHaveApplication(int AntragsAPersonID, int AntragsKategrieID)
        {
            bool isFound = false;
            return isFound;
        }

        public static bool GetActiveApplicationID(int AntragsPersonID, int AntragsKateorieID)
        {
            int AktiveAntragsID = -1;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"SELECT AktiveAntragsID = AntragsID From Anträge 
                           Where    AntragsPersonID = @AntragsPersonID  
                           and      AntragsKategorieID = @AntragsKategorieID 
                           and     AntragsStatus = 1";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AntragsPersonID", AntragsPersonID);
            command.Parameters.AddWithValue("@AntragsKategorieID", AntragsKateorieID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();

            }
            return AktiveAntragsID != -1;
        }

        public static bool GetActiveApplicationIDForLicenseClass(int AntragsPersonID, int AntragsKateorieID)
        {
            bool isfound = false;
            return isfound;
        }

        public static bool UpdateStatus(int AntragsID, short neueStatus)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Update Anträge
                                          Set   AntragsStatus =      @NeueStatus,
                                                LetztesStatusDatum = @LetztesStatusDatum
                                          Where AntragsID   = @AntragsID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AntragsID", AntragsID);
            command.Parameters.AddWithValue("@NeueStatus", neueStatus);
            command.Parameters.AddWithValue("@LetztesStatusDatum", DateTime.Now);

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

        public static int GetAktiveApplicationIDForLicenseClass(int AntragsPersonID, int AntragsKategorieID,int FührerscheinKlasseID)
        {
            int AktivAntragsID = -1;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);

            string query1 = @"Select AktvieAntrag = Anträge.AntragsID
                             From 
                             Anträge Inner Join LokalerFührerscheinAnträge On 
                             Anträge.AntragsID = LokalerFührerscheinAnträge.AntragsID
                             Where AntragsPersonID = @AntragsPersonID
                             And AntragsKategorieID = @AntragsKategorieID
                             And LokalerFührerscheinAnträge.LicenseKlasseID = @LicenseKlasseID
                             And AntragsStatus = 1";
            SqlCommand commnad = new SqlCommand(query1, connection);
            commnad.Parameters.AddWithValue("@AntragsPersonID", AntragsPersonID);
            commnad.Parameters.AddWithValue("@AntragsKategorieID", AntragsKategorieID);
            commnad.Parameters.AddWithValue("@LicenseKlasseID", FührerscheinKlasseID);

            try
            {
                connection.Open();
                object result = commnad.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                    AktivAntragsID = InsertedID;

               
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return AktivAntragsID;
        }
    }
}
