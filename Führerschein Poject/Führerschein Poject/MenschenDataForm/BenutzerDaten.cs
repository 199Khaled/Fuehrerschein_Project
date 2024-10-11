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
    public class clsBenutzerDaten
    {
       public enum enMode { AddNew = 0, Update = 1}
       public enMode _Mode = enMode.AddNew;

        public int BenutzerID { get; set; }
        public string BenutzerName { get; set; }
        public string Password { get; set; }
        public bool  IsAktive { get; set; }
        public int PersonID { get; set; }

        public clsMenschenDaten PersonInfo;

        public clsBenutzerDaten()
        {
            this.BenutzerID = -1;
            this.BenutzerName = "";
            this.Password = "";
            this.IsAktive = true;
            this.PersonID = -1;
            _Mode = enMode.AddNew;
        } 
        private clsBenutzerDaten(int id, string benutzerName, string password, bool isAktive, int personId)
        {
            this.BenutzerID = id;
            this.BenutzerName = benutzerName;
            this.Password = password;
            this.IsAktive = isAktive;
            this.PersonID = personId;
            this.PersonInfo = clsMenschenDaten.Find(PersonID);
            _Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            // call DataAccess Layer
            this.BenutzerID = clsBenutzerDatenZugriff.AddNewUser(this.BenutzerName, this.Password,
                                                                 this.IsAktive, this.PersonID);
            return (BenutzerID != -1);
        }
        private bool _UpdateUser()
        {
            // call DataAccess Layer
            return clsBenutzerDatenZugriff.UpdateUser(this.BenutzerID, this.BenutzerName,                                                          this.Password, this.IsAktive, this.PersonID);
        }
        public static clsBenutzerDaten FindByUserID(int BenutzerID)
        {
            string BenutzerName = ""; string Password = ""; bool isAktive = false; int PersonID = -1;

            bool isFound = clsBenutzerDatenZugriff.FindByUserID(BenutzerID, ref BenutzerName, ref Password,
                                                              ref isAktive, ref PersonID);
            if (isFound)
            {
                return new clsBenutzerDaten(BenutzerID, BenutzerName, Password, isAktive, PersonID);
            }
            else
                return null;
        }

        public static clsBenutzerDaten FindUserByPersonID(int PersonID)
        {
            int BenutzerID = -1; string BenutzerName = ""; string Password = ""; bool isAktive = false;

            bool isFound = clsBenutzerDatenZugriff.FindUserByPersonID(ref BenutzerID, ref BenutzerName, ref Password,
                                                              ref isAktive,  PersonID);
            if (isFound)
            {
                return new clsBenutzerDaten(BenutzerID, BenutzerName, Password, isAktive, PersonID);
            }
            else
                return null;
        }

        public static clsBenutzerDaten FindByUserNameAndPassword(string BenutzerName, string Password)
        {
            int BenutzerID = -1; bool isAktive = false; int PersonID = -1;

            bool isFound = clsBenutzerDatenZugriff.FindByUserNameAndPassword(ref BenutzerID, BenutzerName,
                                                                             Password , ref isAktive, ref PersonID);
            if (isFound)
            {
                // we return the object of that user with the rigth data
                return new clsBenutzerDaten(BenutzerID, BenutzerName, Password, isAktive, PersonID);
            }
            else
                return null;
        }

        public static DataTable GetAllUsers()
        {
            return clsBenutzerDatenZugriff.GetAllUsers();
        }

        public static bool Delete(int BenutzerID)
        {
            return clsBenutzerDatenZugriff.DeleteBenutzer(BenutzerID);
        }
        public static bool IsUserExist(string BenutzerName)
        {
            return clsBenutzerDatenZugriff.IsUserExistByBenutzerName(BenutzerName);
        }

        public static bool IsUserExist(int BenutzerID)
        {
            return clsBenutzerDatenZugriff.IsUserExistByBenutzerID(BenutzerID);
        }
        public static bool IsUserExistForPersonID(int PersonID)
        {
            return clsBenutzerDatenZugriff.IsUserExistForPersonID(PersonID);
        }
        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    if (_UpdateUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
            }
            return true;
        }
    }
}
