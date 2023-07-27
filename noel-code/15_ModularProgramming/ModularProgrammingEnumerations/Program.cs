using System;

// Define an enumeration for days of the week
enum DaysOfWeek
{
    Monday = 0x1,
    Tuesday = 0x2,
    Wednesday = 0x4,
    Thursday = 0x8,
    Friday = 0x10,
    Saturday = 0x20,
    Sunday = 0x40
}

class ModularProgrammingEnumerations
{
    static void Main()
    {
        int days = 0;

        while (true)
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
                    case DaysOfWeek.Saturday:
                    case DaysOfWeek.Sunday:
                        days = days | (int)userDay;
                        break;
                    default:
                        Console.WriteLine("Invalid day.");
                        break;
                }
                //Console.WriteLine(days);
            }
            else if (userInput == "")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid day of the week.");
            }
        }

        Console.WriteLine("You selected the following days:");
        foreach (var key in Enum.GetValues(typeof(DaysOfWeek)))
        {
            if ((days & (int)key) > 0) Console.WriteLine($"    {(DaysOfWeek)key}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}