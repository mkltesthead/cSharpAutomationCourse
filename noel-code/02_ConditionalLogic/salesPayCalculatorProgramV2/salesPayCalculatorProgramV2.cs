using System;

class salesPayCalculatorProgramV2
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

        // Calculate the total pay and check if the user made the quota
        double totalPay = basePay;
        double difference = 0;

        if (numberOfSales > salesThreshold)
        {
            totalPay += bonus;
            // YAY, they did it. Congratulate them
            Console.WriteLine("Congratulations! You have met your sales quota! Way to go!");
        }
        else
        {
            // AWW, they didn't make it. Encourage them to do better
            difference = salesThreshold - numberOfSales;
            Console.WriteLine("You did not meet your sales quota.");
            Console.WriteLine("You were " + difference + " sales short.");
            Console.WriteLine("Better luck next week!");
        }

        // Display the total pay
        Console.WriteLine("Total pay for the week: $" + totalPay);

        // Wait for user input before closing the console window
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
