class MainClass
{
    static void Main()
    {
        Employee jonh = new Employee("Jonh","Cena");
        jonh.salary = 8000m;
        jonh.PrintEmployee();
    }
}

class Employee
{
    private string name;
    private string alias;
    public decimal salary;
    public Employee(string name, string alias)
    {
        this.name = name;
        this.alias = alias;
    }

    public void PrintEmployee()
    {
        Console.WriteLine("Name: {0}\nAlias: {1}", name, alias);
        Console.WriteLine("Taxes: {0}", Tax.CalcTax(this));
    }

    public decimal Salary
    {
        get { return salary; }
    }
}

class Tax
{
    public static decimal taxes;
    public static decimal CalcTax(Employee E)
    {
        taxes = 0.08m * E.salary;
        return taxes;
    }
}