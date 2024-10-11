using MenschenDataForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace Führerschein
{
    public partial class frmAntragZumNeuenLokalenFührerschein : Form
    {
        public delegate void EventDataBack(object seneder);
        public event EventDataBack DataBack;
        public enum enMode { AddNew = 0, Update = 1}
        public enMode Mode = enMode.AddNew;

        private int _LokalerFührerscheinAntragsID = -1;
        private int _SelectedPersonID = -1;
        private clsLokalerFührerscheinAntrag _LokalerFührerscheinAntrag;

        public frmAntragZumNeuenLokalenFührerschein()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmAntragZumNeuenLokalenFührerschein(int LFSAntragsID)
        {
            InitializeComponent();

            _LokalerFührerscheinAntragsID= LFSAntragsID;
            Mode = enMode.Update;
        }
        private void _FillLicenseClassesInComboBox()
        {
            DataTable dt = clsLicenseKlassen.GetAllLicenseClasses();

            foreach (DataRow row in dt.Rows)
            {
                cbFührerscheinKlasse.Items.Add(row["KlassenName"]);
            }
        }
        private void _ResetDefaultValues()
        {
            
            _FillLicenseClassesInComboBox();

            ctrlPersonKarteMitFilter1.FilterFocuse();

            tabControl1.SelectTab("tabpPersonInfo");

            if (Mode == enMode.AddNew)
            {
                this.Text = "Neue Lokaler Führerschein Antrag";
                lblTitel.Text = "Neue Lokaler Führerschein Antrag";
                _LokalerFührerscheinAntrag = new clsLokalerFührerscheinAntrag();
                ctrlPersonKarteMitFilter1.FilterFocuse();
                tabpAntragsInfo.Enabled = false;

                cbFührerscheinKlasse.SelectedIndex = 0;
                lblAntragsGebühren.Text = clsAntragsKategorien.Find((int)clsAnträge.enAntragsKategorie.NeueFahrerlaubnis).Gebühren.ToString();
                lblAntragsDatum.Text = DateTime.Now.ToShortDateString();
                lblErstelltVonBenutzer.Text = clsGlobaleKlasse.Benutzer.BenutzerName;
            }
            else
            {
                this.Text = "Update Lokaler Führerschein Antrag";
                lblTitel.Text = "Update Lokaler Führerschein Antrag";
                tabpAntragsInfo.Enabled = true;
            }
        }

    
        private void _LoadData()
        {
            ctrlPersonKarteMitFilter1.FilterEnabled = false;
            _LokalerFührerscheinAntrag = clsLokalerFührerscheinAntrag.FindLocalDrivingApplicationInfoByID(_LokalerFührerscheinAntragsID);

            if(_LokalerFührerscheinAntrag == null)
            {
                MessageBox.Show("Keiner Antrag mit ID: " + _LokalerFührerscheinAntragsID + " wurde nicht gefunden", "FehlerMeldung",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            ctrlPersonKarteMitFilter1.LoadPersonInfo(_LokalerFührerscheinAntrag.AntragsPersonID);
            lblLokalerFührerscheinID.Text = _LokalerFührerscheinAntrag.LoKalerFührerscheinID.ToString();
            lblAntragsDatum.Text = _LokalerFührerscheinAntrag.AntragsDatum.ToShortDateString();
            string KlassenName = clsLicenseKlassen.Find(_LokalerFührerscheinAntrag.LicenseKlasseID).LicenseKlasseName;
            cbFührerscheinKlasse.SelectedIndex = cbFührerscheinKlasse.FindString(KlassenName);
            lblAntragsGebühren.Text = _LokalerFührerscheinAntrag.BezahlteGebühren.ToString();
            lblErstelltVonBenutzer.Text = clsBenutzerDaten.FindByUserID(_LokalerFührerscheinAntrag.ErstelltVonBenutzer).BenutzerName;
        }
    
        private void frmAntragZumNeuenLokalenFührerschein_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if ( Mode == enMode.Update)
                _LoadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(Mode == enMode.AddNew)
            {
                tabpAntragsInfo.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages["tabpAntragsInfo"];
                cbFührerscheinKlasse.Focus();
                return;
            }

            if (ctrlPersonKarteMitFilter1.PersonID != -1)
            {
                tabpAntragsInfo.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages["tabpAntragsInfo"];
                cbFührerscheinKlasse.Focus();
            }
            else
            {
                MessageBox.Show("Wählen Sie eine Person bitte aus", "Person Auswählen",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrlPersonKarteMitFilter1.FilterEnabled = true;
            }
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            int LicenseKlasseID = clsLicenseKlassen.Find(cbFührerscheinKlasse.Text).LicenseKlasseID;
            int AktiveAntragsID = clsAnträge.GetActivApplicationIDForLicenseClass(ctrlPersonKarteMitFilter1.PersonID,(int) clsAnträge.enAntragsKategorie.NeueFahrerlaubnis, LicenseKlasseID);

            if(AktiveAntragsID != -1)
            {
                MessageBox.Show("Wählen Sie eine andere Führerscheinklasse aus. Die ausgewählte Person hat bereits eine aktive Bewerbung für die ausgewählte Klasse mit der ID=" + AktiveAntragsID, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbFührerscheinKlasse.Focus();
                return;
            }

            //check, if one already had a issued License with the same license Class
            //Überpüfen, Ob diese Person bereits einen ausgestellten Führerschein mit derselben FührerscheinKlasse hat.

            if(clsLicenseDaten.IsLicenseExistsForThisPersonID(ctrlPersonKarteMitFilter1.PersonID,LicenseKlasseID))
            {
                MessageBox.Show("Diese Person hat bereits ein Führerschein mit derselben Klasse", "nicht erlaubt",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            _LokalerFührerscheinAntrag.AntragsPersonID = ctrlPersonKarteMitFilter1.PersonID;
            _LokalerFührerscheinAntrag.AntragsDatum = DateTime.Now;
            _LokalerFührerscheinAntrag.AntragsKategorieID = 1;
            _LokalerFührerscheinAntrag.AntragsStatus = clsAnträge.enAntragsStatus.New;
            _LokalerFührerscheinAntrag.LetztesStatusDatum = DateTime.Now;
            _LokalerFührerscheinAntrag.BezahlteGebühren = Convert.ToDecimal(lblAntragsGebühren.Text);
            _LokalerFührerscheinAntrag.ErstelltVonBenutzer = clsGlobaleKlasse.Benutzer.BenutzerID;
            _LokalerFührerscheinAntrag.LicenseKlasseID = LicenseKlasseID;

            //now we save the data in the database
            if(_LokalerFührerscheinAntrag.Save())
            {
                lblLokalerFührerscheinID.Text = _LokalerFührerscheinAntrag.LoKalerFührerscheinID.ToString();
                Mode = enMode.Update;
                lblTitel.Text = "Update Lokaler Führerschein Antrag";
                MessageBox.Show("Daten wurden erfolgreich gespeichert", "Daten Speichen",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this);
                this.Close();
            }
            else
                MessageBox.Show("Daten wurden nicht erfolgreich gespeichert", "FehlerMeldung",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ctrlPersonKarteMitFilter1_OnPersonSelected(int obj)
        {
            _SelectedPersonID = obj;
        }

        //private void frmAntragZumNeuenLokalenFührerschein_Activated(object sender, EventArgs e)
        //{
        //        //ctrlPersonKarteMitFilter1.FilterFocuse();
        //}

        private void frmAntragZumNeuenLokalenFührerschein_Deactivate(object sender, EventArgs e)
        {
            //ctrlPersonKarteMitFilter1.FilterFocuse();
        }

        private void ctrlPersonKarteMitFilter1_Load(object sender, EventArgs e)
        {

        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
