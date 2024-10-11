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
    public class clsTestTypen
    {
        public enum enMode { AddNew = 0, Update = 1}
        enMode _Mode = enMode.AddNew;
        public enum enTestType { SehTest = 1, SchreibTest = 2, FahrTest = 3}

        public clsTestTypen.enTestType ID { get; set; }
        public string TestTypeTitel { get; set; }
        public string TestTypeDescription { get; set; }
        public decimal TestGebühren { get; set; }

        private clsTestTypen(clsTestTypen.enTestType ID, string titel, string testDescrip, decimal Gebühren)
        {
            this.ID = ID;
            this.TestTypeTitel = titel;
            this.TestTypeDescription = testDescrip;
            this.TestGebühren = Gebühren;
            _Mode = enMode.Update;
        }

        public clsTestTypen()
        {
            this.ID = clsTestTypen.enTestType.SehTest;
            this.TestTypeTitel = "";
            this.TestTypeDescription = "";
            this.TestGebühren = 0;
            _Mode = enMode.AddNew;
        }
        
        private bool _AddNewTestType()
        {
            this.ID= (clsTestTypen.enTestType)clsTestTypenZugriff.AddNewTestType(this.TestTypeTitel,
                                                                 this.TestTypeDescription, this.TestGebühren);
            return (this.TestTypeTitel != "");
        }
        private bool _UpdateTestType()
        {
            return clsTestTypenZugriff.UpdateTestType((int)this.ID, this.TestTypeTitel,
                                      this.TestTypeDescription, this.TestGebühren);
        }

        public static clsTestTypen Find(clsTestTypen.enTestType ID)
        {
            string titel = ""; string testDescrip = ""; decimal gebühren = 0;
            bool isFound = false;
            isFound = clsTestTypenZugriff.FindTestType((int)ID, ref titel, ref testDescrip,
                                                              ref gebühren);

            if (isFound)
                return new clsTestTypen(ID, titel, testDescrip, gebühren);
            else
                return null; 
        }

        public static DataTable GetAllTestType()
        {
            return clsTestTypenZugriff.GetAllTestType();
        }

        public bool Save()
        {  
            switch(_Mode)
            {
                case enMode.Update:
                    if (_UpdateTestType())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.AddNew:
                    if (_AddNewTestType())
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
