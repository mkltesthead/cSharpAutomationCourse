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
}
