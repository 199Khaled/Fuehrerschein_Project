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
    public class clsBeschlagnameLicenseZugriffDaten
    {
        public static bool GetDetainedLicenseInfoByID(int BeschlagnahmeID,ref int LicenseID,
            ref DateTime BeschlagnahmtesDatum, ref float StrafGebühren, ref int ErstelltVonBenutzerID,
            ref bool IsFreigegeben, ref DateTime FreigabeDatum, ref int FreigegebenVonBenutzerID,
            ref int FreigabeAntragsID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string abfrage = @"Select * From BeschlagnahmeLicense  Where BeschlagnahmeID = @BeschlagnahmeID";

            SqlCommand command = new SqlCommand(abfrage, connection);
            command.Parameters.AddWithValue("@BeschlagnahmeID", BeschlagnahmeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    isFound = true;

                    LicenseID = (int)reader["LicenseID"];
                    BeschlagnahmtesDatum = (DateTime)reader["BeschlagnahmtesDatum"];
                    StrafGebühren = (float)reader["StrafGebühren"];
                    ErstelltVonBenutzerID = (int)reader["ErstelltVonBenutzerID"];
                    IsFreigegeben = (bool)reader["IsFreigegeben"];

                    if (reader["FreigabeDatum"] == DBNull.Value)
                        FreigabeDatum = DateTime.MaxValue;
                    else
                        FreigabeDatum = (DateTime)reader["FreigabeDatum"];

                    if (reader["FreigegebenVonBenutzerID"] == DBNull.Value)
                        FreigegebenVonBenutzerID = -1;
                    else
                        FreigegebenVonBenutzerID = (int)reader["FreigegebenVonBenutzerID"];

                    if (reader["FreigabeAntragsID"] == DBNull.Value)
                        FreigabeAntragsID = -1;
                    else
                        FreigabeAntragsID = (int)reader["FreigabeAntragsID"];
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

        public static bool GetDetainedLicenseInfoByLicenseID(ref int BeschlagnahmeID, int LicenseID,
           ref DateTime BeschlagnahmtesDatum, ref float StrafGebühren, ref int ErstelltVonBenutzerID,
           ref bool IsFreigegeben, ref DateTime FreigabeDatum, ref int FreigegebenVonBenutzerID,
           ref int FreigabeAntragsID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string abfrage = @"Select * From BeschlagnahmeLicense  Where LicenseID = @LicenseID
                                                                  Order by BeschlagnahmeID Desc";

            SqlCommand command = new SqlCommand(abfrage, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    BeschlagnahmeID = (int)reader["BeschlagnahmeID"];
                    BeschlagnahmtesDatum = (DateTime)reader["BeschlagnahmtesDatum"];
                    StrafGebühren = Convert.ToSingle(reader["StrafGebühren"]);
                    ErstelltVonBenutzerID = (int)reader["ErstelltVonBenutzerID"];
                    IsFreigegeben = (bool)reader["IsFreigegeben"];

                    if (reader["FreigabeDatum"] == DBNull.Value)
                        FreigabeDatum = DateTime.MaxValue;
                    else
                       FreigabeDatum = (DateTime)reader["FreigabeDatum"];

                    if (reader["FreigegebenVonBenutzerID"] == DBNull.Value)
                        FreigegebenVonBenutzerID = -1;
                    else  
                        FreigegebenVonBenutzerID = (int)reader["FreigegebenVonBenutzerID"];

                    if (reader["FreigabeAntragsID"] == DBNull.Value)
                        FreigabeAntragsID = -1;
                    else
                        FreigabeAntragsID = (int)reader["FreigabeAntragsID"];
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

        public static int AddNewDetainedLicense(int LicenseID,
            DateTime BeschlagnahmtesDatum,  float StrafGebühren,  int ErstelltVonBenutzerID)
        {
            int BeschlagnahmeID = -1;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);

            string abfrage = @"INSERT INTO  BeschlagnahmeLicense(
                                             LicenseID,
                                             BeschlagnahmtesDatum,
                                             StrafGebühren,
                                             ErstelltVonBenutzerID,
                                             IsFreigegeben 
                                             )

                                VALUES       (@LicenseID,
                                              @BeschlagnahmtesDatum,
                                              @StrafGebühren,
                                              @ErstelltVonBenutzerID,
                                              0 
                                              );
                               Select Scope_Identity();";

            SqlCommand command = new SqlCommand(abfrage, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@BeschlagnahmtesDatum", BeschlagnahmtesDatum);
            command.Parameters.AddWithValue("@StrafGebühren", StrafGebühren);
            command.Parameters.AddWithValue("@ErstelltVonBenutzerID", ErstelltVonBenutzerID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(),out int InsertedID))
                {
                    BeschlagnahmeID = InsertedID;
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
            return BeschlagnahmeID;

        }

        public static bool UpdateDetainedLicense(int BeschlagnahmeID, int LicenseID,
            DateTime BeschlagnahmtesDatum, float StrafGebühren, int ErstelltVonBenutzerID,
            bool IsFreigegeben)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);

            string abfrage = @"UPDATE     BeschlagnahmeLicense
                                     SET     LicenseID            = @LicenseID,
                                             BeschlagnahmtesDatum = @BeschlagnahmtesDatum,
                                             StrafGebühren        = @StrafGebühren,
                                             ErstelltVonBenutzerID= @ErstelltVonBenutzerID,
                                    Where   BeschlagnahmeID   = @ID";

            SqlCommand command = new SqlCommand(abfrage, connection);
            command.Parameters.AddWithValue("@ID", BeschlagnahmeID);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@BeschlagnahmtesDatum", BeschlagnahmtesDatum);
            command.Parameters.AddWithValue("@StrafGebühren", StrafGebühren);
            command.Parameters.AddWithValue("@ErstelltVonBenutzerID", ErstelltVonBenutzerID);

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

        public static DataTable GetAllDetainedLicenses()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);

            string query = "select * from BeschlagnahmeLicense_View   order by IsFreigegeben ,BeschlagnahmeID;";

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
        public static bool ReleaseDetainedLicense(int BeschlagnahmeID,
                   int FreigegebenVonBenutzerID, int FreigabeAntragsID)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);

            string abfrage = @"Update BeschlagnahmeLicense
                                      Set   IsFreigegeben = 1,
                                            FreigegebenVonBenutzerID = @BenutzerID,
                                            FreigabeDatum   = @FreigabeDatum,
                                            FreigabeAntragsID  = @FreigabeAntragsID
                                     Where  BeschlagnahmeID  = @ID";

            SqlCommand command = new SqlCommand(abfrage, connection);
            command.Parameters.AddWithValue("@ID", BeschlagnahmeID);
            command.Parameters.AddWithValue("@FreigabeDatum", DateTime.Now);
            command.Parameters.AddWithValue("@BenutzerID", FreigegebenVonBenutzerID);
            command.Parameters.AddWithValue("@FreigabeAntragsID", FreigabeAntragsID);

            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return rowAffected > 0;
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            bool IstFreigegeben = false;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);

            string abfrage = @"Select  IstBeschlagnahmt = 1
                                  From BeschlagnahmeLicense
                             Where LicenseID = @LicenseID
                             And   IsFreigegeben = 0";

            SqlCommand command = new SqlCommand(abfrage, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();


                if(result != null)
                {
                    IstFreigegeben = Convert.ToBoolean(result);
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
            return IstFreigegeben;
        }

        public static bool IsLicenseReleased(int LicenseID)
        {
            bool IstFreigegeben = false;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);

            string abfrage = @"Select  IstFreigegeben = 1
                                  From BeschlagnahmeLicense
                             Where LicenseID = @LicenseID
                             And   IsFreigegeben = 1";

            SqlCommand command = new SqlCommand(abfrage, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();


                if (result != null)
                {
                    IstFreigegeben = Convert.ToBoolean(result);
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
            return IstFreigegeben;
        }
    }
}

