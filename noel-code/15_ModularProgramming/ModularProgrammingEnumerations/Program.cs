using System;

// Define an enumeration for days of the week
enum DaysOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class ModularProgrammingEnumerations
{
    static void Main()
    {
        // Let's ask the user to input a day of the week
        Console.WriteLine("Enter a day of the week:");
        string userInput = Console.ReadLine();

        // Try to parse the user input to the DaysOfWeek enumeration
        if (Enum.TryParse(userInput, out DaysOfWeek userDay))
        {
            // Switch statement to display a message based on the selected day
            switch (userDay)
            {
                case DaysOfWeek.Monday:
                case DaysOfWeek.Tuesday:
                case DaysOfWeek.Wednesday:
                case DaysOfWeek.Thursday:
                case DaysOfWeek.Friday:
                    Console.WriteLine("It's a weekday. Get to work!");
                    break;
                case DaysOfWeek.Saturday:
                case DaysOfWeek.Sunday:
                    Console.WriteLine("It's the weekend. Time to relax!");
                    break;
                default:
                    Console.WriteLine("Invalid day.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid day of the week.");
        }
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
