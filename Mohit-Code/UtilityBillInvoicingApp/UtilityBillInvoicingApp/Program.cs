﻿using System;

namespace Utility_Bill
{
    internal class Program
    {
        public static double basePlanCost = 72.50;
        public static double overageCost = 1.50;
        public static int basicPlanGasUnits = 100;
        static void Main(string[] args)
        {
            Console.Write("enter the total cubic feet of gas used : ");
            int gasUsed = Convert.ToInt32(Console.ReadLine());

            double overgeFees = CalculateOverageFees(gasUsed);
            double taxes = CalculateTaxes(gasUsed, overgeFees);

            PrintUtilityBill(overgeFees, taxes);

        }

        public static double CalculateOverageFees(int gasUsed)
        {
            double overageFee = 0;

            if (gasUsed > 100)
                overageFee = overageCost * (gasUsed - basicPlanGasUnits);


            return overageFee;
        }

        public static double CalculateTaxes(int gasUsed, double overageFees)
        {
            double tax;

            if (gasUsed > 100)
                tax = .12 * (basePlanCost + overageFees);
            else
                tax = .12 * basePlanCost;

            return tax;
        }

        public static void PrintUtilityBill(double overageFees, double taxes)
        {
            Console.WriteLine("\n");
            Console.WriteLine("base fee for gas used at or under 100 cubic feet : " + "$" + basePlanCost);
            Console.WriteLine("any overage costs based on gas used above 100 cubic feet : " + "$" + overageFees);
            Console.WriteLine("taxes as apply to usage : " + "$" + taxes);
            Console.WriteLine("\n");

            double total;
            if (overageFees == 0)
                total = basePlanCost + taxes;
            else
                total = basePlanCost + overageFees + taxes;


            Console.WriteLine("Total utility Bill : " + "$" + total);
        }
    }
}