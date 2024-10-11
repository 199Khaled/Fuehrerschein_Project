using Führerschein.Properties;
using MenschenDataForm;
using MenschenDatenForm;
using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Führerschein.Klassen;

namespace Führerschein
{
    public partial class frmAddUpdatePerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;

        enum enMode { AddNew = 0, Update = 1}
        enMode _Mode;

        enum enGeschlecht { Maenlich = 0, Weiblich = 1}
        int _PersonID = -1;
        clsMenschenDaten _Personen;

        public frmAddUpdatePerson()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _PersonID = PersonID;
        }
        private void _ResetDefaultValues()
        {
            _FillCountrysInCmLand();
            if (_Mode == enMode.AddNew)
            {
                lblTitel.Text = "Neue Person hinzufügen";
                _Personen = new clsMenschenDaten();
            }
            else
                lblTitel.Text = "Update Person";
            // set default image for the Person.
            if (rbMaenlich.Checked)
            {
                pbPersonBild.Image = Resources.Male_512;
            }
            else
                pbPersonBild.Image = Resources.Female_512;
             // hide/ show the remove like incase there is no image for the person
            lnlLöschen.Visible = (pbPersonBild.ImageLocation != null);

            // we set the max Date to 18 years from today , and set the default value the same.
            dtpGeburtstag.MaxDate = DateTime.Now.AddYears(-18);
            dtpGeburtstag.Value = dtpGeburtstag.MaxDate;

            // should not allow adding Age more than 100 years;
            dtpGeburtstag.MinDate = DateTime.Now.AddYears(-100);
            // we set here a default Country to Syrien.
            cbLand.SelectedIndex = cbLand.FindString("Syrien");

            txtbvorname.Text = "";
            txtbNachname.Text = "";
            txtbAusweisNummer.Text = "";
            txtbAnschrift.Text = "";
            txtbTelefon.Text = "";
            rbMaenlich.Checked = true;
            txtbEmail.Text = "";
        }

        private void _FillCountrysInCmLand()
        {
            DataTable dt = clsLänderDaten.GetAllCountries();
            foreach (DataRow row in dt.Rows)
            {
               cbLand.Items.Add(row["LandsName"]);
            }
            
        }

        private void _LoadData()
        {
            _Personen = clsMenschenDaten.Find(_PersonID);
            if(_Personen == null)
            {
                MessageBox.Show("Keine Person Mit der ID = " + _PersonID, "Keine Person gefunden", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            // the following code will not be executed if the person is not found..
            lblPersonID.Text = _PersonID.ToString();
            txtbAusweisNummer.Text = _Personen.AusweisNummer;
            txtbvorname.Text = _Personen.Vorname;
            txtbNachname.Text = _Personen.Nachname;
            dtpGeburtstag.Value = _Personen.Geburtstag;
            if (_Personen.Geschlecht == 0)
                rbMaenlich.Checked = true;
            else
                rbWeiblich.Checked = true;
            txtbAnschrift.Text = _Personen.Anschrift;
            txtbTelefon.Text = _Personen.Telefon;
            txtbEmail.Text = _Personen.Email;
            cbLand.SelectedIndex = cbLand.FindString(_Personen.LandInfo.LandsName);

            // load Person Image incase it was set.
            if (_Personen.FotoPfad != "")
                pbPersonBild.ImageLocation = _Personen.FotoPfad;

            // hide/ show the remove like incase there is no image for the person
            lnlLöschen.Visible = (_Personen.FotoPfad != null);
        }
        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private bool _HandlePersonImage()
        {
            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.

            //_Personen.FotoPfad contains the old Image, we check if it changed then we copy the new Image
            if (_Personen.FotoPfad != pbPersonBild.ImageLocation)
            {
                if (_Personen.FotoPfad != "")
                {
                    // First we delete the old Image from the Folder in case there is any.
                    try
                    {
                        File.Delete(_Personen.FotoPfad);
                    }
                    catch (IOException)
                    {
                        // we could not delete the File
                        // log it later
                    }
                }
            }

            if (pbPersonBild.ImageLocation != null)
            {
                // here we copy the new Image to the ImgeFolder after we rename it
                string SourceImageFile = pbPersonBild.ImageLocation.ToString();
                if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                {
                    pbPersonBild.ImageLocation = SourceImageFile;
                    return true;
                }
                else
                {
                    MessageBox.Show("Fehler beim Kopieren des Bilds", "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
            
        }
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                // here we don't continue because the form is not valid.
                MessageBox.Show("Mansche Felder sind nicht validiert, Setze die Mauszeiger über das rote Sympl(e),um den Fehler zu sehen",
                    "ValidierungsFehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_HandlePersonImage())
                return;

            _Personen.AusweisNummer = txtbAusweisNummer.Text.Trim();
            _Personen.Vorname = txtbvorname.Text.Trim();
            _Personen.Nachname = txtbNachname.Text.Trim();
            _Personen.Geburtstag = dtpGeburtstag.Value;
            if (rbMaenlich.Checked)
                _Personen.Geschlecht = (short)enGeschlecht.Maenlich;
            else
                _Personen.Geschlecht = (short)enGeschlecht.Weiblich;

            _Personen.Anschrift = txtbAnschrift.Text.Trim();
            _Personen.Email = txtbEmail.Text.Trim();
            _Personen.Telefon = txtbTelefon.Text.Trim();

            if (pbPersonBild.ImageLocation != null)
                _Personen.FotoPfad = pbPersonBild.ImageLocation;
            else
                _Personen.FotoPfad = "";

            int landId = clsLänderDaten.Find(cbLand.Text).LandID;
            _Personen.LandID = landId;

            if (_Personen.Save())
            {
                lblPersonID.Text = _Personen.PersonID.ToString();
                _Mode = enMode.Update;
                MessageBox.Show("Daten wurden erfolgreich gespeichert", "Data Speichern", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataBack?.Invoke(this, _Personen.PersonID);
                this.Close();
            }
            else
                MessageBox.Show("Fehler beim Sichern der Daten ist aufgetreten", "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lnlBildSetzen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Bild Datei|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string BildDatei = openFileDialog1.FileName;
                pbPersonBild.ImageLocation = BildDatei;
                lnlLöschen.Visible = true;
            }
        }

        private void lnlLöschen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonBild.ImageLocation = null;
            lnlLöschen.Visible = false;

            if (rbMaenlich.Checked)
                pbPersonBild.Image = Resources.Male_512;
            else
                pbPersonBild.Image = Resources.Female_512;
        }

        private void rbMaenlich_CheckedChanged(object sender, EventArgs e)
        {
            if(pbPersonBild.ImageLocation == null)
                pbPersonBild.Image = Resources.Male_512;
        }

        private void rbWeiblich_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonBild.ImageLocation == null)
                pbPersonBild.Image = Resources.Female_512;
        }

        private void txtbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtbEmail.Text == "")
                return;

            if (!clsValidierung.ValidateEmail(txtbEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbEmail, "Falsche Format für die Email");
                return;
            }
            else
                errorProvider1.SetError(txtbEmail, null);
        }

        private void txtbvorname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbvorname.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbvorname, "Dieses Feled muss Daten enthalten!");
                return;
            }
            else
                errorProvider1.SetError(txtbvorname, null);
        }

        private void txtbNachname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbNachname.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbNachname, "Dieses Feled muss Daten enthalten!");
                return;
            }
            else
                errorProvider1.SetError(txtbNachname, null);
        }

        private void txtbAusweisNummer_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbAusweisNummer.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbAusweisNummer, "Dieses Feled muss Daten enthalten!");
                return;
            }
            else
                errorProvider1.SetError(txtbAusweisNummer, null);

            if(txtbAusweisNummer.Text != _Personen.AusweisNummer && clsMenschenDaten.IsPersonExist(txtbAusweisNummer.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbAusweisNummer,"Diese AusweisNummer wird verwendet für andere Benutzer");
            }
            else
                errorProvider1.SetError(txtbAusweisNummer, null);
        }

        private void txtbAnschrift_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbAnschrift.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbAnschrift, "Dieses Feled muss Daten enthalten!");
                return;
            }
            else
                errorProvider1.SetError(txtbAnschrift, null);
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
