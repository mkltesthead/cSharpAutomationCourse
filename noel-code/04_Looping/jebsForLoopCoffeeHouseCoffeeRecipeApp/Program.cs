using System;

class jebsForLoopCoffeeHouseCoffeeRecipeApp
{
    static void Main()
    {
        Console.WriteLine("Welcome to Jeb's Coffee House!");

        // Array to store the menu items and their prices
        string[] menuItems = { "Jeb's Spiked White", "The Misty Mountain Hop", "The Dangerous Honey Badger" };
        double[] itemPrices = { 3.99, 4.99, 5.49 };

        // Prompt for the number of coffee orders
        Console.Write("How many coffee orders would you like to place? ");
        int numberOfOrders = Convert.ToInt32(Console.ReadLine());

        double totalCost = 0;

        // Loop to collect information and calculate the total cost for each coffee order
        for (int i = 1; i <= numberOfOrders; i++)
        {
            Console.WriteLine($"Order {i}:");

            // Prompt for the type of coffee
            Console.WriteLine("Please select the type of coffee you need to make:");
            for (int j = 0; j < menuItems.Length; j++)
            {
                Console.WriteLine($"{j + 1}. {menuItems[j]} - ${itemPrices[j]}");
            }
            Console.Write("Enter your choice (1-3): ");
            int coffeeType = Convert.ToInt32(Console.ReadLine());

            // Prompt for the size
            Console.WriteLine("Please select the size:");
            Console.WriteLine("1. Small - $0.00");
            Console.WriteLine("2. Medium - $0.50");
            Console.WriteLine("3. Large - $1.00");
            Console.Write("Enter your choice (1-3): ");
            int coffeeSize = Convert.ToInt32(Console.ReadLine());

            // Calculate the cost of the coffee order
            double itemCost = itemPrices[coffeeType - 1];
            switch (coffeeSize)
            {
                case 2:
                    itemCost += 0.50;
                    break;
                case 3:
                    itemCost += 1.00;
                    break;
            }

            // Accumulate the total cost
            totalCost += itemCost;

            Console.WriteLine($"Item Cost: ${itemCost:F2}\n");
        }

        // Display the order total
        Console.WriteLine($"Total Cost: ${totalCost:F2}");

        // Wait for user input before closing the console window
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

