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
    public partial class frmTestFestlegen : Form
    {
        private int _LokalerFührerscheinAntragsID;
        private clsTestTypen.enTestType _TestTypeID = clsTestTypen.enTestType.SehTest;
        private int _TerminID = -1;
        private DateTime _LetztePrüfungsDatum;

        public frmTestFestlegen( DateTime LetztePrüfungsDatum, int LokalerFührerscheinAntragsID, clsTestTypen.enTestType testTypeID,int TerminID = -1 )
        {
            InitializeComponent();
            _LokalerFührerscheinAntragsID = LokalerFührerscheinAntragsID;
            _TestTypeID = testTypeID;
            _TerminID = TerminID;
            _LetztePrüfungsDatum = LetztePrüfungsDatum;
        }

        public frmTestFestlegen( int LokalerFührerscheinAntragsID, clsTestTypen.enTestType testTypeID, int TerminID = -1)
        {
            InitializeComponent();
            _LokalerFührerscheinAntragsID = LokalerFührerscheinAntragsID;
            _TestTypeID = testTypeID;
            _TerminID = TerminID;
        }

        private void frmTestFestlegen_Load(object sender, EventArgs e)
        {
            ctrTestFestlegen1.TestTypeID = _TestTypeID;
            ctrTestFestlegen1.LoadInfo(_LetztePrüfungsDatum, _LokalerFührerscheinAntragsID, _TerminID);

        }

        private void ctrTestFestlegen1_Load(object sender, EventArgs e)
        {

        }
    }
}
