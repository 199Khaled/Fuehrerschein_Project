using MenschenDatenForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MenschenDataForm
{
     public class clsAntragsKategorien
    {
        public enum enMode { AddNew = 0, Update = 1}
        enMode Mode = enMode.AddNew;
        public int ID { get; set; }
        public string Titel { get; set; }
        public decimal Gebühren { get; set;}


        private clsAntragsKategorien(int ID, string Titel, decimal Gebühren)
        {
            this.ID = ID;
            this.Titel = Titel;
            this.Gebühren = Gebühren;
            Mode = enMode.Update;
        }

        private bool _UpdateAntragsKategorie()
        {
            return clsAnträgeKategorieZugriff.UpdateApplication(this.ID,
                 this.Titel, this.Gebühren);
        }
        public static DataTable GetAllApplication()
        {
            return clsAnträgeKategorieZugriff.GetAllApplication();
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.Update:
                    if (_UpdateAntragsKategorie())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
            }
            return true;
        }

        public static clsAntragsKategorien Find(int id)
        {
            string Titel = ""; decimal Gebühren = 0;
            bool isFound = false;
            isFound = clsAnträgeKategorieZugriff.FindApplicationByID(id, ref Titel, ref Gebühren);

            if (isFound)
                return new clsAntragsKategorien(id, Titel, Gebühren);
            else
                return null;

        }
    }
}
