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
    public partial class ctrFahrerLicenseInfo : UserControl
    {
        private clsLicenseDaten _License;
        private int _LicenseID = -1;

        public int LicenseID
        {
            get { return _LicenseID; }
        }

        public clsLicenseDaten SelectedLicenseInfo
        {
            get { return _License; }
        }
        public ctrFahrerLicenseInfo()
        {
            InitializeComponent();
        }

        public void LoadLicenseData(int LicenseID)
        {
            _ResetDefaultValues();

            _License = clsLicenseDaten.GetLicenseInfoByID(LicenseID);

            if(_License == null)
            {

                MessageBox.Show("Der Führerschein mit dieser ID=" + LicenseID.ToString() + " wurde nicht gefunden",
                   "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LicenseID = _License.LicenseID;
            _FillLiceseCardWithData();

        }

        public  string  FillTextBoxWithNote()
        {
           string Notizen = txtbNotizen.Text;
            return Notizen;
        }

        private void _FillLiceseCardWithData()
        {
            lblKlasse.Text = _License.LicenseKlassenInfo.LicenseKlasseName;
            lblVollname.Text = _License.FahrerInfo.PersonInfo.Vollname;
            lblLicenseID.Text = _License.LicenseID.ToString();
            lblAusweisNum.Text = _License.FahrerInfo.PersonInfo.AusweisNummer;
            lblGeschlicht.Text = _License.FahrerInfo.PersonInfo.Geschlecht == 0 ? "Mänlich" : "Weiblich";
            lblAusstellungsDatum.Text = _License.AusstellungsDatum.ToShortDateString();
            txtAusstellungsGrund.Text = _License.AusstellungsGrund.ToString();
            txtbNotizen.Text = _License.Notitzen == "" ? "Keine Notizen" : _License.Notitzen;
            lblIsAktive.Text = _License.IsAktive ? "Ja" : "Nein";
            lblGeburtstag.Text = _License.FahrerInfo.PersonInfo.Geburtstag.ToShortDateString();
            lblFahrerID.Text = _License.FahrerID.ToString();
            lblAblaufDatum.Text = _License.AblaufDatum.ToShortDateString();
            lblIstEntzogen.Text = _License.IstBeschlagnahmt ? "Ja" : "Nein";

            _LoadPersonImage();
        }

        private void _LoadPersonImage()
        {
            if (_License.FahrerInfo.PersonInfo.Geschlecht == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            string FotoPfad = _License.FahrerInfo.PersonInfo.FotoPfad;

            if (FotoPfad != "")
                if (File.Exists(FotoPfad))
                    pbPersonImage.Load(FotoPfad);
                else
                    MessageBox.Show("FotoPfad [ " + FotoPfad + " ] konnte nicht gefunden werden");
                    
          }

        private void _ResetDefaultValues()
        {
            lblKlasse.Text = "[????]";
            lblVollname.Text = "[????]";
            lblLicenseID.Text = "[????]";
            lblAusweisNum.Text= "[????]";
            lblGeschlicht.Text = "[????]";
            lblAusstellungsDatum.Text= "[????]";
            txtAusstellungsGrund.Text= "";
            txtbNotizen.Text = "";
            lblIsAktive.Text = "[????]";
            lblGeburtstag.Text= "[????]";
            lblFahrerID.Text= "[????]";
            lblAblaufDatum.Text= "[????]";
            lblIstEntzogen.Text = "[????]";
            if (lblGeschlicht.Text == "0")
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;
        }
       
    }
}
