namespace GettersSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("Avengers", "Isfduhi sdfsdif", "dog");
            Movie shrek = new Movie("Shrek", "Wasdu Iskd", "PG");

            Console.WriteLine(avengers.Rating);
            Console.WriteLine(shrek.Rating);
        }
    }
}