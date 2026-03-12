using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Rectangle : Shape
    {

        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double _Length, double _Width)
        {
            Length = _Length;
            Width = _Width; 
        }
        public override double GetArea()
        {
            return Length * Width;
        }
    }
}
