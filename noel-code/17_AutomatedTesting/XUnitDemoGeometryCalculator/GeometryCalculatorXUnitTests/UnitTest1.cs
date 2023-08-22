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

        [Fact]
        public void TestSquareArea()
        {
            //Arrange
            double side = 5;
            double expectedArea = side * side;

            //Act
            double actualArea = Square.CalculateArea(side);

            //Assert
            Assert.Equal(expectedArea, actualArea, 4);

        }

        [Fact]
        public void TestParallelogramArea()
        {
            //Arrange
            double baseLen = 6;
            double height = 7;
            double expectedArea = baseLen * height;

            //Act
            double actualArea = Parallelogram.CalculateArea(baseLen, height);

            //Assert
            Assert.Equal(expectedArea, actualArea, 4);

        }

        [Fact]
        public void TestPentagonArea()
        {
            //Arrange
            double side = 8;
            double expectedArea = 5 * 0.5 * side * side * Math.Sin(2 * Math.PI / 5);

            //Act
            double actualArea = Pentagon.CalculateArea(side);

            //Assert
            Assert.Equal(expectedArea, actualArea, 4);

        }

        [Fact]
        public void TestHexagonArea()
        {
            //Arrange
            double side = 9;
            double expectedArea = 6 * 0.5 * side * side * Math.Sin(2 * Math.PI / 6);

            //Act
            double actualArea = Hexagon.CalculateArea(side);

            //Assert
            Assert.Equal(expectedArea, actualArea, 4);

        }

        [Fact]
        public void TestCirclePerimeter()
        {
            // Arrange 
            double radius = 5; // Sample radius
            double expectedPerimeter = 2 * Math.PI * radius;

            // Act
            double actualPerimeter = Circle.CalculatePerimeter(radius);

            // Assert
            Assert.Equal(expectedPerimeter, actualPerimeter, 0.001);
        }

        [Fact]
        public void TestTrianglePerimeter()
        {
            //Arrange
            double baseLength = 4;
            double height = 3;
            double expectedPerimeter = 3 * baseLength;

            //Act
            double actualPerimeter = Triangle.CalculatePerimeter(baseLength);

            //Assert
            Assert.Equal(expectedPerimeter, actualPerimeter, 4);

        }

        [Fact]
        public void TestSquarePerimeter()
        {
            //Arrange
            double side = 5;
            double expectedPerimeter = 4 * side;

            //Act
            double actualPerimeter = Square.CalculatePerimeter(side);

            //Assert
            Assert.Equal(expectedPerimeter, actualPerimeter, 4);

        }

        [Fact]
        public void TestParallelogramPerimeter()
        {
            //Arrange
            double baseLen = 6;
            double sideLen = 7;
            double expectedPerimeter = 2 * (baseLen + sideLen);

            //Act
            double actualPerimeter = Parallelogram.CalculatePerimeter(baseLen, sideLen);

            //Assert
            Assert.Equal(expectedPerimeter, actualPerimeter, 4);

        }

        [Fact]
        public void TestPentagonPerimeter()
        {
            //Arrange
            double side = 8;
            double expectedPerimeter = 5 * side;

            //Act
            double actualPerimeter = Pentagon.CalculatePerimeter(side);

            //Assert
            Assert.Equal(expectedPerimeter, actualPerimeter, 4);

        }

        [Fact]
        public void TestHexagonPerimeter()
        {
            //Arrange
            double side = 9;
            double expectedPerimeter = 6 * side;

            //Act
            double actualPerimeter = Hexagon.CalculatePerimeter(side);

            //Assert
            Assert.Equal(expectedPerimeter, actualPerimeter, 4);

        }
    }
}
