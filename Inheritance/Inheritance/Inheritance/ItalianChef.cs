using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class ItalianChef : Chef
    {
        public void MakePizza()
        {
            Console.WriteLine("Italian Chef makes pizza");
        }

        public override void MakeSpecial()
        {
            Console.WriteLine("Italian Chef makes pasta");
        }
    }
}
