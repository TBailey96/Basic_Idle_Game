using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BasicIdler
{

    public partial class Form1 : Form
    {
        Generator[] idlers;
        Gen_Interface[] gens;
        uint ticker = 100;
        Thread backgroundCruncher;
        System.Windows.Forms.Timer guiRefesher;
        bool keepRunningThread = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int size = 8;
            guiRefesher = new System.Windows.Forms.Timer();
            //initialize the array to a size
            idlers = new Generator [size];
            gens = new Gen_Interface[size];

            guiRefesher.Interval = (1000);
            guiRefesher.Tick += new EventHandler(refeshGUI);

            //setup the actual workers
            idlers[0] = new Producer();
            idlers[1] = new Creator(ref idlers[0]);
            idlers[2] = new Creator(ref idlers[1]);
            idlers[3] = new Creator(ref idlers[2]);
            idlers[4] = new Creator(ref idlers[3]);
            idlers[5] = new Creator(ref idlers[4]);
            idlers[6] = new Creator(ref idlers[5]);
            idlers[7] = new Creator(ref idlers[6]);
            //setup the GUI
            //show the detailes
            for (int x = 0; x < idlers.Length; x++)
            {
                if (x>=1)
                {
                    idlers[x].name += "_"+x;
                }
                gens[x] = new Gen_Interface(ref idlers[x]);
                tableLayoutPanel1.Controls.Add(gens[x]);
                Console.WriteLine(idlers[x].getInfo());
            }
            tableLayoutPanel1.Refresh();
            //Console.WriteLine(idlers[1].getInfo());
           //backgroundCruncher = new Thread(() => { crunchNumbers(ref keepRunningThread); });
           //backgroundCruncher.Start();
            guiRefesher.Start();
            
        }
        private void crunchNumbers(ref bool run) 
        {
            while (run) 
            {
                //allows me to reset the ticker if needed
                checked
                {
                    try
                    {
                        ticker++;
                    }
                    catch
                    {
                        ticker = 0;
                    }
                }

                for (int x = idlers.Length - 1; x >= 0; x--)
                {
                    //only update the idler if it's time
                    if (ticker % idlers[x].speed == 0)
                    {
                        if (x - 1 >= 0)
                            idlers[x].amount += idlers[x].Work();
                        else
                        {
                            //its the producer to add  to currency
                        }
                        //gens[x].updateGUI();
                    }
                }
               
            }
        }
        private void refeshGUI(object sender, EventArgs e)
        {
            for (int x= gens.Length-1; x >= 0; x--)
            {
                if (x - 1 >= 0)
                    idlers[x-1].amount += idlers[x].Work();
                else
                {
                    //its the producer to add  to currency
                }
                //crunchNumbers(ref keepRunningThread);
                gens[x].updateGUI();
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            keepRunningThread = false;
            base.OnClosed(e);
        }
    }
}
