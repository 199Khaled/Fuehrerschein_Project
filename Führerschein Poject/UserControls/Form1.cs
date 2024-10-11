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

namespace UserControls
{
    public partial class Form1 : Form
    {
        // Define a Custom Event handler delegate with parameter
        public event Action<int> Event_Name; 
        // Create a protection method to (raise) pass the event with parameter
        protected virtual void Methode_Name(int Parameter)
        {

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void userControl11_OnCalculationComplete(int obj)
        {

            MessageBox.Show("Result is = " + obj);
        }
    }
}
