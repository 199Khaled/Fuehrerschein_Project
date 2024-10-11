using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenschenDataForm;
using MenschenDatenForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Führerschein
{
    public partial class frmMenschenListe : Form
    {
        private static DataTable _dtAllPeople = clsMenschenDaten.GetAllPersons();

        // nur Die Spalten auswählen , die im Raster angezeigt werden sollen.
        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false,"PersonID","AusweisNummer", "Vorname","Nachname",
                                                                       "Geburtstag", "Geschlecht", "GeschlechtsTitel", "Anschrift", "Telefon", "Email",
                                                                       "LandsName", "FotoPfad");

        private void _RefreschPoepleList()
        {
            _dtAllPeople = clsMenschenDaten.GetAllPersons();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "AusweisNummer", "Vorname", "Nachname",
                                                                       "Geburtstag", "Geschlecht", "GeschlechtsTitel", "Anschrift", "Telefon", "Email",
                                                                       "LandsName", "FotoPfad"); 
            dgvMenschenListe.DataSource = _dtPeople;
            lblRecord.Text = _dtAllPeople.Rows.Count.ToString();
        }

        public frmMenschenListe()
        {
            InitializeComponent();
        }
        private void frmMenschenListe_Load(object sender, EventArgs e)
        {
            dgvMenschenListe.DataSource = _dtPeople;
            cbFilternBei.SelectedIndex = 0;
            lblRecord.Text = dgvMenschenListe.Rows.Count.ToString();

            if(dgvMenschenListe.Rows.Count > 0)
            {
                dgvMenschenListe.Columns[0].HeaderText = "PersonID";
                dgvMenschenListe.Columns[0].Width = 110;

                dgvMenschenListe.Columns[1].HeaderText = "AusweisNummer";
                dgvMenschenListe.Columns[1].Width = 110;

                dgvMenschenListe.Columns[2].HeaderText = "Vorname";
                dgvMenschenListe.Columns[2].Width = 120;

                dgvMenschenListe.Columns[3].HeaderText = "Nachname";
                dgvMenschenListe.Columns[3].Width = 120;

                dgvMenschenListe.Columns[4].HeaderText = "Geburtstag";
                dgvMenschenListe.Columns[4].Width = 200;

                dgvMenschenListe.Columns[5].HeaderText = "Geschlecht";
                dgvMenschenListe.Columns[5].Width = 90;

                dgvMenschenListe.Columns[6].HeaderText = "GeschlechtsTile";
                dgvMenschenListe.Columns[6].Width = 110;

                dgvMenschenListe.Columns[7].HeaderText = "Anschrift";
                dgvMenschenListe.Columns[7].Width = 130;

                dgvMenschenListe.Columns[8].HeaderText = "Telefon";
                dgvMenschenListe.Columns[8].Width = 110;

                dgvMenschenListe.Columns[9].HeaderText = "Email";
                dgvMenschenListe.Columns[9].Width = 200;

                dgvMenschenListe.Columns[10].HeaderText = "LandsName";
                dgvMenschenListe.Columns[10].Width = 120;

                dgvMenschenListe.Columns[11].HeaderText = "FotoPfad";
                dgvMenschenListe.Columns[11].Width = 150;
            }
            
        }

        private void txtbGefiltertBei_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            // Die ausgewählten Filter der tatsäschlichen SpaltenName zuordnen
            // Map selected Filter to real Column name

            switch (cbFilternBei.Text)
            {
                case "PersonID":
                    FilterColumn = "PersonID";
                    break;

                case "AusweisNummer":
                    FilterColumn = "AusweisNummer";
                    break;

                case "Vorname":
                    FilterColumn = "Vorname";
                    break;

                case "Nachname":
                    FilterColumn = "Nachname";
                    break;

                case "Geburtstag":
                    FilterColumn = "Geburtstag";
                    break;

                case "Geschlecht":
                    FilterColumn = "Geschlecht";
                    break;


                case "Anschrift":
                    FilterColumn = "Anschrift";
                    break;

                case "Telefon":
                    FilterColumn = "Telefon";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                case "LandsName":
                    FilterColumn = "LandsName";
                    break;

                case "FotoPfad":
                    FilterColumn = "FotoPfad";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }
            //Reset the filters in case nothing selected or filter value contains nothing.
            //die Filter zurücksetzen, falls nichts ausgewählt wurde oder der Filterwert nichts enthält

            if (txtbGefiltertBei.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblRecord.Text = dgvMenschenListe.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PersonID")
                // in diesem Fall, wenn wir integer werte bearbeiten und nicht Zeichenfolge.
                // in this case we deal with integer not string 
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtbGefiltertBei.Text.Trim());

            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtbGefiltertBei.Text.Trim());
            lblRecord.Text = _dtPeople.Rows.Count.ToString();
        }

        private void cbFilternBei_SelectedIndexChanged(object sender, EventArgs e)
        {
           txtbGefiltertBei.Visible = (cbFilternBei.Text != "None");
            if(txtbGefiltertBei.Visible)
            {
                txtbGefiltertBei.Text = "";
                txtbGefiltertBei.Focus();
            }
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiPersonDetails_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvMenschenListe.CurrentRow.Cells[0].Value;
            frmPersonInfoSehen frm = new frmPersonInfoSehen(PersonID);
            frm.ShowDialog();
        }

        private void tsmiNeuePersonHinfügen_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreschPoepleList();
        }

        private void tsmiUpdatePerson_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvMenschenListe.CurrentRow.Cells[0].Value;
            frmAddUpdatePerson frm = new frmAddUpdatePerson(PersonID);
            frm.ShowDialog();

            _RefreschPoepleList();
        }

        private void tsmiPersonLöschen_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvMenschenListe.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Sind Sie sicher, Sie Möchten diese Person löschen? ", "Achtung",MessageBoxButtons.YesNo,
                          MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                bool Done = clsMenschenDaten.DeletePerson(PersonID);
                if (Done)
                {
                    MessageBox.Show("Person wurde erfolgreich gelöscht", "Meldung", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Fehler beim Löschen aufgetreten", "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _RefreschPoepleList();
        }

        private void btnAddNeu_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();

            _RefreschPoepleList();
        }

        private void txtbGefiltertBei_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilternBei.Text == "PersonID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
