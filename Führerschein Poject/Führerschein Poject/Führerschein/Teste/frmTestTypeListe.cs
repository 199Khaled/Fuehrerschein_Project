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
    public partial class frmTestTypeListe : Form
    {
        private int _TypeID = -1;
        DataTable _TestType;
        public frmTestTypeListe()
        {
            InitializeComponent();
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTestTypeListe_Load(object sender, EventArgs e)
        {
            _TestType = clsTestTypen.GetAllTestType();
            dgvTestTypen.DataSource = _TestType;
            lblRecord.Text = dgvTestTypen.Rows.Count.ToString();
            if(dgvTestTypen.Rows.Count > 0)
            {
                dgvTestTypen.Columns[0].HeaderText = "TestType ID";
                dgvTestTypen.Columns[0].Width = 150;

                dgvTestTypen.Columns[1].HeaderText = "TestType Titel";
                dgvTestTypen.Columns[1].Width = 150;

                dgvTestTypen.Columns[2].HeaderText = "TestType Beschreibung";
                dgvTestTypen.Columns[2].Width = 420;

                dgvTestTypen.Columns[3].HeaderText = "Test Gebühren";
                dgvTestTypen.Columns[3].Width = 160;
            }
        }

        private void tsmiUpdateTestType_Click(object sender, EventArgs e)
        {
           clsTestTypen.enTestType enTestID = (clsTestTypen.enTestType
                )dgvTestTypen.CurrentRow.Cells[0].Value;
            frmUpdateTestTypen frm = new frmUpdateTestTypen(enTestID);
            frm.ShowDialog();

            frmTestTypeListe_Load(null, null);
        }

        private void dgvTestTypen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
