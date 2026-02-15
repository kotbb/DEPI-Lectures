using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class Rectangle : IShape 
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public double Area
        {
            get { return Width * Length; }
        }

        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a rectangle {Width} x {Length}");

        }
    }
}
