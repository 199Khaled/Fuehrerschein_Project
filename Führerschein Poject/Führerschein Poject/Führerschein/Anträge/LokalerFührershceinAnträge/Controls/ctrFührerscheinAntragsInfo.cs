using MenschenDataForm;
using MenschenDatenForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Führerschein
{
    public partial class ctrFührerscheinAntragsInfo : UserControl
    {
        private int _LokalerFührerscheinAntragsID = -1;
        public int LokalerFührerscheinAntragsID
        {
            // hier wird der LokalerAntragsID zurückgeliefert für andere Formen
            get { return _LokalerFührerscheinAntragsID; }
        }
        private int _AntragsID = -1;
        public int AntragsID
        {
            // hier wird der AntragsID zurückgeliefert für andere Formen
            get { return _AntragsID; }
        }
        private clsAnträge _Antrag;
        private clsLokalerFührerscheinAntrag _LokalerFührerscheinAntrag;
        public ctrFührerscheinAntragsInfo()
        {
            InitializeComponent();
        }

        public void LoadBaseApplicationInfosByApplicationID(int AntragsID)
        {
            _Antrag = clsAnträge.FindAppByID(_LokalerFührerscheinAntrag.AntragsID);
            if(_Antrag == null)
            {
                _ResetDefaultValuesForApplicationBasiceDataGroupBox();
                MessageBox.Show("Der Antrag mit ID = " + AntragsID + " wurde nicht gefunden",
                    "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillBasicApplicationGroupBoxWithData();
        }

        public void LoadLocalApplicationInfosByApplicationID(int AntragsID)
        {
            _LokalerFührerscheinAntrag = clsLokalerFührerscheinAntrag.FindLocalDrivingApplicationInfoByID(AntragsID);
            if (_LokalerFührerscheinAntrag == null)
            {
                _ResetDefaultValuesForLocalApplicatonDataGroupBox();
                MessageBox.Show("Der Antrag mit ID = " + AntragsID + " wurde nicht gefunden",
                    "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillLokalDrivingApplicationGroupBoxWithData();
        }
        private  void _FillLokalDrivingApplicationGroupBoxWithData()
        {
            //hier laden wir die Daten der Führerschein Antrag Infos  in GroupBox..
            lblLokalerFührerscheinAntargID.Text = _LokalerFührerscheinAntrag.LoKalerFührerscheinID.ToString();
            lblBeantragtFür.Text = clsLicenseKlassen.Find(_LokalerFührerscheinAntrag.LicenseKlasseID).LicenseKlasseName;
            lblBestandenePrüfungen.Text = _LokalerFührerscheinAntrag.GetPassedTestCount().ToString() + "/3";

        }

        private void _FillBasicApplicationGroupBoxWithData()
        {
            lblAntragID.Text = _Antrag.AntragsID.ToString();
            lblStatus.Text = _Antrag.StatusText;
            lblGebühren.Text = Convert.ToString(_Antrag.BezahlteGebühren);
            // Durch Composition bekomme ich den Titel und AntragsPersonVollname und Benutzer vollname..
            lblKategorie.Text = _Antrag.AntagsKategoreiInfo.Titel;
            lblBeantragter.Text = _Antrag.PersonInfo.Vollname;
            lblDatum.Text = _Antrag.AntragsDatum.ToShortDateString();
            lblDatumStatus.Text = _Antrag.LetztesStatusDatum.ToShortDateString();
            lblErstelltVonBenutzer.Text = _Antrag.BenutzerInfo.PersonInfo.Vollname;
        }

        private void _ResetDefaultValuesForLocalApplicatonDataGroupBox()
        {
            lblLokalerFührerscheinAntargID.Text = "[???]";
            lblBeantragtFür.Text = "[???]";
            lblBestandenePrüfungen.Text = "0/3";
        }

        private void _ResetDefaultValuesForApplicationBasiceDataGroupBox()
        {
            lblAntragID.Text = "[???]";
            lblStatus.Text = "[???]";
            lblGebühren.Text = "[$$$]";
            lblKategorie.Text = "[????]"; ;
            lblBeantragter.Text = "[????]";
            lblDatum.Text = "[??/??/??]";
            lblDatumStatus.Text ="[??/??/??]";
            lblErstelltVonBenutzer.Text = "[????]";
        }
        private void ctrFührerscheinAntragsInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void gbAntragHauptInfo_Enter(object sender, EventArgs e)
        {

        }

        private void gbFührerscheinAntragInfo_Enter(object sender, EventArgs e)
        {

        }

        private void llPersonInfoSehen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonInfoSehen frm = new frmPersonInfoSehen(_Antrag.AntragsPersonID);
            frm.ShowDialog();
        }

        private void llLicenceInfoSehen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmFahrerLicenseInfoAnzeigen frm = new frmFahrerLicenseInfoAnzeigen(_LokalerFührerscheinAntrag.GetActiveLicenseID());
            frm.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
