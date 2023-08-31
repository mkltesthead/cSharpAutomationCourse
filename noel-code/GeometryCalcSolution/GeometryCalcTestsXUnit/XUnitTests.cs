using GeometryCalcLibrary;

namespace GeometryCalcTestsXUnit
{
    [Trait("Category", "Circle tests")]
    public class CircleTests
    {
        [Fact]
        [Trait("Category", "Area tests")]
        public void CircleAreaCalculation()
        {
            double expectedArea = Math.PI * 5 * 5; // Assuming radius is 5
            double actualArea = Circle.CalculateArea(5);
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        [Trait("Category", "Perimeter tests")]
        public void CirclePerimeterCalculation()
        {
            double expectedPerimeter = 2 * Math.PI * 5; // Assuming radius is 5
            double actualPerimeter = Circle.CalculatePerimeter(5);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }
    }

    [Trait("Category", "Triangle tests")]
    public class TriangleTests
    {
        [Fact]
        [Trait("Category", "Area tests")]
        public void TriangleAreaCalculation()
        {
            double expectedArea = 10.0; // Assuming base length = 5 and height = 4
            double actualArea = Triangle.CalculateArea(5, 4);
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        [Trait("Category", "Perimeter tests")]
        public void TrianglePerimeterCalculation()
        {
            double expectedPerimeter = 12.0; // Assuming side lengths are 4, 5, and 3
            double actualPerimeter = Triangle.CalculatePerimeter(4, 5, 3);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }

        [Fact]
        [Trait("Category", "Right angled tests")]
        public void TriangleRightAngled()
        {
            Assert.True(Triangle.IsRightAngled(3, 4, 5));
            Assert.True(Triangle.IsRightAngled(3, 5, 4));
            Assert.True(Triangle.IsRightAngled(4, 3, 5));
            Assert.True(Triangle.IsRightAngled(4, 5, 3));
            Assert.True(Triangle.IsRightAngled(5, 3, 4));
            Assert.True(Triangle.IsRightAngled(5, 4, 3));

            Assert.True(Triangle.IsRightAngled(-3, -4, -5));
            Assert.True(Triangle.IsRightAngled(-3, -5, -4));
            Assert.True(Triangle.IsRightAngled(-4, -3, -5));
            Assert.True(Triangle.IsRightAngled(-4, -5, -3));
            Assert.True(Triangle.IsRightAngled(-5, -3, -4));
            Assert.True(Triangle.IsRightAngled(-5, -4, -3));
        }

        [Fact]
        [Trait("Category", "Right angled tests")]
        public void TriangleNotRightAngled()
        {
            Assert.False(Triangle.IsRightAngled(2, 4, 5));
            Assert.False(Triangle.IsRightAngled(2, 5, 4));
            Assert.False(Triangle.IsRightAngled(4, 2, 5));
            Assert.False(Triangle.IsRightAngled(4, 5, 2));
            Assert.False(Triangle.IsRightAngled(5, 2, 4));
            Assert.False(Triangle.IsRightAngled(5, 4, 2));

            Assert.False(Triangle.IsRightAngled(-2, -4, -5));
            Assert.False(Triangle.IsRightAngled(-2, -5, -4));
            Assert.False(Triangle.IsRightAngled(-4, -2, -5));
            Assert.False(Triangle.IsRightAngled(-4, -5, -2));
            Assert.False(Triangle.IsRightAngled(-5, -2, -4));
            Assert.False(Triangle.IsRightAngled(-5, -4, -2));
        }
    }

    [Trait("Category", "Square tests")]
    public class SquareTests
    {
        [Fact]
        [Trait("Category", "Area tests")]
        public void SquareAreaCalculation()
        {
            double expectedArea = 25; // Assuming side length is 5
            double actualArea = Square.CalculateArea(5);
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        [Trait("Category", "Perimeter tests")]
        public void SquarePerimeterCalculation()
        {
            double expectedPerimeter = 20; // Assuming side length is 5
            double actualPerimeter = Square.CalculatePerimeter(5);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }
    }

    [Trait("Category", "Parallelogram tests")]
    public class ParallelogramTests
    {
        [Fact]
        [Trait("Category", "Area tests")]
        public void ParallelogramAreaCalculation()
        {
            double expectedArea = 10 * 7; // Assuming base length is 10 and height is 7
            double actualArea = Parallelogram.CalculateArea(10, 7);
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        [Trait("Category", "Perimeter tests")]
        public void ParallelogramPerimeterCalculation()
        {
            double expectedPerimeter = 2 * (10 + 7); // Assuming base length is 10 and height is 7
            double actualPerimeter = Parallelogram.CalculatePerimeter(10, 7);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }
    }

    [Trait("Category", "Pentagon tests")]
    public class PentagonTests
    {
        [Fact]
        [Trait("Category", "Area tests")]
        public void PentagonAreaCalculation()
        {
            double expectedArea = 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * 7 * 7; // Assuming side length is 7
            double actualArea = Pentagon.CalculateArea(7);
            Assert.Equal(expectedArea, actualArea, 4); // Adding a tolerance to account for potential floating-point errors
        }

        [Fact]
        [Trait("Category", "Perimeter tests")]
        public void PentagonPerimeterCalculation()
        {
            double expectedPerimeter = 5 * 7; // Assuming side length is 7
            double actualPerimeter = Pentagon.CalculatePerimeter(7);
            Assert.Equal(expectedPerimeter, actualPerimeter, 4); // Adding a tolerance to account for potential floating-point errors
        }
    }

    [Trait("Category", "Hexagon tests")]
    public class HexagonTests
    {
        [Fact]
        [Trait("Category", "Area tests")]
        public void HexagonAreaCalculation()
        {
            double expectedArea = 3 * Math.Sqrt(3) * 5 * 5 / 2; // Assuming side length is 5
            double actualArea = Hexagon.CalculateArea(5);
            Assert.Equal(expectedArea, actualArea, 4); // Adding a tolerance to account for potential floating-point errors
        }

        [Fact]
        [Trait("Category", "Perimeter tests")]
        public void HexagonPerimeterCalculation()
        {
            double expectedPerimeter = 6 * 5; // Assuming side length is 5
            double actualPerimeter = Hexagon.CalculatePerimeter(5);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }
    }
}