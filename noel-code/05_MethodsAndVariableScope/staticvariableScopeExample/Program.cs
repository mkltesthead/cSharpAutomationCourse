using System;

class staticVariableScopeExample
{
    // Static variable
    static int totalCount;

    public static void IncrementCount()
    {
        totalCount++;
    }

    public static void Main(string[] args)
    {
        IncrementCount();
        IncrementCount();
        IncrementCount();

        Console.WriteLine("Total count: " + totalCount);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}