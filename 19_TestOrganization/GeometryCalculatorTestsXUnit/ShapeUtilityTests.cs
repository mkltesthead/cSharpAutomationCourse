using GeometryCalculatorLibrary;

namespace GeometryCalculatorTestsXUnit
{
    public class ShapeUtilitiesTests
    {
        [Fact]
        public void TestIsEven()
        {
            Assert.True(ShapeUtilities.IsEven(4));
            Assert.False(ShapeUtilities.IsEven(7));
        }

        [Fact]
        public void TestBasicMathOperation()
        {
            int result = ShapeUtilities.AddNumbers(3, 4);
            Assert.Equal(7, result);
        }

        [Fact]
        public void TestNumericRange()
        {
            double area = ShapeUtilities.CalculateArea(3); // Assuming a shape with side length 3
            Assert.True(area > 5 && area < 15);
        }

        [Fact]
        public void TestFloatingPointEqualityWithTolerance()
        {
            double expected = 0.1 + 0.2;
            double actual = ShapeUtilities.CalculateResultWithFloats();
            Assert.Equal(expected, actual, 5); // Using an acceptable tolerance
        }

        [Fact]
        public void TestStringAssertions()
        {
            string shapeDescription = ShapeUtilities.GetShapeDescription("Circle", 5);
            Assert.Contains("Circle with dimension 5", shapeDescription);
        }

        [Fact]
        public void TestExceptionAssertions()
        {
            Assert.Throws<ArgumentException>(() => ShapeUtilities.ThrowExceptionOnInvalidInput(-1));
        }
    }
}
