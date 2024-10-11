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
    public partial class frmFahrerLicenseHistoie : Form
    {
        private int _PersonID= -1;
        public frmFahrerLicenseHistoie(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void frmFahrerLicenseHistoie_Load(object sender, EventArgs e)
        {
            if(_PersonID != -1)
            {
                ctrFahrerLicenseHistorie1.LoadInfoByPersonID(_PersonID);
                ctrlPersonKarteMitFilter1.LoadPersonInfo(_PersonID);
               // ctrlPersonKarteMitFilter1.FilterEnabled = false;
            }
            else
            {
                ctrlPersonKarteMitFilter1.Enabled = true;
                ctrlPersonKarteMitFilter1.FilterFocuse();
            }

        }

        private void ctrlPersonKarteMitFilter1_Load(object sender, EventArgs e)
        {

        }

        private void ctrlPersonKarteMitFilter1_OnPersonSelected(int obj)
        {
            _PersonID = obj;
            if (_PersonID == -1)
            {
                ctrFahrerLicenseHistorie1.Clear();
            }
            else
                ctrFahrerLicenseHistorie1.LoadInfoByPersonID(_PersonID);
        }
    }
}
