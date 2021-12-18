using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectExample
{
    internal class Book
    {
        public string author;
        public string title;
        public int pages;

        public Book(string aAuthor, string aTitle, int aPages)
        {
            author = aAuthor;
            title = aTitle;
            pages = aPages;
        }
    }
}
