using GeometryCalculator;
using NUnit.Framework;

namespace GeometryCalculatorNUnitTests
{
    public class GeometryAreaNUnitTests
    {
        [Test]
        public void TestCircleArea()
        {
            double radius = 5;
            double expectedArea = Math.PI * radius * radius;
            double actualArea = Circle.CalculateArea(radius);
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

        [Test]
        public void TestSquareAreaCalculation()
        {
            //Arrange
            double side = 5;
            double expectedArea = side * side;

            //Act
            double actualArea = Square.CalculateArea(side);

            //Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001));

        }

        [Test]
        public void TestParallelogramAreaCalculation()
        {
            //Arrange
            double baseLen = 6;
            double height = 7;
            double expectedArea = baseLen * height;

            //Act
            double actualArea = Parallelogram.CalculateArea(baseLen, height);

            //Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001));

        }

        [Test]
        public void TestPentagonAreaCalculation()
        {
            //Arrange
            double side = 8;
            double expectedArea = 5 * 0.5 * side * side * Math.Sin(2 * Math.PI / 5);

            //Act
            double actualArea = Pentagon.CalculateArea(side);

            //Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001));

        }

        [Test]
        public void TestHexagonAreaCalculation()
        {
            //Arrange
            double side = 9;
            double expectedArea = 6 * 0.5 * side * side * Math.Sin(2 * Math.PI / 6);

            //Act
            double actualArea = Hexagon.CalculateArea(side);

            //Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001));

        }

        [Test]
        public void TestCirclePerimeterCalculation()
        {
            // Arrange 
            double radius = 5; // Sample radius
            double expectedPerimeter = 2 * Math.PI * radius;

            // Act
            double actualPerimeter = Circle.CalculatePerimeter(radius);

            // Assert
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter).Within(0.0001));
        }

        [Test]
        public void TestTrianglePerimeterCalculation()
        {
            //Arrange
            double baseLength = 4;
            double height = 3;
            double expectedPerimeter = 3 * baseLength;

            //Act
            double actualPerimeter = Triangle.CalculatePerimeter(baseLength);

            //Assert
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter).Within(0.0001));

        }

        [Test]
        public void TestSquarePerimeterCalculation()
        {
            //Arrange
            double side = 5;
            double expectedPerimeter = 4 * side;

            //Act
            double actualPerimeter = Square.CalculatePerimeter(side);

            //Assert
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter).Within(0.0001));

        }

        [Test]
        public void TestParallelogramPerimeterCalculation()
        {
            //Arrange
            double baseLen = 6;
            double sideLen = 7;
            double expectedPerimeter = 2 * (baseLen + sideLen);

            //Act
            double actualPerimeter = Parallelogram.CalculatePerimeter(baseLen, sideLen);

            //Assert
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter).Within(0.0001));

        }

        [Test]
        public void TestPentagonPerimeterCalculation()
        {
            //Arrange
            double side = 8;
            double expectedPerimeter = 5 * side;

            //Act
            double actualPerimeter = Pentagon.CalculatePerimeter(side);

            //Assert
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter).Within(0.0001));

        }

        [Test]
        public void TestHexagonPerimeterCalculation()
        {
            //Arrange
            double side = 9;
            double expectedPerimeter = 6 * side;

            //Act
            double actualPerimeter = Hexagon.CalculatePerimeter(side);

            //Assert
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter).Within(0.0001));

        }
    }
}