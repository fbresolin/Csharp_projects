// Exemplo de Get and Set

class MainProgram
{
    static void Main()
    {
        Date dt = new Date();
        dt.Month = -1;
        Console.WriteLine(dt.Month);

        dt.Month = 5;
        Console.WriteLine(dt.Month);
    }
}

public class Date
{
    private int _month = 7;

    public int Month
    {
        get { return _month; }
        set 
        { 
        if (value > 0 && value < 13)
            {
                _month = value;
            }
        
        }
    }
}