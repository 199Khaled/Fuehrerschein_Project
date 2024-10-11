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
    public partial class frmLokalerFührerscheinErneuern : Form
    {
        private int _NeueLicseneID = -1;
        private int _SelectedLicenseID = -1;
        public frmLokalerFührerscheinErneuern()
        {
            InitializeComponent();
        }

       
        private void ctrFahrerLicenseInfoMitFilter1_Load(object sender, EventArgs e)
        {
          
        }

        private void frmLokalerFührerscheinErneuern_Load(object sender, EventArgs e)
        {
            ctrFahrerLicenseInfoMitFilter1.FiltrSelect();
            lblAntragsDatum.Text = DateTime.Now.ToShortDateString();
            lblAusstellungsDatum.Text = lblAntragsDatum.Text;

            lblAblaufDatum.Text = "[??/??//????]";
            lblAntragsGebühren.Text = clsAntragsKategorien.Find((int)clsAnträge.enAntragsKategorie.FahrerlaubnisErneuern).Gebühren.ToString();
            lblErstelletBeiBenutzer.Text = clsGlobaleKlasse.Benutzer.PersonInfo.Vollname;
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnErneuern_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sind Sie sicher, Diesen Führerschein erneuern zu möchten? ", "Bestätigen",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            clsLicenseDaten NeuLicense = ctrFahrerLicenseInfoMitFilter1.SelectedLicenseInfo.RenewLicense(txtNotizen.Text.Trim(), clsGlobaleKlasse.Benutzer.BenutzerID);

            if(NeuLicense == null)
            {
                MessageBox.Show("Fehler zum Erneuern ist aufgetreten", "Fehler Meldung",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblAntragsID.Text = NeuLicense.AntragsID.ToString();
            _NeueLicseneID = NeuLicense.LicenseID;
            lblErneuerteLicenseID.Text = _NeueLicseneID.ToString();
            txtNotizen.Text = NeuLicense.Notitzen;

            MessageBox.Show("Der führerschein wurde Mit der ID= " + _NeueLicseneID.ToString() + " erfolgreich erneuert", "Erneuerungn Bestätigen!",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnErneuern.Enabled = false;
            ctrFahrerLicenseInfoMitFilter1.FilterEnabled = false;


            llbNeuLicnenseInfoAnzeigen.Enabled = true;
        }

        private void llbNeuLicnenseInfoAnzeigen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmFahrerLicenseInfoAnzeigen frm = new frmFahrerLicenseInfoAnzeigen(_NeueLicseneID);
            frm.ShowDialog();
        }

        private void llbAlterLicenseInfoAnzeigen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // Diese Anweisung muss noch implementiert werden
        }

        private void ctrFahrerLicenseInfoMitFilter1_OnLicenseSelected_1(int obj)
        {
            _SelectedLicenseID = obj;

            lblAlterLicenseID.Text = _SelectedLicenseID.ToString();
            llbAlterLicenseInfoAnzeigen.Visible = (_SelectedLicenseID != -1);

            if (_SelectedLicenseID == -1)
                return;

            byte StandardGültigekeitDauer = ctrFahrerLicenseInfoMitFilter1.SelectedLicenseInfo.LicenseKlassenInfo.StandardGültigkeit;

            lblAblaufDatum.Text = DateTime.Now.AddYears(StandardGültigekeitDauer).ToShortDateString();
            lblLicenseGebühren.Text = ctrFahrerLicenseInfoMitFilter1.SelectedLicenseInfo.LicenseKlassenInfo.KlasseGebühren.ToString();
            lblInsgesamteGebühren.Text = (Convert.ToSingle(lblAntragsGebühren.Text) + Convert.ToSingle(lblLicenseGebühren.Text)).ToString();
            txtNotizen.Text = ctrFahrerLicenseInfoMitFilter1.SelectedLicenseInfo.Notitzen;

            //Wir überprüfen, ob das Datum vom Führerschein üperhaupt abgelaufen ist oder nicht.
            if (!ctrFahrerLicenseInfoMitFilter1.SelectedLicenseInfo.IsLicenseExpired())
            {
                MessageBox.Show("Das Datum des ausgewählten Führerscheins ist noch nicht abgelaufen." +
                    " Das Datum läuft am " + ctrFahrerLicenseInfoMitFilter1.SelectedLicenseInfo.AblaufDatum.ToShortDateString() +" ab.",
                    "Ablauf Datum ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnErneuern.Enabled = false;
                return;

            }

            //Wir überprüfen auch, ob der Führerschein Aktive ist.
            if (!ctrFahrerLicenseInfoMitFilter1.SelectedLicenseInfo.IsAktive)
            {
                MessageBox.Show("Der ausgewählten Führerscheins ist nicht aktive",
                   "ist Aktive", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnErneuern.Enabled = false;
                return;
            }

            btnErneuern.Enabled = true;
        }
    }
}
