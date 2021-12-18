namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecial();

            ItalianChef ichef = new ItalianChef();
            ichef.MakeChicken();
            ichef.MakePizza();
            ichef.MakeSpecial();
        }
    }
}