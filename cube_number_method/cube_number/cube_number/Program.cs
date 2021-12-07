class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(PowerNumber(5, 3));
    }
        static double PowerNumber(double num, double power)
    {
        double val = num;
        for (int i=1; i < power; i++)
        {
            val = val * num;
        }
        return val;
    }
}