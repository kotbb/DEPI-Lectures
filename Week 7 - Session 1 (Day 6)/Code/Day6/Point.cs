using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        //public Point()  // need .Net 6.0 to work
        //{
        //    X = 0;
        //    Y = 0;
        //}

        public Point(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }
        public Point(int _x)
        {
            X = _x;
            Y = 0;
        }


        public override string ToString()
        {
            return $"({X}, {Y})";
        }


    }
}
