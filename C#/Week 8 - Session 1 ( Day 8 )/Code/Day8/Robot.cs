using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Robot : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("IMPLICIT: Robot is walking");
        }

        void IWalkable.Walk()
        {
            Console.WriteLine("EXPLICIT: Robot is walking");
        }
    }
}
