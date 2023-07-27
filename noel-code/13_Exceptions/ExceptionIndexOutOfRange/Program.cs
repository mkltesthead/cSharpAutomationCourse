using System;

class ExceptionIndexOutOfRange
{
    static void Main()
    {
        // Exception example - IndexOutOfRangeException
        string[] employees = { "Andy", "Randy", "Gil", "Saba" };
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Hi there " + employees[i]);
        }
        Console.WriteLine("Press any key to quit...");
        Console.ReadKey();
    }
}



