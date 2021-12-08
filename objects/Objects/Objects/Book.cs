using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectExample
{
    internal class Book
    {
        public string title;
        public string author;
        public string pages;

        public Book(string name)
        {
            Console.WriteLine(name);
        }
    }
}
