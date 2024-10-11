using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using MenschenDataForm;

namespace Führerschein
{
    public partial class frmAntragZumInternationalenFührerschein : Form
    {
        private int _SelectedLicenseID = -1;
        private int _InternationalLicenseID = -1;
        public frmAntragZumInternationalenFührerschein()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ctrFahrerLicenseInfoMitFilter1_OnLicenseSelected(int obj)
        {
            _SelectedLicenseID = obj;

            if (_SelectedLicenseID == -1)
                return;

            llLicenseHistorieAnzeigen.Enabled = (_SelectedLicenseID != -1);
            lblLokalLicenseID.Text = _SelectedLicenseID.ToString();

            //Überprüfen Sie die Führerscheinklasse. Eine Person kann keinen internationalen Führerschein ausstellen,
            //ohne einen normalen Führerschein der Klasse 3 zu besitzen.
            if (ctrFahrerLicenseInfoMitFilter1.SelectedLicenseInfo.LicenseKlasseID != 1)
            {
                // die 1 hier ist für Klasse B PKW 
                MessageBox.Show("Die ausgewählte License sollte Klasse 3 sein, bitte wählen Sie eine andere aus.", "Nicht erlaubt",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int FahrerID = ctrFahrerLicenseInfoMitFilter1.SelectedLicenseInfo.FahrerID;

            int AktiveInternationalLicenseID = clsInternationFührerscheinAntragDaten.GetActiveInternationalLicenseByDrivingID(FahrerID);
            if(AktiveInternationalLicenseID != -1)
            {
                MessageBox.Show("Diese Person hat bereits einen aktiven Internationalen License mit der ID " + AktiveInternationalLicenseID , "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                llLicenseInfoAnzeigen.Enabled = true;
                _InternationalLicenseID = AktiveInternationalLicenseID;
                btnAusstellen.Enabled = false;
                return;
            }
            btnAusstellen.Enabled = true;
        }

        private void frmAntragZumInternationalenFührerschein_Load(object sender, EventArgs e)
        {
            lblAntragsDatum.Text = DateTime.Now.ToShortDateString();
            lblAusstellungsDatum.Text = lblAntragsDatum.Text;
            lblAblaufDatum.Text = DateTime.Now.AddYears(5).ToShortDateString();
            lblGebühren.Text = clsAntragsKategorien.Find((int)clsAnträge.enAntragsKategorie.NeueInternationalerFahrerlaubnis).Gebühren.ToString();
            lblErstelltbeiBenuzuer.Text = clsGlobaleKlasse.Benutzer.PersonInfo.Vollname;
        }

        private void llLicenseHistorieAnzeigen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmFahrerLicenseHistoie frm = new frmFahrerLicenseHistoie(ctrFahrerLicenseInfoMitFilter1.SelectedLicenseInfo.FahrerInfo.PersonID);
            frm.ShowDialog();
        }

        private void btnAusstellen_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Sind Sie sicher, Sie möchten für diese Person einen neuen Internationalen Führerschein ausstellen",
                "Beschtätigen",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsInternationFührerscheinAntragDaten InternationalLicenseAntrag = new clsInternationFührerscheinAntragDaten();
            //those are the information for the base application, because it inhirts from application, they are part of the sub class.
            //Diese sind die Informationen für die BaseKlasse,Weil Diese ein Teil der abgeleiteten Klasse ist.

            InternationalLicenseAntrag.AntragsKategorieID = clsAntragsKategorien.Find((int)clsAnträge.enAntragsKategorie.NeueInternationalerFahrerlaubnis).ID;
            InternationalLicenseAntrag.AntragsPersonID = ctrFahrerLicenseInfoMitFilter1.SelectedLicenseInfo.PersonInfo.PersonID;
            InternationalLicenseAntrag.AntragsStatus = clsAnträge.enAntragsStatus.Completed;
            InternationalLicenseAntrag.FahrerID = ctrFahrerLicenseInfoMitFilter1.SelectedLicenseInfo.FahrerID;
            InternationalLicenseAntrag.AntragsDatum = DateTime.Now;
            InternationalLicenseAntrag.LetztesStatusDatum = DateTime.Now;
            InternationalLicenseAntrag.ErstelltVonBenutzer = clsGlobaleKlasse.Benutzer.BenutzerID;
            InternationalLicenseAntrag.BezahlteGebühren = clsAntragsKategorien.Find((int)clsAnträge.enAntragsKategorie.NeueInternationalerFahrerlaubnis).Gebühren;

            InternationalLicenseAntrag.AusstellungsDatum = DateTime.Now;
            InternationalLicenseAntrag.AblaufDatum = DateTime.Now.AddYears(5);
            InternationalLicenseAntrag.AusstellungsMitLokalerLicenseID = ctrFahrerLicenseInfoMitFilter1.SelectedLicenseInfo.LicenseID;

            if(!InternationalLicenseAntrag.Save())
            {
                MessageBox.Show("Fehler beim Ausstellen des Internationalen Führerscheins", "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblInternationlAntragsID.Text = InternationalLicenseAntrag.AntragsID.ToString();
            lblInternationlLicenseID.Text = InternationalLicenseAntrag.InternationalLicenseID.ToString();
            _InternationalLicenseID = InternationalLicenseAntrag.InternationalLicenseID;
        
            MessageBox.Show("Internationaler License wurde erfolgreich mit der ID = " + _InternationalLicenseID + " ausgestellt",
                "Erflog", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnAusstellen.Enabled = false;
            ctrFahrerLicenseInfoMitFilter1.FilterEnabled = false;
            llLicenseInfoAnzeigen.Enabled = true;
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llLicenseInfoAnzeigen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmFahrerInternationalLicenseInfoAnzeigen frm = new frmFahrerInternationalLicenseInfoAnzeigen(_InternationalLicenseID);
            frm.ShowDialog();
        }
    }
}
