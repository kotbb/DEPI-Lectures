using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Bike : IVechicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine of the Bike has started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine of the Bike has stopped");

        }
    }
}
