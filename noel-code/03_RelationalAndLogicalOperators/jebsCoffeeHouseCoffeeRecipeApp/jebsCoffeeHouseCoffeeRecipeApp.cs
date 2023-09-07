using System;

class jebsCoffeeHouseCoffeeRecipeApp
{
    static void Main()
    {
        // Prompt for the type of coffee
        Console.WriteLine("Welcome to Jeb's Coffee House!");
        Console.WriteLine("Please select the type of coffee you need to make:");
        Console.WriteLine("1. Jeb's Flat White");
        Console.WriteLine("2. The Misty Mountain");
        Console.WriteLine("3. The Honey Badger");
        Console.Write("Enter your choice (1-3): ");
        int coffeeType = Convert.ToInt32(Console.ReadLine());

        // Prompt for the size
        Console.WriteLine("Please select the size:");
        Console.WriteLine("1. Small");
        Console.WriteLine("2. Medium");
        Console.WriteLine("3. Large");
        Console.Write("Enter your choice (1-3): ");
        int coffeeSize = Convert.ToInt32(Console.ReadLine());

        // Process the order based on the selected drink
        switch (coffeeType)
        {
            case 1: // Jeb's Flat White
                Console.WriteLine("Jeb's Flat White Recipe:");
                Console.WriteLine("3 shots espresso");
                Console.WriteLine(".5 cup whole milk (light froth)");
                Console.WriteLine(".25 tsp vanilla extract");
                break;

            case 2: // The Misty Mountain
                Console.WriteLine("The Misty Mountain Recipe:");
                Console.WriteLine("3 shots espresso");
                Console.WriteLine(".5 milk of choice (heavy froth)");
                Console.WriteLine("1 tsp hazelnut syrup");
                Console.WriteLine("2 tsp lavender syrup");
                break;

            case 3: // The Honey Badger
                Console.WriteLine("The Honey Badger Recipe:");
                Console.WriteLine("3 shots espresso");
                Console.WriteLine(".5 milk of choice (medium froth)");
                Console.WriteLine(".25 tsp vanilla extract");
                Console.WriteLine("1 TB honey");
                break;

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                return;
        }

        // Display the instructions based on the selected size
        switch (coffeeSize)
        {
            case 1: // Small
                Console.WriteLine("Instructions: Use a small cup for this size.");
                break;

            case 2: // Medium
                Console.WriteLine("Instructions: Use a medium cup for this size.");
                break;

            case 3: // Large
                Console.WriteLine("Instructions: Use a large cup for this size.");
                break;

            default:
                Console.WriteLine("Invalid size choice. Please try again.");
                return;
        }

        // Wait for user input before closing the console window
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}