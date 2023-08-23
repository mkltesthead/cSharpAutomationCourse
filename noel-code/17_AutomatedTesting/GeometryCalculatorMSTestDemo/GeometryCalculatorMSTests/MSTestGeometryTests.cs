// This line includes the namespace of the GeometryCalculator project where the shape classes are defined.
using GeometryCalculator;
// This line includes the necessary namespace for MSTest framework.
using Microsoft.VisualStudio.TestTools.UnitTesting;
// This is our standard system namespace to use most of what we are used to using
using System;

// This defines a new namespace specific to MSTest tests for the GeometryCalculator project.
namespace GeometryCalculatorMSTests
{
    // This defines a test class named GeometryAreaTests that contains various test methods.
    [TestClass]
    public class GeometryAreaMSTests
    {
        // This defines a test method named TestCircleArea to test the Circle class's CalculateArea method.
        [TestMethod]
        public void TestCircleAreaCalculation()
        {
            // Arrange 
            double radius = 5; // Sample radius
            double expectedArea = Math.PI * radius * radius; // Calculate the expected area using the formula.

            // Act
            double actualArea = Circle.CalculateArea(radius); // Calculate the actual area by calling the Circle class's CalculateArea method.

            // Assert

            // Use the Assert.AreEqual method to check if the expected and actual areas are equal within a certain tolerance.
            Assert.AreEqual(expectedArea, actualArea, 0.001); // Allow a small tolerance for floating-point precision
        }

        [TestMethod]
        public void TestTriangleAreaCalculation()
        {
            // Arrange
            double baseLength = 4;
            double height = 3;
            double expectedArea = 0.5 * baseLength * height;

            // Act
            double actualArea = Triangle.CalculateArea(baseLength, height);

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.0001);
        }

        [TestMethod]
        public void TestSquareAreaCalculation()
        {
            // Arrange
            double side = 5;
            double expectedArea = side * side;

            // Act
            double actualArea = Square.CalculateArea(side);

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.0001);
        }

        [TestMethod]
        public void TestParallelogramAreaCalculation()
        {
            // Arrange
            double baseLen = 6;
            double height = 7;
            double expectedArea = baseLen * height;

            // Act
            double actualArea = Parallelogram.CalculateArea(baseLen, height);

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.0001);
        }

        [TestMethod]
        public void TestPentagonAreaCalculation()
        {
            // Arrange
            double side = 8;
            double expectedArea = 5 * 0.5 * side * 0.5 * side / Math.Tan(Math.PI / 5);

            // Act
            double actualArea = Pentagon.CalculateArea(side);

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.0001);
        }

        [TestMethod]
        public void TestHexagonAreaCalculation()
        {
            // Arrange
            double side = 9;
            double expectedArea = 6 * 0.5 * side * side * Math.Sin(2 * Math.PI / 6);

            // Act
            double actualArea = Hexagon.CalculateArea(side);

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.0001);
        }

        [TestMethod]
        public void TestCirclePerimeterCalculation()
        {
            // Arrange 
            double radius = 5; // Sample radius
            double expectedPerimeter = 2 * Math.PI * radius;

            // Act
            double actualPerimeter = Circle.CalculatePerimeter(radius);

            // Assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.001);
        }

        [TestMethod]
        public void TestTrianglePerimeterCalculation()
        {
            // Arrange
            double baseLength = 4;
            double expectedPerimeter = 3 * baseLength;

            // Act
            double actualPerimeter = Triangle.CalculatePerimeter(baseLength);

            // Assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.0001);
        }

        [TestMethod]
        public void TestSquarePerimeterCalculation()
        {
            // Arrange
            double side = 5;
            double expectedPerimeter = 4 * side;

            // Act
            double actualPerimeter = Square.CalculatePerimeter(side);

            // Assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.0001);
        }

        [TestMethod]
        public void TestParallelogramPerimeterCalculation()
        {
            // Arrange
            double baseLen = 6;
            double sideLen = 7;
            double expectedPerimeter = 2 * (baseLen + sideLen);

            // Act
            double actualPerimeter = Parallelogram.CalculatePerimeter(baseLen, sideLen);

            // Assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.0001);
        }

        [TestMethod]
        public void TestPentagonPerimeterCalculation()
        {
            // Arrange
            double side = 8;
            double expectedPerimeter = 5 * side;

            // Act
            double actualPerimeter = Pentagon.CalculatePerimeter(side);

            // Assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.0001);
        }

        [TestMethod]
        public void TestHexagonPerimeterCalculation()
        {
            // Arrange
            double side = 9;
            double expectedPerimeter = 6 * side;

            // Act
            double actualPerimeter = Hexagon.CalculatePerimeter(side);

            // Assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.0001);
        }
    }
}