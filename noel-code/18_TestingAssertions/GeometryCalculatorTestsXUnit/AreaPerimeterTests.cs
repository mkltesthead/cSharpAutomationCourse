using GeometryCalculatorLibrary;

namespace GeometryCalculatorTestsXUnit
{
    public class CircleTests
    {
        [Fact]
        public void CircleAreaCalculation()
        {
            double expectedArea = Math.PI * 5 * 5; // Assuming radius is 5
            double actualArea = Circle.CalculateArea(5);
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void CirclePerimeterCalculation()
        {
            double expectedPerimeter = 2 * Math.PI * 5; // Assuming radius is 5
            double actualPerimeter = Circle.CalculatePerimeter(5);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }
    }

    public class TriangleTests
    {
        [Fact]
        public void TriangleAreaCalculation()
        {
            double expectedArea = 10.0; // Assuming base length = 5 and height = 4
            double actualArea = Triangle.CalculateArea(5, 4);
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void TrianglePerimeterCalculation()
        {
            double expectedPerimeter = 12.0; // Assuming side lengths are 4, 5, and 3
            double actualPerimeter = Triangle.CalculatePerimeter(4, 5, 3);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }
    }

    public class SquareTests
    {
        [Fact]
        public void SquareAreaCalculation()
        {
            double expectedArea = 25; // Assuming side length is 5
            double actualArea = Square.CalculateArea(5);
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void SquarePerimeterCalculation()
        {
            double expectedPerimeter = 20; // Assuming side length is 5
            double actualPerimeter = Square.CalculatePerimeter(5);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }
    }

    public class ParallelogramTests
    {
        [Fact]
        public void ParallelogramAreaCalculation()
        {
            double expectedArea = 10 * 7; // Assuming base length is 10 and height is 7
            double actualArea = Parallelogram.CalculateArea(10, 7);
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void ParallelogramPerimeterCalculation()
        {
            double expectedPerimeter = 2 * (10 + 7); // Assuming base length is 10 and height is 7
            double actualPerimeter = Parallelogram.CalculatePerimeter(10, 7);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }
    }

    public class PentagonTests
    {
        [Fact]
        public void PentagonAreaCalculation()
        {
            double expectedArea = 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * 7 * 7; // Assuming side length is 7
            double actualArea = Pentagon.CalculateArea(7);
            Assert.Equal(expectedArea, actualArea, 4); // Adding a tolerance to account for potential floating-point errors
        }

        [Fact]
        public void PentagonPerimeterCalculation()
        {
            double expectedPerimeter = 5 * 7; // Assuming side length is 7
            double actualPerimeter = Pentagon.CalculatePerimeter(7);
            Assert.Equal(expectedPerimeter, actualPerimeter, 4); // Adding a tolerance to account for potential floating-point errors
        }
    }

    public class HexagonTests
    {
        [Fact]
        public void HexagonAreaCalculation()
        {
            double expectedArea = 3 * Math.Sqrt(3) * 5 * 5 / 2; // Assuming side length is 5
            double actualArea = Hexagon.CalculateArea(5);
            Assert.Equal(expectedArea, actualArea, 4); // Adding a tolerance to account for potential floating-point errors
        }

        [Fact]
        public void HexagonPerimeterCalculation()
        {
            double expectedPerimeter = 6 * 5; // Assuming side length is 5
            double actualPerimeter = Hexagon.CalculatePerimeter(5);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }
    }
}
