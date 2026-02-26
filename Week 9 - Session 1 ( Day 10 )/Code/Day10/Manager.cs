using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class Manager : Employee, IComparable<Manager>
    {
        public Manager(int _id, string _name, double _salary) : base(_id, _name, _salary)
        {
        }

        public int CompareTo(Manager other)
        {
            return this.Salary.CompareTo(other.Salary);
        }
    }
}
