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
    public class clsInternationFührerscheinAntragDaten :clsAnträge
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;
        public int InternationalLicenseID { get; set; }
        public int FahrerID { get; set; }
        public int AusstellungsMitLokalerLicenseID { get; set; }
        public DateTime AusstellungsDatum { get; set; }
        public DateTime AblaufDatum { get; set; }
        public bool IsAktive { get; set; }

        public clsFahrerDaten FahrerInfo;
      


        public clsInternationFührerscheinAntragDaten()
        {
            this.InternationalLicenseID = -1;
            this.FahrerID = -1;
            this.AusstellungsMitLokalerLicenseID = -1;
            this.AusstellungsDatum = DateTime.Now;
            this.AblaufDatum = DateTime.Now.AddYears(5);
            this.IsAktive = true;
            //here we set the Application type to new international license
            this.AntragsKategorieID = (int)clsAnträge.enAntragsKategorie.NeueInternationalerFahrerlaubnis;

            Mode = enMode.AddNew;
        }

        private clsInternationFührerscheinAntragDaten(int InternationalLicenseID,int FahrerID,
            int AusstellungsMitLokalerLicenseID, DateTime AusstellungsDatum, DateTime AblaufDatum, 
            bool IsAktive,
            int AntragsID, int AntragsPersonID, DateTime AntragsDatum ,enAntragsStatus AntragsStatus,
             DateTime LetzteStatusDatum, decimal BezahlteGebühren, int ErstelltBeiBenutzerID)
        {
            //first we fill the base Application
            base.AntragsKategorieID = (int)clsAnträge.enAntragsKategorie.NeueInternationalerFahrerlaubnis;
            base.AntragsID = AntragsID;
            base.AntragsPersonID = AntragsPersonID;
            base.AntragsDatum = AntragsDatum;
            base.AntragsStatus = AntragsStatus;
            base.LetztesStatusDatum = LetzteStatusDatum;
            base.BezahlteGebühren = BezahlteGebühren;
            base.ErstelltVonBenutzer = ErstelltBeiBenutzerID;

            this.InternationalLicenseID = InternationalLicenseID;
            this.AntragsID = AntragsID;
            this.FahrerID = FahrerID;
            this.FahrerInfo = clsFahrerDaten.GetDriverInfoByDriverID(this.FahrerID);
            this.AusstellungsMitLokalerLicenseID = AusstellungsMitLokalerLicenseID;
            this.AusstellungsDatum = AusstellungsDatum;
            this.AblaufDatum = AblaufDatum;
            this.IsAktive = IsAktive;

            Mode = enMode.Update;
        }

        private bool _UpdateInternationalLicense()
        {
            return clsInternationalFührerscheinAntragZugriffsDaten.UpdateInternationalLicense(this.InternationalLicenseID, 
                this.AntragsID, this.FahrerID, this.AusstellungsMitLokalerLicenseID, this.AusstellungsDatum, this.AblaufDatum,
                this.IsAktive,this.ErstelltVonBenutzer);
        }

        private bool _AddNewInternationalLicense()
        {
           this.InternationalLicenseID = clsInternationalFührerscheinAntragZugriffsDaten.AddNewInternationalLicense(this.AntragsID,
              this.FahrerID, this.AusstellungsMitLokalerLicenseID, this.AusstellungsDatum,
                              this.AblaufDatum, this.IsAktive, this.ErstelltVonBenutzer);

            return (this.InternationalLicenseID != -1);
        }
        
        public static clsInternationFührerscheinAntragDaten Find(int InternationalLokalLicenseID)
        {
            
            int AntragsID = -1; int FahrerID = -1; int AusgestelltMitLokalerLicenseID = -1;
            DateTime AusstellungsDatum = DateTime.Now; DateTime AblaufDatum = DateTime.Now;
            bool IsAktive = true; 

            bool isFound = false;

            isFound = clsInternationalFührerscheinAntragZugriffsDaten.GetInternationalLicenseByID(InternationalLokalLicenseID,
                ref AntragsID, ref FahrerID, ref AusgestelltMitLokalerLicenseID, ref AusstellungsDatum, ref AblaufDatum,
                 ref IsAktive);

            if (isFound)
            {
                // now we find the base Application
                clsAnträge Antrag = clsAnträge.FindAppByID(AntragsID);

                return new clsInternationFührerscheinAntragDaten(InternationalLokalLicenseID, FahrerID, AusgestelltMitLokalerLicenseID,
                    AusstellungsDatum, AblaufDatum, IsAktive, Antrag.AntragsID, Antrag.AntragsPersonID, Antrag.AntragsDatum,
                    Antrag.AntragsStatus, Antrag.LetztesStatusDatum, Antrag.BezahlteGebühren,Antrag.ErstelltVonBenutzer);
            }
            else
                return null;
           
        }
        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalFührerscheinAntragZugriffsDaten.GetAllInternationalLicense();
        }

        public static DataTable GetDriverInternationalLicense(int FahrerID)
        {
            return clsInternationalFührerscheinAntragZugriffsDaten.GetDriverInternationalLicense(FahrerID);
        }
        public static int GetActiveInternationalLicenseByDrivingID(int FahrerID)
        {
            return clsInternationalFührerscheinAntragZugriffsDaten.GetActiveInternationalLicenseByDrivingID(FahrerID);
        }

     
        public bool Save()
        {
            // Wir setzen den Modus der Basisklasse auf den aktuellen Modus der abgeleiteten Klasse.
            base.Mode = (clsAnträge.enMode)Mode;

            // Wir rufen die Save-Methode der Basisklasse auf und prüfen, ob sie erfolgreich ist.
            if (!base.Save())
            {
                return false;
            }
               
            switch (Mode)
            {

                case enMode.Update:
                    return _UpdateInternationalLicense();

                case enMode.AddNew:
                    if (_AddNewInternationalLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                

            }
            return true;
        }
    }
}
