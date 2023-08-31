namespace GeometryCalculatorLibrary
{
    public class Circle
    {
        public static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double CalculatePerimeter(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }

    public class Triangle
    {
        public static double CalculateArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        public static double CalculatePerimeter(double side1, double side2, double side3)
        {
            return side1 + side2 + side3;
        }
    }
    public class Square
    {
        public static double CalculateArea(double side)
        {
            return side * side;
        }

        public static double CalculatePerimeter(double side)
        {
            return 4 * side;
        }
    }

    public class Parallelogram
    {
        public static double CalculateArea(double baseLength, double height)
        {
            return baseLength * height;
        }

        public static double CalculatePerimeter(double side1, double side2)
        {
            return 2 * (side1 + side2);
        }
    }
    public class Pentagon
    {
        public static double CalculateArea(double side)
        {
            return 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * side * side;
        }

        public static double CalculatePerimeter(double side)
        {
            return 5 * side;
        }
    }

    public class Hexagon
    {
        public static double CalculateArea(double side)
        {
            return 3 * Math.Sqrt(3) * side * side / 2;
        }

        public static double CalculatePerimeter(double side)
        {
            return 6 * side;
        }
    }
}