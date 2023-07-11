using System;

class salesPayCalculatorProgram
{
    static void Main()
    {
        // Define our variables here
        double basePay = 750;
        double bonus = 250;
        int salesThreshold = 15;

        // Get the number of sales from the user
        Console.Write("Enter the number of sales for the week: ");
        int numberOfSales = Convert.ToInt32(Console.ReadLine());

        // Calculate the total pay based on the pay structure
        double totalPay = basePay;
        if (numberOfSales > salesThreshold)
        {
            totalPay += bonus;
        }

        // Display the total pay
        Console.WriteLine("Total pay for the week: $" + totalPay);

        // Wait for user input before closing the console window
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}