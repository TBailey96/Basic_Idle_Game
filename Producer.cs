using System;
namespace BasicIdler
{
    //inherits from abstract base class
    //makes the currency the player spends
    partial class Producer : Generator
    {
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
        /// <summary>
        /// inherits from Generator for simlar funcitonality
        /// </summary>
        public Producer()
        {
           
            name = "Producer";
            amount = 0;
            multiplyer = 1;
            counter = 0;
            speed = 10000;
        }
        public override ulong Work()
        {
            return amount * multiplyer;
            //throw new NotImplementedException();
        }
        /*
        public ulong calcTotal()
        {
            return amount * multiplyer;
        }
        */
        public override string getInfo()
        {
            return string.Format("Name: {0}\n\tMultiplier: {1}\n\tAmount: {2}\n\tSpeed: {3}\n\tCounter: {4}",name, multiplyer, amount,speed,counter);
        }

    }
}
