using System;

class Parent
{
    // value definition of Child
    public string StringVal = "ParentString";

    //a class can have multiple constructors...
    public Parent()
    {
        Console.WriteLine("This is Parent Constructor without input");
        Console.WriteLine(this.StringVal);
    }
    public Parent(int parameter)
    {
        Console.WriteLine("Parent ctor, parameter is " + parameter);
    }

    public Parent(int parameter, int parameter2)
    {
        Console.WriteLine("Parent ctor, parameter 1 is " + parameter + " and parameter 2 is " + parameter2);
    }
}

class Child : Parent
{
    // value definition of Child
    public string StringVal = "ChildString";

    //the different constructors can be inherited using the proper call...
    public Child() : base()
    {
        Console.WriteLine("This is child constructor without input");
        Console.WriteLine(base.StringVal);
        Console.WriteLine(this.StringVal);
    }
    public Child(int parameter) : base(parameter)
    {
        Console.WriteLine("This is child constructor with input");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("parentObject");
        Parent parentObject = new Parent();
        Console.WriteLine("parentObjectCtor");
        Parent parentObjectCtor = new Parent(1);
        Console.WriteLine("parentObjectCtor2");
        Parent parentObjectCtor2 = new Parent(10,20);
        Console.WriteLine("-------------------------------------");

        Console.WriteLine("childObject");
        Child childObject = new Child();
        Console.WriteLine("childObjectCtor");
        Child childObjectCtor = new Child(10);
    }
}