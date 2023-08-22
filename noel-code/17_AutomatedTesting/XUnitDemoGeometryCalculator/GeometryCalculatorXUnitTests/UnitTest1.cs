using GeometryCalculator;

namespace GeometryCalculatorXUnitTests
{
    public class GeometryCalculatorTests
    {
        [Fact]
        public void TestCircleArea()
        {
            double radius = 5;
            double expectedArea = Math.PI * radius * radius;
            double actualArea = Circle.CalculateArea(radius);
            Assert.Equal(expectedArea, actualArea, 4);
        }

        [Fact]
        public void TestTriangleArea()
        {
            double baseLength = 4;
            double height = 3;
            double expectedArea = 0.5 * baseLength * height;
            double actualArea = Triangle.CalculateArea(baseLength, height);
            Assert.Equal(expectedArea, actualArea, 4);
        }
    }
}
