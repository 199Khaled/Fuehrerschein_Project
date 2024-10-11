using MenschenDatenForm;
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
    public partial class frmPersonInfoSehen : Form
    {
        int _PersonID;
        clsMenschenDaten _Personen;
        public frmPersonInfoSehen(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            ctrlPersonKarte1.LoadPersonData(_PersonID);
           
        }
        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
