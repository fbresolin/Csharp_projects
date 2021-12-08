class Program
{
    static void Main(string[] args)
    {
        try 
        { 
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the desired operator:");
            string oper = Console.ReadLine();
            Console.Write("Enter a second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(BetterCalculator(num1, num2, oper));
        } 
        catch(FormatException)
        {
            Console.WriteLine("Input format error");
        }
        finally
        {
            Console.WriteLine("Thanks for using this code");
        }
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