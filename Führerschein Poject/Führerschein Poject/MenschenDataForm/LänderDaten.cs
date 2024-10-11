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
    public class clsLänderDaten
    {
        public enum enMode { AddNew = 0, Update= 1}
        enMode _Mode = enMode.AddNew;
        public int LandID { get; set; }
        public string LandsName { get; set; }

        private clsLänderDaten(int id, string name)
        {
            this.LandID = id;
            this.LandsName = name;

            _Mode = enMode.Update;
        }
        public clsLänderDaten()
        {
            this.LandID = -1;
            this.LandsName = "";

            _Mode = enMode.AddNew;
        }

        private bool _AddNewCountry()
        {
            this.LandID = clsLänderDatenZugriff.AddNewCountry(this.LandsName);
            return (this.LandID != 0 && this.LandID != -1);
        }
        

        public static DataTable GetAllCountries()
        {
            return clsLänderDatenZugriff.GetAllCountries();
        }

        public static clsLänderDaten Find(int id)
        {
            string name = "";
            if (clsLänderDatenZugriff.FindCountryInfoByID(id, ref name))
            {
                return new clsLänderDaten(id, name);
            }
            else
                return null;
        }

        public static clsLänderDaten Find(string name)
        {
            int id = -1;
            if (clsLänderDatenZugriff.FindByName(ref id, name))
            {
                return new clsLänderDaten(id, name);
            }
            else
                return null;
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCountry())
                    {
                        _Mode = enMode.AddNew;
                        return true;
                    }
                    else
                        return false;
            }
            return false;
        }
    }
}
