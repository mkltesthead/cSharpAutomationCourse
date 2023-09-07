using System;
class howMuchChangeForaDollar
{
    static void Main()
    {
        int pennies;
        int nickels;
        int dimes; 
        int quarters;

        Console.WriteLine("Welcome to the Change Game!");
        Console.WriteLine("Enter the quantities of each coin type to add up to $1.");

        // Prompt user for coin quantities
        Console.Write("Enter the number of pennies: ");
        pennies = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of nickels: ");
        nickels = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of dimes: ");
        dimes = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of quarters: ");
        quarters = int.Parse(Console.ReadLine());

        // Calculate total value of coins
        int totalCents = pennies + (nickels * 5) + (dimes * 10) + (quarters * 25);
        double totalDollars = totalCents / 100.0;

        // Check if the total value matches $1
        if (totalDollars == 1)
        {
            Console.WriteLine("Congratulations! You win!");
        }
        else if (totalDollars > 1)
        {
            double overAmount = totalDollars - 1;
            Console.WriteLine($"Oops! You went over by ${overAmount:F2}.");
        }
        else
        {
            double underAmount = 1 - totalDollars;
            Console.WriteLine($"Oops! You were under by ${underAmount:F2}.");
        }

        // Wait for user input before closing the console window
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
