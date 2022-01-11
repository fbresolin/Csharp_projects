namespace DependecyInjection_Method
{
    public interface IMethodInjuction
    {
        void Print();
    }
    class servc : IMethodInjuction
    {
        public void Print()
        {
            Console.WriteLine("running app");
        }
    }

    class client
    {
        private IMethodInjuction? _set;
        public void run (IMethodInjuction servc)
        {
            _set = servc;
            Console.WriteLine("starting app...");
            _set.Print();
        }
    }

    class Program
    {
        public static void Main()
        {
            servc service = new servc();
            service.Print();


        }
    }
}