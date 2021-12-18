namespace StaticAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Artic Monekys", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 180);

            Console.WriteLine(kashmir.author);
            Console.WriteLine(kashmir.getSongCount());
            Console.WriteLine(Song.songCount);
        }
    }
}