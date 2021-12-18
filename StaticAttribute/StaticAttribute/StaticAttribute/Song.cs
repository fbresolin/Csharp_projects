using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAttribute
{
    internal class Song
    {
        public string name;
        public string author;
        public int mlenght;
        public static int songCount = 0;

        public Song(string aname, string aauthor, int amlength)
        {
            name = aname;
            author = aauthor;
            mlenght = amlength;
            songCount++;
        }
        public int getSongCount()
        {
            return songCount;
        }
    }
}
