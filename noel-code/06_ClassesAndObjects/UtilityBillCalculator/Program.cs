using System;

public class UtilityBillCalculator
{
    // set up variables with scope for classes
    private const double BaseRate = 72.50;
    private const double OverageRate = 1.50;
    private const double TaxRate = 0.12;

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the total cubic feet of gas used:");
        double gasUsed = Convert.ToDouble(Console.ReadLine());

        double overageFees = CalculateOverageFees(gasUsed);
        double taxes = CalculateTaxes(BaseRate + overageFees);
        double totalBill = CalculateTotalBill(BaseRate, overageFees, taxes);

        Console.WriteLine("Itemized Bill:\n" +
            $"Base Fee: ${BaseRate:F2}\n" +
            $"Overage Costs: ${overageFees:F2}\n" +
            $"Taxes: ${taxes:F2}\n" +
            $"Total Bill: ${totalBill:F2}");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

    }

    private static double CalculateOverageFees(double gasUsed)
    {
        double overage = gasUsed - 100;
        if (overage > 0)
        {
            return overage * OverageRate;
        }
        else
        {
            return 0;
        }
    }

    private static double CalculateTaxes(double subtotal)
    {
        return subtotal * TaxRate;
    }

    private static double CalculateTotalBill(double baseRate, double overageFees, double taxes)
    {
        return baseRate + overageFees + taxes;
    }
}
