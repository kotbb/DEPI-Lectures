using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class Child : Parent
    {

        public int Z { get; set; }

        public Child(int x, int y, int z) : base(x,y)
        {
            Z = z;
        }
        //public override int Product()
        //{
        //    return base.Product() * Z; 
        //}

        public new int Product()
        {
            return base.Product() * Z;
        }

        public override string ToString()
        { 
            return base.ToString() + $", Z: {Z}";
        }

    }
}
