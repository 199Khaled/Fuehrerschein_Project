using Führerschein.Properties;
using MenschenDataForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Führerschein
{
    public partial class frmTestTerminListe : Form
    {
        private DataTable _dtFührerscheinTestTermine;
        private int _LokalerFührerscheinAntragsID = -1;
        private clsTestTypen.enTestType _TestTypeID = clsTestTypen.enTestType.SehTest;

        public frmTestTerminListe(int LokalerFührerscheinAntragsID, clsTestTypen.enTestType TestTypID)
        {
            InitializeComponent();
            _LokalerFührerscheinAntragsID = LokalerFührerscheinAntragsID;
            _TestTypeID = TestTypID;
        }


        private void _LoadTestTypeImageAndTitle()
        {
            switch (_TestTypeID)
            {
                case clsTestTypen.enTestType.SehTest:
                    {
                        lblTestTilte.Text = "Termin zum SehPrüfung";
                        this.Text = lblTestTilte.Text;
                        pbTestTermine.Image = Resources.Vision_512;
                        break;
                    }

                case clsTestTypen.enTestType.SchreibTest:
                    {
                        lblTestTilte.Text = "Termin zum SchreibPrüfugn";
                        this.Text = lblTestTilte.Text;
                        pbTestTermine.Image = Resources.Written_Test_512;
                        break;
                    }

                case clsTestTypen.enTestType.FahrTest:
                    {
                        lblTestTilte.Text = "Termin zum FahrPrüfung";
                        this.Text = lblTestTilte.Text;
                        pbTestTermine.Image = Resources.driving_test_512;
                        break;
                    }

            }
        }
        private void frmTestTerminListe_Load(object sender, EventArgs e)
        {
            _LoadTestTypeImageAndTitle();

            ctrFührerscheinAntragsInfo1.LoadLocalApplicationInfosByApplicationID(_LokalerFührerscheinAntragsID);
            ctrFührerscheinAntragsInfo1.LoadBaseApplicationInfosByApplicationID(_LokalerFührerscheinAntragsID);


            _dtFührerscheinTestTermine = clsTestTermineDaten.GetApplicationTestAppointmentInfosPerTestType(_LokalerFührerscheinAntragsID, (int)_TestTypeID);
            dgvTestTermin.DataSource = _dtFührerscheinTestTermine;
            lblRecord.Text = dgvTestTermin.Rows.Count.ToString();

            if (dgvTestTermin.Rows.Count > 0)
            {
                dgvTestTermin.Columns[0].HeaderText = "Test TerminID";
                dgvTestTermin.Columns[0].Width = 200;

                dgvTestTermin.Columns[1].HeaderText = "Termin Datum";
                dgvTestTermin.Columns[1].Width = 200;

                dgvTestTermin.Columns[2].HeaderText = "Bezahlte Gebühren";
                dgvTestTermin.Columns[2].Width = 200;

                dgvTestTermin.Columns[3].HeaderText = "ist Geperrt";
                dgvTestTermin.Columns[3].Width = 150;
            }
        }

        private void btnTerminFestlegen_Click(object sender, EventArgs e)
        {
            clsLokalerFührerscheinAntrag lokalerFührerscheinAntrag = clsLokalerFührerscheinAntrag.FindLocalDrivingApplicationInfoByID(_LokalerFührerscheinAntragsID);

            if (lokalerFührerscheinAntrag.IsThereAnActiveScheduledTest(_TestTypeID))
            {
                MessageBox.Show("Diese Person hat bereits einen aktiven Termin für diesen Test.","Meldung",
                    MessageBoxButtons.OK,MessageBoxIcon.Question);
                return;
            }


            //--
            clsPrüfungenDaten LetzterTest = lokalerFührerscheinAntrag.GetLastTestPerTestType(_TestTypeID);

            if(LetzterTest == null)
            {
                frmTestFestlegen frm1 = new frmTestFestlegen( _LokalerFührerscheinAntragsID, _TestTypeID);
                frm1.ShowDialog();

                frmTestTerminListe_Load(null, null);
                return;
            }

            //wenn diese Person bereits diesen Test bestanden hat, darf er ihn nicht wiederholen.
            if(LetzterTest.TestErgebnis == true)
            {
                MessageBox.Show("Diese Person hat bereits diesen Test bestanden, Bestande Teste dürfen nich wiederholt werden",
                               "Nicht zulässig", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmTestFestlegen frm2 = new frmTestFestlegen
                (LetzterTest.TestTerminInfos.TerminDatum, LetzterTest.TestTerminInfos.LokalerFührerscheinAntragsID, _TestTypeID);
            frm2.ShowDialog();

            frmTestTerminListe_Load(null, null);
        }

        private void ctrFührerscheinAntragsInfo1_Load(object sender, EventArgs e)
        {

        }

        private void UpdatetoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int TestTerminID = (int)dgvTestTermin.CurrentRow.Cells[0].Value;

            frmTestFestlegen frm = new frmTestFestlegen(_LokalerFührerscheinAntragsID, _TestTypeID, TestTerminID);
            frm.ShowDialog();

            frmTestTerminListe_Load(null, null);
        }

        private void TestFestlegentoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int TestTerminID = (int)dgvTestTermin.CurrentRow.Cells[0].Value;
            //clsTestTermineDaten TestTermin = clsTestTermineDaten.GetTestAppointmentInfosByID(TestTerminID);

            //clsPrüfungenDaten Prüfung = clsPrüfungenDaten.Find(TestTermin.TestID);
            //if (Prüfung.TestErgebnis == true)
            //{
            //    MessageBox.Show("Diese Person hat diesen Test bestanden.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            frmPrüfungBuchen frm = new frmPrüfungBuchen(TestTerminID, _TestTypeID);
            frm.ShowDialog();
            frmTestTerminListe_Load(null, null);
        }
    }
}
