using MenschenDatenForm;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MenschenDataForm
{
    public class clsFahrerDaten
    {
        public enum enMode { AddNew = 0, Update = 1}
        public enMode Mode = enMode.AddNew;

        public int FahrerID { get; set; }
        public int PersonID { get; set; }
        public int ErstelltVonBenutzerID { get; set; }
        public DateTime ErstellungsDatum { get; set; }
        public clsMenschenDaten PersonInfo;

        public clsFahrerDaten()
        {
            this.FahrerID = -1;
            this.PersonID = -1;
            this.ErstelltVonBenutzerID = -1;
            this.ErstellungsDatum = DateTime.Now;
            Mode = enMode.AddNew;
        }

        private clsFahrerDaten(int FahrerID, int PersonID, int ErstelltVonBenutzerID, DateTime ErstellungsDatum)
        {
            this.FahrerID = FahrerID;
            this.PersonID = PersonID;
            this.PersonInfo = clsMenschenDaten.Find(PersonID);
            this.ErstelltVonBenutzerID = ErstelltVonBenutzerID;
            this.ErstellungsDatum = ErstellungsDatum;
            Mode = enMode.Update;
        }

        private bool _AddNewDrivers()
        {
            this.FahrerID = clsFahrerDatenZugriff.AddNewDriver(this.PersonID, this.ErstelltVonBenutzerID);
            return (this.FahrerID != -1);
        }
        
        private bool _UpdateDrivers()
        {
            return clsFahrerDatenZugriff.UpdateDriver(this.FahrerID, this.PersonID, this.ErstelltVonBenutzerID);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDrivers())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateDrivers();

            }
            return true;
        }

        public static clsFahrerDaten GetDriverInfoByDriverID(int FahrerID)
        {
            int PersonID = -1; int ErstelltVonBenutzer = -1; DateTime ErstellungsDatum = DateTime.Now;
            bool isFound = false;

            isFound = clsFahrerDatenZugriff.GetDriverInfoByDriverID(FahrerID, ref PersonID, ref ErstelltVonBenutzer, ref ErstellungsDatum);

            if (isFound)
                return new clsFahrerDaten(FahrerID, PersonID, ErstelltVonBenutzer, ErstellungsDatum);
            else
                return null;
        }

        public static clsFahrerDaten GetDriverInfoByPersonID(int PersonID)
        {
            int FahrerID = -1; int ErstelltVonBenutzer = -1; DateTime ErstellungsDatum = DateTime.Now;
            bool isFound = false;

            isFound = clsFahrerDatenZugriff.GetDriverInfoByPersonID(PersonID,ref FahrerID, ref ErstelltVonBenutzer, ref ErstellungsDatum);

            if (isFound)
                return new clsFahrerDaten(FahrerID, PersonID, ErstelltVonBenutzer, ErstellungsDatum);
            else
                return null;
        }

        public static DataTable GetAllDrivers()
        {
            return clsFahrerDatenZugriff.GetAllDrivers();
        }

        public static DataTable GetLicenes(int FahrerID)
        {

            return clsLicenseDaten.GetDriverLiceseByDriverID(FahrerID);
        }
    }
}
