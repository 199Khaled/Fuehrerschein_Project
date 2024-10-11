using MenschenDataForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Führerschein
{
    public partial class frmInternationalLicenseListe : Form
    {
        private int _InternationalLicenseID = -1;
        private DataTable _dtInternationalLicense;

        public frmInternationalLicenseListe()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAntragZumInternationalenFührerschein frm = new frmAntragZumInternationalenFührerschein();
            frm.ShowDialog();
        }

        private void frmInternationalLicenseListe_Load(object sender, EventArgs e)
        {
            cbFilterBei.SelectedIndex = 0;
            _dtInternationalLicense = clsInternationFührerscheinAntragDaten.GetAllInternationalLicenses();
            dgvInternationalLicense.DataSource = _dtInternationalLicense;
            lblRecord.Text = dgvInternationalLicense.Rows.Count.ToString();

            if(dgvInternationalLicense.Rows.Count > 0)
            {
                dgvInternationalLicense.Columns[0].HeaderText =  "International LicenseID";
                dgvInternationalLicense.Columns[0].Width = 150;

                dgvInternationalLicense.Columns[1].HeaderText =  "AntragsID";
                dgvInternationalLicense.Columns[1].Width = 120;

                dgvInternationalLicense.Columns[2].HeaderText =  "FahrerID";
                dgvInternationalLicense.Columns[2].Width = 120;

                dgvInternationalLicense.Columns[3].HeaderText =  "Lokal LicenseID";
                dgvInternationalLicense.Columns[3].Width = 140;

                dgvInternationalLicense.Columns[4].HeaderText =  "AusstellungsDatum";
                dgvInternationalLicense.Columns[4].Width = 180;

                dgvInternationalLicense.Columns[5].HeaderText =  "AblaufDatum";
                dgvInternationalLicense.Columns[5].Width = 180;

                dgvInternationalLicense.Columns[6].HeaderText =  "Ist Aktive";
                dgvInternationalLicense.Columns[6].Width = 120;

            }
        }

        private void cbFilterBei_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBei.Text != "None")
            {
                if (cbFilterBei.Text != "IstAktive")
                {
                    txtbFilterWert.Visible = true;
                    txtbFilterWert.Text = "";
                    txtbFilterWert.Focus();
                }
            }

            cbIstAktive.Visible = (cbFilterBei.Text== "IstAktive");
            if(cbIstAktive.Visible)
            {
                cbIstAktive.SelectedIndex = 0;
            }
        }

        private void txtbFilterWert_TextChanged(object sender, EventArgs e)
        { 

            string FilterColumn;

            switch (cbFilterBei.Text)
            {
                case "Int_LicenseID":
                    FilterColumn = "InternationalLicenseID";
                    break;

                case "AntragsID":
                    FilterColumn = "AntragsID";
                    break;

                case "FahrerID":
                    FilterColumn = "FahrerID";
                    break;

                case "Lokal_LicenseID":
                    FilterColumn =  "AusstellungsMitLokalerLicenseID";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (cbFilterBei.Text == "None" || txtbFilterWert.Text == "")
            {
                _dtInternationalLicense.DefaultView.RowFilter = "";
                return;
            }


            _dtInternationalLicense.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtbFilterWert.Text.Trim());
            lblRecord.Text = _dtInternationalLicense.Rows.Count.ToString();
        }

        private void cbIstAktive_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Der Spalten Name von der Database
            string FilterColumn = "IsAktive";
            string FilterWert = cbIstAktive.Text;

            switch (FilterWert)
            {
                case "Alle":
                    break;

                case "Ja":
                    FilterWert = "1";
                    break;

                case "Nein":
                    FilterWert = "0";
                    break;
            }

            if(cbIstAktive.Text == "Alle")
            {
                _dtInternationalLicense.DefaultView.RowFilter = "";
                lblRecord.Text = _dtInternationalLicense.Rows.Count.ToString();
                return;
            }
            _dtInternationalLicense.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterWert);
            lblRecord.Text = _dtInternationalLicense.Rows.Count.ToString();
        }

        private void personInfoAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int FahrerID = (int)dgvInternationalLicense.CurrentRow.Cells[2].Value;
            clsFahrerDaten FahrerInfo = clsFahrerDaten.GetDriverInfoByDriverID(FahrerID);

            if(FahrerInfo == null)
            {
                MessageBox.Show("Fahrer mit der ID "+ FahrerID + " wurde nicht gefunden", "Fehler Meldung",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            frmPersonInfoSehen frm = new frmPersonInfoSehen(FahrerInfo.PersonID);
            frm.ShowDialog();
        }

        private void licenseInfoAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int InternationalLicenseID = (int)dgvInternationalLicense.CurrentRow.Cells[0].Value;
            frmFahrerInternationalLicenseInfoAnzeigen frm = new frmFahrerInternationalLicenseInfoAnzeigen(InternationalLicenseID);
            frm.ShowDialog();
        }

        private void personLicenseHistorieAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int FahrerID = (int)dgvInternationalLicense.CurrentRow.Cells[2].Value;
            clsFahrerDaten FahrerInfo = clsFahrerDaten.GetDriverInfoByDriverID(FahrerID);

            if (FahrerInfo == null)
            {
                MessageBox.Show("Fahrer mit der ID "+ FahrerID + " wurde nicht gefunden", "Fehler Meldung",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmFahrerLicenseHistoie frm = new frmFahrerLicenseHistoie(FahrerInfo.PersonID);
            frm.ShowDialog();
            
           
        }

        private void txtbFilterWert_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
