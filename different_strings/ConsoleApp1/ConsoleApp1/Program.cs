class Program
{
    static void Main(string[] args)
    {
        string phrase = "sakldkljhlkjfj";
        Console.WriteLine(phrase);
        Console.WriteLine(phrase.Length);
        Console.WriteLine(phrase.ToUpper());
        Console.WriteLine(phrase.Contains("dfj"));
        Console.WriteLine(phrase[0]);
        Console.WriteLine(phrase[2]);
        Console.WriteLine(phrase.IndexOf("ld"));
        Console.WriteLine(phrase.Substring(3,5));

        Console.ReadLine();
    }
}