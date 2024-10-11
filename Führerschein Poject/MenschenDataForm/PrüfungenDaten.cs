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
    public class clsPrüfungenDaten
    {
       public enum enMode { AddNew = 0, Update = 1}
        public enMode Mode = enMode.AddNew;

        public int PrüfungID { get; set; }
        public int TestTerminID { get; set; }
        public clsTestTermineDaten TestTerminInfos;
        public bool TestErgebnis { get; set; }
        public string Notizen { get; set; }
        public int ErstelltVonBenutzerID { get; set; }

        public clsPrüfungenDaten()
        {
            this.PrüfungID = -1;
            this.TestTerminID = -1;
            this.TestErgebnis = false;
            this.Notizen = "";
            this.ErstelltVonBenutzerID = -1;
            Mode = enMode.AddNew;
        }

        private clsPrüfungenDaten(int PrüfungID, int TestTerminID, bool TestErgebnis, string Notizen, int ErstelltVonBenutzerID)
        {
            this.PrüfungID = PrüfungID;
            this.TestTerminID = TestTerminID;
            this.TestTerminInfos = clsTestTermineDaten.GetTestAppointmentInfosByID(TestTerminID);
            this.TestErgebnis = TestErgebnis;
            this.Notizen = Notizen;
            this.ErstelltVonBenutzerID = ErstelltVonBenutzerID;
            Mode = enMode.Update;
        }

        private bool _AddNewTest()
        {
            this.PrüfungID = clsPrüfungenDatenZugriff.AddNewTest(this.TestTerminID, this.TestErgebnis,
                                                            this.Notizen, this.ErstelltVonBenutzerID);

            return (this.PrüfungID != -1);
        }

        private bool _UpdateTest()
        {
            return clsPrüfungenDatenZugriff.UpdateTest(this.PrüfungID,this.TestTerminID, this.TestErgebnis,
                                                            this.Notizen, this.ErstelltVonBenutzerID);
        }

        public static clsPrüfungenDaten Find(int PrüfungID)
        {
            int TestTerminID = -1; bool TestErgebnis = false; string Notizen = "";
            int ErstelltVonBenutzerID = -1; bool isfound = false;

            isfound = clsPrüfungenDatenZugriff.GetTestInfosByID(PrüfungID, ref TestTerminID, ref TestErgebnis,
                                                       ref Notizen, ref ErstelltVonBenutzerID);

            if (isfound)
            {
                //record was found , return record with a daten 
                return new clsPrüfungenDaten(PrüfungID, TestTerminID, TestErgebnis, Notizen, ErstelltVonBenutzerID);
            }
            else
                return null;
        }

        public static clsPrüfungenDaten FindLastTestPerPersonAndLicenseClassAndTestTypeID(int PersonID, int LicenseKlasseID, int TestTypeID)
        {
            int PrüfungID = -1; int TestTerminID = -1; bool TestErgebnis = false; string Notizen = "";
            int ErstelltVonBenutzerID = -1; bool isfound = false;

            isfound = clsPrüfungenDatenZugriff.GetLastTestByPersonAndTestTypeAndLicenseClsse(PersonID, LicenseKlasseID, TestTypeID,
                                           ref PrüfungID, ref TestTerminID, ref TestErgebnis, ref Notizen, ref ErstelltVonBenutzerID);

            if (isfound)
            {
                //record was found , return record with a daten 
                return new clsPrüfungenDaten(PrüfungID, TestTerminID, TestErgebnis, Notizen, ErstelltVonBenutzerID);
            }
            else
                return null;
        }

        public static DataTable GetAllTests()
        {
            return clsPrüfungenDatenZugriff.GetAllTests();
        }

        public static byte GetPassedTestCount(int LokalerFührerscheinAntragsID)
        {
            return clsPrüfungenDatenZugriff.GetPassedTestCount(LokalerFührerscheinAntragsID);
        }
        public static bool PassedAllTest(int LokalerFührerscheinAntragsID)
        {
            //if total passed test less than 3 it will return false otherwise will return 
            return clsPrüfungenDatenZugriff.GetPassedTestCount(LokalerFührerscheinAntragsID) == 3;
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTest())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateTest();
            }
            return true;
        }
    }
}
 