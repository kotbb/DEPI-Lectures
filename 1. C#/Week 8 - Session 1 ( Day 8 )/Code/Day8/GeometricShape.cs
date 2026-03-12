using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    abstract class GeometricShape
    {

        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }

        protected GeometricShape(double _Dimension1, double _Dimension2)
        {
            Dimension1 = _Dimension1;
            Dimension2 = _Dimension2;
        }

        public abstract double Perimeter { get; }

        public abstract double CalculateArea();

    }
}
