using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class RectangleS : Shape
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public RectangleS(double width, double length)
        {
            Width = width;
            Length = length;
        }
        public override double CalculateArea()
        {
            return Width * Length;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a rectangle {Width} x {Length}");
        }
    }
}
