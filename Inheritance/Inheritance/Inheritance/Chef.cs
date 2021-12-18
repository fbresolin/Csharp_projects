using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("Chef makes chicken dinner");
        }
        public void MakeSalad()
        {
            Console.WriteLine("Chef makes salad");
        }
        public virtual void MakeSpecial()
        {
            Console.WriteLine("Chef makes bbq");
        }
    }
}
