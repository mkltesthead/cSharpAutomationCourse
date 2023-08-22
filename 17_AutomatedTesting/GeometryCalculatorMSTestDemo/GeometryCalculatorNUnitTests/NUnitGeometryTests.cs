using GeometryCalculator; // The namespace of your original code

namespace GeometryCalculatorNUnitTests
{
    public class GeometryAreaNUnitTests
    {
        [Test]
        public void TestCircleArea()
        {
            //Arrange
            double radius = 5;
            double expectedArea = Math.PI * radius * radius;

            //Act
            double actualArea = Circle.CalculateArea(radius);

            //Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001));
        }

        [Test]
        public void TestTriangleAreaCalculation()
        {
            //Arrange
            double baseLength = 4;
            double height = 3;
            double expectedArea = 0.5 * baseLength * height;

            //Act
            double actualArea = Triangle.CalculateArea(baseLength, height);

            //Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001));

        }
    }
}
