using System;

namespace PaymentCalculator
{
    class salesPaymentCalculatorProgramV6
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the do-while looping Payment Calculator!");

            bool continueEntering = true;

            do
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
                        Console.Write("Enter the number of hours worked (1-40): ");
                        string hoursInput = Console.ReadLine();

                        if (double.TryParse(hoursInput, out hoursWorked) && hoursWorked >= 1 && hoursWorked <= 40)
                        {
                            isValidHours = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a value between 1 and 40.");
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

            } while (continueEntering);

            Console.WriteLine("Thank you for using the Payment Calculator. Goodbye!");
        }
    }
}

