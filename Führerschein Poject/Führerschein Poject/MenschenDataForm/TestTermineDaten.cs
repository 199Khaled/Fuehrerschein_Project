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
    public class clsTestTermineDaten
    {
        public enum enMode { AddNew = 0, Update = 1}
        public enMode Mode = enMode.AddNew;

        public int TestTerminID { get; set; }
        public clsTestTypen.enTestType TestTypeID { get; set; }
        public int LokalerFührerscheinAntragsID { get; set; }
        public DateTime TerminDatum { get; set; }
        public decimal BezahlteGebühren { get; set; }
        public int ErstelltVonBenutzerID { get; set; }
        public int WiederholungsTest_AntragsID { get; set; }
        public bool istGesperrt { get; set; }


        public int TestID
        {
            get { return _GetTestID(); }
        }

        public clsTestTermineDaten()
        {
            this.TestTerminID = -1;
            this.TestTypeID = clsTestTypen.enTestType.SehTest;
            this.LokalerFührerscheinAntragsID = -1;
            this.TerminDatum = DateTime.Now;
            this.BezahlteGebühren = 0;
            this.ErstelltVonBenutzerID = -1;
            this.WiederholungsTest_AntragsID = -1;
            this.istGesperrt = false ;
            Mode = enMode.AddNew;
        }

        private clsTestTermineDaten(int TesTerminID, int TesTypeID, int LokalerFührerscheinAntragsID, DateTime TerminDatum,
           decimal BezahlteGebühren, int ErstelltVonBenutzerID, int WiederholungsTest_AntragsID,bool istGesperrt)
        {
            this.TestTerminID = TesTerminID;
            this.TestTypeID = (clsTestTypen.enTestType)TestTypeID;
            this.LokalerFührerscheinAntragsID = LokalerFührerscheinAntragsID;
            this.TerminDatum = TerminDatum;
            this.BezahlteGebühren = BezahlteGebühren;
            this.ErstelltVonBenutzerID = ErstelltVonBenutzerID;
            this.WiederholungsTest_AntragsID = WiederholungsTest_AntragsID;
            this.istGesperrt = istGesperrt;
            Mode = enMode.Update;
        }

        private int _GetTestID()
        {
            return clsTestTermineDatenZugriff.GetTestID(this.TestTerminID);
        }

        private bool _AddNewTestAppointment()
        {
            this.TestTerminID = clsTestTermineDatenZugriff.AddNewTestAppointment((int)this.TestTypeID, this.LokalerFührerscheinAntragsID,
           this.TerminDatum, this.BezahlteGebühren, this.ErstelltVonBenutzerID,this.WiederholungsTest_AntragsID, this.istGesperrt);

            return (this.TestTerminID != -1);
        }

        private bool _UpdateTestAppiontemt()
        {
            return clsTestTermineDatenZugriff.UpdateTestAppointment(this.TestTerminID, (int)this.TestTypeID, this.LokalerFührerscheinAntragsID,
            this.TerminDatum, this.BezahlteGebühren, this.ErstelltVonBenutzerID,this.WiederholungsTest_AntragsID, this.istGesperrt);
        }

        public static clsTestTermineDaten GetTestAppointmentInfosByID(int TestTerminID)
        {
            int TestTypeID = -1;int LokalerFührerscheinAntragsID = -1; DateTime TerminDatum = DateTime.Now;
            decimal BezahlteGebühren = 0; int ErstelltVonBenutzerID = -1;
            int WiederholungsTest_AntragsID = -1; bool istGesperrt = false;
            bool isFound = false;

            isFound = clsTestTermineDatenZugriff.GetTestAppointmentInfosByID(TestTerminID, ref TestTypeID, ref LokalerFührerscheinAntragsID,
                ref TerminDatum, ref BezahlteGebühren, ref ErstelltVonBenutzerID,ref WiederholungsTest_AntragsID, ref istGesperrt);

            if (isFound)
            {
                return new clsTestTermineDaten(TestTerminID, TestTypeID, LokalerFührerscheinAntragsID,
               TerminDatum, BezahlteGebühren, ErstelltVonBenutzerID, WiederholungsTest_AntragsID, istGesperrt);
            }
            else
                return null;
        }

        public static DataTable GetApplicationTestAppointmentInfosPerTestType(int  LokalerFührerscheinAntragsID, int TestTypeID)
        {
            return clsTestTermineDatenZugriff.GetApplicationTestAppointmentPerTestType(LokalerFührerscheinAntragsID, TestTypeID);
        }

        public static DataTable GetAllTestAppointments()
        {
            return clsTestTermineDatenZugriff.GetAllTestAppointments();
        }

        public static clsTestTermineDaten GetLastTestAppointment(int LokalerFührerscheinAntragsID, int TestTypeID)
        {
            int TestTerminID = -1; DateTime TerminDatum = DateTime.Now; decimal BezahlteGebühren = 0;
            int ErstelltVonBenutzerID = -1; int WiederholungsTest_AntragsID = -1;  bool istGeperrt = false;
            bool isFound = false;

            isFound = clsTestTermineDatenZugriff.GetLastTestAppointment(ref TestTerminID, TestTypeID, LokalerFührerscheinAntragsID,
           ref TerminDatum, ref BezahlteGebühren, ref ErstelltVonBenutzerID,ref WiederholungsTest_AntragsID, ref istGeperrt);

            if (isFound)
            {
                return new clsTestTermineDaten(TestTerminID, TestTypeID, LokalerFührerscheinAntragsID, TerminDatum,
                                BezahlteGebühren, ErstelltVonBenutzerID, WiederholungsTest_AntragsID, istGeperrt);
            }
            else
                return null;
         }

        public  bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateTestAppiontemt();
            }
            return true;
        }
    }
}
