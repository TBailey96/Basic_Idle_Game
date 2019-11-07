using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicIdler
{
    
    ///<summary>
    ///base class for the idle bits, so we can create a list or array
    ///</summary>
    public abstract class Generator
    {
        //name of the thing
        abstract public string name { get; set; }
        //how many producers their are
        abstract public ulong amount { get; set; }
        //the bonus to the production
        abstract public ulong multiplyer { get; set; }
        //keeps track of upgrades purchased
        abstract public byte counter { get; set; }
        //cost of the next upgrade
        abstract public ulong cost { get; set; }
        //how fast it updates
        abstract public double speed { get; set; }
        //public Generator() { }
        //universal function call
        abstract public ulong Work();
        abstract public string getInfo();
    }
}
