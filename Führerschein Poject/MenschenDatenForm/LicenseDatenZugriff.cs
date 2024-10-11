using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MenschenDatenForm
{
    public class clsLicenseDatenZugriff
    {


        public static bool GetLicenseInfoByID(int LicenseID, ref int AntragsID, ref int FahrerID, ref int LicenseKlasseID,
               ref DateTime AusstellungsDatum, ref DateTime AblaufDatum, ref string Notizen,
                ref float BezahlteGebühren, ref bool IsAktive, ref byte AustellungsGrund, ref int ErstelltVonBenutzerID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);

            string query = "SELECT * FROM License WHERE LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;
                    AntragsID= (int)reader["AntragsID"];
                    FahrerID  = (int)reader["FahrerID"];
                    LicenseKlasseID= (int)reader["LicenseKlasseID"];
                    AusstellungsDatum=(DateTime)reader["AusstellungsDatum"];
                    AblaufDatum= (DateTime)reader["AblaufDatum"];

                    if (reader["Notizen"]==DBNull.Value)
                        Notizen= "";
                    else
                        Notizen = (string)reader["Notizen"];

                    BezahlteGebühren= Convert.ToSingle(reader["BezahlteGebühren"]);
                    IsAktive = (bool)reader["IsAktive"];
                    AustellungsGrund = (byte)reader["AusstellungsGrund"];
                    ErstelltVonBenutzerID = (int)reader["ErstelltVonBenutzerID"];


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

        public static bool GetLicenseInfoByAntragsID(ref int LicenseID, int AntragsID, ref int FahrerID, ref int LicenseKlasseID,
             ref DateTime AusstellungsDatum, ref DateTime AblaufDatum, ref string Notizen, ref float BezahlteGebühren,
                       ref bool IsAktive, ref byte AustellungsGrund, ref int ErstelltVonBenutzerID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);

            string query = "SELECT * FROM License WHERE AntragsID = @AntragsID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AntragsID", AntragsID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;
                    LicenseID= (int)reader["LicenseID"];
                    FahrerID  = (int)reader["FahrerID"];
                    LicenseKlasseID= (int)reader["LicenseKlasseID"];
                    AusstellungsDatum=(DateTime)reader["AusstellungsDatum"];
                    AblaufDatum= (DateTime)reader["AblaufDatum"];

                    if (reader["Notizen"]==DBNull.Value)
                        Notizen= "";
                    else
                        Notizen = (string)reader["Notizen"];

                    BezahlteGebühren= Convert.ToSingle(reader["BezahlteGebühren"]);
                    IsAktive = (bool)reader["IsAktive"];
                    AustellungsGrund = (byte)reader["AusstellungsGrund"];
                    ErstelltVonBenutzerID = (int)reader["ErstelltVonBenutzerID"];


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

        public static DataTable GetAllLicenses()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);

            string query = "SELECT * FROM License";

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

        public static DataTable GetDriverLicenses(int FahrerID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);

            string query = @"SELECT     
                           License.LicenseID,
                           AntragsID,
		                   LicenseKlassen.KlassenName, License.AusstellungsDatum, 
		                   License.AblaufDatum, License.IsAktive
                           FROM License INNER JOIN
                                LicenseKlassen ON License.LicenseKlasseID = LicenseKlassen.LicenseKlasseID
                            where FahrerID=@FahrerID
                            Order By IsAktive Desc, AblaufDatum Desc";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FahrerID", FahrerID);

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

        public static int AddNewLicense(int AntragsID, int FahrerID, int LicenseKlasseID,
                DateTime AusstellungsDatum, DateTime AblaufDatum, string Notizen,
                float BezahlteGebühren, bool IsAktive, byte AusstellungsGrund, int ErstelltVonBenutzerID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);

            string query = @"
                            INSERT INTO License
                                        (AntragsID,
                                         FahrerID,
                                         LicenseKlasseID,
                                         AusstellungsDatum,
                                         AblaufDatum,
                                         Notizen,
                                         BezahlteGebühren,
                                         IsAktive, 
                                         AusstellungsGrund,
                                         ErstelltVonBenutzerID)

                                        VALUES
                                        (@AntragsID,
                                         @FahrerID,
                                         @LicenseKlasseID,
                                         @AusstellungsDatum,
                                         @AblaufDatum,
                                         @Notizen,
                                         @BezahlteGebühren,
                                          @IsAktive, 
                                          @AusstellungsGrund,
                                          @ErstelltVonBenutzerID)
                                         SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AntragsID", AntragsID);
            command.Parameters.AddWithValue("@FahrerID", FahrerID);
            command.Parameters.AddWithValue("@LicenseKlasseID", LicenseKlasseID);
            command.Parameters.AddWithValue("@AusstellungsDatum", AusstellungsDatum);

            command.Parameters.AddWithValue("@AblaufDatum", AblaufDatum);

            if (Notizen == "")
                command.Parameters.AddWithValue("@Notizen", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Notizen", Notizen);

            command.Parameters.AddWithValue("@BezahlteGebühren", BezahlteGebühren);
            command.Parameters.AddWithValue("@IsAktive", IsAktive);
            command.Parameters.AddWithValue("@AusstellungsGrund", AusstellungsGrund);

            command.Parameters.AddWithValue("@ErstelltVonBenutzerID", ErstelltVonBenutzerID);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
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


            return LicenseID;

        }

        public static bool UpdateLicense(int LicenseID, int AntragsID, int FahrerID, int LicenseKlasseID,
                DateTime AusstellungsDatum, DateTime AblaufDatum, string Notizen,
                float BezahlteGebühren, bool IsAktive, byte AustellungsGrund, int ErstelltVonBenutzerID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);

            string query = @"UPDATE Licens
                           SET AntragsID=@AntragsID, FahrerID = @FahrerID,
                              LicenseKlasseID = @LicenseKlasseID,
                              AusstellungsDatum = @AusstellungsDatum,
                              AblaufDatum = @AblaufDatum,
                              Notizen = @Notizen,
                              BezahlteGebühren = @BezahlteGebühren,
                              IsAktive = @IsAktive,AustellungsGrund=@AustellungsGrund,
                              ErstelltVonBenutzerID = @ErstelltVonBenutzerID
                         WHERE LicenseID=@LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@AntragsID", AntragsID);
            command.Parameters.AddWithValue("@FahrerID", FahrerID);
            command.Parameters.AddWithValue("@LicenseKlasseID", LicenseKlasseID);
            command.Parameters.AddWithValue("@AusstellungsDatum", AusstellungsDatum);
            command.Parameters.AddWithValue("@AblaufDatum", AblaufDatum);

            if (Notizen=="")
                command.Parameters.AddWithValue("@Notizen", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Notizen", Notizen);

            command.Parameters.AddWithValue("@BezahlteGebühren", BezahlteGebühren);
            command.Parameters.AddWithValue("@IsAktive", IsAktive);
            command.Parameters.AddWithValue("@AustellungsGrund", AustellungsGrund);
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

        public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseKlasseID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);

            string query = @"SELECT   License.LicenseID
                            FROM License INNER JOIN
                                        Fahrer ON License.FahrerID = Fahrer.FahrerID
                            WHERE                  
                             License.LicenseKlasseID = @LicenseKlasseID 
                              AND Fahrer.PersonID = @PersonID
                              And IsAktive=1;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseKlasseID", LicenseKlasseID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
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


            return LicenseID;
        }

        public static bool DeactivateLicense(int LicenseID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);

            string query = @"UPDATE License
                           SET 
                              IsAktive = 0
                             
                         WHERE LicenseID=@LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);


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
