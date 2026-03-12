using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }

        public static ComplexNumber operator* (ComplexNumber a, ComplexNumber b)
        {
            double RealPart = a.Real * b.Real;
            double ImaginaryPart = a.Imaginary * b.Imaginary;
            return new ComplexNumber(RealPart, ImaginaryPart);
        }

    }
}
