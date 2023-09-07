using System;

class StringReversalDemo
{
    static void Main(string[] args)
    {
        string text = GetString();

        ReverseStringMethod(text);

        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static string GetString()
    {
        Console.WriteLine("Enter a string that you'd like us to print backwards for you: ");
        return Console.ReadLine();
    }

    static void ReverseStringMethod(string text)
    {
        for (int i = text.Length - 1; i >= 0; i--)
        {
            Console.Write(text[i]);
        }
    }
}