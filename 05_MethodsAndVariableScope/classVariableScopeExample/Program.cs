using System;

class MyClass
{
    // Class-scoped variable that works only for the immediate object
    private int immediateCount = 0;

    // the value is updated throughout all classes
    private static int allCount = 0;

    public void IncrementCount()
    {
        allCount++;
        immediateCount++;
    }

    public void PrintCount()
    {
        Console.WriteLine("Immediate Count: " + immediateCount);
        Console.WriteLine("All Count: " + allCount);
    }
}

class Program
{
    static void Main()
    {
        MyClass obj1 = new MyClass();
        obj1.IncrementCount();
        obj1.PrintCount();  // Output: Count: 1

        MyClass obj2 = new MyClass();
        obj2.IncrementCount();
        obj2.PrintCount();  // Output: Count: 2

        obj1.PrintCount();  // Output: Count: 2

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}