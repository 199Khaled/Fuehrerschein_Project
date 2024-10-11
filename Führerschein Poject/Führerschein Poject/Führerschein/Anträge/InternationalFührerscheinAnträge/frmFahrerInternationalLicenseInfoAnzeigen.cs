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
    public partial class frmFahrerInternationalLicenseInfoAnzeigen : Form
    {
        private int _InternationalLicenseID = -1;
        public frmFahrerInternationalLicenseInfoAnzeigen(int InternationalLicenseID)
        {
            InitializeComponent();
            _InternationalLicenseID = InternationalLicenseID;
            ctrFahrerInternationalLicenseInfo1.LoadInternationalLicenseInfo(_InternationalLicenseID);
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
