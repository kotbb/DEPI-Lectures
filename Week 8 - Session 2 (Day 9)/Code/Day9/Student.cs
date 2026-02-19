using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Student : Person
    {
        public Student(int _Id, string _Name, string _Departnment) : base(_Id, _Name, _Departnment)
        {
        }

        public sealed override decimal Salary { get; set; }

  
    }
}
