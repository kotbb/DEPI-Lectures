using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal struct Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double _Length, double _Width)
        {
            Length = _Length;
            Width = _Width;
        }
        public static void Swap(ref Rectangle r1, ref Rectangle r2)
        {
            Rectangle Temp = r1;
            r1 = r2;
            r2 = Temp;
        }

        public override string ToString()
        {
            return $"Length = {Length}, Width = {Width}";
        }
    }
}
