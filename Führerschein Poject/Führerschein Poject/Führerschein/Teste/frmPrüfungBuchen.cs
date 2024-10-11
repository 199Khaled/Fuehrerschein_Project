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
    public partial class frmPrüfungBuchen : Form
    {
        private int _TestTerminID = -1;
        private clsTestTypen.enTestType _TestTypeID;
        private int _TestPrüfung;
        private clsPrüfungenDaten _Test;
        public frmPrüfungBuchen(int TestTerminID, clsTestTypen.enTestType TestTypeID)
        {
            InitializeComponent();
            _TestTerminID = TestTerminID;
            _TestTypeID = TestTypeID;
        }

        private void frmPrüfungBuchen_Load(object sender, EventArgs e)
        {
           
            ctrPrüfungDaten1.TestTypeID = _TestTypeID;
            ctrPrüfungDaten1.LoadData(_TestTerminID);

            if (ctrPrüfungDaten1.TestTerminID == -1)
                btnSpeichern.Enabled = false;
            else
                btnSpeichern.Enabled = true;

            int TestID = ctrPrüfungDaten1.TestID;
            if (TestID != -1)
            {
                _Test = clsPrüfungenDaten.Find(TestID);

                if (_Test.TestErgebnis == true)
                {
                    lblErgebnisMessage.Text = "Die Person hat diesen Test bestanden!";
                    btnSpeichern.Enabled = false;
                    btnBeenden.Enabled = true ;
                    rbBestanden.Checked = true;
                    txtNotizen.Text = _Test.Notizen;
                }
                else
                {
                    lblErgebnisMessage.Text = "Diese Person hat bei diesem Termin in diesem Test durchgefallen";
                    btnSpeichern.Enabled = false;
                    btnBeenden.Enabled = true;
                    rbDurchgefallen.Checked = true;
                    txtNotizen.Text = _Test.Notizen;
                }

                lblErgebnisMessage.Visible = true;
                rbBestanden.Enabled = false; ;
                rbDurchgefallen.Enabled = false;
            }
            else
                _Test = new clsPrüfungenDaten();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sind Sie sicher,Diese Daten zu speichern, weil danach können Sie die" +
                "Bestehens/nichtBestehensErgebnisse nicht mehr ändern , nachdem Sie gepeichert haben", "Bestätigen",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;

            }

            _Test.TestTerminID = _TestTerminID;
            _Test.TestErgebnis = rbBestanden.Checked;
            _Test.Notizen = txtNotizen.Text.Trim();
            _Test.ErstelltVonBenutzerID = clsGlobaleKlasse.Benutzer.BenutzerID;

            if (_Test.Save())
            {
                MessageBox.Show("Daten wurden erfolgreich gespeichert.", "Speichern", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
                MessageBox.Show("Daten wurden nicht erfolgreich gespeichert.", "Speichern", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
