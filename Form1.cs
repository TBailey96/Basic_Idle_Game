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
        Thread backgroundCruncher;
        bool keepRunningThread = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initialize the array to a size
            idlers = new Generator [8];

            //setup the actual workers
            idlers[0] = new Producer();
            idlers[1] = new Creator(ref idlers[0]);
            idlers[2] = new Creator(ref idlers[1]);
            idlers[3] = new Creator(ref idlers[2]);
            idlers[4] = new Creator(ref idlers[3]);
            idlers[5] = new Creator(ref idlers[4]);
            idlers[6] = new Creator(ref idlers[5]);
            idlers[7] = new Creator(ref idlers[6]);

            //show the detailes
            for(int x=0; x< idlers.Length; x++)
                Console.WriteLine(idlers[x].getInfo());
            //Console.WriteLine(idlers[1].getInfo());
           // backgroundCruncher = new Thread(crunchNumbers);
        }
        private void crunchNumbers() 
        {
            while (keepRunningThread) 
            {
                if (backgroundCruncher.IsAlive)
                {
                   
                }
                else 
                {
                    
                }
            }
        }
    }
}
