using MenschenDatenForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MenschenDataForm
{
    public class clsLicenseKlassen
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;
        public int LicenseKlasseID { get; set; }

        public string LicenseKlasseName { get; set; }

        public string LicenseKlasseBeschreibung { get; set; }

        public byte MidestAlter { get; set; }

        public byte StandardGültigkeit { get; set; }

        public float KlasseGebühren { get; set; }

        public clsLicenseKlassen()
        {
            this.LicenseKlasseID = -1;
            this.LicenseKlasseName = "";
            this.LicenseKlasseBeschreibung = "";
            this.MidestAlter = 18;
            this.StandardGültigkeit = 10;
            this.KlasseGebühren = 0;
            Mode = enMode.AddNew;
        }
        
        private clsLicenseKlassen(int LicenseKlasseID, string LicenseKlasseName, string LicenseKlasseBeschreibung,
                                 byte MindestAlter , byte StandardGültigkeit, float KlasseGebühren)
        {
            this.LicenseKlasseID = LicenseKlasseID;
            this.LicenseKlasseName = LicenseKlasseName;
            this.LicenseKlasseBeschreibung = LicenseKlasseBeschreibung;
            this.MidestAlter = MindestAlter;
            this.StandardGültigkeit = StandardGültigkeit;
            this.KlasseGebühren = KlasseGebühren;
            Mode = enMode.Update;
        }
        
        public static DataTable GetAllLicenseClasses()
        {
            return clsLicenseKlassenZugriff.GetAllLicenseClasses();
        }

        public static clsLicenseKlassen Find(int LicenseKlasseID)
        {
            string LicenseKlasseName = ""; string LicenseKlasseBeschreibung = ""; byte MindestAlter = 10;
            byte StandardGültigkeit = 18; float KlasseGebühren = 0;

            if (clsLicenseKlassenZugriff.GetLicenseClassInfoByID(LicenseKlasseID, ref LicenseKlasseName, ref LicenseKlasseBeschreibung,
                           ref MindestAlter, ref StandardGültigkeit, ref KlasseGebühren))
            {
                return new clsLicenseKlassen(LicenseKlasseID, LicenseKlasseName, LicenseKlasseBeschreibung,
                                             MindestAlter, StandardGültigkeit, KlasseGebühren);
            }
            else
                return null;
        }

        public static clsLicenseKlassen Find(string LicenseKlassenName)
        {
            int LicenseKlasseID = -1; string LicenseKlasseBeschreibung = ""; byte MindestAlter = 18;
            byte StandardGültigkeit = 10; float KlasseGebühren = 0;

            if (clsLicenseKlassenZugriff.GetLicenseClassInfoByClassName(ref LicenseKlasseID, LicenseKlassenName, ref LicenseKlasseBeschreibung,
                           ref MindestAlter, ref StandardGültigkeit, ref KlasseGebühren))
            {
                return new clsLicenseKlassen(LicenseKlasseID, LicenseKlassenName, LicenseKlasseBeschreibung,
                                             MindestAlter, StandardGültigkeit, KlasseGebühren);
            }
            else
                return null;
        }

    
    }
}
