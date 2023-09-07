using System;

namespace paymentCalculator
{
    class paymentCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Payment Calculator 4.0!");

            bool continueEntering = true;

            while (continueEntering)
            {
                // Prompt the user to enter employee information
                Console.Write("Enter employee name: ");
                string employeeName = Console.ReadLine();

                Console.Write("Enter employee type (Regular/Salaried): ");
                string employeeType = Console.ReadLine();

                Console.Write("Enter number of sales: ");
                int numberOfSales = int.Parse(Console.ReadLine());

                // Calculate the payment based on the employee type and number of sales
                double payment = CalculatePayment(employeeType, numberOfSales);

                // Display the payment information
                Console.WriteLine($"Employee: {employeeName}");
                Console.WriteLine($"Payment: ${payment:F2}");

                // Prompt the user if they want to continue entering employee information
                Console.Write("Do you want to enter payment information for another employee? (Yes/No): ");
                string response = Console.ReadLine();

                continueEntering = (response.ToLower() == "yes");
            }
        }

        static double CalculatePayment(string employeeType, int numberOfSales)
        {
            const double RegularBasePay = 750.0;
            const double RegularBonus = 250.0;
            const double SalariedBasePay = 1500.0;
            const double SalariedBonus = 500.0;

            double basePay = (employeeType.ToLower() == "salaried") ? SalariedBasePay : RegularBasePay;
            double bonus = (numberOfSales > 15) ? RegularBonus : 0.0;

            return basePay + bonus;
        }
    }
}
