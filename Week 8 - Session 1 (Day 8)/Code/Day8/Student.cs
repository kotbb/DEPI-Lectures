using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }

        public Student(int _Id, string _Name, double _Grade)
        {
            Id = _Id;
            Name = _Name;
            Grade = _Grade;
        }
        public Student(Student CopyStudent)
        {
            Id = CopyStudent.Id;
            Name = CopyStudent.Name;
            Grade = CopyStudent.Grade;
        }

        public override string ToString() 
        {
            return $"Name: {Name} Id: {Id} Grade: {Grade}";
        }
    }
}
