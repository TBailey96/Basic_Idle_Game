using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicIdler
{
    //makes producers, should probably have inheritnace, same base class
    partial class Creator : Generator
    {
       Generator  gen=null;

        
        //name of the thing
        override public string name { get; set; }
        //how many producers their are
        override public ulong amount { get; set; }
        //the bonus to the production
        override public ulong multiplyer { get; set; }
        //keeps track of upgrades purchased
        override public byte counter { get; set; }
        //cost of the next upgrade
        override public ulong cost { get; set; }
        //how fast it updates
        override public double speed { get; set; }

        public Creator(ref Generator p)
        {
            gen = p;
            name = "Creator";
            amount = 0;
            multiplyer = 1;
            counter = 0;
            speed = 1000;
            //producer = p;
        }

        public override ulong Work()
        {
            return amount * multiplyer;
            //throw new NotImplementedException();
        }
        public override string getInfo()
        {
            return string.Format("Name: {0}\n\tMultiplier: {1}\n\tAmount: {2}\n\tSpeed: {3}\n\tCounter: {4}", name, multiplyer, amount, speed, counter);
        }
    }
}
