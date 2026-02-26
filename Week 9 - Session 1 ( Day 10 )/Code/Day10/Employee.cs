using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class Employee : IComparable<Employee>, ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int _id, string _name, double _salary)
        {
            Id = _id;
            Name = _name;
            Salary = _salary;
        }

        public override string ToString()
        {
            return $"Id is {Id}, Name is {Name}, Salary is {Salary}";
        }
        public int CompareTo(Employee other)
        {
            int result = this.Salary.CompareTo(other.Salary);
            if (result == 0)
            {
                return this.Name.Length.CompareTo(other.Name.Length);            
            }
            return result;
        }

        public object Clone()
        {
            return new Employee(Id, Name, Salary);
        }
    }
}
