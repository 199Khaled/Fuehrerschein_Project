using MenschenDataForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Führerschein
{
    public partial class frmUpdateAntragsKategorie : Form
    {
        private enum enMode { Update = 0 }
        enMode _Mode;
        private int _AntragsID = -1;
        clsAntragsKategorien _Antrag;
        public frmUpdateAntragsKategorie(int ID)
        {
            InitializeComponent();
            _AntragsID = ID;
        }

        private void frmUpdateAntragsKategorie_Load(object sender, EventArgs e)
        {
            _Antrag = clsAntragsKategorien.Find(_AntragsID);
            if (_Antrag == null)
            {
                MessageBox.Show("Antrag mit ID = " + _Antrag.ID + " wurde nicht gefunden",
                    "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblID.Text = _Antrag.ID.ToString();
            txtbTitel.Text = _Antrag.Titel;
            txtbGebühren.Text = _Antrag.Gebühren.ToString();
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Die Feleder Müssen richtige Daten enthalten", "Fehler Meldung",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // i assigned the previously data in Variable to chack if there is any change 
             // if there is no Change ,it will nothig be saved 
            string PreviousTitel = _Antrag.Titel;
            decimal previousMony = _Antrag.Gebühren;

            _Antrag.Titel = txtbTitel.Text.Trim();
            _Antrag.Gebühren = Convert.ToDecimal(txtbGebühren.Text.Trim());

            if (txtbTitel.Text!= PreviousTitel ||  Convert.ToDecimal(txtbGebühren.Text)!= previousMony)
            {
                if (_Antrag.Save())
                {

                    MessageBox.Show("Daten wurden erfolgreich geändert und gespeichert", "Meldung",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }


                else
                    MessageBox.Show("Fheler beim Speichern ist aufgetreten", "Fehler Meldung",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("es sing keine Änderungen durchgeführt", "Meldung",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbTitel.Focus();
            }
        }
        

        private void txtbGebühren_Validating(object sender, CancelEventArgs e)
        {
            if (txtbGebühren.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbGebühren, "Das Feld muss Daten enthalten");
            }
            else
                errorProvider1.SetError(txtbGebühren, null);
            
        }

        private void txtbTitel_Validating(object sender, CancelEventArgs e)
        {
            if (txtbTitel.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbTitel, "Das Feld muss Daten enthalten");
            }
            else
                errorProvider1.SetError(txtbTitel, null);
        }

    }
}
