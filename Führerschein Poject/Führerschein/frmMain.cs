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
    public partial class frmMain : Form
    {
        frmAnmeldung _frmAnmelden;
      public frmMain(frmAnmeldung frmanmelden)
        {
            InitializeComponent();
            _frmAnmelden = frmanmelden;
        }

        private void tsmiAbmelden_Click(object sender, EventArgs e)
        {
            clsGlobaleKlasse.Benutzer = null;
            this.Close();
            _frmAnmelden.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsGlobaleKlasse.Benutzer = null;
            this.Close();
            _frmAnmelden.Show();
        }
        private void tsmiMenschen_Click(object sender, EventArgs e)
        {
            frmMenschenListe frm = new frmMenschenListe();
            frm.ShowDialog();
        }

        private void anträgeKategorieBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnträgeBildschirm frm = new frmAnträgeBildschirm();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void testTypenBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestTypeListe frm = new frmTestTypeListe();
            frm.ShowDialog();
        }
        private void tsmiPasswordÄndern_Click(object sender, EventArgs e)
        {
            frmPasswordÄndern frm = new frmPasswordÄndern(clsGlobaleKlasse.Benutzer.BenutzerID);
            frm.ShowDialog();
        }

        private void tsmiAktuelleBenutzerInfos_Click(object sender, EventArgs e)
        {
            frmBenutzerInfo frm = new frmBenutzerInfo(clsGlobaleKlasse.Benutzer.BenutzerID);
            frm.ShowDialog();
        }

        private void accountEinsetellungToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmiFührerscheinService_Click(object sender, EventArgs e)
        {

        }

        private void lokalerFührerscheinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAntragZumNeuenLokalenFührerschein frm = new frmAntragZumNeuenLokalenFührerschein();
            frm.ShowDialog();
        }

        private void tsmiBenutzer_Click(object sender, EventArgs e)
        {
            frmBenutzerListe frm = new frmBenutzerListe();
            frm.ShowDialog();
        }

        private void lokalerFührerscheinAntragToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLokalerFührerscheinAntragsListe frm = new FrmLokalerFührerscheinAntragsListe();
            frm.ShowDialog();
        }

        private void prüfungWiederholenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLokalerFührerscheinAntragsListe frm = new FrmLokalerFührerscheinAntragsListe();
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLokalerFührerscheinErneuern frm = new frmLokalerFührerscheinErneuern();
            frm.ShowDialog();
        }

        private void ErsatzFürVerlorenenOderBeschädigtentoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmBeschädigterOderVerlorenerFührerscheinErsetzen frm =
                new frmBeschädigterOderVerlorenerFührerscheinErsetzen();
            frm.ShowDialog();
        }

        private void tsmiFahrer_Click(object sender, EventArgs e)
        {
            frmFahrerListAnzeigen frm = new frmFahrerListAnzeigen();
            frm.ShowDialog();
        }

        private void führerscheinBeschlagnahmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFührerscheinBeschlagnahme frm = new frmFührerscheinBeschlagnahme();
            frm.ShowDialog();
        }

        private void führerscheinFreigebenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFreigabeBeschlagnahmteFührerschein frm = new frmFreigabeBeschlagnahmteFührerschein();
            frm.ShowDialog();
        }

        private void beschlagnahmteFührerscheineVerwaltenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBeschlagnahmeUndFreigabeLicenseListe frm = new frmBeschlagnahmeUndFreigabeLicenseListe();
            frm.ShowDialog();
        }

        private void internationalFührerscheinAntragToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseListe frm = new frmInternationalLicenseListe();
            frm.ShowDialog();
        }

        private void internationalerFührerscheinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAntragZumInternationalenFührerschein frm = new frmAntragZumInternationalenFührerschein();
            frm.ShowDialog();
        }
    }
}
 