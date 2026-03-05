using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
   internal class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(int empId, string name, decimal salary)
        {
            EmpId = empId;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"EmpId: {EmpId}, Name: {Name}, Salary: {Salary}";
        }

    }
}
