using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual string Departnment { get; set; }

        public Person(int _Id, string _Name, string _Departnment)
        {
            Id = _Id;
            Name = _Name;
            Departnment = _Departnment;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Department: {Departnment}";
        }

        public virtual decimal Salary { get; set; }

    }
}
