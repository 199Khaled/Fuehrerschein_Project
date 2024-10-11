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
    public partial class ctrFahrerLicenseInfoMitFilter : UserControl
    {
        private int _LicenseID = -1;
        //Benutzer Defenierte handler Delegate mit Parameter.
        public event Action<int> OnLicenseSelected;
        
        //Protected Virtual Methode zur Freigabe Des Ereignises mit Parameter erstellen
        protected virtual void PersonSelected(int LicenseID)
        {
            Action<int> handler = OnLicenseSelected;
            if(handler != null)
            {
                handler(LicenseID); // Das Ereignis mit Parameter freigeben!
            }
        }
        public ctrFahrerLicenseInfoMitFilter()
        {
            InitializeComponent();
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }

            set { 
                _FilterEnabled = value;
                gbFahrerLicenseFilter.Enabled = _FilterEnabled;
                }

        }

        public int LicenseID
        {
            get { return ctrFahrerLicenseInfo1.LicenseID; }
        }

        public clsLicenseDaten SelectedLicenseInfo
        {
            get { return ctrFahrerLicenseInfo1.SelectedLicenseInfo; }
            
        }

        public void LoadLicenseInfo(int LicenseID)
        {
            ctrFahrerLicenseInfo1.LoadLicenseData(LicenseID);
            _LicenseID = ctrFahrerLicenseInfo1.LicenseID;
            
            //if(OnLicenseSelected != null && FilterEnabled)
            //{
            //    //Das Ereignis mit Parameter freigeben
            //    OnLicenseSelected(_LicenseID);
            //}
        }

        public void FiltrSelect()
        {
            txtbFilterWert.Select();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                MessageBox.Show("Das Feld muss eine ID als Nummer enthalten ", "Fehler Meldung");
                return;
            }
            _LicenseID = int.Parse(txtbFilterWert.Text);
            LoadLicenseInfo(_LicenseID);         
        }

        private void txtbFilterWert_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbFilterWert.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbFilterWert, "Das Feld darf nicht leer sein");
            }
            else
                errorProvider1.SetError(txtbFilterWert, null);
        }

        private void txtbFilterWert_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            //wir überprüfen ,ob der Anwender den Enter gedückt hat Wenn ja  dann ausführen..
            if (e.KeyChar == (char)13)
            {
                btnSuchen.PerformClick();
            }
        }   
        private void ctrFahrerLicenseInfoMitFilter_Load(object sender, EventArgs e)
        {
        
        }
    }
}
