using System;

class methodVariableScopeExample
{
    static void MyMethod()
    {
        // Method-scoped variable
        int myVariable = 10;
        Console.WriteLine("Inside MyMethod: " + myVariable);
    }

    static void Main()
    {
        // Main-scoped variable
        int myVariable = 5;
        Console.WriteLine("Inside Main: " + myVariable);

        MyMethod();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

