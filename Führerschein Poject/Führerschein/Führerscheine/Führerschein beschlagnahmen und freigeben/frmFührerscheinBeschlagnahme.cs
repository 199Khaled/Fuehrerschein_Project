using MenschenDataForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace Führerschein
{
    public partial class frmFührerscheinBeschlagnahme : Form
    {
        private int _SelectedLicenseID = -1;
        public frmFührerscheinBeschlagnahme()
        {
            InitializeComponent();
        }

        public frmFührerscheinBeschlagnahme(int LicenseID)
        {
            InitializeComponent();
            _SelectedLicenseID = LicenseID;
            ctrFahrerLicenseInfoMitFilter1.LoadLicenseInfo(_SelectedLicenseID);
            ctrFahrerLicenseInfoMitFilter1.FilterEnabled = false;
        }
        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmFahrerLicenseHistoie frm 
                = new frmFahrerLicenseHistoie(ctrFahrerLicenseInfoMitFilter1.SelectedLicenseInfo.FahrerInfo.PersonID);
            frm.ShowDialog();
        }

        private void ctrFahrerLicenseInfoMitFilter1_OnLicenseSelected(int obj)
        {
            _SelectedLicenseID = obj;
            if (_SelectedLicenseID == -1)
                return;

            
            lblLicenseID.Text = _SelectedLicenseID.ToString();
            llLicenseHistorieAnzeigen.Enabled= (_SelectedLicenseID != -1);

            //wir stellen sicher, dess der Führerschein bereits nicht beschlagnahmt ist,
            if(ctrFahrerLicenseInfoMitFilter1.SelectedLicenseInfo.IstBeschlagnahmt)
            {
                MessageBox.Show("Der ausgewählte Führerschein Mit ID = " + _SelectedLicenseID + " ist bereits beschlagnahmt", "Nicht Zulässig",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            txtStrafgebühren.Focus();
            btnBeschlagnahme.Enabled = true;
        }

        private void frmFührerscheinBeschlagnahme_Load(object sender, EventArgs e)
        {
            lblBeschlagnahmeDatum.Text = DateTime.Now.ToShortDateString();
            lblErstelltBeiBenutzer.Text = clsGlobaleKlasse.Benutzer.PersonInfo.Vollname;
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBeschlagnahme_Click(object sender, EventArgs e)
        {
           
            if(MessageBox.Show("Sind Sie sicher,dass Sie diesen Führerschein beschlagnahmen möchten?","Meldung zum Bestätigen",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            //hier rufen wir die Methode DetainLicense zum Beschlagnahmen des Führerscheins auf.
            int BeschlagnahmeID = ctrFahrerLicenseInfoMitFilter1.SelectedLicenseInfo.DetainLicense(Convert.ToSingle((txtStrafgebühren.Text.Trim())), clsGlobaleKlasse.Benutzer.BenutzerID);

            if(BeschlagnahmeID == -1)
            {
                MessageBox.Show("Fehler beim Beschlagnahmen des Führerscheins", "Fehler Meldung",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblBeschlagnahmeID.Text = BeschlagnahmeID.ToString();
            MessageBox.Show("Führerschein wurde erfolgreich Beschlagnahmt", "Führerschein Beschlagnahme",
                MessageBoxButtons.OK, MessageBoxIcon.Information);


            btnBeschlagnahme.Enabled = false;
            ctrFahrerLicenseInfoMitFilter1.FilterEnabled = false;
            txtStrafgebühren.Enabled = false;
            llLicenseInfoAnzeigen.Enabled = true;
        }

        private void llLicenseInfoAnzeigen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmFahrerLicenseInfoAnzeigen frm = new frmFahrerLicenseInfoAnzeigen(_SelectedLicenseID);
            frm.ShowDialog();
        }

        private void txtStrafgebühren_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtStrafgebühren.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtStrafgebühren, "leeres Feld ist nicht erlaubt");
            }
            else
                errorProvider1.SetError(txtStrafgebühren,null);

            if (!clsValidierung.IsNumber(txtStrafgebühren.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtStrafgebühren, "Das Feld akzeptiert nur nummerische Eingaben!");
            }
            else
                errorProvider1.SetError(txtStrafgebühren, null);
        }
    }
}
