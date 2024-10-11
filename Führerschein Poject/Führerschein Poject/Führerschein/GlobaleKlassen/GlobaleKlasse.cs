using MenschenDataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Führerschein
{
    internal static  class clsGlobaleKlasse
    {
        public static clsBenutzerDaten Benutzer;
        private static string _DateiPfad = "C:\\Users\\Khaled\\Desktop\\Daten1\\Kopie1\\Führerschein\\LoginInfo.txt";

        public static bool RememberUsernameAndPassword(string BenutzerName, string Password)
        {
            try
            {
                // this will get the current project directory folder
                // das wird den Ordner des aktuellen Projekt Verzeichnis erhalten.
                string AktuellesVezeichnis = System.IO.Directory.GetCurrentDirectory();

                // define the path to the txtfile , where you want to save the data
                // Definiere den Pfad zur Textdatei, in der du die Daten speichern möchtest
                string DateiPfad = AktuellesVezeichnis + "\\data.txt";

                // incase the username is empty, delete the file
                // wenn der BenutzerName Leer ist, Lösche die Datei.
                if (BenutzerName == "" && File.Exists(DateiPfad))
                {
                    using(StreamWriter write = new StreamWriter(DateiPfad))
                    {
                        //wir schreiben leere Inhalte in die Datei.
                        write.WriteLine(string.Empty);
                    }
                    return true;
                }

                //concatenate username and password with seperator
                // verkette Benutzername und Password mit Trennzeichen.
                string DatenZumSpeichern = BenutzerName + "#//#"+ Password;

                // Create a StreamWriter to write to the file
                // erstelle Streamwriter to write zur Datei.
                using (StreamWriter Writer = new StreamWriter(DateiPfad))
                {
                    //write the data to the file
                    Writer.WriteLine(DatenZumSpeichern);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler ist aufgetreten", ex.Message);
                return false;
            }

        }

        public static bool GetStoredCredential(ref string BenutzerName, ref string Password)
        {
            // this will get the stored username and password it will return true if found and flase if not found
            // das gibt die gespeicherten Daten zurück

            try
            {
                // this will get the current project directory folder
                // das wird den Ordner des aktuellen Projekt Verzeichnis erhalten.
                string AktuellesVerzeichnis = System.IO.Directory.GetCurrentDirectory();

                //path for the file that conaints tha data
                // Pfad für die Datei, der die Daten enthält.
                string DateiPfad = AktuellesVerzeichnis + "\\data.txt";

                //we check if file exists
                if (File.Exists(DateiPfad))
                {
                    // Create a StreamReader to read from the file
                    // Erstelle StreamReader zu lesen von der Datei
                    using (StreamReader reader = new StreamReader(DateiPfad))
                    {
                        // read file line by line untill the end of the file
                        // Lese zeile für Zeile bis Ende der Datei
                        string Zeile;
                        while ((Zeile = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(Zeile); // output each line of file to the console
                            string[] result = Zeile.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            BenutzerName = result[0];
                            Password = result[1];
                        }
                        return true;
                    }
                }
                else
                    return false;
            }
            catch (IOException io)
            {
                MessageBox.Show("Fehler ist aufgetreten", io.Message);
                return false;
            }
        }

        // Another Methode to WriteData in File
        public static bool WriteDataToFile(string BenutzerName, string Password , bool DatenSpeichern)
        {
           
            if (DatenSpeichern)
            {
                string DatenZumSpeichern = BenutzerName + "#//#" + Password;
                File.WriteAllText(_DateiPfad, DatenZumSpeichern);
            }
            else
            {
                File.WriteAllText(_DateiPfad, "");
                return false;
            }
            return true;
        }

        public static bool ReadDataFromFile(ref string BenutzerName, ref string Password)
        {
            try
            {
                if (!File.Exists(_DateiPfad))
                {
                    //File.WriteAllText(_DateiPfad ,"") will be called...
                    BenutzerName = "";
                    Password = "";
                    return false;
                }

                string DatenInDatei = File.ReadAllText(_DateiPfad);

                if (DatenInDatei == "" || DatenInDatei == null)
                {
                    BenutzerName = "";
                    Password = "";
                    return false;
                }
                else
                {
                    string[] DatenTrennen = DatenInDatei.Split(new string[] { "#//#" }, StringSplitOptions.None);

                    BenutzerName = DatenTrennen[0];
                    Password = DatenTrennen[1];
                }
            }
            catch(IOException io)
            {
                MessageBox.Show(io.Message);
            }
            return true;
        }
        
    }
}
