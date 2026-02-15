using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal abstract class Shape
    {

        public virtual void Draw()
        {
            Console.WriteLine("Drawing shape");
        }

        public abstract double CalculateArea();
    }
}
