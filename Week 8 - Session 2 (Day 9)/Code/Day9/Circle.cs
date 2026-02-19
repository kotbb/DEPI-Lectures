using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal struct Circle
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public Circle(double _Radius, string _Color)
        {
            Radius = _Radius;
            Color = _Color;
        }

    }
}
