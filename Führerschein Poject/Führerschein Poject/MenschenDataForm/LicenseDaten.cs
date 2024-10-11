using MenschenDatenForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MenschenDataForm
{
    public class clsLicenseDaten
    {
        private enum enMode { AddNew = 0, Update = 1}
        private enMode Mode = enMode.AddNew;

        public enum enAusstellungsGrund {Erstmal = 1, Erneuern = 2, 
           ErsatzFürVerlorenenFührerschein = 3, ErsatzFürBeschädigtenFührerschein = 4}

        public int LicenseID { get; set; }
        public int AntragsID { get; set; }
        public int FahrerID { get; set; }
        public int LicenseKlasseID { get; set; }
        public DateTime AusstellungsDatum { get; set; }
        public DateTime AblaufDatum { get; set; }
        public string Notitzen { get; set; }
        public float BezahlteGebühren { get; set; }
        public bool IsAktive { get; set; }

        public int ErstelltVonBeNutzerID { get; set; }
        public enAusstellungsGrund AusstellungsGrund { get; set; }
        public string AusstellungsGrundText
        {
            get
            {
                return GetAusstellungsGrundText(this.AusstellungsGrund);
            }
        }

        public clsBeschlagnahmeLicenseDaten BeschlagnahmeLicenseInfo { get; set; }
        public bool IstBeschlagnahmt
        {
            get { return clsBeschlagnahmeLicenseDaten.IsLicenseDetained(this.LicenseID); }
        }

        public bool IstFreigegeben
        {
            get { return clsBeschlagnahmeLicenseDaten.IsLicenseReleased(this.LicenseID); }
        }

        public clsLicenseKlassen LicenseKlassenInfo;
        public clsFahrerDaten FahrerInfo;
        public clsMenschenDaten PersonInfo;

        private clsLicenseDaten(int LicenseID, int AntragsID, int FahrerID, int LicenseKlasseID, DateTime AusstellungsDatum, 
         DateTime AblaufDatum, string Notizen, float BezahlteGebühren,enAusstellungsGrund AusstellungsGrund,int ErstelltVonBenutzerID, bool IsAktive)
        {
            this.LicenseID = LicenseID;
            this.AntragsID = AntragsID;
            this.FahrerID = FahrerID;
            this.FahrerInfo = clsFahrerDaten.GetDriverInfoByDriverID(this.FahrerID);
            this.PersonInfo = clsMenschenDaten.Find(FahrerInfo.PersonID);
            this.LicenseKlasseID = LicenseKlasseID;
            this.LicenseKlassenInfo = clsLicenseKlassen.Find(this.LicenseKlasseID);
            this.AusstellungsDatum = AusstellungsDatum;
            this.AblaufDatum = AblaufDatum;
            this.Notitzen = Notizen;
            this.BezahlteGebühren = BezahlteGebühren;
            this.AusstellungsGrund = AusstellungsGrund;
            this.ErstelltVonBeNutzerID = ErstelltVonBenutzerID;
            this.IsAktive = IsAktive;
            this.BeschlagnahmeLicenseInfo = clsBeschlagnahmeLicenseDaten.FindByLicenseID(this.LicenseID);
            Mode = enMode.Update;
        }

        public clsLicenseDaten()
        {
            this.LicenseID = -1;
            this.AntragsID = -1;
            this.FahrerID = -1;
            this.LicenseKlasseID = -1;
            this.AusstellungsDatum = DateTime.Now;
            this.AblaufDatum = DateTime.Now;
            this.Notitzen = "";
            this.BezahlteGebühren = 0;
            this.AusstellungsGrund = enAusstellungsGrund.Erstmal;
            this.IsAktive = true;
            Mode = enMode.AddNew;
        }

        private bool _AddNewLicense()
        {
            this.LicenseID = clsLicenseDatenZugriff.AddNewLicense(this.AntragsID, this.FahrerID,
                 this.LicenseKlasseID, this.AusstellungsDatum, this.AblaufDatum, this.Notitzen,
                this.BezahlteGebühren,this.IsAktive, (byte)this.AusstellungsGrund,this.ErstelltVonBeNutzerID);

            return (this.LicenseID != -1);
        }

        private bool _UpdateLicense()
        {
            return clsLicenseDatenZugriff.UpdateLicense(this.LicenseID, this.AntragsID, this.FahrerID,
                this.LicenseKlasseID, this.AusstellungsDatum, this.AblaufDatum, this.Notitzen,
                this.BezahlteGebühren, this.IsAktive, (byte)this.AusstellungsGrund, this.ErstelltVonBeNutzerID);
        }

        public static clsLicenseDaten GetLicenseInfoByID(int LicenseID)
        {
            int AntragsID = -1;int FahrerID = -1;int LicenseKlasseID = -1; DateTime AusstellungsDatum = DateTime.Now;
            DateTime AblaufDatum = DateTime.Now; string Notizen = ""; float BezahlteGebühren = 0;
            bool IsAktive = false; byte AusstellungsGrund = 0; int ErstelltVonBenutzerID = -1;

            bool IsFound = false;
            IsFound = clsLicenseDatenZugriff.GetLicenseInfoByID(LicenseID, ref AntragsID, ref FahrerID,
                ref LicenseKlasseID, ref AusstellungsDatum, ref AblaufDatum, ref Notizen, ref BezahlteGebühren,
                ref IsAktive, ref AusstellungsGrund, ref ErstelltVonBenutzerID);

            //if record found
            if (IsFound)
            {
                //we return a new Constructor with the Parameters 
                return new clsLicenseDaten(LicenseID, AntragsID, FahrerID, LicenseKlasseID,
                  AusstellungsDatum, AblaufDatum, Notizen, BezahlteGebühren, (enAusstellungsGrund)AusstellungsGrund, ErstelltVonBenutzerID, IsAktive);

            }
            else
                //if not found return null
                return null;
  
        }

        public static clsLicenseDaten GetLicenseInfoByAntragsID(int AntragsID)
        {
            int LicenseID = -1; int FahrerID = -1; int LicenseKlasseID = -1; DateTime AusstellungsDatum = DateTime.Now;
            DateTime AblaufDatum = DateTime.Now; string Notizen = ""; float BezahlteGebühren = 0;
            bool IsAktive = false; byte AusstellungsGrund = 0; int ErstelltVonBenutzerID = -1;

            bool IsFound = false;
            IsFound = clsLicenseDatenZugriff.GetLicenseInfoByAntragsID(ref LicenseID, AntragsID, ref FahrerID,
                ref LicenseKlasseID, ref AusstellungsDatum, ref AblaufDatum, ref Notizen, ref BezahlteGebühren,
                ref IsAktive, ref AusstellungsGrund, ref ErstelltVonBenutzerID);

            //if record found
            if (IsFound)
            {
                //we return a new Constructor with the Parameters 
                return new clsLicenseDaten(LicenseID, AntragsID, FahrerID, LicenseKlasseID,
                  AusstellungsDatum, AblaufDatum, Notizen, BezahlteGebühren, (enAusstellungsGrund)AusstellungsGrund, ErstelltVonBenutzerID, IsAktive);

            }
            else
                //if not found return null
                return null;

        }
        public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseKlasseID)
        {
            return clsLicenseDatenZugriff.GetActiveLicenseIDByPersonID(PersonID, LicenseKlasseID);
        }

        public static bool IsLicenseExistsForThisPersonID(int PersonID, int LicenseKlasseID)
        {
            return (GetActiveLicenseIDByPersonID(PersonID, LicenseKlasseID) != -1);
        }
        private static string GetAusstellungsGrundText(enAusstellungsGrund Grund)
        {
            switch (Grund)
            {
                case enAusstellungsGrund.Erstmal:
                    return "Erstmal";

                case enAusstellungsGrund.Erneuern:
                    return "Erneurn des Führerscheins";

                case enAusstellungsGrund.ErsatzFürBeschädigtenFührerschein:
                    return "Ersatz für einen beschädigten Führerschein";

                case enAusstellungsGrund.ErsatzFürVerlorenenFührerschein:
                    return "Ersatz für einen verlorenen Führerschein";

                default:
                    return "Erstmal";
            }
            
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    if (_UpdateLicense())
                        return true;
                    else
                        return false;
            }
            return true;
        }

        public static bool DeactiveLicense(int LicenseID)
        {
            return clsLicenseDatenZugriff.DeactivateLicense(LicenseID);
        }

        public bool DeactiveCurrentLicense()
        {
            return clsLicenseDaten.DeactiveLicense(this.LicenseID);
        }
        public static DataTable GetAllLicenses()
        {
            return clsLicenseDatenZugriff.GetAllLicenses();
        }

        public bool ReleaseDetainedLicense(int FreigabeBeiBenutzerID, ref int AntragsID)
        {
            //ReleaseDetainedLLicense  bedeutet so viel wie Freigabe beschlagnahmter Führerschein
            //zuerst erstellen wir einen Antrag
            clsAnträge Antrag = new clsAnträge();

            Antrag.AntragsPersonID = this.FahrerInfo.PersonID;
            Antrag.AntragsDatum = DateTime.Now;
            Antrag.AntragsKategorieID = (int)clsAnträge.enAntragsKategorie.FreigabeBeschlagnahmterFahrerlaubnis;
            Antrag.AntragsStatus = clsAnträge.enAntragsStatus.Completed;
            Antrag.LetztesStatusDatum = DateTime.Now;
            Antrag.BezahlteGebühren = clsAntragsKategorien.Find((int)clsAnträge.enAntragsKategorie.FreigabeBeschlagnahmterFahrerlaubnis).Gebühren;
            Antrag.ErstelltVonBenutzer = FreigabeBeiBenutzerID;

            if(!Antrag.Save())
            {
                AntragsID = -1;
                return false;
            }

            AntragsID = Antrag.AntragsID;

            return this.BeschlagnahmeLicenseInfo.ReleaseDetainedLicense(FreigabeBeiBenutzerID, AntragsID);
        }

        public  clsLicenseDaten RenewLicense(string Notizen, int ErstelltBeiBenutzerID)
        {
            // zuerst einen neuen Antrag erstellen

            clsAnträge Antrag = new clsAnträge();

            Antrag.AntragsPersonID = this.FahrerInfo.PersonID;
            Antrag.AntragsDatum = DateTime.Now;
            Antrag.AntragsKategorieID = (int)clsAnträge.enAntragsKategorie.FreigabeBeschlagnahmterFahrerlaubnis;
            Antrag.AntragsStatus = clsAnträge.enAntragsStatus.Completed;
            Antrag.LetztesStatusDatum = DateTime.Now;
            Antrag.BezahlteGebühren = clsAntragsKategorien.Find((int)clsAnträge.enAntragsKategorie.FahrerlaubnisErneuern).Gebühren;
            Antrag.ErstelltVonBenutzer = ErstelltBeiBenutzerID;

            if(!Antrag.Save())
            {
                return null;
            }

            clsLicenseDaten neuLicense = new clsLicenseDaten();

            neuLicense.AntragsID = Antrag.AntragsID;
            neuLicense.FahrerID = this.FahrerID;
            neuLicense.LicenseKlasseID = this.LicenseKlasseID;
            neuLicense.AusstellungsDatum = DateTime.Now;

       
            neuLicense.AblaufDatum = DateTime.Now.AddYears(this.LicenseKlassenInfo.StandardGültigkeit);
            neuLicense.Notitzen = Notizen;
            neuLicense.BezahlteGebühren = this.LicenseKlassenInfo.KlasseGebühren;
            neuLicense.IsAktive = true;
            neuLicense.AusstellungsGrund = clsLicenseDaten.enAusstellungsGrund.Erneuern;
            neuLicense.ErstelltVonBeNutzerID = ErstelltBeiBenutzerID;

            if(!neuLicense.Save())
            {
                return null;
            }

            // wie deaktivieren hier den Alten Führerschein
            //man darf nur einen aktiven Führerschein haben.
            DeactiveCurrentLicense();

            return neuLicense;
        }

        public clsLicenseDaten Replace(string Notizen,enAusstellungsGrund AusstellungsGrund, int ErstelltBeiBenutzerID)
        {
            clsAnträge Antrag = new clsAnträge();

            Antrag.AntragsPersonID = this.FahrerInfo.PersonID;
            Antrag.AntragsDatum = DateTime.Now;

            Antrag.AntragsKategorieID = (AusstellungsGrund == enAusstellungsGrund.ErsatzFürBeschädigtenFührerschein) ?
                 (int)clsAnträge.enAntragsKategorie.BeschädigteFahrerlaubnisErsetzen  :
                 (int)clsAnträge.enAntragsKategorie.VerloreneFahrerlaubnisErsetzen;

            Antrag.AntragsStatus = clsAnträge.enAntragsStatus.Completed;
            Antrag.LetztesStatusDatum = DateTime.Now;
            Antrag.BezahlteGebühren = clsAntragsKategorien.Find(Antrag.AntragsKategorieID).Gebühren;
            Antrag.ErstelltVonBenutzer = ErstelltBeiBenutzerID;

            if(!Antrag.Save())
            {
                return null;
            }
            clsLicenseDaten neuLicense = new clsLicenseDaten();

            neuLicense.AntragsID = Antrag.AntragsID;
            neuLicense.FahrerID = this.FahrerID;
            neuLicense.LicenseKlasseID = this.LicenseKlasseID;
            neuLicense.AusstellungsDatum = DateTime.Now;


            neuLicense.AblaufDatum = DateTime.Now.AddYears(this.LicenseKlassenInfo.StandardGültigkeit);
            neuLicense.Notitzen = Notizen;
            neuLicense.BezahlteGebühren = 0;  //Keine Gebühren Für den Ersatz Dokumente
            neuLicense.IsAktive = true;
            neuLicense.AusstellungsGrund = AusstellungsGrund;
            neuLicense.ErstelltVonBeNutzerID = ErstelltBeiBenutzerID;

            if (!neuLicense.Save())
            {
                return null;
            }

            // wie deaktivieren hier den Alten Führerschein
            //man darf nur einen aktiven Führerschein haben.
            DeactiveCurrentLicense();

            return neuLicense;


        }

        public Boolean IsLicenseExpired()
        {
            return (this.AblaufDatum < DateTime.Now);
        }

        public static DataTable GetDriverLiceseByDriverID(int FahrerID)
        {
            return clsLicenseDatenZugriff.GetDriverLicenses(FahrerID);
        }

        public int DetainLicense(float Strafgebühren, int ErstelltBeiBenutzerID)
        {
            clsBeschlagnahmeLicenseDaten BeschlagnahmeLicense = new clsBeschlagnahmeLicenseDaten();

            BeschlagnahmeLicense.LicenseID = this.LicenseID;
            BeschlagnahmeLicense.BeschlagnahmtesDatum = DateTime.Now;
            BeschlagnahmeLicense.StrafGebühren = Convert.ToSingle(Strafgebühren);
            BeschlagnahmeLicense.ErstelltVonBenutzerID = ErstelltBeiBenutzerID;

            if(!BeschlagnahmeLicense.Save())
            {
                return -1;
            }

            return BeschlagnahmeLicense.BeschlagnahmeID;
        }
    }
}
