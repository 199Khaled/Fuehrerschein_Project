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
    public partial class frmBenutzerInfo : Form
    {


        public frmBenutzerInfo(int BenutzerID)
        {
            InitializeComponent();
            ctrlBenutzerKarte1.LoadBenutzerDaten(BenutzerID);

        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
