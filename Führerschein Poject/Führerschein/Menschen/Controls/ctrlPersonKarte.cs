using Führerschein.Properties;
using MenschenDatenForm;
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
using System.Runtime.InteropServices.WindowsRuntime;
using MenschenDataForm;

namespace Führerschein
{
    public partial class ctrlPersonKarte : UserControl
    {
 
        clsMenschenDaten _Personen;

        private bool _IsPersonFound;
        public bool IsPersonFound
        {
            get { return _IsPersonFound; }
            set { _IsPersonFound =value; }
        }
        private int _PersonID = -1;
        public int PersonID
        {
            get { return _PersonID; }
        }
        public clsMenschenDaten SelectedPersonInfo
        {
            get { return _Personen; }
        }
        public ctrlPersonKarte()
        {
            InitializeComponent();
           
        }

        private void _ResetDefaultValues()
        {
            _PersonID = -1;
            lblPersonID.Text = "[????]"; ;
            lblVollname.Text = "[????]"; ;
            lblAusweisNum.Text = "[????]"; ;
            lblGeschlecht.Text = "[????]";
            lblEmail.Text = "[????]"; 
            lblAddress.Text = "[????]"; ;
            lblGeburtstag.Text = "[????]"; ;
            lblTelefon.Text = "[????]"; ;
            lblLand.Text = "[????]"; ;
            pbPersonIImage.Image = Resources.Male_512;
        }
        public void LoadPersonData(int PersonID)
        {
            _Personen = clsMenschenDaten.Find(PersonID);
            if (_Personen == null)
            {
                _ResetDefaultValues();
                MessageBox.Show("Person mit ID = " + PersonID + " Wurde nicht gefunden", "Meldung", MessageBoxButtons.OK);
                return;
            }
            _FillPersonKarte();
        }

        public void LoadPersonData(string AusweisNum)
        {
            _Personen = clsMenschenDaten.Find(AusweisNum);
            if(_Personen == null)
            {
                _ResetDefaultValues();
                MessageBox.Show("Person mit AusweiNum = " + AusweisNum + " Wurde nicht gefunden", "Meldung", MessageBoxButtons.OK);
                return;
            }
            // to return _PersonID to PersonKarteMitFilter if it is found
            _FillPersonKarte();
        }
        private void _FillPersonKarte()
        { 
            _IsPersonFound = (_Personen != null);   
            _PersonID = _Personen.PersonID;
            lblPersonID.Text = _Personen.PersonID.ToString();
            lblVollname.Text = _Personen.Vollname;
            lblAusweisNum.Text = _Personen.AusweisNummer;
            lblGeschlecht.Text = _Personen.Geschlecht == 0 ? "Mänschlich" : "Weiblich";
            if (!string.IsNullOrEmpty(_Personen.Email))
                lblEmail.Text = _Personen.Email;
            else
                lblEmail.Text = "NULL";
            lblAddress.Text = _Personen.Anschrift;
            lblGeburtstag.Text = _Personen.Geburtstag.ToShortDateString();
            if (!string.IsNullOrEmpty(_Personen.Telefon))
                lblTelefon.Text = _Personen.Telefon;
            else
                lblTelefon.Text = "NULL";
            lblLand.Text = clsLänderDaten.Find(_Personen.LandID).LandsName;

            _LoadPersonImage();
        }

        private void _LoadPersonImage()
        {
            if (_Personen.Geschlecht == 0)
                pbPersonIImage.Image = Resources.Male_512;
            else
                pbPersonIImage.Image = Resources.Female_512;

            string ImagePath = _Personen.FotoPfad;
            if(ImagePath != "")
            {
                if (File.Exists(ImagePath))
                {
                    pbPersonIImage.ImageLocation = ImagePath;
                }
                else
                    MessageBox.Show("Dad Bild Konnte nicht gefunden werden", "Fehler", MessageBoxButtons.OK);
            }
        }
        private void ctrlPersonKarte_Load(object sender, EventArgs e)
        {
          
        }

        private void llUpdatePerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(PersonID);
            frm.ShowDialog();
        }

    }
}
