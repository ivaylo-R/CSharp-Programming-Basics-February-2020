using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BgnToEur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            Convert();
        }
        void Convert()
        {
            var amount = this.numericUpDownAmount.Value;
            var amountInEuro = amount * 1.955832m;
            this.labelResult.Text =
            amount + " лева = " + 
            Math.Round(amountInEuro,2) + " евро ";

        }

        private void numericUpDownAmount_KeyUp(object sender, KeyEventArgs e)
        {
            Convert();
        }
    }
    
}
