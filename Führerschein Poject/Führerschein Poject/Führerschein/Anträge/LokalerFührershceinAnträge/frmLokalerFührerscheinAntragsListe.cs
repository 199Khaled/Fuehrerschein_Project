using MenschenDataForm;
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
    public partial class FrmLokalerFührerscheinAntragsListe : Form
    {
        private DataTable _dataTableGetAlleLokalerFührerscheinAnträge;
        public FrmLokalerFührerscheinAntragsListe()
        {
            InitializeComponent();
        }

        private void FrmLokalerFührerscheinAntragsListe_Load(object sender, EventArgs e)
        {
             cbFilterLokalerFührerschein.SelectedIndex = 0;
            _dataTableGetAlleLokalerFührerscheinAnträge = clsLokalerFührerscheinAntrag.GetAllLocalDrivingLicenseApplications();
            dgvLokalerFührerscheinAntragsListe.DataSource = _dataTableGetAlleLokalerFührerscheinAnträge;
            lblRecord.Text = dgvLokalerFührerscheinAntragsListe.Rows.Count.ToString();

            if (dgvLokalerFührerscheinAntragsListe.Rows.Count > 0)
            {
                dgvLokalerFührerscheinAntragsListe.Columns[0].HeaderText= "LF_AntragsID";
                dgvLokalerFührerscheinAntragsListe.Columns[0].Width = 100;

                dgvLokalerFührerscheinAntragsListe.Columns[1].HeaderText = "Führerschein Klasse";
                dgvLokalerFührerscheinAntragsListe.Columns[1].Width = 250;

                dgvLokalerFührerscheinAntragsListe.Columns[2].HeaderText = "Ausweisnummmer";
                dgvLokalerFührerscheinAntragsListe.Columns[2].Width = 120;

                dgvLokalerFührerscheinAntragsListe.Columns[3].HeaderText = "Vollname";
                dgvLokalerFührerscheinAntragsListe.Columns[3].Width = 250;

                dgvLokalerFührerscheinAntragsListe.Columns[4].HeaderText = "AntragsDatum";
                dgvLokalerFührerscheinAntragsListe.Columns[4].Width = 120;

                dgvLokalerFührerscheinAntragsListe.Columns[5].HeaderText = "Bestandene Prüfungen";
                dgvLokalerFührerscheinAntragsListe.Columns[5].Width = 100;

                dgvLokalerFührerscheinAntragsListe.Columns[6].HeaderText = "Status";
                dgvLokalerFührerscheinAntragsListe.Columns[6].Width = 100;
            }
        }

        private void txtbFilterWert_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            //Map selected Filter to real Column name
            // Ordne den  ausgewählte Filter zu den tatsächlichen Spaltenname zu...
            switch(cbFilterLokalerFührerschein.Text)
            {
                case "LF_AntragsID":
                    FilterColumn = "LokalerFührerscheinAntragsID";
                    break;

                case "Führerschein Klasse":
                    FilterColumn = "KlassenName";
                    break;

                case "Ausweisnummer":
                    FilterColumn = "Ausweisnummer";
                    break;

                case "Vollname":
                    FilterColumn = "Vollname";
                    break;

                case "AntragsDatum":
                    FilterColumn = "AntragsDatum";
                    break;

                case "Bestandene Prüfung":
                    FilterColumn = "BestandenePrüfungenZahl";
                    break;

                default:
                    FilterColumn = "None";
                    break;                   
            }


            if(txtbFilterWert.Text == "" || FilterColumn == "None")
            {
                _dataTableGetAlleLokalerFührerscheinAnträge.DefaultView.RowFilter = "";
                lblRecord.Text = dgvLokalerFührerscheinAntragsListe.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "LokalerFührerscheinAntragsID")
            {
                _dataTableGetAlleLokalerFührerscheinAnträge.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtbFilterWert.Text.Trim());
            }
            else
            {
                _dataTableGetAlleLokalerFührerscheinAnträge.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", FilterColumn, txtbFilterWert.Text.Trim());
            }
            lblRecord.Text = dgvLokalerFührerscheinAntragsListe.Rows.Count.ToString();
        }

        private void cbFilterLokalerFührerschein_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbFilterWert.Visible = (cbFilterLokalerFührerschein.Text != "None");
            if(txtbFilterWert.Visible)
            {
                txtbFilterWert.Text = "";
                txtbFilterWert.Focus();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAntragZumNeuenLokalenFührerschein frm = new frmAntragZumNeuenLokalenFührerschein();
            frm.DataBack += _DataBackFromAddNewApplication;
            frm.ShowDialog();

        }

        private void _DataBackFromAddNewApplication(object sender)
        {
            FrmLokalerFührerscheinAntragsListe_Load(sender, null);
        }
        private void antragsDetailsSehenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LokalerFührerscheinAntragsID = (int)dgvLokalerFührerscheinAntragsListe.CurrentRow.Cells[0].Value;
            frmLokalerFührerscheinAntragsInfo frm = new frmLokalerFührerscheinAntragsInfo(LokalerFührerscheinAntragsID);
            frm.ShowDialog();


        }

        private void updateAntragToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LokalerFührerscheinAntragsID = (int)dgvLokalerFührerscheinAntragsListe.CurrentRow.Cells[0].Value;
            frmAntragZumNeuenLokalenFührerschein frm = new frmAntragZumNeuenLokalenFührerschein(LokalerFührerscheinAntragsID);
            frm.ShowDialog();

            FrmLokalerFührerscheinAntragsListe_Load(null, null);
        }

        private void antragLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Sind Sie sicher,Dass Sie Diesen Antrag löschen möchten? Y/N? ",
               "Bestätigung",MessageBoxButtons.YesNo,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            {
                return;
            }     

            int LokalerFührerscheinAntragsID = (int)dgvLokalerFührerscheinAntragsListe.CurrentRow.Cells[0].Value;
            clsLokalerFührerscheinAntrag LokalerFührerscheinAntrag =
            clsLokalerFührerscheinAntrag.FindLocalDrivingApplicationInfoByID(LokalerFührerscheinAntragsID);

            if(LokalerFührerscheinAntrag != null)
            {
                if(LokalerFührerscheinAntrag.Delete(LokalerFührerscheinAntragsID))
                {
                    MessageBox.Show("Antrag wurde erfolgreich gelöscht", "Löschen Bestätigen",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmLokalerFührerscheinAntragsListe_Load(null, null);
                }
                else
                    MessageBox.Show("Antrag wurde Nicht erfolgreich gelöscht", "Löschen Bestätigen",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
   
        }

        private void antragZurückziehenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sind Sie sicher,Dass Sie Diesen Antrag zurückziehen möchten? Y/N? ",
            "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            {
                return;
            }

            int LokalerFührerscheinAntragsID = (int)dgvLokalerFührerscheinAntragsListe.CurrentRow.Cells[0].Value;
            clsLokalerFührerscheinAntrag LokalerFührerscheinAntrag =
            clsLokalerFührerscheinAntrag.FindLocalDrivingApplicationInfoByID(LokalerFührerscheinAntragsID);

            if (LokalerFührerscheinAntrag != null)
            {
                if (LokalerFührerscheinAntrag.Cancle())
                {
                    MessageBox.Show("Der Antrag wurde erfolgreich Zurückgezogen", "Zurückziehen Bestätigen",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmLokalerFührerscheinAntragsListe_Load(null, null);
                }
                else
                    MessageBox.Show("Antrag wurde Nicht erfolgreich gelöscht", "Löschen Bestätigen",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }

        private void schreibTestFestlegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _TestFestlegen(clsTestTypen.enTestType.SchreibTest);
        }

        private void cmsLokalerFührerschein_Opening(object sender, CancelEventArgs e)
        {
            int LokalerFührerscheinAtragsID = (int)dgvLokalerFührerscheinAntragsListe.CurrentRow.Cells[0].Value;
            clsLokalerFührerscheinAntrag LokalerFührerscheinAntrag;
            LokalerFührerscheinAntrag = clsLokalerFührerscheinAntrag.FindLocalDrivingApplicationInfoByID(LokalerFührerscheinAtragsID);

            int InsgesamteBestandenePrüfungen = (int)dgvLokalerFührerscheinAntragsListe.CurrentRow.Cells[5].Value;

            //we check here if license already is issued 
            bool IsFührerscheinExistiert = LokalerFührerscheinAntrag.IsLicenseIssued();

            // Enable/Disable/ Cancle Menue Item
            //Enabled only if Person passed all tests and does not have License
            ausstellungDesFührerscheinserstmalToolStripMenuItem.Enabled = (InsgesamteBestandenePrüfungen == 3) && !IsFührerscheinExistiert;
            führerscheinAnzeigenToolStripMenuItem.Enabled = IsFührerscheinExistiert;
            updateAntragToolStripMenuItem.Enabled = !IsFührerscheinExistiert && (LokalerFührerscheinAntrag.AntragsStatus == clsAnträge.enAntragsStatus.New);
            prüfungFestlegenToolStripMenuItem.Enabled = !IsFührerscheinExistiert;

            // Enable/Disable/ Cancle Menue Item
            //We only cancle the Application with Status = New;
            antragZurückziehenToolStripMenuItem.Enabled = (LokalerFührerscheinAntrag.AntragsStatus == clsAnträge.enAntragsStatus.New);

            // Enable/Disable/ Cancle Menue Item
            //We only allow delete incase the Application status is New and not Completed or Cancelled.
            antragLöschenToolStripMenuItem.Enabled = (LokalerFührerscheinAntrag.AntragsStatus == clsAnträge.enAntragsStatus.New);

            //Enable / Disable Prüfung Festlegen Items
            bool IsSehTestBestanden = LokalerFührerscheinAntrag.DoesPassTestType(clsTestTypen.enTestType.SehTest);
            bool IsSchreibTestBestanden = LokalerFührerscheinAntrag.DoesPassTestType(clsTestTypen.enTestType.SchreibTest);
            bool IsFahrTestBestanden = LokalerFührerscheinAntrag.DoesPassTestType(clsTestTypen.enTestType.FahrTest);

            prüfungFestlegenToolStripMenuItem.Enabled = (!IsSehTestBestanden || !IsSchreibTestBestanden || !IsFahrTestBestanden);

           if(prüfungFestlegenToolStripMenuItem.Enabled)
            {
                //to allow schdule vision test, person must not passed the same test before
                seheTestFestlegenToolStripMenuItem.Enabled = !IsSehTestBestanden;

                // to allow schdule written test, Person must passed the vision test and must not passed the same test before
                schreibTestFestlegenToolStripMenuItem.Enabled = IsSehTestBestanden && !IsSchreibTestBestanden;

                //to allow schdule street test, Person must passed the vision test and written test and must not passed the same test before
                fahrTestFestlegenToolStripMenuItem.Enabled = IsSchreibTestBestanden && IsSchreibTestBestanden && !IsFahrTestBestanden;
            }
        }

        private void seheTestFestlegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _TestFestlegen(clsTestTypen.enTestType.SehTest);
        }

        private void _TestFestlegen(clsTestTypen.enTestType TestType)
        {
            int LokalerFührerscheinAntragsID = (int)dgvLokalerFührerscheinAntragsListe.CurrentRow.Cells[0].Value;

            frmTestTerminListe frm = new frmTestTerminListe(LokalerFührerscheinAntragsID, TestType);
            frm.ShowDialog();

            FrmLokalerFührerscheinAntragsListe_Load(null, null);
        }

        private void fahrTestFestlegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _TestFestlegen(clsTestTypen.enTestType.FahrTest);

        }

        private void ausstellungDesFührerscheinserstmalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LokalerFührerscheinAntragsID = (int)dgvLokalerFührerscheinAntragsListe.CurrentRow.Cells[0].Value;

            frmFührerschein_Ausstellung frm = new frmFührerschein_Ausstellung(LokalerFührerscheinAntragsID);
            frm.ShowDialog();

            FrmLokalerFührerscheinAntragsListe_Load(null, null);
        }

        private void führerscheinAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LokalerFührerscheinAntragsID = (int)dgvLokalerFührerscheinAntragsListe.CurrentRow.Cells[0].Value;

            int LicenseID = clsLokalerFührerscheinAntrag.
                FindLocalDrivingApplicationInfoByID(LokalerFührerscheinAntragsID).GetActiveLicenseID();
            if (LicenseID != -1)
            {
                frmFahrerLicenseInfoAnzeigen frm = new frmFahrerLicenseInfoAnzeigen(LicenseID);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("License mit der ID " + LicenseID.ToString() + " wurde nicht gefunden","Fheler Meldung",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
                 
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LokalerFührerscheinAntragsID = (int)dgvLokalerFührerscheinAntragsListe.CurrentRow.Cells[0].Value;
            clsLokalerFührerscheinAntrag lokalerFührerscheinAntrag = clsLokalerFührerscheinAntrag.FindLocalDrivingApplicationInfoByID(LokalerFührerscheinAntragsID);

            int PersonID = lokalerFührerscheinAntrag.AntragsPersonID;
            frmFahrerLicenseHistoie frm = new frmFahrerLicenseHistoie(PersonID);
            frm.Show();
        }
    }
}
