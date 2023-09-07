using System;

class niceToMeetYouMethod
{
    static void Main()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();

        GreetUser(name);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void GreetUser(string name)
    {
        Console.WriteLine($"Hello, {name}! Nice to meet you.");
    }
}
