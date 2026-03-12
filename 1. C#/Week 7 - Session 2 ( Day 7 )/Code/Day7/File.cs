using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class File : IReadable, IWritable
    {
        public String Name { get; set; }

        public File(string name)
        {
            Name = name;
        }
        public void Read()
        {
            Console.WriteLine($"Reading from File: {Name}");
        }

        public void Write()
        {
            Console.WriteLine($"Writing to File: {Name}");
        }
    }
}
