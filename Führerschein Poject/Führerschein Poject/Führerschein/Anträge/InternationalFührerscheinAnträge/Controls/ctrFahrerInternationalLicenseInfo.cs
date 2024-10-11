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
using System.IO;

namespace Führerschein
{
    public partial class ctrFahrerInternationalLicenseInfo : UserControl
    {
        private int _InternationalLicensID = -1;
        public int SelectdInternationLicenseID
        {
            get { return _InternationalLicensID; }
        }

        private clsInternationFührerscheinAntragDaten _InternationalLicense;
        public clsInternationFührerscheinAntragDaten SelectedInternationalLicense
        {
            get { return _InternationalLicense; }
        }
        public ctrFahrerInternationalLicenseInfo()
        {
            InitializeComponent();
        }


        public void LoadInternationalLicenseInfo(int InternationalLicenseID)
        {
            _ResetDefaultValues();

            _InternationalLicense = clsInternationFührerscheinAntragDaten.Find(InternationalLicenseID);
            if(_InternationalLicense == null)
            {
                MessageBox.Show("International License mit der ID " + InternationalLicenseID + " wurde nicht gefunden",
                    "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _InternationalLicensID = InternationalLicenseID;

            _FillInternationalLicenseKarteWithData();
        }

        private void _FillInternationalLicenseKarteWithData()
        {
            lblVollname.Text = _InternationalLicense.FahrerInfo.PersonInfo.Vollname;
            lblInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            lblAusweisNum.Text = _InternationalLicense.FahrerInfo.PersonInfo.AusweisNummer;
            lblGeschlicht.Text = (_InternationalLicense.FahrerInfo.PersonInfo.Geschlecht == 0) ? "Mänlich" : "Weiblich";
            lblAusstellungsDatum.Text = _InternationalLicense.AusstellungsDatum.ToShortDateString();
            lblIsAktive.Text = (_InternationalLicense.IsAktive == true) ? "Ja" : "Nein";
            lblGeburtstag.Text = _InternationalLicense.FahrerInfo.PersonInfo.Geburtstag.ToShortDateString();
            lblFahrerID.Text = _InternationalLicense.FahrerID.ToString();
            lblAblaufDatum.Text = _InternationalLicense.AblaufDatum.ToShortDateString();

            _LoadImage();
        }

        private void _LoadImage()
        {
            if (_InternationalLicense.FahrerInfo.PersonInfo.Geschlecht == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            string Fotopfad = _InternationalLicense.FahrerInfo.PersonInfo.FotoPfad;
            if (Fotopfad != "")
            {
                if (File.Exists(Fotopfad))
                    pbPersonImage.Load(Fotopfad);
                else
                    MessageBox.Show("Bild mit Pfad [" + Fotopfad + "] wurde nicht gefunden",
                        "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
        }
        private void _ResetDefaultValues()
        {
            lblVollname.Text = "[????]";
            lblInternationalLicenseID.Text = "[????]";
            lblAusweisNum.Text= "[????]";
            lblGeschlicht.Text = "[????]";
            lblAusstellungsDatum.Text= "[????]";
            lblIsAktive.Text = "[????]";
            lblGeburtstag.Text= "[????]";
            lblFahrerID.Text= "[????]";
            lblAblaufDatum.Text= "[????]";
            if (lblGeschlicht.Text == "0")
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;
        }
    }
}
