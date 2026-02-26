using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
        public Employee(int _Id, string _Name, Department _Departnment)
        {
            Id = _Id;
            Name = _Name;
            Department = _Departnment;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Dept: {Department}";
        }
        public override bool Equals(object obj)
        {
            if(obj == null || obj is not Employee) return false;

            Employee Other = (Employee)obj;

            return this.Id == Other.Id && this.Name == Other.Name;

        }
    }
}
