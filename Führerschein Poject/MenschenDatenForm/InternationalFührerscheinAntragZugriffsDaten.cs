using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MenschenDatenForm
{
    public class clsInternationalFührerscheinAntragZugriffsDaten
    {
        
        public static bool GetInternationalLicenseByID(int InternationalLicenseID,
            ref int AntragsID, ref int FahrerID, ref int AusstellungsMitLokalerLicenseID,
            ref DateTime AusstellungsDatum , ref DateTime AblaufDatum, ref bool IsAktive)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string abfrage = @"Select * from InternationalerFührerscheinAnträge  Where InternationalLicenseID = @ID";

            SqlCommand command = new SqlCommand(abfrage, connection);
            command.Parameters.AddWithValue("@ID", InternationalLicenseID);

            try
            {
                connection.Open() ;
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    isFound = true;

                    AntragsID = (int)reader["AntragsID"];
                    FahrerID = (int)reader["FahrerID"];
                    AusstellungsMitLokalerLicenseID = (int)reader["AusstellungsMitLokalerLicenseID"];
                    AusstellungsDatum = (DateTime)reader["AusstellungsDatum"];
                    AblaufDatum = (DateTime)reader["AblaufDatum"];
                    IsAktive = (bool)reader["IsAktive"];
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

        public static DataTable GetAllInternationalLicense()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string abfrage = @"Select   InternationalLicenseID, AntragsID, FahrerID,   AusstellungsMitLokalerLicenseID,
                                        AusstellungsDatum, AblaufDatum, IsAktive
                               From     InternationalerFührerscheinAnträge
                              Order by  IsAktive, AblaufDatum Desc";

            SqlCommand command = new SqlCommand(abfrage, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);

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

        public static DataTable GetDriverInternationalLicense(int FahrerID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string abfrage = @"Select    InternationalLicenseID, AntragsID, FahrerID, AusstellungsMitLokalerLicenseID,
                                         AusstellungsDatum, AblaufDatum, IsAktive
                               From      InternationalerFührerscheinAnträge
                               Where     FahrerID = @FahrerID
                              Order by   AblaufDatum Dece";

            SqlCommand command = new SqlCommand(abfrage, connection);
            command.Parameters.AddWithValue("@FahrerID", FahrerID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);

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

        public static int AddNewInternationalLicense(
            int AntragsID, int FahrerID, int AusstellungsMitLokalerLicenseID,
             DateTime AusstellungsDatum, DateTime AblaufDatum, bool IsAktive,
            int ErstelltBeiBenutzerID)
        {
            int NeueInternationalLlicenseID =  -1;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string abfrage = @"
                                      Update InternationalerFührerscheinAnträge
                                           Set     IsAktive = 0
                                           Where FahrerID = @FahrerID

                                       Insert into InternationalerFührerscheinAnträge
                                                     (
                                                       AntragsID, 
                                                       FahrerID,
                                                       AusstellungsMitLokalerLicenseID,
                                                       AusstellungsDatum,  
                                                       AblaufDatum,      
                                                       IsAktive,          
                                                       ErstelltBeiBenutzerID
                                                      )
                                                Values(
                                                       @AntragsID,
                                                       @FahrerID,
                                                       @AusstellungsMitLokalerLicenseID,
                                                       @AusstellungsDatum,
                                                       @AblaufDatum,
                                                       @IsAktive,
                                                       @ErstelltBeiBenutzerID
                                                       );
                                      Select Scope_Identity()";

            SqlCommand command = new SqlCommand(abfrage, connection);
            command.Parameters.AddWithValue("@AntragsID", AntragsID);
            command.Parameters.AddWithValue("@FahrerID", FahrerID);
            command.Parameters.AddWithValue("@AusstellungsMitLokalerLicenseID", AusstellungsMitLokalerLicenseID);
            command.Parameters.AddWithValue("@AusstellungsDatum", AusstellungsDatum);
            command.Parameters.AddWithValue("@AblaufDatum", AblaufDatum);
            command.Parameters.AddWithValue("@IsAktive", IsAktive);
            command.Parameters.AddWithValue("@ErstelltBeiBenutzerID", ErstelltBeiBenutzerID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    NeueInternationalLlicenseID = InsertedID;
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
            return NeueInternationalLlicenseID;
        }
        public static bool UpdateInternationalLicense(int InternationalLicenseID,
            int AntragsID, int FahrerID, int AusstellungsMitLokalerLicenseID,
             DateTime AusstellungsDatum,  DateTime AblaufDatum,bool IsAktive,
            int ErstelltBeiBenutzerID)
        {
            int rowAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string abfrage = @"Update InternationalerFührerscheinAnträge
                                                 Set 
                                                       AntragsID            = @AntragsID,
                                                       FahrerID             = @FahrerID,
                                                       AusstellungsMitLokalerLicenseID = @AusstellungsMitLokalerLicenseID,
                                                       AusstellungsDatum    = @AusstellungsDatum,
                                                       AblaufDatum          = @AblaufDatum,
                                                       IsAktive             = @IsAktive,
                                                       ErstelltBeiBenutzerID = @ErstelltBeiBenutzerID

                                              Where   InternationalLicenseID = @ID";

            SqlCommand command = new SqlCommand(abfrage, connection);
            command.Parameters.AddWithValue("@ID", InternationalLicenseID);
            command.Parameters.AddWithValue("@AntragsID", AntragsID);
            command.Parameters.AddWithValue("@FahrerID", FahrerID);
            command.Parameters.AddWithValue("@@AusstellungsMitLokalerLicenseID", AusstellungsMitLokalerLicenseID);
            command.Parameters.AddWithValue("@AusstellungsDatum", AusstellungsDatum);
            command.Parameters.AddWithValue("@AblaufDatum", AblaufDatum);
            command.Parameters.AddWithValue("@IsAktive", IsAktive);
            command.Parameters.AddWithValue("@ErstelltBeiBenutzerID", ErstelltBeiBenutzerID);

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

        public static int GetActiveInternationalLicenseByDrivingID(int FahrerID)
        {
            int InternationalLicenseID = -1;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string abfrage = @"Select Top 1 InternationalLicenseID  
                                 From   InternationalerFührerscheinAnträge
                                 Where  FahrerID = @FahrerID and  GetDate() Between AusstellungsDatum and AblaufDatum
                             Order by AblaufDatum  Desc";

            SqlCommand command = new SqlCommand(abfrage, connection);
            command.Parameters.AddWithValue("@FahrerID", FahrerID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(), out int SelectedLicenseID))
                {
                    InternationalLicenseID = SelectedLicenseID;
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
            return InternationalLicenseID;
        }
    }
}
