using ATC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaneTracker = ATC.PlaneTracker;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlaneTracker planeTracker = new PlaneTracker();
            ATM _atm = new ATM(planeTracker);
            while(true) { }
        }
    }
}
