// Define an enumeration for days of the week
enum Seasons
{
    Summer,
    Spring,
    Autumn,
    Winter,
    Rainy
}

class ModularProgrammingEnumerations
{
    static void Main()
    {
        Console.WriteLine("List of seasons:");
        Console.WriteLine("1. Summer");
        Console.WriteLine("2. Spring");
        Console.WriteLine("3. Autumn");
        Console.WriteLine("4. Winter");
        Console.WriteLine("5. Rainy");
        // Let's ask the user to input a day of the week
        Console.WriteLine("Enter a season(1 to 5):");
        string userInput = Console.ReadLine();

        // Try to parse the user input to the DaysOfWeek enumeration
        if (Enum.TryParse(userInput, out Seasons season))
        {
            // Switch statement to display a message based on the selected day
            switch ((int)season - 1)
            {
                case (int)Seasons.Summer:
                    Console.WriteLine("You have selected " + Seasons.Summer);
                    break;
                case (int)Seasons.Spring:
                    Console.WriteLine("You have selected " + Seasons.Spring);
                    break;
                case (int)Seasons.Autumn:
                    Console.WriteLine("You have selected " + Seasons.Autumn);
                    break;
                case (int)Seasons.Winter:
                    Console.WriteLine("You have selected " + Seasons.Winter);
                    break;
                case (int)Seasons.Rainy:
                    Console.WriteLine("You have selected " + Seasons.Rainy + ".It's drizzling!!");
                    break;
                default:
                    Console.WriteLine("Invalid season.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid season");
        }
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
