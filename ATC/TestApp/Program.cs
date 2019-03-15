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
            PlaneTracker planeTracker = new PlaneTracker();

            planeTracker.Update("ATR423;39045;12932;14000;20151006213456789");
        }
    }
}
