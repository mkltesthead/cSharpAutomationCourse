using System;

    internal class salesPayCalculatorProgramV4
    {
        static void Main()
        {

           double totalPay;

            Console.Write("Do You work in Sales? (Y/N): ");

            if (Console.ReadLine() == "n")
            {
                //Get employee's number of hours worked
                Console.Write("Enter the number of hours worked: ");
                double hoursWorked = Convert.ToDouble(Console.ReadLine());

                //Get employee's hourly pay rate
                Console.Write("Enter the hourly pay rate: ");
                double hourlyPayRate = Convert.ToDouble(Console.ReadLine());

                //Multiply the hours by pay rate
                totalPay = hoursWorked * hourlyPayRate;
            }
            else
            {
                // Get the number of sales from the user
                Console.Write("Enter the number of sales for the week: ");

                int numberOfSales = Convert.ToInt32(Console.ReadLine());

                // Calculate the total pay based on the pay structure
                totalPay = 750;

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
            }

            //Display the result
            Console.WriteLine("The total payment for the employee is: " + totalPay);

            //Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }