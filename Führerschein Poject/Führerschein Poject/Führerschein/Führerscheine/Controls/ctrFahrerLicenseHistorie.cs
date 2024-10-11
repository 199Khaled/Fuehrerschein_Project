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
    public partial class ctrFahrerLicenseHistorie : UserControl
    {
        private int _FahrerID = -1;
        private clsFahrerDaten _FahrerInfo;
        private DataTable _dtLokalerFührerschein;
        private DataTable _dtInternationalerFührerschein;

        private int _LokalLicenseID;
        public int LokalLicenseID
        {
            get { return _LokalLicenseID; }
        }

        public clsFahrerDaten FahrerInfo
        {
            get { return _FahrerInfo; }
        }

        public ctrFahrerLicenseHistorie()
        {
            InitializeComponent();
        }

        private void _LoadLocalDrivingLicenseInfo()
        {
            _dtLokalerFührerschein = clsFahrerDaten.GetLicenes(_FahrerID);
            dgvLokalerFührerschein.DataSource  = _dtLokalerFührerschein;
            lblRecord.Text = dgvLokalerFührerschein.Rows.Count.ToString();

            if(dgvLokalerFührerschein.Rows.Count > 0)
            {
                dgvLokalerFührerschein.Columns[0].HeaderText = "License ID";
                dgvLokalerFührerschein.Columns[0].Width = 120;

                dgvLokalerFührerschein.Columns[1].HeaderText = "Antrag ID";
                dgvLokalerFührerschein.Columns[1].Width = 120;

                dgvLokalerFührerschein.Columns[2].HeaderText = "KlassenName";
                dgvLokalerFührerschein.Columns[2].Width = 250;

                dgvLokalerFührerschein.Columns[3].HeaderText = "AusstellungsDatum";
                dgvLokalerFührerschein.Columns[3].Width = 150;

                dgvLokalerFührerschein.Columns[4].HeaderText = "AblaufDatum";
                dgvLokalerFührerschein.Columns[4].Width = 150;

                dgvLokalerFührerschein.Columns[5].HeaderText ="IstAktive";
                dgvLokalerFührerschein.Columns[5].Width = 100;
            }

        }

        private void _LoadInternationalDrivingLicenseInfo()
        {
            //_dtLokalerFührerschein = clsFahrerDaten.GetLicenes(_FahrerID);
            //dgvLokalerFührerschein.DataSource  = _dtLokalerFührerschein;
            //lblRecord.Text = dgvLokalerFührerschein.Rows.Count.ToString();

            //if (dgvLokalerFührerschein.Rows.Count > 0)
            //{
            //    dgvLokalerFührerschein.Columns[0].HeaderText = "License ID";
            //    dgvLokalerFührerschein.Columns[0].Width = 100;

            //    dgvLokalerFührerschein.Columns[1].HeaderText = "Antrag ID";
            //    dgvLokalerFührerschein.Columns[1].Width = 100;

            //    dgvLokalerFührerschein.Columns[2].HeaderText = "KlassenName";
            //    dgvLokalerFührerschein.Columns[2].Width = 250;

            //    dgvLokalerFührerschein.Columns[3].HeaderText = "AusstellungsDatum";
            //    dgvLokalerFührerschein.Columns[3].Width = 150;

            //    dgvLokalerFührerschein.Columns[4].HeaderText = "AblaufDatum";
            //    dgvLokalerFührerschein.Columns[4].Width = 150;

            //    dgvLokalerFührerschein.Columns[5].HeaderText ="IstAktive";
            //    dgvLokalerFührerschein.Columns[5].Width = 100;
            //}
        }
        public void LoadInfoByDriverID(int FahrerID)
        {
            _FahrerInfo = clsFahrerDaten.GetDriverInfoByDriverID(FahrerID);
            if(_FahrerInfo == null)
            {
                MessageBox.Show("Fahrer mit der ID = " + FahrerID.ToString() + "Wurde nicht gefunden",
                    "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FahrerID = _FahrerInfo.FahrerID;

            _LoadLocalDrivingLicenseInfo();
            _LoadInternationalDrivingLicenseInfo();
        }

        public void LoadInfoByPersonID(int PersonID)
        {
            _FahrerInfo = clsFahrerDaten.GetDriverInfoByPersonID(PersonID);
            if(_FahrerInfo == null)
            {
                MessageBox.Show("es wurde keinen Fahrer in Verbindung mit dieser Person gefunden",
                     "Fehler Meldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FahrerID = _FahrerInfo.FahrerID;
           
            _LoadLocalDrivingLicenseInfo();
            _LoadInternationalDrivingLicenseInfo();

        }

        public void Clear()
        {
            _dtLokalerFührerschein.Clear();
          //  _dtInternationalerFührerschein.Clear();
        }
        private void ctrFahrerLicenseHistorie_Load(object sender, EventArgs e)
        {

        }

        private void licenseInfoAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvLokalerFührerschein.CurrentRow.Cells[0].Value;
            frmFahrerLicenseInfoAnzeigen frm = new frmFahrerLicenseInfoAnzeigen(LicenseID);
            frm.ShowDialog();
        }
    }
}
