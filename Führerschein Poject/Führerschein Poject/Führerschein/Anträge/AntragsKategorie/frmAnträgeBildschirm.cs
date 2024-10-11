using MenschenDataForm;
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
    public partial class frmAnträgeBildschirm : Form
    {
        public DataTable _dtAntragsKategorie;
        public frmAnträgeBildschirm()
        {
            InitializeComponent();
        }


        private void frmAnträgeBildschirm_Load(object sender, EventArgs e)
        {
            _dtAntragsKategorie = clsAntragsKategorien.GetAllApplication();
            dgvAntragsKategorie.DataSource = _dtAntragsKategorie;
            lblRecord.Text = _dtAntragsKategorie.Rows.Count.ToString();

            if(dgvAntragsKategorie.Rows.Count > 0)
            {
                dgvAntragsKategorie.Columns[0].HeaderText = "ID";
                dgvAntragsKategorie.Columns[0].Width = 150;

                dgvAntragsKategorie.Columns[1].HeaderText = "Titel";
                dgvAntragsKategorie.Columns[1].Width = 450;

                dgvAntragsKategorie.Columns[2].HeaderText = "Gebühren";
                dgvAntragsKategorie.Columns[2].Width = 150;
            }
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiUpdateAntragsKategorie_Click(object sender, EventArgs e)
        {
            int AntragsID =(int )dgvAntragsKategorie.CurrentRow.Cells[0].Value;
            frmUpdateAntragsKategorie frm = new frmUpdateAntragsKategorie(AntragsID);
            frm.ShowDialog();

            frmAnträgeBildschirm_Load(null, null);
        }
    }
}
