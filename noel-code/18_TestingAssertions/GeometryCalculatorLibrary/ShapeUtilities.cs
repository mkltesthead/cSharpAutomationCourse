namespace GeometryCalculatorLibrary
{
    public class ShapeUtilities
    {
        public static double CalculateArea(double side)
        {
            // Assuming this calculates the area of a shape with a given side length
            return side * side;
        }

        public static int AddNumbers(int a, int b)
        {
            // Assuming this adds two numbers
            return a + b;
        }

        public static double CalculateResultWithFloats()
        {
            // Assuming this performs a calculation involving floating-point numbers
            return 0.1 + 0.2;
        }

        public static string GetShapeDescription(string shapeName, double dimension)
        {
            // Assuming this generates a description of a shape
            return $"{shapeName} with dimension {dimension}";
        }

        public static void ThrowExceptionOnInvalidInput(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Value must be non-negative");
            }
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}