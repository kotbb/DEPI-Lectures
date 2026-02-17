using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class TriangleGeo : GeometricShape
    {
        public TriangleGeo(double _BaseLength, double _Height) : base(_BaseLength, _Height)
        {
        }

        public override double Perimeter { get; }

        public override double CalculateArea()
        {
            return 0.5 * Dimension1 * Dimension2;
        }
    }
}
