using MenschenDataForm;
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
    public partial class ctrlBenutzerKarte : UserControl
    {
        private int _BenutzerID = -1;
        public int BenuterID
        {
            get { return _BenutzerID; }
        }
        private clsBenutzerDaten _Benutzer;
        private clsMenschenDaten _Personen;

        public ctrlBenutzerKarte()
        {
            InitializeComponent();
        }

        public void LoadBenutzerDaten(int BenutzerID)
        {
            _BenutzerID =BenutzerID;
            _Benutzer = clsBenutzerDaten.FindByUserID(_BenutzerID);
            if(_Benutzer == null)
            {
                MessageBox.Show("Benutzer mit BenutzerID= " + _BenutzerID + " wurde nicht gefunden",
                     "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillUserData();
            ctrlPersonKarte1.LoadPersonData(_Benutzer.PersonID);
        }

        private void _FillUserData()
        {
            ctrlPersonKarte1.LoadPersonData(_Benutzer.PersonID);

            lblBenutzerID.Text = _Benutzer.BenutzerID.ToString();
            lblBenutzerName.Text = _Benutzer.BenutzerName;
            if (_Benutzer.IsAktive)
                lblIsAktive.Text = "Yes";
            else
                lblIsAktive.Text = "No";
        
        }
    }
}
