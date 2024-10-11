using MenschenDatenForm;
using System;
using System.Data;
using System.Data.SqlClient;


namespace MenschenDatenZugriffForm
{
    public class clsMenschenDatenZugriff
    {
        public static DataTable GetAllPersons()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"SELECT Menschen.PersonID, Menschen.AusweisNummer, Menschen.Vorname,Menschen.Nachname,
                          Menschen.Geburtstag, Menschen.Geschlecht,
                               CASE
                               WHEN Menschen.Geschlecht = 0 THEN 'Maenlich'
                               ELSE 'Weiblich'

                                END as GeschlechtsTitel,
                            Menschen.Anschrift, Menschen.Telefon, Menschen.Email, Länder.LandsName,
                            Menschen.FotoPfad 
                            From            Menschen INNER JOIN Länder  ON
                            Menschen.LandID = Länder.LandID                      
                            Order by Menschen.Vorname";

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
                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); }

            return dt;
        }

        public static bool FindeByID(int ID, ref string AusweisNummer, ref string Vorname, ref string Nachname,
            ref DateTime Geburtstag, ref short Geschlecht, ref string Anschrift, ref string Telefon, ref string Email,
             ref int LandID, ref string FotoPfad)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select * From Menschen  Where PersonID = @ID";
            SqlCommand commmand = new SqlCommand(query, connection);

            commmand.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = commmand.ExecuteReader();
                if (reader.Read())
                {
                    isfound = true;
                    AusweisNummer = (string)reader["AusweisNummer"];
                    Vorname = (string)reader["Vorname"];
                    Nachname = (string)reader["Nachname"];
                    Geburtstag = (DateTime)reader["Geburtstag"];
                    Geschlecht = (byte)reader["Geschlecht"];
                    Anschrift = (string)reader["Anschrift"];
                    Telefon = reader.IsDBNull(reader.GetOrdinal("Telefon")) ? "" : (string)reader["Telefon"];
                    Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? "" : (string)reader["Email"];
                    LandID = (int)reader["LandID"];
                    FotoPfad = reader.IsDBNull(reader.GetOrdinal("FotoPfad")) ? "" : (string)reader["FotoPfad"];
                }
                reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return isfound;
        }

        public static bool FindeByAusWeisNummer(ref int ID, string AusweisNummer, ref string Vorname, ref string Nachname,
     ref DateTime Geburtstag, ref short Geschlecht, ref string Anschrift, ref string Telefon, ref string Email,
      ref int LandID, ref string FotoPfad)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select * From Menschen  Where AusweisNummer = @AusweisNummer";
            SqlCommand commmand = new SqlCommand(query, connection);

            commmand.Parameters.AddWithValue("@AusweisNummer", AusweisNummer);
            try
            {
                connection.Open();
                SqlDataReader reader = commmand.ExecuteReader();
                if(reader.Read())
                {
                    isfound = true;
                    ID = (int)reader["PersonID"];
                    Vorname = (string)reader["Vorname"];
                    Nachname = (string)reader["Nachname"];
                    Geburtstag = (DateTime)reader["Geburtstag"];
                    Geschlecht = (byte)reader["Geschlecht"];
                    Anschrift = (string)reader["Anschrift"];
                    Telefon = reader.IsDBNull(reader.GetOrdinal("Telefon")) ? "" : (string)reader["Telefon"];
                    Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? "" : (string)reader["Email"];
                    LandID = (int)reader["LandID"];
                    FotoPfad = reader.IsDBNull(reader.GetOrdinal("FotoPfad")) ? "" : (string)reader["FotoPfad"];
                }
                reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return isfound;
        }

        public static int AddNewPerson(string AusweisNummer, string Vorname, string Nachname,
              DateTime Geburtstag, short Geschlecht, string Anschrift,  string Telefon, string Email,
              int LandID, string FotoPfad)
        {
            int PersonID = -1;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"INSERT INTO Menschen(AusweisNummer, Vorname, Nachname, Geburtstag, Geschlecht, Anschrift, Telefon,
                         Email, LandID, FotoPfad)
                         VALUES (@AusweisNummer, @Vorname, @Nachname, @Geburtstag, @Geschlecht, @Anschrift, @Telefon,
                         @Email, @LandID, @FotoPfad);
                          SELECT SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AusweisNummer", AusweisNummer);
            command.Parameters.AddWithValue("@Vorname", Vorname);
            command.Parameters.AddWithValue("@Nachname", Nachname);
            command.Parameters.AddWithValue("@Geburtstag", Geburtstag);
            command.Parameters.AddWithValue("@Geschlecht", Geschlecht);
            command.Parameters.AddWithValue("@Anschrift", Anschrift);
            if(!String.IsNullOrEmpty(Telefon))
                command.Parameters.AddWithValue("@Telefon", Telefon);
            else        
                command.Parameters.AddWithValue("@Telefon", System.DBNull.Value);  
            
            if(!String.IsNullOrEmpty(Email))          
                command.Parameters.AddWithValue("@Email", Email);       
            else            
               command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            command.Parameters.AddWithValue("@LandID", LandID);

            if(!String.IsNullOrEmpty(FotoPfad))
                command.Parameters.AddWithValue("@FotoPfad", FotoPfad);
            else
                command.Parameters.AddWithValue("@FotoPfad", System.DBNull.Value);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    PersonID = InsertedID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); }

            return PersonID;
        }

        public static bool UpdatePerson(int id,string AusweisNummer, string Vorname, string Nachname,
           DateTime Geburtstag, short Geschlecht, string Anschrift, string Telefon, string Email,
           int LandID, string FotoPfad)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"UPDATE Menschen 
                               Set Vorname = @Vorname,
                                    Nachname = @Nachname,
                                    AusweisNummer = @AusweisNummer,
                                     Geburtstag = @Geburtstag,
                                     Geschlecht = @Geschlecht,
                                     Anschrift = @Anschrift,
                                     Telefon = @Telefon,
                                     Email = @Email,
                                     LandID = @LandID,
                                     FotoPfad = @FotoPfad
                                 Where PersonID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@AusweisNummer", AusweisNummer);
            command.Parameters.AddWithValue("@Vorname", Vorname);
            command.Parameters.AddWithValue("@Nachname", Nachname);
            command.Parameters.AddWithValue("@Geburtstag", Geburtstag);
            command.Parameters.AddWithValue("@Geschlecht", Geschlecht);
            command.Parameters.AddWithValue("@Anschrift", Anschrift);
            if (!String.IsNullOrEmpty(Telefon))
                command.Parameters.AddWithValue("@Telefon", Telefon);
            else
                command.Parameters.AddWithValue("@Telefon", System.DBNull.Value);

            if (!String.IsNullOrEmpty(Email))
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            command.Parameters.AddWithValue("@LandID", LandID);

            if (!String.IsNullOrEmpty(FotoPfad))
                command.Parameters.AddWithValue("@FotoPfad", FotoPfad);
            else
                command.Parameters.AddWithValue("@FotoPfad", System.DBNull.Value);

            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); }

            return (rowAffected > 0);
        }
        public static bool IsPersonExist(int id)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select Find=1 From Menschen   Where PersonID = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
                throw;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool IsPersonExist(string AusweisNummer)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select Find=1 From Menschen   Where AusweisNummer = @AusweisNummer";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AusweisNummer", AusweisNummer);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
                throw;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool DeletePerson(int ID)
        {
            int rowAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Delete From Menschen   Where PersonID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
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
    }
}
