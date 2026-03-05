using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    static class Utility
    {

        public static double CalculateRectanglePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }


        public static double ConvertCelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}
