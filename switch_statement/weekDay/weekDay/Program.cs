class Program
{
    static void Main(string[] args)
    {
        Console.Write("Write the desired week day: ");
        int dayNum = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("This a " + WeekDay(dayNum));
    }

    static string WeekDay(int dayNum)
    {
        dayNum = dayNum % 7;
        string dayName;
        switch (dayNum)
        {
            case 0:
                dayName = "Sunday";
                break;
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thursday";
                break ;
            case 5:
                dayName = "Friday";
                break;
            case 6:
                dayName = "Saturday";
                break;
            default: 
                dayName = "not valid input"; 
                break;
        }
        return dayName;
    }
}