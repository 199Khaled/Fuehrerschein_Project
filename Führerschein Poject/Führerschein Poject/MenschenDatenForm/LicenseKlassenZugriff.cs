using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MenschenDatenForm
{
    public class clsLicenseKlassenZugriff
    {
        public static DataTable GetAllLicenseClasses()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select * From LicenseKlassen";
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
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static bool GetLicenseClassInfoByID(int LicenseKlasseID, ref string KlassenName, ref string KlassenBeschreibung,
                        ref byte MindestAlter, ref byte StandardGültigkeitDauer, ref float KlasseGebühren)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select * From LicenseKlassen 
                                                     Where LicenseKlasseID = @LicenseKlasseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseKlasseID", LicenseKlasseID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    isFound = true;

                    KlassenName = (string)reader["KlassenName"];
                    KlassenBeschreibung = (string)reader["KlassenBeschreibung"];
                    MindestAlter = (byte)reader["MindestAlter"];
                    StandardGültigkeitDauer = (byte)reader["StandardGültigkeitDauer"];
                    KlasseGebühren = Convert.ToSingle(reader["KlasseGebühren"]);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static bool GetLicenseClassInfoByClassName(ref  int LicenseKlasseID, string KlassenName, ref string KlassenBeschreibung,
                       ref byte MindestAlter, ref byte StandardGültigkeitDauer, ref float KlasseGebühren)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select * From LicenseKlassen 
                                                     Where KlassenName = @KlassenName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@KlassenName", KlassenName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    LicenseKlasseID = (int)reader["LicenseKlasseID"];
                    KlassenName = (string)reader["KlassenName"];
                    KlassenBeschreibung = (string)reader["KlassenBeschreibung"];
                    MindestAlter = (byte)reader["MindestAlter"];
                    StandardGültigkeitDauer = (byte)reader["StandardGültigkeitDauer"];
                    KlasseGebühren = Convert.ToSingle(reader["KlasseGebühren"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        
        public static bool IsLicenseClassExistForPersonID(int PersonID, int LicenseKlasseID)
        {
            bool Isfound = false;

            SqlConnection connection = new SqlConnection(clsConnectWithSqlServer.ConnectionLink);
            string query = @"Select Find=1 From LicenseKlassen INNER JOIN 
                                             Where LicenseKlasseID = @LicenseKlasseID
                                             And   PersonID        = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseKlasseID", LicenseKlasseID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    Isfound = true;
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return Isfound;
        }
       
    }
}
