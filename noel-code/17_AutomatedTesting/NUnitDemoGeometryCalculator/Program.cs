namespace GeometryCalculator
{
    class Program
    {
        static void Main()
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

                double result;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the radius of the circle: ");
                        double circleRadius = GetPositiveNumber();
                        result = Circle.CalculateArea(circleRadius);
                        break;

                    case 2:
                        Console.Write("Enter the base of the triangle: ");
                        double triangleBase = GetPositiveNumber();
                        Console.Write("Enter the height of the triangle: ");
                        double triangleHeight = GetPositiveNumber();
                        result = Triangle.CalculateArea(triangleBase, triangleHeight);
                        break;

                    case 3:
                        Console.Write("Enter the side length of the square: ");
                        double squareSide = GetPositiveNumber();
                        result = Square.CalculateArea(squareSide);
                        break;

                    case 4:
                        Console.Write("Enter the base of the parallelogram: ");
                        double parallelogramBase = GetPositiveNumber();
                        Console.Write("Enter the height of the parallelogram: ");
                        double parallelogramHeight = GetPositiveNumber();
                        result = Parallelogram.CalculateArea(parallelogramBase, parallelogramHeight);
                        break;

                    case 5:
                        Console.Write("Enter the side length of the pentagon: ");
                        double pentagonSide = GetPositiveNumber();
                        result = Pentagon.CalculateArea(pentagonSide);
                        break;

                    case 6:
                        Console.Write("Enter the side length of the hexagon: ");
                        double hexagonSide = GetPositiveNumber();
                        result = Hexagon.CalculateArea(hexagonSide);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select again.");
                        continue;
                }

                Console.WriteLine($"The area is: {result}");
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


    public class Circle
    {
        public static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

    }

    public class Triangle
    {
        public static double CalculateArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }
    }

    public class Square
    {
        public static double CalculateArea(double side)
        {
            return side * side;
        }
    }

    public class Parallelogram
    {
        public static double CalculateArea(double baseLength, double height)
        {
            return baseLength * height;
        }
    }

    public class Pentagon
    {
        public static double CalculateArea(double side)
        {
            return 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * side * side;
        }

    }

    public class Hexagon
    {
        public static double CalculateArea(double side)
        {
            return 3 * Math.Sqrt(3) * side * side / 2;
        }
    }
}