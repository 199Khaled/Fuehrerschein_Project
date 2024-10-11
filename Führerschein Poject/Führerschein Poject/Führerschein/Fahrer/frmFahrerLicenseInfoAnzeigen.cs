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
    public partial class frmFahrerLicenseInfoAnzeigen : Form
    {
        private int _LicenseID = -1;
        public frmFahrerLicenseInfoAnzeigen(int LicneseID)
        {
            InitializeComponent();

            _LicenseID = LicneseID;
        }

        private void frmFahrerLicenseInfoAnzeigen_Load(object sender, EventArgs e)
        {
            ctrFahrerLicenseInfo1.LoadLicenseData(_LicenseID);
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
