using MenschenDatenForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace MenschenDataForm
{
    public class clsLokalerFührerscheinAntrag : clsAnträge
    {
        public enum enMode { AddNew = 0, Update = 1}
        public enMode Mode = enMode.AddNew;

        public int LoKalerFührerscheinID { get; set; }
        public int LicenseKlasseID { get; set; }

        public string Vollname
        {
            get { return clsMenschenDaten.Find(AntragsPersonID).Vollname; }
        }

        public clsLicenseKlassen LicenseKlasseInfos;

        public clsLokalerFührerscheinAntrag()
        {
            this.LoKalerFührerscheinID = -1;
            this.LicenseKlasseID = -1;
            Mode = enMode.AddNew;
        }

        private clsLokalerFührerscheinAntrag(int LoKalerFührerscheinID, int LicenseKlasseID,
             int AntragsID, int AntragsPersonID, DateTime AntragsDatum,
                         int AntragsKategorieID, byte AntragsStatus, DateTime LetztesStatusDatum,
                         decimal BezahlteGebühren, int ErstelltVonBenutzer)
        {
            // we fill this Constructor with the Parameter from Base class.
            this.LoKalerFührerscheinID = LoKalerFührerscheinID;
            this.LicenseKlasseID = LicenseKlasseID;
            this.LicenseKlasseInfos = clsLicenseKlassen.Find(LicenseKlasseID);
            this.AntragsID = AntragsID;
            this.AntragsPersonID = AntragsPersonID;
            this.AntragsDatum = AntragsDatum;
            this.AntragsKategorieID = AntragsKategorieID;
            this.AntragsStatus = (clsAnträge.enAntragsStatus) AntragsStatus;
            this.LetztesStatusDatum = LetztesStatusDatum;
            this.BezahlteGebühren = BezahlteGebühren;
            this.ErstelltVonBenutzer = ErstelltVonBenutzer;


            Mode = enMode.Update;
        }

        private bool _AddNewLocalDrivingLicenseApplication()
        {
            this.LoKalerFührerscheinID = clsLokalerFührerscheinAntragZugriff.AddNewLocalDrivingLicenseApplication(this.AntragsID,
                                                                                 this.LicenseKlasseID);
            return (this.LoKalerFührerscheinID != -1);
        }

        private bool _UpdateLocalDrivingLicenseApplication()
        {
            return clsLokalerFührerscheinAntragZugriff.UpdateLocalDrivingLicenseApplication(this.LoKalerFührerscheinID,
                                                                  this.AntragsID, this.LicenseKlasseID);
        }

        public static clsLokalerFührerscheinAntrag FindLocalDrivingApplicationInfoByID(int LoKalerFührerscheinID)
        {
            int AntragsID = -1; int LicenseKlasseID = -1;
            bool found = false;
            found = clsLokalerFührerscheinAntragZugriff.GetLocalDrivingLicenseApplicationInfoByID(LoKalerFührerscheinID,
                                                           ref AntragsID, ref LicenseKlasseID);

            if (found)
            {
                // jetzt finden wir den Antrag
                clsAnträge Antrag = clsAnträge.FindAppByID(AntragsID);

                // wir geben neue Object für diese Person mit den richtigen Daten.
                return new clsLokalerFührerscheinAntrag(LoKalerFührerscheinID, LicenseKlasseID,
               Antrag.AntragsID, Antrag.AntragsPersonID, Antrag.AntragsDatum, Antrag.AntragsKategorieID,
               (byte)Antrag.AntragsStatus, Antrag.LetztesStatusDatum, Antrag.BezahlteGebühren, Antrag.ErstelltVonBenutzer);
            }
            else
                return null;
        }

        public static clsLokalerFührerscheinAntrag FindLocalDrivingApplicationInfoByApplicationID(int AntragsID)
        {
            int LokalerFührerscheinID = -1; int LicenseKlasseID = -1;
            bool found = false;
            found = clsLokalerFührerscheinAntragZugriff.GetLocalDrivingLicenseApplicationInfoByApplicationID(ref LokalerFührerscheinID,
                                                           AntragsID, ref LicenseKlasseID);

            if (found)
            {
                // jetzt finden wir den Antrag
                clsAnträge Antrag = clsAnträge.FindAppByID(AntragsID);

                // wir geben neue Object für diese Person mit den richtigen Daten.
                return new clsLokalerFührerscheinAntrag(LokalerFührerscheinID, LicenseKlasseID,
               Antrag.AntragsID, Antrag.AntragsPersonID, Antrag.AntragsDatum, Antrag.AntragsKategorieID,
               (byte)Antrag.AntragsStatus, Antrag.LetztesStatusDatum, Antrag.BezahlteGebühren, Antrag.ErstelltVonBenutzer);
            }
            else
                return null;
        }

        public bool Save()
        {
            // Because of inheritance first we call the save methode in the base class
            // it will take care of adding all information to the Application table.

            base.Mode =(clsAnträge.enMode) Mode;

            if (!base.Save())
                return false;

            //after saving the data in the base Application we save the data in Sub Application.
            switch(Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalDrivingLicenseApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateLocalDrivingLicenseApplication();
            }
            return true;
        }

        public bool Delete(int LoKalerFührerscheinID)
        {
            bool IstLokalerFührerscheinAntragGelöscht = false;
            bool IstHauptAntragsGelöscht = false;

            //zuerst wir löschen den Antrag für den lokalen Führerschein
            IstLokalerFührerscheinAntragGelöscht = clsLokalerFührerscheinAntragZugriff.DeleteLocalDrivingLicenseApplication(LoKalerFührerscheinID);

            if (!IstLokalerFührerscheinAntragGelöscht)
                return false;

            //dann wir löschen den HauptAntrag.
            IstHauptAntragsGelöscht = base.DeleteApplication();
            return IstHauptAntragsGelöscht;
        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsLokalerFührerscheinAntragZugriff.GetAllLocalDrivingLicenseApplications(); 
        }


        public int GetActiveLicenseID()
        {
            return clsLicenseDaten.GetActiveLicenseIDByPersonID(this.AntragsPersonID, this.LicenseKlasseID);
        }

        public bool IsLicenseIssued()
        {
            return (GetActiveLicenseID() != -1);
        }

        public  bool DoesPassTestType( clsTestTypen.enTestType TestType)
        {
            return clsLokalerFührerscheinAntragZugriff.DoesPassTestType(this.LoKalerFührerscheinID, (int)TestType);
        }

        public byte GetPassedTestCount()
        {
            return clsPrüfungenDaten.GetPassedTestCount(this.LoKalerFührerscheinID);
        }

        public bool PassedAllTests()
        {
            return clsPrüfungenDaten.PassedAllTest(this.LoKalerFührerscheinID);
        }


        public int GetActiveLicense()
        {
            return clsLicenseDaten.GetActiveLicenseIDByPersonID(this.AntragsPersonID, LicenseKlasseID);
        }
        public  bool DoesAttendTestType(clsTestTypen.enTestType TestTypeID)
        {
            // Attend bedeutet sowiel wie absolvieren
            return clsLokalerFührerscheinAntragZugriff.DoesAttendTestType(this.LoKalerFührerscheinID, (int)TestTypeID);
        }

        public byte TotalTrailsPerTest(clsTestTypen.enTestType TestTypeID)
        {
            // Trails bedeutet sowiel wie Versuche..
            return clsLokalerFührerscheinAntragZugriff.TotalTrialsPerTest(this.LoKalerFührerscheinID,(int) TestTypeID);
        }

        public bool IsThereAnActiveScheduledTest(clsTestTypen.enTestType TestTypeID)
        {
             return IsThereAnActiveScheduledTest(this.LoKalerFührerscheinID, TestTypeID);
        }
        public static bool IsThereAnActiveScheduledTest(int LokalerFührerscheinAntragsID, clsTestTypen.enTestType TestTypeID)
        {
            // Die Methode bedeutet , gibt es eine aktiven geplanten Test.
            return clsLokalerFührerscheinAntragZugriff.IsThereAnActiveScheduledTest(LokalerFührerscheinAntragsID, (int)TestTypeID);
        }

        public  clsPrüfungenDaten GetLastTestPerTestType(clsTestTypen.enTestType TestType)
        {
            return clsPrüfungenDaten.FindLastTestPerPersonAndLicenseClassAndTestTypeID(this.AntragsPersonID, this.LicenseKlasseID, (int)TestType);
        }

        public int IssuedLicenseForTheFirsTime(int ErstelltBeiBenutzerID, string Notizen)
        {
            int FahrerID = -1;

            clsFahrerDaten Fahrer = clsFahrerDaten.GetDriverInfoByPersonID(this.AntragsPersonID);

            if (Fahrer == null)
            {
                //zuerst erstellen wir einen neuen Konstruktor von Fahrer Daten
                Fahrer = new clsFahrerDaten();

                Fahrer.PersonID = this.AntragsPersonID;
                Fahrer.ErstelltVonBenutzerID = ErstelltBeiBenutzerID;

                if (Fahrer.Save())
                    FahrerID = Fahrer.FahrerID;
                else
                    return -1;
            }
            else
                 FahrerID = Fahrer.FahrerID;


            //Jetzt wir müssen einen neuen Lokalen Führerschein Für diesen Fahrer erstellen und setzen status zu Compllet

            int LicenseID = CreateNewLicenseForNewDreiver(ErstelltBeiBenutzerID, Notizen, FahrerID);
            return LicenseID;
        }

        private int  CreateNewLicenseForNewDreiver(int ErstelltBeiBenutzerID, string Notizen, int FahrerID )
        {
            int LicenseID = -1;

            //wir erstellen einen neuen Konstruktor von License Daten
            clsLicenseDaten License = new clsLicenseDaten();

            License.AntragsID = this.AntragsID;
            License.FahrerID = FahrerID;
            License.LicenseKlasseID = this.LicenseKlasseID;
            License.AusstellungsDatum = DateTime.Now;
            License.AblaufDatum = this.LicenseKlasseInfos.StandardGültigkeit;
            License.AusstellungsGrund = clsLicenseDaten.enAusstellungsGrund.Erstmal;
            License.Notitzen = Notizen;
            License.BezahlteGebühren = this.LicenseKlasseInfos.KlasseGebühren;
            License.IsAktive = true;
            License.ErstelltVonBeNutzerID = ErstelltBeiBenutzerID;

            if (License.Save())
            //jetzt setzen wir din AntragsStatus zu Completed
            {
                this.SetComplete();
                return License.LicenseID;
            }
            else
                return -1;

        }
    }
}
