using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndClasses
{
    static class UsefulTools //using static we cant create a instance of useful tools "UsefulTools tools = new UsefulTools();"
    {
        public static void SayHi(string name)
        {
            Console.WriteLine("Hi " + name);
        }
    }
}
