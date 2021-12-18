using System;

namespace aa { 
    public class UtilTest
    {
        public static void Main()
        {
            // simple arithmetics
            double a = 1;
            double b = 2;
            Console.WriteLine("Simple arithmetics");
            Console.WriteLine(a+b);
            Console.WriteLine(a*b);
            Console.WriteLine(Math.Pow(a,b));
            Console.WriteLine(" ");



            // ****** Public class Util ******
            //PublicUtil.PublicSwap(a, b); // --> non-static methods cannot be called from non-instatiated classes
            PublicUtil.StaticSwap(a,b);
            // PublicUtil.PrivateSwap(a, b); --> cannot be called outside the class

            // create an instance of PublicUtil
            PublicUtil u = new PublicUtil();
            u.PublicSwap(a, b);
            // u.StaticSwap(a,b); // --> static methods cannot be called from an instance of the class
            // u.PrivateSwap(a, b); --> cannot be called outside the class

            // testing Util constructor
            Console.WriteLine("Calling constructor");
            // Console.WriteLine(PublicUtil.isInitialized); --> PublicUtil is not static, so the constructor can only be called from an instance of the class 
            Console.WriteLine(u.isInitialized);
            Console.WriteLine(u.whatisutil);
            Console.WriteLine(u.whyUtils);
            // Console.WriteLine(u.errorOnPrivate); --> private strings cannot be called outside the class



            // ****** Public Static class Util ******
            PublicStaticUtil.StaticSwap(a, b);
            // static classes cannot have constructors
            // static classes cannot have non-static and private methods



            // ****** Inherit Public Static class Util ******
            InheritPublicUtil.StaticSwap(a, b); // === PublicUtil.StaticSwap(a, b)
            InheritPublicUtil ui = new InheritPublicUtil();
            ui.PublicSwap(a, b);
            Console.WriteLine(u.isInitialized);
            Console.WriteLine(u.whatisutil);
            Console.WriteLine(u.whyUtils);
            // classes who inherit another class have the same methods as the original
            // base class (PublicUtil) has priority over methods and construtors when calling the derived class

        }
    }

    public class PublicUtil
    {
        public bool isInitialized;
        public string whatisutil;
        public string whyUtils;
        private string errorOnPrivate;
        public PublicUtil()
        {
            this.isInitialized = true;
            this.whatisutil = "utilities";
            this.whyUtils = "because Utils are important";
            this.errorOnPrivate = "yes?";
        }
        public void PublicSwap(double x, double y)
        {
            Console.WriteLine("PublicUtil with PublicSwap");
            Console.WriteLine(x + y);
            Console.WriteLine(x * y);
            Console.WriteLine(Math.Pow(x, y));
            Console.WriteLine(" ");
        }
        public static void StaticSwap(double x, double y)
        {
            Console.WriteLine("PublicUtil with StaticSwap");
            Console.WriteLine(x + y);
            Console.WriteLine(x * y);
            Console.WriteLine(Math.Pow(x, y));
            Console.WriteLine(" ");
        }
        private void PrivateSwap(double x, double y) // this method is inaccessible outside this class
        {
            Console.WriteLine("PublicUtil with PrivateSwap");
            Console.WriteLine(x + y);
            Console.WriteLine(x * y);
            Console.WriteLine(Math.Pow(x, y));
            Console.WriteLine(" ");
        }
    }
    public static class PublicStaticUtil
    {
        // static classes cannot have constructors
        /*public PublicStaticUtil()
        {

        }*/

        // static classes cannot declare non-static methods
        /*public void PublicSwap(double x, double y)
        {
            Console.WriteLine("PublicStaticUtil with PublicSwap");
            Console.WriteLine(x + y);
            Console.WriteLine(x * y);
            Console.WriteLine(Math.Pow(x, y));
            Console.WriteLine(" ");
        }*/
        public static void StaticSwap(double x, double y)
        {
            Console.WriteLine("PublicStaticUtil with StaticSwap");
            Console.WriteLine(x + y);
            Console.WriteLine(x * y);
            Console.WriteLine(Math.Pow(x, y));
            Console.WriteLine(" ");
        }

        // static classes cannot declare private methods
        /*private void PrivateSwap(double x, double y) // this method is inaccessible outside this class
        {
            Console.WriteLine("PublicStaticUtil with PrivateSwap");
            Console.WriteLine(x + y);
            Console.WriteLine(x * y);
            Console.WriteLine(Math.Pow(x, y));
            Console.WriteLine(" ");
        }*/
    }

    public class InheritPublicUtil : PublicUtil
    {
        public bool isInitialized;
        public new string whatisutil;
        public new string whyUtils;
        private string errorOnPrivate;
        public InheritPublicUtil()
        {
            this.isInitialized = false;
            this.whatisutil = "utilities YY";
            this.whyUtils = "because Utils are important YY";
            this.errorOnPrivate = "yes? YY";
        }
    }
}