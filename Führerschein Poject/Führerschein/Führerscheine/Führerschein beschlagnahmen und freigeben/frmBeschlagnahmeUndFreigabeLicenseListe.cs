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
    public partial class frmBeschlagnahmeUndFreigabeLicenseListe : Form
    {
        private DataTable _dtBaschlagenahmeLicense;

        public frmBeschlagnahmeUndFreigabeLicenseListe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmBeschlagnahmeUndFreigabeLicenseListe_Load(object sender, EventArgs e)
        {
            cbFilterBei.SelectedIndex = 0;
         
            _dtBaschlagenahmeLicense = clsBeschlagnahmeLicenseDaten.GetAllDetainedLicenses();
            dgvBeschlagnahmeLicense.DataSource = _dtBaschlagenahmeLicense;

            lblRecord.Text =  dgvBeschlagnahmeLicense.Rows.Count.ToString();

            if(dgvBeschlagnahmeLicense.Rows.Count > 0)
            {
                dgvBeschlagnahmeLicense.Columns[0].HeaderText = "BeschlagnahmeID";
                dgvBeschlagnahmeLicense.Columns[0].Width = 150;

                dgvBeschlagnahmeLicense.Columns[1].HeaderText = "LicenseID";
                dgvBeschlagnahmeLicense.Columns[1].Width = 110;

                dgvBeschlagnahmeLicense.Columns[2].HeaderText = "BeschlagnameDatum";
                dgvBeschlagnahmeLicense.Columns[2].Width = 150;

                dgvBeschlagnahmeLicense.Columns[3].HeaderText = "istFreigegeben";
                dgvBeschlagnahmeLicense.Columns[3].Width = 120;

                dgvBeschlagnahmeLicense.Columns[4].HeaderText = "Strafgebühren";
                dgvBeschlagnahmeLicense.Columns[4].Width = 150;

                dgvBeschlagnahmeLicense.Columns[5].HeaderText = "FreigabeDatum";
                dgvBeschlagnahmeLicense.Columns[5].Width = 150;

                dgvBeschlagnahmeLicense.Columns[6].HeaderText = "Ausweisnummer";
                dgvBeschlagnahmeLicense.Columns[6].Width = 150;

                dgvBeschlagnahmeLicense.Columns[7].HeaderText = "Vollname";
                dgvBeschlagnahmeLicense.Columns[7].Width = 200;

                dgvBeschlagnahmeLicense.Columns[8].HeaderText = "Freigabe AntragsID";
                dgvBeschlagnahmeLicense.Columns[8].Width = 100;

            }
        }

        private void btnBeschlagnahme_Click(object sender, EventArgs e)
        {
            frmFührerscheinBeschlagnahme frm = new frmFührerscheinBeschlagnahme();
            frm.ShowDialog();

            frmBeschlagnahmeUndFreigabeLicenseListe_Load(null, null);
        }

        private void btnFreigabe_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvBeschlagnahmeLicense.CurrentRow.Cells[1].Value;
            frmFreigabeBeschlagnahmteFührerschein frm = new frmFreigabeBeschlagnahmteFührerschein(LicenseID);
            frm.ShowDialog();

            frmBeschlagnahmeUndFreigabeLicenseListe_Load(null, null);
        }

        private void cbFilterBei_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterWert.Visible = (cbFilterBei.Text != "None");
            if(cbFilterBei.Text != "None")
            {
                txtFilterWert.Text = "";
                txtFilterWert.Focus();
            }

            cbIstFreigegeben.Visible = (cbFilterBei.Text == "istFreigegeben");
            if (cbIstFreigegeben.Visible)
            {
                cbIstFreigegeben.SelectedIndex = 0;
                txtFilterWert.Visible = false;
            }
        }

        private void txtFilterWert_TextChanged(object sender, EventArgs e)
        {
            
            string FilterColumn = "";

            switch(cbFilterBei.Text)
            {
                case "BeschlagnahmeID":
                    FilterColumn = "BeschlagnahmeID";
                    break;

                case "LicenseID":
                    FilterColumn = "LicenseID";
                    break;

                case "Ausweisnummer":
                    FilterColumn = "AusweisNummer";
                    break;

                case "Vollname":
                    FilterColumn = "Vollname";
                    break;

                case "IstFreigegeben":
                    FilterColumn = "istFreigegeben";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if(cbFilterBei.Text == "None" || txtFilterWert.Text == "")
            {
                _dtBaschlagenahmeLicense.DefaultView.RowFilter = "";
                lblRecord.Text = _dtBaschlagenahmeLicense.Rows.Count.ToString();
                return;
            }

            if (cbFilterBei.Text == "BeschlagnahmeID" || cbFilterBei.Text == "LicenseID")
            {
                _dtBaschlagenahmeLicense.DefaultView.RowFilter = String.Format("[{0}] = {1}", FilterColumn, txtFilterWert.Text.Trim());
            }
            else
                _dtBaschlagenahmeLicense.DefaultView.RowFilter = string.Format("[{0}] like '{1}%' ", FilterColumn, txtFilterWert.Text.Trim());

            lblRecord.Text = _dtBaschlagenahmeLicense.Rows.Count.ToString();
        }

        private void txtFilterWert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBei.Text == "BeschlagnahmeID" || cbFilterBei.Text == "LicenseID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl((e.KeyChar));
        }

        private void cbIstFreigegeben_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Der Name in der Spalte oder Column auf englisch muss unbedingt mit dem Namen in der Database übereinstimmen!!!!!!
            // und nicht mit dem Namen , der in DataGridView ist.
           // deswegen der Name in dataGridVeiw heißt (istFreigegeben) und in database heisßt (IsFreigegeb)
          
            string FilterSpalte = "IsFreigegeben";
            string FilterWert = cbIstFreigegeben.Text;

            switch(FilterWert)
            {
                case "Alle":
                    FilterWert= "Alle";
                    break;

                case "Ja":
                    FilterWert = "1";
                    break;

                case "Nein":
                    FilterWert = "0";
                    break;

                default:
                    FilterWert ="Alle";
                    break;

            }

            if(FilterWert == "Alle")
            {
                _dtBaschlagenahmeLicense.DefaultView.RowFilter = "";
                return;
            }

            _dtBaschlagenahmeLicense.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterSpalte, FilterWert);
            lblRecord.Text = _dtBaschlagenahmeLicense.Rows.Count.ToString();
        }

        private void personToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvBeschlagnahmeLicense.CurrentRow.Cells[1].Value;

            clsLicenseDaten License = clsLicenseDaten.GetLicenseInfoByID(LicenseID);

            frmPersonInfoSehen frm = new frmPersonInfoSehen(License.PersonInfo.PersonID);
            frm.ShowDialog();
        }

        private void licenseInfoAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvBeschlagnahmeLicense.CurrentRow.Cells[1].Value;

            frmFahrerLicenseInfoAnzeigen frm = new frmFahrerLicenseInfoAnzeigen(LicenseID);
            frm.ShowDialog();
        }

        private void personLiceneseHistorieAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvBeschlagnahmeLicense.CurrentRow.Cells[1].Value;

            clsLicenseDaten License = clsLicenseDaten.GetLicenseInfoByID(LicenseID);
            frmFahrerLicenseHistoie frm = new frmFahrerLicenseHistoie(License.PersonInfo.PersonID);
            frm.ShowDialog();
        }

        private void cmsAnträge_Opening(object sender, CancelEventArgs e)
        {
            //int LicenseID = (int)dgvBeschlagnahmeLicense.CurrentRow.Cells[1].Value;

            //clsLicenseDaten License = clsLicenseDaten.GetLicenseInfoByID(LicenseID);
            //if (!License.IstBeschlagnahmt)
            //{
            //    FreigabBeschlagnahmteLicenseToolStripMenuItem.Enabled = false;
            //}
            //else
            //    FreigabBeschlagnahmteLicenseToolStripMenuItem.Enabled = true;
        }

        private void FreigabBeschlagnahmteLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvBeschlagnahmeLicense.CurrentRow.Cells[1].Value;
            frmFreigabeBeschlagnahmteFührerschein frm = new frmFreigabeBeschlagnahmteFührerschein(LicenseID);
            frm.ShowDialog();

            frmBeschlagnahmeUndFreigabeLicenseListe_Load(null, null);
        }

        private void cmsAnträge_Opened(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvBeschlagnahmeLicense.CurrentRow.Cells[1].Value;

            clsLicenseDaten License = clsLicenseDaten.GetLicenseInfoByID(LicenseID);
            if (!License.IstBeschlagnahmt)
            {
                FreigabBeschlagnahmteLicenseToolStripMenuItem.Enabled = false;
            }
            else
                FreigabBeschlagnahmteLicenseToolStripMenuItem.Enabled = true;
        }
    }
}
