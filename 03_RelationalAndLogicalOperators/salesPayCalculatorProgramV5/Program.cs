using System;

namespace PaymentCalculator
{
    class salesPayCalculatorProgramV5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the looping version of the Payment Calculator!");

            bool continueEntering = true;

            while (continueEntering)
            {
                Console.Write("Do you work in Sales? (Y/N): ");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "n")
                {
                    // Regular Employee
                    double hoursWorked = 0;
                    bool isValidHours = false;

                    while (!isValidHours)
                    {
                        Console.Write("Enter the number of hours worked (between 1 and 40): ");
                        string hoursInput = Console.ReadLine();

                        if 
                            hoursWorked >= 1 && hoursWorked <= 40)
                        {
                            isValidHours = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number of hours between 1 and 40.");
                        }
                    }

                    Console.Write("Enter the hourly pay rate: ");
                    double hourlyPayRate = Convert.ToDouble(Console.ReadLine());

                    double totalPay = hoursWorked * hourlyPayRate;

                    Console.WriteLine("The total payment for the employee is: " + totalPay);
                }
                else
                {
                    // Sales Employee
                    Console.Write("Enter the number of sales for the week: ");
                    int numberOfSales = Convert.ToInt32(Console.ReadLine());

                    double totalPay = 750;

                    if (numberOfSales > 40)
                    {
                        totalPay += 1000;
                    }
                    else if (numberOfSales > 25)
                    {
                        totalPay += 500;
                    }
                    else if (numberOfSales > 15)
                    {
                        totalPay += 250;
                    }

                    Console.WriteLine("The total payment for the employee is: " + totalPay);
                }

                // Prompt the user if they want to continue entering payment information
                Console.Write("Do you want to enter payment information for another employee? (Yes/No): ");
                string response = Console.ReadLine();

                continueEntering = (response.ToLower() == "yes");
            }
        }
    }
}

