using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicIdler
{ 
    public partial class Gen_Interface : UserControl
    {
        Generator gen;
        private byte threshold = 10;
        public Gen_Interface()
        {
            InitializeComponent();
        }
        public Gen_Interface(ref Generator g)
        {
            InitializeComponent();
            gen = g;
            lblAmount.Text = "Amount: "+gen.amount.ToString();
            lblmultiplier.Text = "Multiplier: "+ gen.multiplyer.ToString();
            grpDescription.Text = gen.name;
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
           
            gen.counter += 1;
            if (gen.counter >= threshold)
            {
                gen.amount += 1;
                gen.multiplyer *= 2;
                gen.counter = 0;
            }
            else
            {
                gen.amount += 1;              
            }
            updateGUI();
        }
        public void updateGUI()
        {
            grpDescription.Text = gen.name;
            lblAmount.Text = "Amount: " + gen.amount.ToString();
            lblmultiplier.Text = "Multiplier: " + gen.multiplyer.ToString();
        }
    }
}
