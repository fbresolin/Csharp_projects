namespace ObjectExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Mike");
            book1.author = "Dostoiveski";
            book1.title = "Crime e Castigo";
            book1.pages = "not enough";

            Book book2 = new Book("John");
            book2.author = "Tolkien";
            book2.title = "Lord of the Rings";
            book2.pages = "800";

            Console.WriteLine(book2.title);        
        }
    }
}