using Führerschein.Properties;
using MenschenDataForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Führerschein
{
    public partial class ctrPrüfungDaten : UserControl
    {
        private int _TestID = -1;
        public int TestID
        {
            get { return _TestID; }

        }
        private int _LokalerFührerscheinAntragsID = -1;
        private  clsLokalerFührerscheinAntrag _LokalerFührerscheinAntrag;

        private clsTestTypen.enTestType _TestTypeID;
        public clsTestTypen.enTestType TestTypeID
        {
            get { return _TestTypeID; }

            set
            {
                _TestTypeID = value;
                switch(_TestTypeID)
                {
                    case clsTestTypen.enTestType.SehTest:
                        { 
                            gbTestType.Text = "Seh Test";
                            lblTitel.Text = "SehTest Festlegen";
                            pbTestTypeImage.Image = Resources.Vision_512;
                            break;
                        }

                    case clsTestTypen.enTestType.SchreibTest:
                        {
                            gbTestType.Text = "Schreib Test";
                            lblTitel.Text = "SchreibTest Festlegen";
                            pbTestTypeImage.Image = Resources.Written_Test_512;
                            break;
                        }

                    case clsTestTypen.enTestType.FahrTest:
                       {
                            gbTestType.Text = "Fahr Test";
                            lblTitel.Text = "FahrTest Festlegen";
                            pbTestTypeImage.Image = Resources.driving_test_512;
                            break;
                       }
                }
            }
        }

        private int _TestTerminID = -1;
        public int TestTerminID
        {
            get { return _TestTerminID; }
        }
     
       

        
        public ctrPrüfungDaten()
        {
            InitializeComponent();
        }

        public void LoadData(int TestTerminID)
        {
            clsTestTermineDaten TestTerminDaten = clsTestTermineDaten.GetTestAppointmentInfosByID(TestTerminID);
            if(TestTerminDaten == null)
            {
                MessageBox.Show("Es wurde kein Object mir der ID = " + TestTerminID + " gefunden",
                    "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _TestTerminID = -1;
                return;
            }

            _TestID = TestTerminDaten.TestID;
            _TestTerminID = TestTerminDaten.TestTerminID;
            _LokalerFührerscheinAntragsID = TestTerminDaten.LokalerFührerscheinAntragsID;
            _LokalerFührerscheinAntrag = clsLokalerFührerscheinAntrag.FindLocalDrivingApplicationInfoByID(_LokalerFührerscheinAntragsID);

            if(_LokalerFührerscheinAntrag == null)
            {
                MessageBox.Show("Es wurde kein Object mir der ID = " + _LokalerFührerscheinAntragsID + " gefunden",
                    "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblLokalerFührerscheinAntragsID.Text = _LokalerFührerscheinAntrag.LoKalerFührerscheinID.ToString();
            lblFührerscheinKlasse.Text = _LokalerFührerscheinAntrag.LicenseKlasseInfos.LicenseKlasseName;
            lblFullName.Text = _LokalerFührerscheinAntrag.Vollname;
            lblVersuche.Text = _LokalerFührerscheinAntrag.TotalTrailsPerTest(_TestTypeID).ToString();

            dtpTestDatum.Text = TestTerminDaten.TerminDatum.ToShortDateString();
            lblGebühren.Text = TestTerminDaten.BezahlteGebühren.ToString();
            lblTestID.Text = (TestTerminDaten.TestID == -1) ? "Noch keine Prüfung vereinbart" : TestTerminDaten.TestID.ToString();


        }
        private void ctrPrüfungDaten_Load(object sender, EventArgs e)
        {

        }

        private void gbTestType_Enter(object sender, EventArgs e)
        {

        }
    }
}
