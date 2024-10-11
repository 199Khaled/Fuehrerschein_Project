using MenschenDatenForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace MenschenDataForm
{
    public class clsAnträge
    {
        public enum enMode { AddNew = 0,Update = 1}
        public enMode Mode = enMode.AddNew;

        public enum enAntragsKategorie { NeueFahrerlaubnis = 1, FahrerlaubnisErneuern = 2,
                     VerloreneFahrerlaubnisErsetzen = 3, BeschädigteFahrerlaubnisErsetzen = 4,
                    FreigabeBeschlagnahmterFahrerlaubnis = 5, NeueInternationalerFahrerlaubnis = 6,
                    PrüfungWiederholen = 10}
       
        public enum enAntragsStatus { New = 1, Cancelled = 2, Completed = 3}

        public int AntragsID { get; set; }
        public int AntragsPersonID { get; set; }

        public string AntragsPersonVollname
        {
            //composition for Person vollname
            get { return clsMenschenDaten.Find(AntragsPersonID).Vollname; }
        }
        
        public DateTime AntragsDatum { get; set; }
        public int AntragsKategorieID { get; set; }

        public clsAntragsKategorien AntagsKategoreiInfo;
        public DateTime LetztesStatusDatum { get; set; }
        public decimal BezahlteGebühren { get; set; }
        public int ErstelltVonBenutzer { get; set; }
        public enAntragsStatus AntragsStatus { get; set; }
        public string StatusText
        {
            get
            {
                switch(AntragsStatus)
                {
                    case enAntragsStatus.New:
                        return "New";
                    case enAntragsStatus.Cancelled:
                        return "Cancelled";
                    case enAntragsStatus.Completed:
                        return "Completed";
                    default:
                        return "UnKnown";
                }
            }
        }

        // I do here composition for Person and User
        public clsMenschenDaten PersonInfo;
        public clsBenutzerDaten BenutzerInfo;

        private clsAnträge(int AntragsID, int AntragsPersonID, DateTime AntragsDatum, 
                         int AntragsKategorieID, enAntragsStatus AntragsStatus, DateTime LetztesStatusDatum,
                         decimal BezahlteGebühren, int ErstelltVonBenutzer)
        {
            this.AntragsID = AntragsID;
            this.AntragsPersonID = AntragsPersonID;
            this.PersonInfo = clsMenschenDaten.Find(this.AntragsPersonID);
            this.AntragsDatum = AntragsDatum;
            this.AntragsKategorieID = AntragsKategorieID;
            // composition for AntragsKategorien.
            this.AntagsKategoreiInfo = clsAntragsKategorien.Find(this.AntragsKategorieID);
            this.AntragsStatus = AntragsStatus;
            this.LetztesStatusDatum = LetztesStatusDatum;
            this.BezahlteGebühren = BezahlteGebühren;
            this.ErstelltVonBenutzer = ErstelltVonBenutzer;
            this.BenutzerInfo = clsBenutzerDaten.FindByUserID(this.ErstelltVonBenutzer);

            Mode = enMode.Update;
        }

        public clsAnträge()
        {
            this.AntragsID = -1;
            this.AntragsPersonID = -1;
            this.AntragsDatum = DateTime.Now;
            this.AntragsKategorieID = -1;
            this.AntragsStatus = enAntragsStatus.New;
            this.LetztesStatusDatum = DateTime.Now;
            this.BezahlteGebühren = 0;
            this.ErstelltVonBenutzer = -1;

            Mode = enMode.AddNew;
        }

        private bool _AddNewApplication()
        {
            this.AntragsID = clsAnträgeZugriff.AddNewApplication(this.AntragsPersonID, this.AntragsDatum,
                                     this.AntragsKategorieID, (byte)this.AntragsStatus, this.LetztesStatusDatum,
                                     this.BezahlteGebühren,this.ErstelltVonBenutzer);

            return (this.AntragsID != -1);
        }

        private bool _UpdateApplication()
        {
            return clsAnträgeZugriff.UpdateApplication(this.AntragsID, this.AntragsPersonID, this.AntragsDatum,
                                     this.AntragsKategorieID, (byte)this.AntragsStatus, this.LetztesStatusDatum,
                                     this.BezahlteGebühren, this.ErstelltVonBenutzer);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateApplication();
            }

            return true;
        }

        public bool DeleteApplication()
        {
            
            return clsAnträgeZugriff.DeleteApplication(this.AntragsID);
        }

        public static bool IsApplicationExist(int AntragsID)
        {
            return clsAnträgeZugriff.IsApplicationExist(AntragsID);
        }

        public static DataTable GetAllApplication()
        {
            return clsAnträgeZugriff.GetAllApplication();
        }

        public static clsAnträge FindAppByID(int AntragsID)
        {
            int AntragsPersonID = -1; DateTime AntragsDatum = DateTime.Now; int AntragsKategorieID = -1;
            byte AntragsStatus = 0; DateTime LetztesStatusDatum = DateTime.Now;
            decimal BezahlteGebühren = 0;int ErstelltVonBenutzer = -1;

            bool found = false;
            found = clsAnträgeZugriff.GetApplicationInfoByID(AntragsID, ref AntragsPersonID, ref AntragsDatum,
                   ref AntragsKategorieID, ref AntragsStatus, ref LetztesStatusDatum,
                                  ref BezahlteGebühren, ref ErstelltVonBenutzer);

            if (found)
                return new clsAnträge(AntragsID, AntragsPersonID, AntragsDatum, AntragsKategorieID,
                         (enAntragsStatus)AntragsStatus, LetztesStatusDatum, BezahlteGebühren, ErstelltVonBenutzer);
            else
                return null;
        }

        public static int GetActivApplicationIDForLicenseClass(int AntragsPerson, int AntragsKategorie,int FührerscheinKlasseID )
        {
            return clsAnträgeZugriff.GetAktiveApplicationIDForLicenseClass(AntragsPerson, AntragsKategorie, FührerscheinKlasseID);
        }

        public bool Cancle()
        {
            return clsAnträgeZugriff.UpdateStatus(this.AntragsID,2);
        }

        public bool SetComplete()
        {
            return clsAnträgeZugriff.UpdateStatus(this.AntragsID, 3);
        }


    }
}
