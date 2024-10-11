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

namespace Führerschein
{
    public partial class frmUpdateTestTypen : Form
    {
        private enum enMode { Update = 0, AddNew = 1}
        enMode _Mode;
        private clsTestTypen.enTestType _TestTypeID = clsTestTypen.enTestType.SehTest;
        clsTestTypen _TestType;
        public frmUpdateTestTypen(clsTestTypen.enTestType enTestType)
        {
            InitializeComponent();
            _TestTypeID = enTestType;
        }

        private void frmUpdateTestTypen_Load(object sender, EventArgs e)
        {
            _TestType = clsTestTypen.Find(_TestTypeID);
            if(_TestType == null)
            {
                MessageBox.Show("es wurde kein TestType gefunden mit ID " + _TestTypeID,
                    "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
             }

            lblTestTypeID.Text = ((int)_TestType.ID).ToString();
            txtbTitel.Text = _TestType.TestTypeTitel.Trim();
            txtbBeschreibung.Text = _TestType.TestTypeDescription.Trim();
            txtbGebühren.Text = _TestType.TestGebühren.ToString().Trim();
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Die Felder dürfen keine Leere Inhalte haben", "Fehler Meldung",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _TestType.TestTypeTitel = txtbTitel.Text;
            _TestType.TestTypeDescription = txtbBeschreibung.Text;
            _TestType.TestGebühren = Convert.ToDecimal(txtbGebühren.Text);

            // we check here ,if there is no changes ,then we save nothing in database 
            if (txtbTitel.Text != clsTestTypen.Find(_TestTypeID).TestTypeTitel ||
               Convert.ToDecimal(txtbGebühren.Text) != clsTestTypen.Find(_TestTypeID).TestGebühren)
            {
                if (_TestType.Save())
                {
                    _Mode = enMode.Update;
                    MessageBox.Show("Daten wurden erfolgreich geändert und gespeichert",
                         "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Daten wurden nicht erfolgreich geändert und gespeichert",
                      "Feheler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbGebühren.Focus();
                }
            }
            else
            {
                MessageBox.Show("Keine Daten wurden geändert, um sie zu speichern", "Achtung",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtbGebühren.Focus();
            }
        }

        private void txtbTitel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbTitel.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbTitel, "Das Feld muss Daten enthalten");
            }
            else
                errorProvider1.SetError(txtbTitel, null);
        }

        private void txtbBeschreibung_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbBeschreibung.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbBeschreibung, "Das Feld muss Daten enthalten");
            }
            else
                errorProvider1.SetError(txtbBeschreibung, null);
        }

        private void txtbGebühren_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
