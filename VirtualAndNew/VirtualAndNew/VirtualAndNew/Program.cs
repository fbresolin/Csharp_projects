namespace OverrideAndNew
{
    class Program
    {
        static void Main()
        {
            baseClass bc = new baseClass();
            derivedClass dc = new derivedClass();
            baseClass bcdc = new derivedClass();

            Console.WriteLine("bc - method 1 and 2");
            bc.Method1();
            bc.Method2();
            Console.WriteLine("--------------------");
            Console.WriteLine("bc - method 3");
            bc.Method3();
            Console.WriteLine("--------------------");
            Console.WriteLine("dc - method 1 and 2");
            dc.Method1();
            dc.Method2();
            Console.WriteLine("--------------------");
            Console.WriteLine("dc - method 3");
            dc.Method3();
            Console.WriteLine("--------------------");
            Console.WriteLine("bcdc - method 1 and 2");
            bcdc.Method1();
            bcdc.Method2();
            Console.WriteLine("--------------------");
            Console.WriteLine("bcdc - method 3");
            bcdc.Method3();
        }
    }

    class baseClass
    {
        public virtual void Method1()
        {
            Console.WriteLine("Base Class - Method 1");
        }
        public virtual void Method2()
        {
            Console.WriteLine("Base Class - Method 2");
        }
        public void Method3()
        {
            Method1();
            Method2();
        }
    }

    class derivedClass : baseClass
    {
        public override void Method1()
        {
            Console.WriteLine("Derived Class - Method 1");
        }
        public new void Method2()
        {
            Console.WriteLine("Derived Class - Method 2");
        }
    }
}