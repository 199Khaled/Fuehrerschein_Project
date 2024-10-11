using Führerschein.Properties;
using MenschenDataForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Führerschein
{
    public partial class ctrTestFestlegen : UserControl
    {
        public enum enMode { AddNew = 0, Update = 1}
        private enMode _Mode = enMode.AddNew;

        public enum enErstellungsModus { ErstmaligZeitPlanZumTest = 0, ZeitplanZumTestWiederholung}
        private enErstellungsModus _ErstellungsModus = enErstellungsModus.ErstmaligZeitPlanZumTest;

        private clsTestTypen.enTestType _TestTypeID = clsTestTypen.enTestType.SehTest;

        private clsLokalerFührerscheinAntrag _LokalerFührerscheinAntrag;
        private int _LokalerFührerscheinAntragsID = -1;

        private clsTestTermineDaten _TestTermine;
        private int _TestTerminID = -1;

        public clsTestTypen.enTestType TestTypeID
        {
            get { return _TestTypeID; }
            set
            {
                _TestTypeID = value;
                
                switch(_TestTypeID)
                {
                    case clsTestTypen.enTestType.SehTest:
                        gbTestType.Text = "theoretische Führerschein_Prüfung";
                        pbTestTypeImage.Image = Resources.Vision_512;
                        break;

                    case clsTestTypen.enTestType.SchreibTest:
                        gbTestType.Text = "Schriftlicher Teil Test";
                        pbTestTypeImage.Image = Resources.Written_Test_512;
                        break;

                    case clsTestTypen.enTestType.FahrTest:
                        gbTestType.Text = "Fahren Test";
                        pbTestTypeImage.Image = Resources.driving_test_512;
                        break;

                }
            }
        }

        public ctrTestFestlegen()
        {
            InitializeComponent();
        }

        public void LoadInfo(DateTime LetztePrüfungsDatum, int LokalerFührerscheinAntragsID, int TestTerminID = -1)
        {
            //if no appointment ID this means AddNew Mode otherwise it is Upadate Mode.
            //wenn es keine Termin ID gibt,bedeutet das AddNew Mode, anderfalls ist UpdatMode;
            if (TestTerminID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

            _LokalerFührerscheinAntragsID = LokalerFührerscheinAntragsID;
            _TestTerminID = TestTerminID;
            _LokalerFührerscheinAntrag = clsLokalerFührerscheinAntrag.FindLocalDrivingApplicationInfoByID(_LokalerFührerscheinAntragsID);

            if(_LokalerFührerscheinAntrag == null)
            {
                MessageBox.Show("Fehler: Keine LokalerFührerschein Object mit der ID = " + _LokalerFührerscheinAntragsID,
                    "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSpeichern.Enabled = false;
                return;
            }

            // Decide if the Creation Mode is retake Test or not based if the Person attended this Test Befor
            // Entscheiden, ob der ErstellungsModus ein WiederholungsPrüfung ist oder nicht,
            // basierd darauf, ob die Person diese Prüfung bereits absolviert hat
            if (_LokalerFührerscheinAntrag.DoesAttendTestType(_TestTypeID))
                _ErstellungsModus = enErstellungsModus.ZeitplanZumTestWiederholung;

            else
                _ErstellungsModus = enErstellungsModus.ErstmaligZeitPlanZumTest;

            if(_ErstellungsModus == enErstellungsModus.ZeitplanZumTestWiederholung && _Mode == enMode.AddNew)
            {
                string PrüfungsWiederholungsGebühren = clsAntragsKategorien.Find((int)clsAnträge.enAntragsKategorie.PrüfungWiederholen).Gebühren.ToString();
                lblWiederholungsAntragGebühren.Text =  PrüfungsWiederholungsGebühren;
                gbWiederholungsTestInfo.Enabled = true;
                lblTitel.Text = "Termin zur WiederholungsPrüfung Festsetzen";
                lblWiederholungsTestAntragsID.Text= "0";

                
                    dtpTestDatum.MinDate = LetztePrüfungsDatum;
            }
            else
            {
                gbWiederholungsTestInfo.Enabled = false;
                lblTitel.Text = "Termin zur Prüfung Festsetzen";
                lblWiederholungsAntragGebühren.Text = "0";
                lblWiederholungsTestAntragsID.Text = "N/A";
                dtpTestDatum.MinDate = DateTime.Now;
            }

            lblLokalerFührerscheinAntragsID.Text = _LokalerFührerscheinAntrag.LoKalerFührerscheinID.ToString();
            lblFührerscheinKlasse.Text = _LokalerFührerscheinAntrag.LicenseKlasseInfos.LicenseKlasseName;
            lblFullName.Text = _LokalerFührerscheinAntrag.AntragsPersonVollname;

            //Das wird die vorherige Versuche für diesen Test  Zeigen
            lblVersuche.Text = _LokalerFührerscheinAntrag.TotalTrailsPerTest(_TestTypeID).ToString();

            if (_Mode == enMode.AddNew)
            {
                lblGebühren.Text = clsTestTypen.Find(_TestTypeID).TestGebühren.ToString();
                lblWiederholungsTestAntragsID.Text = "N/A";
                _TestTermine = new clsTestTermineDaten();
            }
            else
                if (!_LoadTestAppointmentDate())
                    return;

            lblInsgesamteGebühren.Text = (Convert.ToDecimal(lblGebühren.Text) + Convert.ToDecimal(lblWiederholungsAntragGebühren.Text)).ToString();
            // if person has already active test then return 
            if (!_HandleActiveTestAppointmentConstraint())
                return;
            //if the appointment is lockend then return 
            if (!_HandleAppointmentLockedConstraint())
                return;
            //if the person didn't pass the privous test then return
            if (!_HandlePrviousTestConstraint())
                return;
            
        }

        private bool _HandleActiveTestAppointmentConstraint()
        {
            // wir behandlen hier die aktiven TestTermine 
            if(_Mode == enMode.AddNew && clsLokalerFührerscheinAntrag.IsThereAnActiveScheduledTest(_LokalerFührerscheinAntragsID,_TestTypeID))
            {
                lblBenutzerNachricht.Text = "Diese Person hat bereits einen aktiven Termin für diesen Test";
                btnSpeichern.Enabled = false;
                dtpTestDatum.Enabled = false;
                return false;
            }

            return true;
        }

        private bool _HandleAppointmentLockedConstraint()
        {
            //if Appointment is locked that means the Person already sat for this Test
            // we can not update locked Appointment

            //wenn der Termin Gesperrt ist, das bedeutet, dass die Person bereits an diesem Test
            //teilgenommen hat
            //wir können keine gesperrten Termine aktualisieren,
            if(_TestTermine.istGesperrt)
            {
                lblBenutzerNachricht.Visible = true;
                lblBenutzerNachricht.Text = "Diese Person hat bereits an diesem Test teilgenommen, Termin gesperrt.";
                dtpTestDatum.Enabled = false;
                btnSpeichern.Enabled = false;
                return false;
            }
            return true;
        }

        private bool _HandlePrviousTestConstraint()
        {
            //we need to make sure the this Person passed the prvious required Test  before apply to the new Test.
            //Person cannot apply for written Test unless he passed the vision Test.
            //Person cannot apply for street Test unless he passed the written Test.


            // Wir müssen sicherstellen, dass diese Person zuvor den erforderlichen Test bestanden hat, bevor sie sich für den neuen Test bewirbt.
            // Eine Person kann sich nicht für die schriftliche Prüfung bewerben, es sei denn, sie hat den Sehtest bestanden.
            // Eine Person kann sich nicht für die Straßenprüfung bewerben, es sei denn, sie hat die schriftliche Prüfung bestanden.

            switch (TestTypeID)
            {

                case clsTestTypen.enTestType.SehTest:
                    {
                        //in this case no required prvious test to pass
                        lblBenutzerNachricht.Visible = false;
                        return true;
                    }

                case clsTestTypen.enTestType.SchreibTest:
                    {
                        //we check if Person passed VisionTest.
                        if (!_LokalerFührerscheinAntrag.DoesPassTestType(clsTestTypen.enTestType.SehTest))
                        {
                            lblBenutzerNachricht.Text = "Sie müssen ermal den Seh Test bestehen";
                            lblBenutzerNachricht.Visible = true;
                            btnSpeichern.Enabled = false;
                            dtpTestDatum.Enabled = false;
                            return false;
                        }
                        else
                        {
                            lblBenutzerNachricht.Visible = false;
                            btnSpeichern.Enabled = true;
                            dtpTestDatum.Enabled = true;
                        }
                        return true;
                    }

                case clsTestTypen.enTestType.FahrTest:
                    {
                        //we check if Person passed the written test.
                        if (!_LokalerFührerscheinAntrag.DoesPassTestType(clsTestTypen.enTestType.SchreibTest))
                        {
                            lblBenutzerNachricht.Text = "Sie müssen ermal den Schreib Test bestehen";
                            lblBenutzerNachricht.Visible = true;
                            btnSpeichern.Enabled = false;
                            dtpTestDatum.Enabled = false;
                            return false;
                        }
                        else
                        {
                            lblBenutzerNachricht.Visible = false;
                            btnSpeichern.Enabled = true;
                            dtpTestDatum.Enabled = true;
                        }
                        return true;
                    }
            }
            return true;
        }
        private bool _LoadTestAppointmentDate()
        {
            _TestTermine = clsTestTermineDaten.GetTestAppointmentInfosByID(_TestTerminID);
            if (_TestTermine == null)
            {
                MessageBox.Show("Fehler: Keine TestTermin Object mit der ID = " + _TestTerminID,
                    "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSpeichern.Enabled = false;
                return false;
            }

            lblGebühren.Text = _TestTermine.BezahlteGebühren.ToString();
            //we compare the current Date with the Appointment Date to set the MinDate
            //Wir vergleichen das aktulle Datum mit dem TerminDatum ,um das MindestDatum festzulegen
            if (DateTime.Compare(DateTime.Now, _TestTermine.TerminDatum) < 0)
                dtpTestDatum.MinDate = DateTime.Now;
            else
                dtpTestDatum.MinDate = _TestTermine.TerminDatum;   /// das muss koregiert werden

            dtpTestDatum.Value = _TestTermine.TerminDatum;

            if (_TestTermine.WiederholungsTest_AntragsID == -1)
            {
                lblWiederholungsAntragGebühren.Text = "0";
                lblWiederholungsTestAntragsID.Text = "N/A";
            }
            else
            {
                lblWiederholungsAntragGebühren.Text = _TestTermine.BezahlteGebühren.ToString();
                gbWiederholungsTestInfo.Enabled = true;
                lblTitel.Text = "WiederholungsPrüfung";
                lblWiederholungsTestAntragsID.Text = _TestTermine.WiederholungsTest_AntragsID.ToString();
            }
            return true;
        }

        private bool _HandleRetakeApplication()
        {

            if (_TestTermine.istGesperrt)
            {
                lblBenutzerNachricht.Visible = true;
                lblBenutzerNachricht.Text = "Diese Termin ist gesperrt, Wählen Sie bitte einen anderen Termin!";
                dtpTestDatum.Enabled = false;
                btnSpeichern.Enabled = false;
                return false;
            }
            //this will decide to create a seperate application for retake test or not
            //and will create it if  needed, then it will link it to the appointment


            // Dies wird entscheiden, ob eine separate Bewerbung für die Wiederholungsprüfung erstellt werden soll oder nicht,
            // und wird sie erstellen, wenn erforderlich, und dann mit dem Termin verknüpfen.

            if (_Mode == enMode.AddNew &&  _ErstellungsModus == enErstellungsModus.ZeitplanZumTestWiederholung)
            {
                //incase the mode is AddNew and ErstellungsModus is ZeitplanZumTestWiederholung we create a sperator Appoiontment for it,
                //the we link it with the appointmnet

                //first create Application
                clsAnträge Antrag = new clsAnträge();

                Antrag.AntragsPersonID = _LokalerFührerscheinAntrag.AntragsPersonID;
                Antrag.AntragsDatum = DateTime.Now;
                Antrag.AntragsKategorieID = (int)clsAnträge.enAntragsKategorie.PrüfungWiederholen;
                Antrag.AntragsStatus = clsAnträge.enAntragsStatus.Completed;
                Antrag.LetztesStatusDatum = DateTime.Now;
                Antrag.BezahlteGebühren = clsAntragsKategorien.Find((int)clsAnträge.enAntragsKategorie.PrüfungWiederholen).Gebühren;
                Antrag.ErstelltVonBenutzer = clsGlobaleKlasse.Benutzer.BenutzerID;

                if(!Antrag.Save())
                {
                    _TestTermine.WiederholungsTest_AntragsID = -1;
                    MessageBox.Show("Fehler beim erstellen des Antrags ist aufgetreten ", "Fehler Meldung",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                _TestTermine.WiederholungsTest_AntragsID = Antrag.AntragsID;
            }

            return true;
        }
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (!_HandleRetakeApplication())
                return;

            DateTime PrviousDatum = dtpTestDatum.Value;
            int ErstelltVonBenutzerID = clsGlobaleKlasse.Benutzer.BenutzerID;

            if (PrviousDatum == _TestTermine.TerminDatum && ErstelltVonBenutzerID == _TestTermine.ErstelltVonBenutzerID)
            {
                MessageBox.Show("Keine Änderungen werden durchgeführt, um die zu speichern", "Medlung", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                btnSpeichern.Enabled = false;
                return;
            }

            _TestTermine.TestTypeID = _TestTypeID;
            _TestTermine.LokalerFührerscheinAntragsID = _LokalerFührerscheinAntrag.LoKalerFührerscheinID;
            _TestTermine.TerminDatum = dtpTestDatum.Value;
            _TestTermine.BezahlteGebühren = Convert.ToDecimal(lblGebühren.Text);
            _TestTermine.ErstelltVonBenutzerID = clsGlobaleKlasse.Benutzer.BenutzerID;

            if(_TestTermine.Save())
            {
                _Mode =enMode.Update;
                MessageBox.Show("Daten wurden erfolgreich gespeichert", "Daten Speichern", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Daten wurden nicht erfolgreich gespeichert", "Daten Speichern", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gbWiederholungsTestInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
