class Program
{
    static void Main(string[] args)
    {
        SayHi("Mark");
        SayHi("Johnny");
    }

    static void SayHi(string name)
    {
        Console.WriteLine("Hi " + name);
    }
}
