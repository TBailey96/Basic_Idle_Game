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
        public Gen_Interface()
        {
            InitializeComponent();
        }
        public Gen_Interface(Generator g)
        {
            InitializeComponent();
        }
    }
}
