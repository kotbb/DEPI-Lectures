using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class RectangleGeo : GeometricShape
    {
        public RectangleGeo(double _Length, double _Width) : base(_Length, _Width)
        {
        }

        public override double Perimeter 
        {

            get
            {
                return 2 * (Dimension1 + Dimension2);
            }
        
        } 

        public override double CalculateArea()
        {
            return Dimension1 * Dimension2;
        }
    }
}
