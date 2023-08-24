using GeometryCalculatorLibrary;

namespace GeometryCalculatorTestsMSTest
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CircleAreaCalculation()
        {
            double expectedArea = Math.PI * 5 * 5; // Assuming radius is 5
            double actualArea = Circle.CalculateArea(5);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CirclePerimeterCalculation()
        {
            double expectedPerimeter = 2 * Math.PI * 5; // Assuming radius is 5
            double actualPerimeter = Circle.CalculatePerimeter(5);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }
    }

    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TriangleAreaCalculation()
        {
            double expectedArea = 10.0; // Assuming base length = 5 and height = 4
            double actualArea = Triangle.CalculateArea(5, 4);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void TrianglePerimeterCalculation()
        {
            double expectedPerimeter = 12.0; // Assuming side lengths are 4, 5, and 3
            double actualPerimeter = Triangle.CalculatePerimeter(4, 5, 3);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }
    }

    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void SquareAreaCalculation()
        {
            double expectedArea = 25; // Assuming side length is 5
            double actualArea = Square.CalculateArea(5);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void SquarePerimeterCalculation()
        {
            double expectedPerimeter = 20; // Assuming side length is 5
            double actualPerimeter = Square.CalculatePerimeter(5);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }
    }

    [TestClass]
    public class ParallelogramTests
    {
        [TestMethod]
        public void ParallelogramAreaCalculation()
        {
            double expectedArea = 10 * 7; // Assuming base length is 10 and height is 7
            double actualArea = Parallelogram.CalculateArea(10, 7);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void ParallelogramPerimeterCalculation()
        {
            double expectedPerimeter = 2 * (10 + 7); // Assuming base length is 10 and height is 7
            double actualPerimeter = Parallelogram.CalculatePerimeter(10, 7);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }
    }
    [TestClass]
    public class PentagonTests
    {
        [TestMethod]
        public void PentagonAreaCalculation()
        {
            double expectedArea = 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * 7 * 7; // Assuming side length is 7
            double actualArea = Pentagon.CalculateArea(7);
            Assert.AreEqual(expectedArea, actualArea, 0.0001); // Adding a delta to account for potential floating-point errors
        }

        [TestMethod]
        public void PentagonPerimeterCalculation()
        {
            double expectedPerimeter = 5 * 7; // Assuming side length is 7
            double actualPerimeter = Pentagon.CalculatePerimeter(7);
            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.0001); // Adding a delta to account for potential floating-point errors
        }
    }
    [TestClass]
    public class HexagonTests
    {
        [TestMethod]
        public void HexagonAreaCalculation()
        {
            double expectedArea = 3 * Math.Sqrt(3) * 5 * 5 / 2; // Assuming side length is 5
            double actualArea = Hexagon.CalculateArea(5);
            Assert.AreEqual(expectedArea, actualArea, 0.0001); // Adding delta for floating-point precision
        }

        [TestMethod]
        public void HexagonPerimeterCalculation()
        {
            double expectedPerimeter = 6 * 5; // Assuming side length is 5
            double actualPerimeter = Hexagon.CalculatePerimeter(5);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }
    }
}