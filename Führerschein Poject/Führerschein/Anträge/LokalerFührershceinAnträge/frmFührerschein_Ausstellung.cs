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
    public partial class frmFührerschein_Ausstellung : Form
    {
        private int _LokalerFührerscheürinAntragsID = -1;
        private clsLokalerFührerscheinAntrag _LokalerFührerscheinAntrag;

        public frmFührerschein_Ausstellung(int LokalerFührerscheinAntragsID)
        {
            InitializeComponent();
            _LokalerFührerscheürinAntragsID = LokalerFührerscheinAntragsID;
        }

        private void frmFührerschein_Ausstellung_Load(object sender, EventArgs e)
        {
            txtNotizen.Focus();

            _LokalerFührerscheinAntrag = clsLokalerFührerscheinAntrag.FindLocalDrivingApplicationInfoByID(_LokalerFührerscheürinAntragsID);

            if(_LokalerFührerscheinAntrag == null)
            {
                MessageBox.Show("Keinen Antrag mit der ID = " + _LokalerFührerscheürinAntragsID + " gefunden", "Nicht erlaubt",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }    

            if(!_LokalerFührerscheinAntrag.PassedAllTests())
            {
                MessageBox.Show("Die Person soll erst Alle Prüfungen bestehen!", "Nicht erlaubt",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            int FührerscheinID = _LokalerFührerscheinAntrag.GetActiveLicense();

            if(FührerscheinID != -1)
            {
                MessageBox.Show("Diese Person hat bereits einen Führerschein mit der ID " + FührerscheinID.ToString(), "Nicht erlaubt",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            ctrFührerscheinAntragsInfo1.LoadLocalApplicationInfosByApplicationID(_LokalerFührerscheürinAntragsID);
            ctrFührerscheinAntragsInfo1.LoadBaseApplicationInfosByApplicationID(_LokalerFührerscheürinAntragsID);
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFührerscheinAusstellung_Click(object sender, EventArgs e)
        {
            int FührerscheinID = _LokalerFührerscheinAntrag.IssuedLicenseForTheFirsTime(clsGlobaleKlasse.Benutzer.BenutzerID, txtNotizen.Text.Trim());

            if(FührerscheinID != -1)
            {
                MessageBox.Show("Der Führerschein wurde erfolgreich ausgestellt mit der ID = " + FührerscheinID.ToString(), "Ausstellung Eines Führerschiens",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Ein Fehler beim Ausstellen des Führerscheins ist aufgetreten!", "Fheler Meldung",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
