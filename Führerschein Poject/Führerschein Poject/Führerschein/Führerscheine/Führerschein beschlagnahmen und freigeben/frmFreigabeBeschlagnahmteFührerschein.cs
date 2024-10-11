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
    public partial class frmFreigabeBeschlagnahmteFührerschein : Form
    {
        private int _SelectedLicenseID = -1;
        private clsBeschlagnahmeLicenseDaten _BeschlagnahmteLicense;
        public frmFreigabeBeschlagnahmteFührerschein()
        {
            InitializeComponent();
        }

        public frmFreigabeBeschlagnahmteFührerschein(int LicenseID)
        {
            InitializeComponent();
            _SelectedLicenseID = LicenseID;
            _LoadBeschlagnahmteLicenseInfo();

            ctrFahrerLicenseInfoMitFilter1.LoadLicenseInfo(_SelectedLicenseID);

            if (_SelectedLicenseID != -1)
                ctrFahrerLicenseInfoMitFilter1.FilterEnabled = false;
        }
        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFreigabe_Click(object sender, EventArgs e)
        {
            int AntragsID = -1;


            bool istFreigegeben = ctrFahrerLicenseInfoMitFilter1.SelectedLicenseInfo.ReleaseDetainedLicense(clsGlobaleKlasse.Benutzer.BenutzerID, ref AntragsID);
            if(!istFreigegeben)
            {
                MessageBox.Show("Fehler beim Freigeben dieses Führerscheins", "Fehler Meldung",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblAntragsID.Text = AntragsID.ToString();
           
            btnFreigabe.Enabled = false;
            ctrFahrerLicenseInfoMitFilter1.FilterEnabled = false;

            MessageBox.Show("Der Führerschein wurde erfogreich mit AntragsID =" + AntragsID.ToString() + " Freigegeben",
                "Führerschein Freigabe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmFreigabeBeschlagnahmteFührerschein_Load(object sender, EventArgs e)
        {
            
        }

        private void ctrFahrerLicenseInfoMitFilter1_OnLicenseSelected(int obj)
        {
            _SelectedLicenseID = obj;
            if(_SelectedLicenseID == -1)
            {
                return;
            }

            lblLicenseID.Text = _SelectedLicenseID.ToString();
            //wir überprüfen hier, ob der Führerschein freigegeben ist oder nicht.
           if(!ctrFahrerLicenseInfoMitFilter1.SelectedLicenseInfo.IstBeschlagnahmt)
            {
                MessageBox.Show("Der Führerschein mit dieser ID =" + lblLicenseID.Text + " ist nicht beschlagnahmt",
                    "Nicht zulässig", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btnFreigabe.Enabled = false;
                return;
            }

            _LoadBeschlagnahmteLicenseInfo();

            btnFreigabe.Enabled = true;
            llLicenseInfoAnzeigen.Enabled = true;
            llLicenseHistorieAnzeigen.Enabled = true;
        }

        private void _LoadBeschlagnahmteLicenseInfo()
        {
            _BeschlagnahmteLicense = clsBeschlagnahmeLicenseDaten.FindByLicenseID(_SelectedLicenseID);

            if(_BeschlagnahmteLicense == null)
            {
                MessageBox.Show("Der Object ist null und enthält keine Daten",
                   "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblBeschlagnahmeID.Text = _BeschlagnahmteLicense.BeschlagnahmeID.ToString();
            lblBeschlagnahmtesDatum.Text = _BeschlagnahmteLicense.BeschlagnahmtesDatum.ToShortDateString();
            lblAntragsGebühren.Text = clsAntragsKategorien.Find((int)clsAnträge.enAntragsKategorie.FreigabeBeschlagnahmterFahrerlaubnis).Gebühren.ToString();
            lblErstelltBeiBenutzer.Text = _BeschlagnahmteLicense.BenutzerInfo.PersonInfo.Vollname;
            lblStrafgebühren.Text = _BeschlagnahmteLicense.StrafGebühren.ToString();
            lblAntragsID.Text = _BeschlagnahmteLicense.FreigabeAntragsID.ToString();
            decimal Antragsgebühren = clsAntragsKategorien.Find((int)clsAnträge.enAntragsKategorie.FreigabeBeschlagnahmterFahrerlaubnis).Gebühren;

            lblInsgesamteGebühren.Text = (_BeschlagnahmteLicense.StrafGebühren + Convert.ToSingle(Antragsgebühren)).ToString();
           
        }

        private void llLicenseInfoAnzeigen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmFahrerLicenseInfoAnzeigen frm = new frmFahrerLicenseInfoAnzeigen(_SelectedLicenseID);
            frm.Show();
        }

        private void llLicenseHistorieAnzeigen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmFahrerLicenseHistoie frm = new frmFahrerLicenseHistoie(ctrFahrerLicenseInfoMitFilter1.SelectedLicenseInfo.FahrerInfo.PersonID);
            frm.Show();
        }
    }
}
