using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Product : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + " Name: " + Name + " Price: " + Price;
        }

        public int CompareTo(object obj)
        {

            Product Passed = (Product)obj;

            if (this.Price > Passed.Price)
            {
                return 1;
            }
            else if (this.Price < Passed.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
