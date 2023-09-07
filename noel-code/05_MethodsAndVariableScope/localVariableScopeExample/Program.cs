using System;

class localVariableScopeExample
{
    static void Main()
    {
        int number = 10;

        Console.WriteLine("Before calling the method, the value of number is: " + number);

        // Call the method
        ModifyNumber();

        Console.WriteLine("After calling the method, the value of number is: " + number);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void ModifyNumber()
    {
        // Local variable declaration within the method
        int number = 20;

        Console.WriteLine("Inside the method, the value of number is: " + number);
    }
}
