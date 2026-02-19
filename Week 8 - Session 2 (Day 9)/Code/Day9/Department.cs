using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Department : IComparable<Department>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name}({Id})";
        }

        override public bool Equals(object obj)
        {
            if (obj == null || obj is not Department) return false;
            Department Other = (Department)obj;
            return this.Id == Other.Id && this.Name == Other.Name;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public int CompareTo(Department? other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }
}
