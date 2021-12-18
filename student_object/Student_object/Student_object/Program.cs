namespace Student_object
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Jim", "arts", 1.1);
            Console.WriteLine(student1.HasHonors());
            Student student2 = new Student("Tom", "enginneering", 123123);
            Console.WriteLine(student2.HasHonors());
        }
    }
}