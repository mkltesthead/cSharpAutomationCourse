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
            //Arrange
            double baseLength = 4;
            double height = 3;
            double expectedArea = 0.5 * baseLength * height;

            //Act
            double actualArea = Triangle.CalculateArea(baseLength, height);

            //Assert
            Assert.AreEqual(expectedArea, actualArea, 0.0001);

        }


        // Add more test methods for other shapes
        // ...
    }
}