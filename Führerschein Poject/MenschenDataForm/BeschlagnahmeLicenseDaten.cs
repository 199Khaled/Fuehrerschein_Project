using MenschenDatenForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MenschenDataForm
{
    public class clsBeschlagnahmeLicenseDaten
    {
        public enum enMode { AddNew = 0, Update= 1 }
        public enMode Mode = enMode.AddNew;
        public int BeschlagnahmeID { get; set; }
        public int LicenseID { get; set; }
        public clsLicenseDaten LicenseInfo;
        public DateTime BeschlagnahmtesDatum { get; set; }
        public float StrafGebühren { get; set; }
        public int ErstelltVonBenutzerID { get; set; }
        public clsBenutzerDaten BenutzerInfo;
        public clsBenutzerDaten FreigegebenBeiBenutzerInfo;
        public bool IstFreigegeben { get; set; }
        public DateTime FreigabeDatum { get; set; }
        public int FreigegebenVonBenutzerID { get; set; }
        public int FreigabeAntragsID { get; set; }

        public clsBeschlagnahmeLicenseDaten()
        {
            this.BeschlagnahmeID = -1;
            this.LicenseID = -1;
            this.BeschlagnahmtesDatum = DateTime.Now;
            this.StrafGebühren = 0;
            this.ErstelltVonBenutzerID = -1;
            this.IstFreigegeben = false;
            this.FreigabeDatum = DateTime.MaxValue;
            this.FreigegebenVonBenutzerID = 0;
            this.FreigabeAntragsID = -1;

            Mode = enMode.AddNew;
        }

        private clsBeschlagnahmeLicenseDaten(int BeschlagnahmeID, int LicenseID, DateTime BeschlagnahmtesDatum,
            float StrafGebühren, int ErstelltVonBenutzerID, bool IstFreigegeben, DateTime FreigabeDatum,
            int FreigegebenVonBenutzerID, int FreigabeAntragsID)
        {
            this.BeschlagnahmeID = BeschlagnahmeID;
            this.LicenseID = LicenseID;
            this.BeschlagnahmtesDatum = BeschlagnahmtesDatum;
            this.StrafGebühren = StrafGebühren;
            this.ErstelltVonBenutzerID = ErstelltVonBenutzerID;
            this.BenutzerInfo = clsBenutzerDaten.FindByUserID(this.ErstelltVonBenutzerID);
            this.IstFreigegeben = IstFreigegeben;
            this.FreigabeDatum = FreigabeDatum;
            this.FreigegebenVonBenutzerID = FreigegebenVonBenutzerID;
            this.FreigegebenBeiBenutzerInfo = clsBenutzerDaten.FindUserByPersonID(this.FreigegebenVonBenutzerID);
            this.FreigabeAntragsID = FreigabeAntragsID;

            Mode = enMode.Update;

        }

        private bool _AddNewDetainedLicense()
        {
            this.BeschlagnahmeID  = clsBeschlagnameLicenseZugriffDaten.AddNewDetainedLicense(this.LicenseID,
                this.BeschlagnahmtesDatum, this.StrafGebühren, this.ErstelltVonBenutzerID);

            return (this.BeschlagnahmeID != -1);
        }

        private bool _UpdateDetainedLicense()
        {
            return clsBeschlagnameLicenseZugriffDaten.UpdateDetainedLicense(this.BeschlagnahmeID,this.LicenseID,
                this.BeschlagnahmtesDatum, this.StrafGebühren, this.ErstelltVonBenutzerID, this.IstFreigegeben);
        }

        public static clsBeschlagnahmeLicenseDaten Find(int BeschlagnahmeID)
        {
            int LicenseID = -1; DateTime BeschlagnahmtesDatum = DateTime.Now; float StrafGebühren = 0;
            int ErstelltVonBenutzerID = -1; bool IstFreigegeben = false; DateTime FreigabeDatum = DateTime.MaxValue;
            int FreigegebenVonBenutzerID = 0; int FreigabeAntragsID = -1;

            bool isFound = clsBeschlagnameLicenseZugriffDaten.GetDetainedLicenseInfoByID(BeschlagnahmeID,
               ref LicenseID, ref BeschlagnahmtesDatum, ref StrafGebühren, ref ErstelltVonBenutzerID,
               ref IstFreigegeben, ref FreigabeDatum, ref FreigegebenVonBenutzerID, ref FreigabeAntragsID);

            if (isFound)
            {
                // wir liefern einen neuen Kostruktor mit den Daten
                return new clsBeschlagnahmeLicenseDaten(BeschlagnahmeID, LicenseID, BeschlagnahmtesDatum,
                   StrafGebühren, ErstelltVonBenutzerID, IstFreigegeben, FreigabeDatum, FreigegebenVonBenutzerID,
                   FreigabeAntragsID);
            }
            else
                //else return null
                return null;

        }

        public static DataTable GetAllDetainedLicenses()
        {
            return clsBeschlagnameLicenseZugriffDaten.GetAllDetainedLicenses();
        }
        public static  clsBeschlagnahmeLicenseDaten FindByLicenseID(int LicenseID)
        {
            int BeschlagnahmeID = -1; DateTime BeschlagnahmtesDatum = DateTime.Now; float StrafGebühren = 0;
            int ErstelltVonBenutzerID = -1; bool IstFreigegeben = false; DateTime FreigabeDatum = DateTime.MaxValue;
            int FreigegebenVonBenutzerID = 0; int FreigabeAntragsID = -1;

            bool isFound = clsBeschlagnameLicenseZugriffDaten.GetDetainedLicenseInfoByLicenseID(ref BeschlagnahmeID,
               LicenseID, ref BeschlagnahmtesDatum, ref StrafGebühren, ref ErstelltVonBenutzerID,
               ref IstFreigegeben, ref FreigabeDatum, ref FreigegebenVonBenutzerID, ref FreigabeAntragsID);

            if (isFound)
            {
                // wir liefern einen neuen Kostruktor mit den Daten
                return new clsBeschlagnahmeLicenseDaten(BeschlagnahmeID, LicenseID, BeschlagnahmtesDatum,
                   StrafGebühren, ErstelltVonBenutzerID, IstFreigegeben, FreigabeDatum, FreigegebenVonBenutzerID,
                   FreigabeAntragsID);
            }
            else
                //else return null
                return null;
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDetainedLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateDetainedLicense();
            }
            return true;
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsBeschlagnameLicenseZugriffDaten.IsLicenseDetained(LicenseID);
        }

        public static bool IsLicenseReleased(int LicenseID)
        {
            return clsBeschlagnameLicenseZugriffDaten.IsLicenseReleased(LicenseID);
        }

        public bool ReleaseDetainedLicense(int FreigegebenVonBenutzerID,int FreigabeAntragsID)
        {
            return clsBeschlagnameLicenseZugriffDaten.ReleaseDetainedLicense(this.BeschlagnahmeID, FreigegebenVonBenutzerID, FreigabeAntragsID);
        }
 
    }
}
