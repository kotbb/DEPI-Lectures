using Day6;
using System;

namespace TestVisibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeA a1 = new Day6.TypeA();
            // a1.F = 'A';  // private not allowed
            // a1.G = 'B';  // internal not allowed
            a1.H = 'C';
        }
    }
}
