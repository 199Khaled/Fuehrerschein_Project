using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Permissions;
using MenschenDataForm;
using MenschenDatenZugriffForm;

namespace MenschenDatenForm
{
    public class clsMenschenDaten
    {
        public enum enMode { AddNew = 0, Update= 1}
        enMode _Mode = enMode.AddNew;
        public int PersonID { get; set; }
        public string AusweisNummer { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }

        public clsLänderDaten LandInfo;
        public string Vollname
        {
            get { return Vorname + " " + Nachname;}
        }
        public DateTime Geburtstag { get; set; }
        public short Geschlecht { get; set; }
        public string Anschrift { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public int LandID { get; set; }

        private string _FotoPfad;
        public string FotoPfad
        {
            get { return _FotoPfad; }
            set { _FotoPfad = value; }
        }
          

        private clsMenschenDaten(int id, string ausweisnummer,string vorname, string nachname,DateTime geburtstag, short geschlecht,
            string anschrift , string telefon, string emial, int landId, string fotopfad)
        {
            this.PersonID = id;
            this.AusweisNummer = ausweisnummer;
            this.Vorname = vorname;
            this.Nachname = nachname;
            this.Geburtstag = geburtstag;
            this.Geschlecht = geschlecht;
            this.Anschrift = anschrift;
            this.Telefon = telefon;
            this.Email = emial;
            this.LandID = landId;
            this.LandInfo = clsLänderDaten.Find(landId);
            this.FotoPfad = fotopfad;

            _Mode = enMode.Update;
        }

        public clsMenschenDaten()
        {
            this.PersonID = -1;
            this.AusweisNummer = "";
            this.Vorname = "";
            this.Nachname = "";
            this.Geburtstag = DateTime.Now;
            this.Anschrift = "";
            this.Telefon = "";
            this.Email = "";
            this.LandID = -1;
            this.FotoPfad = "";

            _Mode = enMode.AddNew;
        }
        private bool _AddNewPerson()
        {
            this.PersonID = clsMenschenDatenZugriff.AddNewPerson(this.AusweisNummer, this.Vorname, this.Nachname,this.Geburtstag,
                 this.Geschlecht, this.Anschrift, this.Telefon, this.Email, this.LandID, this.FotoPfad);

            return (PersonID != 0 && PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return clsMenschenDatenZugriff.UpdatePerson(this.PersonID, this.AusweisNummer, this.Vorname, this.Nachname, this.Geburtstag,
                 this.Geschlecht, this.Anschrift, this.Telefon, this.Email, this.LandID, this.FotoPfad);
        
        }

        public static bool DeletePerson(int id)
        {
            return clsMenschenDatenZugriff.DeletePerson(id);
        }
        public static clsMenschenDaten Find(int id)
        {
            string Ausweisnummer = ""; string Vorname = ""; string Vachname = "";
            DateTime Geburtstag = DateTime.Now; short Geschlecht = 0; string Anschrift = "";
            string Telefon = "";  string Emial = "";  int LandId = -1; string Fotopfad = "";

            if (clsMenschenDatenZugriff.FindeByID(id, ref Ausweisnummer, ref Vorname, ref Vachname, ref Geburtstag, ref Geschlecht,
                                                   ref Anschrift, ref Telefon, ref Emial, ref LandId, ref Fotopfad))
            {
                return new clsMenschenDaten(id, Ausweisnummer, Vorname, Vachname, Geburtstag, Geschlecht, Anschrift, Telefon, Emial, LandId, Fotopfad);
            }
            else
                return null;
           
        }

        public static clsMenschenDaten Find(string AusweisNummer)
        {
            int id = -1  ; string Vorname = ""; string Vachname = "";
            DateTime Geburtstag = DateTime.Now; short Geschlecht = 0; string Anschrift = "";
            string Telefon = ""; string Emial = ""; int LandId = -1; string Fotopfad = "";

            if (clsMenschenDatenZugriff.FindeByAusWeisNummer(ref id,AusweisNummer, ref Vorname, ref Vachname, ref Geburtstag, ref Geschlecht,
                                                   ref Anschrift, ref Telefon, ref Emial, ref LandId, ref Fotopfad))
            {
                return new clsMenschenDaten(id, AusweisNummer, Vorname, Vachname, Geburtstag, Geschlecht, Anschrift, Telefon, Emial, LandId, Fotopfad);
            }
            else
                return null;
        }
        public static DataTable GetAllPersons()
        {
            return clsMenschenDatenZugriff.GetAllPersons();
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    if (_UpdatePerson())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
            }

            return false;
        }

        public static bool IsPersonExist(int id)
        {
            return clsMenschenDatenZugriff.IsPersonExist(id);
        }

        public static bool IsPersonExist(string AusweiNummer)
        {
            return clsMenschenDatenZugriff.IsPersonExist(AusweiNummer);
        }
    }
}
