using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = new DateTime();
            time.AddHours(10);
            time.AddMinutes(11);
            var addMilliseconds = time.AddMilliseconds(12);
            addMilliseconds = time.AddHours(10);

            Console.WriteLine(addMilliseconds.ToLongTimeString());
        }
    }
}
