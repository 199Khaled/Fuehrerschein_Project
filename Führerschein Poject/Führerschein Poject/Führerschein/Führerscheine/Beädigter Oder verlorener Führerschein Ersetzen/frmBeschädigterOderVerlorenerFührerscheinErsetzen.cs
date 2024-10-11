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
using static MenschenDataForm.clsLicenseDaten;

namespace Führerschein
{
    public partial class frmBeschädigterOderVerlorenerFührerscheinErsetzen : Form
    {
        private int _LicenseID = -1;
        private int _NeuLicenseID = -1;
        public frmBeschädigterOderVerlorenerFührerscheinErsetzen()
        {
            InitializeComponent();
        }

        private int _GetApplicationType()
        {
            if (rbBeschädigtenFührerschein.Checked)
                return (int)clsAnträge.enAntragsKategorie.BeschädigteFahrerlaubnisErsetzen;
            else
                return (int)clsAnträge.enAntragsKategorie.VerloreneFahrerlaubnisErsetzen;
        }

        private enAusstellungsGrund _GetIssueReasen()
        {
            if (rbBeschädigtenFührerschein.Checked)
                return enAusstellungsGrund.ErsatzFürBeschädigtenFührerschein;
            else
                return enAusstellungsGrund.ErsatzFürVerlorenenFührerschein;
        }
        private void frmBeschädigterOderVerlorenerFührerscheinErsetzen_Load(object sender, EventArgs e)
        {
            lblErstelletBeiBenutzer.Text = clsGlobaleKlasse.Benutzer.PersonInfo.Vollname;
            lblAntragsDatum.Text = DateTime.Now.ToShortDateString();

            rbBeschädigtenFührerschein.Checked = true;

        }


        private void btnSuchen_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Das Feld muss eine ID als Nummer enthalten ", "Fehler Meldung");
                return;
            }
            _LicenseID = int.Parse(txtbFilterWert.Text);
            ctrFahrerLicenseInfo1.LoadLicenseData(_LicenseID);

            if (ctrFahrerLicenseInfo1.LicenseID == -1)
                btnErsetzen.Enabled = false;
            else
                btnErsetzen.Enabled = true;
        }

        private void txtbFilterWert_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbFilterWert.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbFilterWert, "Dieses Feld muss einen Wert enhalten.");
            }
            else
                errorProvider1.SetError(txtbFilterWert, null);
        }

     
        private void rbVerlorenenFührerschein_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Ersatz für einen verlorenen Führerschein.";
            this.Text = lblTitle.Text;
            lblAntragsGebühren.Text = clsAntragsKategorien.Find((int)_GetApplicationType()).Gebühren.ToString();
        }

        private void rbBeschädigtenFührerschein_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Ersatz für einen beschädigten Führerschein.";
            this.Text = lblTitle.Text;
            lblAntragsGebühren.Text = clsAntragsKategorien.Find((int)_GetApplicationType()).Gebühren.ToString();
        }

     
        private void btnErsetzen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie wirklich diesen Führerschein ersetzen? ", "Information",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;

            if(!ctrFahrerLicenseInfo1.SelectedLicenseInfo.IsAktive)
            {
                MessageBox.Show("Dieser Führerschein ist nicht mehr aktive",
                    "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            string NeuNotizen = ctrFahrerLicenseInfo1.FillTextBoxWithNote();
            clsLicenseDaten NeueLicense = ctrFahrerLicenseInfo1.SelectedLicenseInfo.
            Replace(NeuNotizen,_GetIssueReasen(), 1014);

            if(NeueLicense == null)
            {
                MessageBox.Show("Fehler beim Ersetzen dieses Führerscheins ist aufgetreten", "Fehler Meldung",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _NeuLicenseID = NeueLicense.LicenseID;
            lblErsetzteLicenseID.Text = _NeuLicenseID.ToString();
            lblAntragsID.Text = NeueLicense.AntragsID.ToString();

            MessageBox.Show("Führerschein wurde erfolgreich ersetzt", "Erfolgreich ersetzt",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnErsetzen.Enabled = false;
            gbErsatzFür.Enabled = false;
            gbFilter.Enabled = false;

            llbAlterLicenseInfoAnzeigen.Enabled = true;
            llbNeueLicenseInfoAnzeigen.Enabled = true;
        }

        private void llbNeueFührerscheinInfoAnzeigen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_NeuLicenseID == -1)
            {
                MessageBox.Show("Dieser Führerschein mit der ID = " + _LicenseID + " wurde noch nicht ersetzt\n" +
                    "Oder er ist nicht aktive ", "Fehler Meldung",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmFahrerLicenseInfoAnzeigen frm = new frmFahrerLicenseInfoAnzeigen(_NeuLicenseID);
            frm.ShowDialog();
        }

        private void txtbFilterWert_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbFilterWert_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

               //wenn Enter Taste gedrücht wird 
               if (e.KeyChar == (char)13)
                   btnSuchen.PerformClick();
        }

        private void llbAlterLicenseInfoAnzeigen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmFahrerLicenseInfoAnzeigen frm = new frmFahrerLicenseInfoAnzeigen(_LicenseID);
            frm.Show();
        }
    }
}
