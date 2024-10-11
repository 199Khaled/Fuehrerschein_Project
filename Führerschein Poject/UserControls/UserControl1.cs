using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public partial class UserControl1 : UserControl
    {
        public event Action<int> OnCalculationComplete;
        protected virtual void CalculateComplete(int id)
        {
            Action<int> handler = OnCalculationComplete;
            if(handler != null)
            {
                handler(id);
            }
        }
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
            lblResult.Text = result.ToString();
            if(OnCalculationComplete != null)
            {
                CalculateComplete(result);
            }
        }
    }
}
