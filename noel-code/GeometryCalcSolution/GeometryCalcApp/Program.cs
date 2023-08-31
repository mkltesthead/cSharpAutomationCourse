using System;
using GeometryCalcLibrary;

namespace GeometryCalcApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose a shape:");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Triangle");
                Console.WriteLine("3. Square");
                Console.WriteLine("4. Parallelogram");
                Console.WriteLine("5. Pentagon");
                Console.WriteLine("6. Hexagon");
                Console.WriteLine("7. Exit");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                if (choice == 7)
                {
                    Console.WriteLine("Exiting the program...");
                    break;
                }

                Console.WriteLine("Do you want to calculate Area (A) or Perimeter (P)?");
                string calculationType = Console.ReadLine().ToLower();

                if (calculationType != "a" && calculationType != "p")
                {
                    Console.WriteLine("Invalid input. Please enter 'A' for Area or 'P' for Perimeter.");
                    continue;
                }

                double result;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the radius of the circle: ");
                        double circleRadius = GetPositiveNumber();
                        result = calculationType == "a" ? Circle.CalculateArea(circleRadius) : Circle.CalculatePerimeter(circleRadius);
                        break;

                    case 2:
                        Console.Write("Enter the base of the triangle: ");
                        double triangleBase = GetPositiveNumber();
                        Console.Write("Enter the height of the triangle: ");
                        double triangleHeight = GetPositiveNumber();
                        result = calculationType == "a" ? Triangle.CalculateArea(triangleBase, triangleHeight) : Triangle.CalculatePerimeter(triangleBase, triangleHeight, triangleHeight);
                        break;

                    case 3:
                        Console.Write("Enter the side length of the square: ");
                        double squareSide = GetPositiveNumber();
                        result = calculationType == "a" ? Square.CalculateArea(squareSide) : Square.CalculatePerimeter(squareSide);
                        break;

                    case 4:
                        Console.Write("Enter the base of the parallelogram: ");
                        double parallelogramBase = GetPositiveNumber();
                        Console.Write("Enter the height of the parallelogram: ");
                        double parallelogramHeight = GetPositiveNumber();
                        result = calculationType == "a" ? Parallelogram.CalculateArea(parallelogramBase, parallelogramHeight) : Parallelogram.CalculatePerimeter(parallelogramBase, parallelogramHeight);
                        break;

                    case 5:
                        Console.Write("Enter the side length of the pentagon: ");
                        double pentagonSide = GetPositiveNumber();
                        result = calculationType == "a" ? Pentagon.CalculateArea(pentagonSide) : Pentagon.CalculatePerimeter(pentagonSide);
                        break;

                    case 6:
                        Console.Write("Enter the side length of the hexagon: ");
                        double hexagonSide = GetPositiveNumber();
                        result = calculationType == "a" ? Hexagon.CalculateArea(hexagonSide) : Hexagon.CalculatePerimeter(hexagonSide);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select again.");
                        continue;
                }

                Console.WriteLine(calculationType == "a" ? "The area is:" : "The perimeter (or circumference) is:");
                Console.WriteLine(result);
            }
        }

        static double GetPositiveNumber()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
            return number;
        }
    }
}
