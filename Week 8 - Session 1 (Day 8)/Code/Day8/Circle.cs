using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(int _Radius)
        {
            Radius = _Radius;
        }
        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
