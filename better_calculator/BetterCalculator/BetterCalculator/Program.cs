class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(BetterCalculator(12, 2, "power"));
    }

    static double BetterCalculator(double num1, double num2, string oper)
    {
        if (oper == "sum")
        {
            return num1 + num2;
        }
        else if (oper == "mult")
        {
            return num1 * num2;
        }
        else if (oper == "power")
        {
            int i;
            double val = num1;
            for (i = 1; i < num2; i++)
            {
                val = val * num1;
            }
            return val;
        } else
        {
            return double.NaN;
        }
    }
}