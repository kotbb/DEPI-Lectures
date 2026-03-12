using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal interface IShape
    {

        public double Area { get; }

        public void Draw();

        public void PrintDetails()
        {
            Draw();
            Console.WriteLine($"Area: {Area}");
        }
    }
}
