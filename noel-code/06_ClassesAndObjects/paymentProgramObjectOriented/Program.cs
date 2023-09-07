using System;
class PaymentProgramObjectOriented
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Object Oriented Payment Calculator, Version 5!");

        bool continueEntering = true;

        while (continueEntering)
        {
            Console.Write("Enter employee name: ");
            string employeeName = Console.ReadLine();

            Console.Write("Enter employee type (Regular/Sales): ");
            string employeeType = Console.ReadLine();

            double payment;

            if (employeeType.ToLower() == "regular")
            {
                Console.Write("Enter number of hours worked: ");
                double hoursWorked = double.Parse(Console.ReadLine());

                Console.Write("Enter hourly pay rate: ");
                double hourlyPayRate = double.Parse(Console.ReadLine());

                RegularEmployee regularEmployee = new RegularEmployee(employeeName, hoursWorked, hourlyPayRate);
                payment = regularEmployee.CalculatePayment();
            }
            else if (employeeType.ToLower() == "sales")
            {
                Console.Write("Enter number of sales: ");
                int numberOfSales = int.Parse(Console.ReadLine());

                SalesEmployee salesEmployee = new SalesEmployee(employeeName, numberOfSales);
                payment = salesEmployee.CalculatePayment();
            }
            else
            {
                Console.WriteLine("Invalid employee type entered. Please try again.");
                continue;
            }

            Console.WriteLine($"Employee: {employeeName}");
            Console.WriteLine($"Payment: ${payment:F2}");

            Console.Write("Do you want to enter payment information for another employee? (Yes/No): ");
            string response = Console.ReadLine();

            continueEntering = (response.ToLower() == "yes");
        }
    }
}

class RegularEmployee
{
    public string Name { get; set; }
    public double HoursWorked { get; set; }
    public double HourlyPayRate { get; set; }

    public RegularEmployee(string name, double hoursWorked, double hourlyPayRate)
    {
        Name = name;
        HoursWorked = hoursWorked;
        HourlyPayRate = hourlyPayRate;
    }

    public double CalculatePayment()
    {
        const double MaxRegularHours = 40;
        const double RegularBasePay = 750.0;

        if (HoursWorked > MaxRegularHours)
        {
            Console.WriteLine("Overtime hours are not allowed for regular employees.");
            return 0.0;
        }

        return HoursWorked * HourlyPayRate;
    }
}

class SalesEmployee
{
    public string Name { get; set; }
    public int NumberOfSales { get; set; }

    public SalesEmployee(string name, int numberOfSales)
    {
        Name = name;
        NumberOfSales = numberOfSales;
    }

    public double CalculatePayment()
    {
        const double SalesBasePay = 750.0;
        const double SalesQuota = 15;
        const double BonusLevel1 = 250.0;
        const double BonusLevel2 = 500.0;
        const double BonusLevel3 = 1000.0;

        double payment = SalesBasePay;

        if (NumberOfSales >= SalesQuota)
        {
            double bonus = 0.0;

            if (NumberOfSales > 40)
            {
                bonus = BonusLevel3;
                Console.WriteLine("Congratulations! You reached the 40+ sales stretch bonus level!");
            }
            else if (NumberOfSales > 25)
            {
                bonus = BonusLevel2;
                Console.WriteLine("Congratulations! You reached the 25+ sales stretch bonus level!");
            }
            else if (NumberOfSales >= 15)
            {
                bonus = BonusLevel1;
                Console.WriteLine("Congratulations! You made your quota!");
            }

            payment += bonus;
        }
        else
        {
            double difference = SalesQuota - NumberOfSales;
            Console.WriteLine($"You were {difference} sales short of reaching your quota. Better luck next time!");
        }

        return payment;
    }
}