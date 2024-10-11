using MenschenDataForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace Führerschein
{
    public partial class frmPasswordÄndern : Form
    {
        private enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;
        private clsBenutzerDaten _Benutzer;
        private int _BenutzerID = -1;
        public frmPasswordÄndern(int BenutzerID)
        {
            InitializeComponent();
            _BenutzerID = BenutzerID;
            _Mode = enMode.Update;

        }

        private void _ResetDefaultValues()
        {
            txtbAktuellesPassword.Text = "";
            txtbNeuesPassword.Text = "";
            txtbPasswordBestätigung.Text = "";
        }
        private void _LoadData()
        {
            _ResetDefaultValues();

            _Benutzer = clsBenutzerDaten.FindByUserID(_BenutzerID);
            if (_Benutzer == null)
            {
                MessageBox.Show("Benutzer mit ID: " + _BenutzerID + "wurde nicht gefunden",
                    "FehlerMeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtbAktuellesPassword.Text = _Benutzer.Password;
            ctrlBenutzerKarte1.LoadBenutzerDaten(_BenutzerID);

        }
        private void ctrlBenutzerKarte1_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private bool _IsTextBoxEmpty(TextBox text)
        {
            // wir prüfen hier,ob TextFelder leer oder nicht leer sind
            if (string.IsNullOrEmpty(text.Text))
            {
                errorProvider1.SetError(text, "Das Feled darf nicht leer sein");
                return true;
            }
            else
            {
                errorProvider1.SetError(text, null);
                return false;
            }
        }

        private bool _Validation()
        {
            bool valid = true;
            // wir prüfen hier ,ob alle TextFelder nicht leer sind Veketteung der Felder mit 
            // Bitwise & .
            valid &= !_IsTextBoxEmpty(txtbNeuesPassword);
            valid &= !_IsTextBoxEmpty(txtbPasswordBestätigung);

            return valid;
        }
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (!_Validation())
            {
                MessageBox.Show("Kein Feld darf leer sein", "Leere Felder",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtbNeuesPassword.Text != txtbPasswordBestätigung.Text)
            {
                MessageBox.Show("Die Passwörte müssen übereinstimmen!!", "Übereinstimmung",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Benutzer.Password = txtbNeuesPassword.Text;
            _Benutzer.Password = txtbPasswordBestätigung.Text;


            if (_Benutzer.Save())
            {
                _Mode = enMode.Update;
                MessageBox.Show("Password wurde erfolgreich geändert", "Password Ändern",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Password wurde nicht erfolgreich geändert", "Password Ändern",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool _IsPasswordHide = true;

        private void _ChenageBetweenCharAndStar(TextBox text)
        {
            // überprüfen , ob das Passwort unsichbar ist. dann zu sichtbar ändern und andersrum .
            // wir wechseln hier zwischen *** und Buchstaben
            if (_IsPasswordHide)
            {
                text.PasswordChar = '\0';
            }
            else
                text.PasswordChar = '*';

            // Umkehrung des Flags für den nächsten Klick
            _IsPasswordHide = !_IsPasswordHide;
        }
        private void btnAktuellesPasswordSehen_Click(object sender, EventArgs e)
        {
            _ChenageBetweenCharAndStar(txtbAktuellesPassword);
        }

        private void btnNeuesPasswordSehen_Click(object sender, EventArgs e)
        {
            _ChenageBetweenCharAndStar(txtbNeuesPassword);
        }

        private void btnPasswortBastätigungSehen_Click(object sender, EventArgs e)
        {
            _ChenageBetweenCharAndStar(txtbPasswordBestätigung);
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
