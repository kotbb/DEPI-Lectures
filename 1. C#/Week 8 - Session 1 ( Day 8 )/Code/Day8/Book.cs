using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Book
    {

        public string Title { get; set; }
        public string Author { get; set; }

        public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
        }
        public Book(string _Title)
        {
            Title = _Title;

        }
        public Book(string _Title, string _Author)
        {
            Title = _Title;
            Author = _Author;
        }

        public override string ToString()
        {
            return $"Title: {Title} Author: {Author}";
        }


    }
}
