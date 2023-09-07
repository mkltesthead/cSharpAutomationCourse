namespace GeometryCalculator
{
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