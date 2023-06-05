using System;

public class madlibProgram
{
    public static void Main()
    {
        // Prompt the user for input
        Console.Write("Enter a season of the year: ");
        // The string? represents that we could put in null values 
        string? season = Console.ReadLine();

        Console.Write("Enter a whole number: ");
        int wholeNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter an adjective: ");
        string? adjective = Console.ReadLine();

        Console.Write("Enter a day of the week: ");
        string? dayOfWeek = Console.ReadLine();

        Console.Write("Enter your favorite beverage: ");
        string? beverage = Console.ReadLine();

        // Generate the sentence using the user input
        string sentence = $"On a {adjective} {dayOfWeek} in {season}, I enjoy at least {wholeNumber} cups of {beverage}.";

        // Display the sentence
        Console.WriteLine(sentence);

        // Wait for user input before closing the console window
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
