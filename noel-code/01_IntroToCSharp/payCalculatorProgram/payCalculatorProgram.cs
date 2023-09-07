using System;

class payCalculatorProgram
{
    static void Main()
    {
        // Get employee's number of hours worked
        Console.Write("Enter the number of hours worked: ");
        double hoursWorked = Convert.ToDouble(Console.ReadLine());

        // Get employee's hourly pay rate
        Console.Write("Enter the hourly pay rate: ");
        double hourlyPayRate = Convert.ToDouble(Console.ReadLine());

        // Multiply hours by pay rate
        double totalPayment = hoursWorked * hourlyPayRate;

        // Display the result
        Console.WriteLine("The total payment for the employee is: $" + totalPayment);

        // Wait for user input before closing the console window
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}