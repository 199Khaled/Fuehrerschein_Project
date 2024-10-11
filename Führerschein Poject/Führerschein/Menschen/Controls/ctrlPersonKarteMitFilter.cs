using MenschenDatenForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Führerschein
{
    public partial class ctrlPersonKarteMitFilter : UserControl
    {
        // define a custom event handler delegate with parameters
        public event Action<int> OnPersonSelected;

        // Create a protected methode to rais the event with a parameter
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if(handler != null)
            {
                handler(PersonID);  // rease the event with the parameter
            }
        }

        private bool _ShowAddPerson = true;

        public bool ShowAddPerson
        {
            get { return _ShowAddPerson; }
            set
            {
                _ShowAddPerson = value;
                btnAddPerson.Visible = _ShowAddPerson;
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }
        public ctrlPersonKarteMitFilter()
        {
            InitializeComponent();
        }
        public int PersonID
        {
            get { return ctrlPersonKarte1.PersonID;}
        }

        public clsMenschenDaten SelectedPersonInfo
        {
            get { return ctrlPersonKarte1.SelectedPersonInfo; }
        }

        public void LoadPersonInfo(int PersonID)
        {
           cbFilterBei.SelectedIndex = 0;
           txtbFilterWert.Text = PersonID.ToString();
            _FindNow();
        }

        public bool IsPersonFound()
        {
            return ctrlPersonKarte1.IsPersonFound;
        }

        private void _FindNow()
        {
            switch (cbFilterBei.Text)
            {
                case "PersonID":
                    ctrlPersonKarte1.LoadPersonData(int.Parse(txtbFilterWert.Text.Trim()));
                    break;

                case "AusweisNum":
                    ctrlPersonKarte1.LoadPersonData(txtbFilterWert.Text);
                    break;

                default:
                    break;
            }

            if(OnPersonSelected != null)
            {
                // rais the event with a parameter...
                OnPersonSelected(ctrlPersonKarte1.PersonID);
            }
        }
        private void btnSuchen_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                // don't countinue because the form is not valid.
                MessageBox.Show("Manche Felder sing nicht validiert", "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FindNow();
        }

        private void cbFilterBei_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbFilterWert.Text = "";
            txtbFilterWert.Focus();
        }

        private void txtbFilterWert_Validating(object sender, CancelEventArgs e)
        {

            //if (string.IsNullOrEmpty(txtbFilterWert.Text))
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txtbFilterWert, "Diese Feled Muss Daten enthalten");
            //    return;
            //}
            //else
            //    errorProvider1.SetError(txtbFilterWert, null);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.DataBack +=  _DataBackValue;   // Subscribe to the event
            frm.ShowDialog();
        }

        private void _DataBackValue(object sender, int PersonID)
        {
            // handle the data received.
            cbFilterBei.SelectedIndex = 1;
            txtbFilterWert.Text = PersonID.ToString();
            ctrlPersonKarte1.LoadPersonData(PersonID);
        }

        private void txtbFilterWert_KeyPress(object sender, KeyPressEventArgs e)
      {
            // this will allow only digits if person id is selected
            if (cbFilterBei.Text == "PersonID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }

            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {
                btnSuchen.PerformClick();
            }
            
        }

        public void FilterFocuse()
        {
            txtbFilterWert.Select();
        }

        public void TextBoxFocuse()
        {
            txtbFilterWert.Select();
        }
        private void ctrlPersonKarteMitFilter_Load(object sender, EventArgs e)
        {
            cbFilterBei.SelectedIndex = 0;
            //txtbFilterWert.Select();
        }
    }
}
