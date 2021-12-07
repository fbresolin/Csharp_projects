class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input a number to sum: ");
        double firstNum = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input a second number to sum: ");
        double secondNum = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Response is " + (firstNum + secondNum));    }
}