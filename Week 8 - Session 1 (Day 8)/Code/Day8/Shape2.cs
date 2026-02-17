using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Shape2 : IComparable
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public int CompareTo(object obj)
        {
            Shape2 passed = (Shape2)obj;

            if (this.Area > passed.Area)
            {
                return 1;
            }
            else if (this.Area < passed.Area)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        override public string ToString()
        {
            return $"{Name}, Area: {Area}";
        }
    }
}
