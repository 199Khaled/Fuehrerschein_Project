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
    public partial class frmLokalerFührerscheinAntragsInfo : Form
    {
        private int _AntragsID = -1;
        private clsLokalerFührerscheinAntrag _LokalerFührerscheinAntrag;

        public frmLokalerFührerscheinAntragsInfo(int AntragsID)
        {
            InitializeComponent();
            _AntragsID = AntragsID;
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLokalerFührerscheinAntragsInfo_Load(object sender, EventArgs e)
        {
            ctrFührerscheinAntragsInfo1.LoadLocalApplicationInfosByApplicationID(_AntragsID);

            ctrFührerscheinAntragsInfo1.LoadBaseApplicationInfosByApplicationID(_AntragsID);
        }

        private void ctrFührerscheinAntragsInfo1_Load(object sender, EventArgs e)
        {

        }

        private void ctrFührerscheinAntragsInfo1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
