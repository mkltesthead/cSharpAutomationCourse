using System;

class MyClass
{
    // Instance variables
    private string name;
    private int age;

    public void SetData(string newName, int newAge)
    {
        name = newName;
        age = newAge;
    }

    public void PrintData()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class instancevariableScopeExample
{
    static void Main()
    {
        MyClass obj1 = new MyClass();
        obj1.SetData("David", 45);
        obj1.PrintData();  // Output: Name: John, Age: 25

        MyClass obj2 = new MyClass();
        obj2.SetData("Sarah", 30);
        obj2.PrintData();  // Output: Name: Sarah, Age: 30

        obj1.PrintData();  // Output: Name: John, Age: 25

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
