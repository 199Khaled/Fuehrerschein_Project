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
    public partial class frmBenutzerListe : Form
    {
        private static DataTable _dtAllUsers;
        public frmBenutzerListe()
        {
            InitializeComponent();
        }

        private void frmBenutzerListe_Load(object sender, EventArgs e)
        {
            _dtAllUsers = clsBenutzerDaten.GetAllUsers();
            dgvBenutzer.DataSource = _dtAllUsers;
            lblRecord.Text = dgvBenutzer.Rows.Count.ToString();
            cbFilterBei.SelectedIndex = 0;
            if (dgvBenutzer.Rows.Count > 0)
            {
                dgvBenutzer.Columns[0].HeaderText = "BenutzerID";
                dgvBenutzer.Columns[0].Width = 100;

                dgvBenutzer.Columns[1].HeaderText = "PersonID";
                dgvBenutzer.Columns[1].Width = 100;

                dgvBenutzer.Columns[2].HeaderText = "Vollname";
                dgvBenutzer.Columns[2].Width = 400;

                dgvBenutzer.Columns[3].HeaderText = "BenutzerName";
                dgvBenutzer.Columns[3].Width = 150;

                dgvBenutzer.Columns[4].HeaderText = "IsAktive";
                dgvBenutzer.Columns[4].Width = 100;

            }
            
        }

        private void cbFilterBei_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterBei.Text == "IsAktive")
            {
                txtbFilterWert.Visible = false;
                cbIsAktive.Visible = true;
                cbIsAktive.Focus();
                cbIsAktive.SelectedIndex = 0;
            }
            else
            {
                txtbFilterWert.Visible = (cbFilterBei.Text != "None");
                cbIsAktive.Visible = false;

                if (cbFilterBei.Text == "None")
                {
                    txtbFilterWert.Enabled = false;
                }
                else
                    txtbFilterWert.Enabled = true;

                txtbFilterWert.Text = "";
                txtbFilterWert.Focus();
            }
        }

        private void txtbFilterWert_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch(cbFilterBei.Text)
            {
                case "BenutzerID":
                    FilterColumn = "BenutzerID";
                    break;

                case "BenutzerName":
                    FilterColumn = "BenutzerName";
                    break;

                case "PersonID":
                    FilterColumn = "PersonID";
                    break;

                case "Vollname":
                    FilterColumn = "Vollname";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            // reset the filter incase nothing selected or filter value contains nothing
            if(txtbFilterWert.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lblRecord.Text = _dtAllUsers.Rows.Count.ToString();
                return;
            }

            if (FilterColumn != "Vollname" && FilterColumn != "BenutzerName")
            {
                // in this case we deal numbers not string.
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}",FilterColumn, txtbFilterWert.Text.Trim());
            }
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", FilterColumn, txtbFilterWert.Text.Trim());

            lblRecord.Text = _dtAllUsers.Rows.Count.ToString();
        }

        private void cbIsAktive_SelectedIndexChanged(object sender, EventArgs e)
        {
             string FilterColumn = "IsAktive";
            string FilterValue = cbIsAktive.Text;
            
            switch(FilterValue)
            {
                case "All":
                    break;

                case "Yes":
                    FilterValue = "1";
                    break;

                case "No":
                    FilterValue = "0" ;
                     break;
            }

            if (FilterValue == "All")
            {
                // in this case we select all FilterValues   true and false
                _dtAllUsers.DefaultView.RowFilter = "";
            }
            else
                
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblRecord.Text = _dtAllUsers.Rows.Count.ToString();
        }

        private void btnAddBenutzer_Click(object sender, EventArgs e)
        {
            frmAddUpdateBenutzer frm = new frmAddUpdateBenutzer();  
            frm.ShowDialog();
            frmBenutzerListe_Load(null, null);
        }

        private void GetDataBack(object sender, int BenutzerID)
        {
            
        }

        private void tsmiPersonDetails_Click(object sender, EventArgs e)
        {
            int BenutzerID = (int)dgvBenutzer.CurrentRow.Cells[0].Value;
            frmBenutzerInfo frm = new frmBenutzerInfo(BenutzerID);
            frm.ShowDialog();
        }

        private void tsmiUpdatePerson_Click(object sender, EventArgs e)
        {
            int BenutzerID = (int)dgvBenutzer.CurrentRow.Cells[0].Value;
            frmAddUpdateBenutzer frm = new frmAddUpdateBenutzer(BenutzerID);
            frm.ShowDialog();
            frmBenutzerListe_Load(null, null);
        }

        private void tsmiPersonLöschen_Click(object sender, EventArgs e)
        {
            int BenutzerID = (int)dgvBenutzer.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Sind Sie sicher, dass Sie diesen Benutzer löschen möchten? ",
                "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                if (clsBenutzerDaten.Delete(BenutzerID))
                {
                    MessageBox.Show("Benutzer Daten erfolgreich gelöscht", "Daten Löschen",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmBenutzerListe_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Fehler is aufgetreten", "Fehler Meldung", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
        }

        private void tsmiPasswordÄndern_Click(object sender, EventArgs e)
        {
            int BenutzerID = (int)dgvBenutzer.CurrentRow.Cells[0].Value;
            frmAddUpdateBenutzer frm = new frmAddUpdateBenutzer(BenutzerID,true);
            frm.ShowDialog();
            frmBenutzerListe_Load(null, null);
        }

        private void txtbFilterWert_KeyPress(object sender, KeyPressEventArgs e)
        {
            // we allow just number incase UserID or PersonID
            if (cbFilterBei.Text == "PersonID" || cbFilterBei.Text == "BenutzerID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
