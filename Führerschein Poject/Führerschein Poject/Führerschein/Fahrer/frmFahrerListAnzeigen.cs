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
    public partial class frmFahrerListAnzeigen : Form
    {
        private DataTable _dtFahrer;
        public frmFahrerListAnzeigen()
        {
            InitializeComponent();
        }

        private void frmFahrerListAnzeigen_Load(object sender, EventArgs e)
        {
            cbFilterBei.SelectedIndex = 0;

            _dtFahrer = clsFahrerDaten.GetAllDrivers();
            dgvFahrer.DataSource = _dtFahrer;
            lblRecord.Text = dgvFahrer.Rows.Count.ToString();

            if(dgvFahrer.Rows.Count > 0)
            {
                dgvFahrer.Columns[0].HeaderText = "Fahrer ID";
                dgvFahrer.Columns[0].Width = 120;

                dgvFahrer.Columns[1].HeaderText = "Person ID";
                dgvFahrer.Columns[1].Width = 120;

                dgvFahrer.Columns[2].HeaderText = "AusweisNummer";
                dgvFahrer.Columns[2].Width = 200;

                dgvFahrer.Columns[3].HeaderText = "Vollname";
                dgvFahrer.Columns[3].Width = 200;

                dgvFahrer.Columns[4].HeaderText = "ErstellungsDatum";
                dgvFahrer.Columns[4].Width = 200;

                dgvFahrer.Columns[5].HeaderText = "Aktive Führerscheine Zahl";
                dgvFahrer.Columns[5].Width = 200;
            }
        }

        private void cbFilterBei_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterWert.Visible = (cbFilterBei.SelectedIndex != 0);

            if (cbFilterBei.SelectedIndex != 0)
            {
                txtFilterWert.Text = "";
                txtFilterWert.Focus();
            }
        }

        private void txtFilterWert_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(cbFilterBei.Text == "FahrerID" || cbFilterBei.Text == "PersonID" || cbFilterBei.Text == "ZahlDerAktiveLicense")
                  e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFilterWert_TextChanged(object sender, EventArgs e)
        {
            //zum entspechen mit den richtigen Name in der Datenbank
            string FilterColumn = "";

            switch(cbFilterBei.Text)
            {
                case "FahrerID":
                    FilterColumn = "FahrerID";
                    break;

                case "PersonID":
                    FilterColumn = "PersonID";
                    break;

                case "AusweisNummer":
                    FilterColumn = "AusweisNummer";
                    break;

                case "Vollname":
                    FilterColumn = "Vollname";
                    break;

                case "ZahlDerAktiveLicense":
                    FilterColumn = "ZahlDerAktiveLicense";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }
            
            if(txtFilterWert.Text.Trim() == "" || cbFilterBei.Text == "None")
            {
                _dtFahrer.DefaultView.RowFilter = "";
                lblRecord.Text = _dtFahrer.Rows.Count.ToString();
                return;
            }

            if (cbFilterBei.Text == "FahrerID" || cbFilterBei.Text == "PersonID" || cbFilterBei.Text =="ZahlDerAktiveLicense")
            {
                //wir handeln hier nur nummer
                _dtFahrer.DefaultView.RowFilter = string.Format("[{0}] = {1} ", FilterColumn,txtFilterWert.Text.Trim());
            }
            else
                //wir handeln zeichenkette
                _dtFahrer.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'",FilterColumn, txtFilterWert.Text.Trim());

            lblRecord.Text = dgvFahrer.Rows.Count.ToString();
        }

        private void tsmiPersonInfoAnzeigen_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvFahrer.CurrentRow.Cells[1].Value;
            frmPersonInfoSehen frm = new frmPersonInfoSehen(PersonID);
            frm.ShowDialog();

        }

        private void tsmiAlterPersonFührerscheinAnzeigen_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvFahrer.CurrentRow.Cells[1].Value;
            frmFahrerLicenseHistoie frm = new frmFahrerLicenseHistoie(PersonID);
            frm.ShowDialog();
        }
    }
}
