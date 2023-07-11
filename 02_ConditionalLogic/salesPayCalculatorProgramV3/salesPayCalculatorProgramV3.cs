using System;

class Program
{
    static void Main()
    {
        // Define our variables here
        double basePay = 750;
        double bonusLevel1 = 250;
        double bonusLevel2 = 500;
        double bonusLevel3 = 1000;
        int salesThreshold1 = 15;
        int salesThreshold2 = 25;
        int salesThreshold3 = 40;

        // Get the number of sales from the user
        Console.Write("Enter the number of sales for the week: ");
        int numberOfSales = Convert.ToInt32(Console.ReadLine());

        // Calculate the total pay and check bonus levels
        double totalPay = basePay;

        if (numberOfSales > salesThreshold3)
        {
            totalPay += bonusLevel3;
            Console.WriteLine("Congratulations! You have reached Bonus Level 3.");
            Console.WriteLine("You receive a base pay of $" + basePay + " and a bonus of $" + bonusLevel3);
        }
        else if (numberOfSales > salesThreshold2)
        {
            totalPay += bonusLevel2;
            Console.WriteLine("Congratulations! You have reached Bonus Level 2.");
            Console.WriteLine("You receive a base pay of $" + basePay + " and a bonus of $" + bonusLevel2);
        }
        else if (numberOfSales > salesThreshold1)
        {
            totalPay += bonusLevel1;
            Console.WriteLine("Congratulations! You have reached Bonus Level 1.");
            Console.WriteLine("You receive a base pay of $" + basePay + " and a bonus of $" + bonusLevel1);
        }

        // Display the total pay
        Console.WriteLine("Total pay for the week: $" + totalPay);

        // Wait for user input before closing the console window
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
