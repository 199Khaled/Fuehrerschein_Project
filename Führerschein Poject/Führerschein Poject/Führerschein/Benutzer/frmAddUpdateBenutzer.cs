using MenschenDataForm;
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

namespace Führerschein
{
    public partial class frmAddUpdateBenutzer : Form
    {
        public enum enMode { AddNew = 0, Update = 1}
        private enMode _Mode;
        private int _BenutzerID = -1;
        private clsBenutzerDaten _Benutzer;

        private bool _Password = false;

        // define a delegate to return data
        public delegate void DataBackEventHandler(object sender, int Benutzer);
        public event DataBackEventHandler DataBack;
        public frmAddUpdateBenutzer()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddUpdateBenutzer(int BenutzerID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _BenutzerID = BenutzerID;
        }

        public frmAddUpdateBenutzer(int BenutzerID, bool Password)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _BenutzerID = BenutzerID;
            _Password = Password;
        }

         

        private void _ResetDefaultValues()
        {
            if(_Mode == enMode.AddNew)
            {
                lblTile.Text = "\tNeu Benutzer hinzufügen";
                this.Text = "Neu Benutzer hinzufügen";
                _Benutzer = new clsBenutzerDaten();
                tpLoginInfo.Enabled = false;
                ctrlPersonKarteMitFilter1.TextBoxFocuse();
            }
            
            else
            {
               lblTile.Text = "      Update Benutzer";
                this.Text = "Update Benutzer";

                tpLoginInfo.Enabled = true;
                btnBeenden.Enabled = true;
                btnNext.Select();
            }

            lblBenutzerID.Text = "???";
            txtBenutzerName.Text = "";
            txtBenutzerPassword.Text = "";
            txtPasswordBestätigen.Text = "";
            chkIsActive.Checked = true;
                
        }

        private void _LoadBenutzerData()
        {
            _Benutzer = clsBenutzerDaten.FindByUserID(_BenutzerID);
            ctrlPersonKarteMitFilter1.FilterEnabled = false;
            
            if(_Benutzer == null)
            {
                MessageBox.Show("Kein Benutzer mit ID " + _Benutzer, "Benutzer nicht gefunden", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            if(_Password)
            {
                tcBenutzerInfo.SelectedTab = tcBenutzerInfo.TabPages["tpLoginInfo"];
                txtBenutzerName.Select();
            }
            // this following code will cot be executed if the person is not found.
            lblBenutzerID.Text = _Benutzer.BenutzerID.ToString();
            txtBenutzerName.Text = _Benutzer.BenutzerName;
            txtBenutzerPassword.Text = _Benutzer.Password;
            txtPasswordBestätigen.Text = _Benutzer.Password;
            chkIsActive.Checked = _Benutzer.IsAktive;
            // we load the person data.
            ctrlPersonKarteMitFilter1.LoadPersonInfo(_Benutzer.PersonID);
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Manche Feleder sind nicht validiert, setzte die Mauszeiger aus die rote icons," +
                    "um den Fehler zu sehen","Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Benutzer.PersonID = ctrlPersonKarteMitFilter1.PersonID;
            _Benutzer.BenutzerName = txtBenutzerName.Text.Trim();
            _Benutzer.Password = txtBenutzerPassword.Text.Trim();
            _Benutzer.IsAktive = chkIsActive.Checked;

            if(_Benutzer.Save())
            {
                lblBenutzerID.Text = _Benutzer.BenutzerID.ToString();
                _Mode = enMode.Update;
                lblTile.Text = "Update Benutzer";
                this.Text = "Update Benutzer";
                MessageBox.Show("Daten wurden erfolgreich gespeichert", "Speichern", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, _Benutzer.BenutzerID);
                this.Close();
            }
            else
            {
                MessageBox.Show("Daten wurden nicht erfolgreich gespeichert", "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void frmAddUpdateBenutzer_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadBenutzerData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(_Mode == enMode.Update)
            {
                btnSpeichern.Enabled = true;
                tpLoginInfo.Enabled = true;
                tcBenutzerInfo.SelectedTab = tcBenutzerInfo.TabPages["tpLoginInfo"];
                txtBenutzerName.Select();

                return;
            }
             // incase of add new mode
            if (ctrlPersonKarteMitFilter1.PersonID != -1)
            {
                if(clsBenutzerDaten.IsUserExistForPersonID(ctrlPersonKarteMitFilter1.PersonID))
                {
                    MessageBox.Show("Die ausgewählte Person ist schon ein Benutzer," +
                        "Wählen Sie bitte eine Andere aus", "andere Person Auswählen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonKarteMitFilter1.TextBoxFocuse();
                }
                else
                {
                    btnSpeichern.Enabled = true;
                    tpLoginInfo.Enabled = true;
                    tcBenutzerInfo.SelectedTab = tcBenutzerInfo.TabPages["tpLoginInfo"];
                    txtBenutzerName.Select();

                }
            }
            else
            {
                MessageBox.Show("Wählen Sie bitte eine Person aus", "Person Auswählen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonKarteMitFilter1.FilterFocuse();
            }
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBenutzerName_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBenutzerName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtBenutzerName, "Das Feld muss Daten enthalten");
                return;
            }
            else
                errorProvider1.SetError(txtBenutzerName, null);

            if (_Mode == enMode.AddNew)
            {
                if (clsBenutzerDaten.IsUserExist(txtBenutzerName.Text))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtBenutzerName, "BenutzerName ist verwendet bei einem andern Benutzer");
                    return;
                }
                else
                    errorProvider1.SetError(txtBenutzerName, null);
            }
            else
            {
                // Check again if the User exists...
                if (_Benutzer.BenutzerName != txtBenutzerName.Text.Trim())
                {
                    
                    if (clsBenutzerDaten.IsUserExist(txtBenutzerName.Text))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtBenutzerName, "BenutzerName ist verwendet bei einem andern Benutzer");
                        return;
                    }
                    else
                        errorProvider1.SetError(txtBenutzerName, null);
                    
                }
            }
        }

        private void txtBenutzerPassword_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBenutzerPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtBenutzerPassword, "Das Feld muss Daten enthalten");
                return;
            }
            else
                errorProvider1.SetError(txtBenutzerPassword, null);
        }

        private void txtPasswordBestätigen_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtPasswordBestätigen.Text.Trim() != txtBenutzerPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPasswordBestätigen, "Die PasswordBestätigung muss das erste Password entsprechen");
            }
            else
                errorProvider1.SetError(txtPasswordBestätigen, null);
        }

        private void ctrlPersonKarteMitFilter1_Load(object sender, EventArgs e)
        {

        }
    }
}
