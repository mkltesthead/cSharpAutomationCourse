using System;

class storeLoanQualifier
{
    static void Main()
    {
        // Enter variables here
        double minimumIncome = 45000;
        int minimumJobDuration = 1;

        // Get customer information
        Console.Write("Enter customer's gross income: $");
        double grossIncome = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter customer's job duration (in years): ");
        int jobDuration = Convert.ToInt32(Console.ReadLine());

        // Check if the customer meets the criteria
        if (grossIncome >= minimumIncome)
        {
            if (jobDuration >= minimumJobDuration)
            {
                Console.WriteLine("Congratulations! The customer is pre-qualified for a line of credit.");
            }
            else
            {
                Console.WriteLine("The customer does not meet the job duration requirement.");
            }
        }
        else
        {
            Console.WriteLine("The customer does not meet the minimum income requirement.");
        }

        // Wait for user input before closing the console window
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
