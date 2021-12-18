namespace ObjectExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Dostoiveski", "Crime e Castigo", 400);

            Book book2 = new Book("Tolkien", "Lord of the Rings", 800);

            Console.WriteLine(book2.title);        
        }
    }
}