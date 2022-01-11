namespace propertyinjuction
{
    public interface Itext
    {
        void print();
    }
    class format : Itext
    {
        public void print()
        {
            Console.WriteLine(" here is text format");
        }
    }

    class anotherFormat : Itext
    {
        public void print()
        {
            Console.WriteLine(" here is text anotherFormat");
        }
    }
    // constructor injection
    public class constructorinjection
    {
        private Itext _text;
        public constructorinjection(Itext t1)
        {
            _text = t1;
        }
        public void print()
        {
            _text.print();
        }
    }
    class constructor
    {
        static void Main(string[] args)
        {
            constructorinjection cs = new constructorinjection(new format());
            cs.print();
            constructorinjection cs2 = new constructorinjection(new anotherFormat());
            cs2.print();
            format format2 = new format();
            format2.print();
        }
    }
}