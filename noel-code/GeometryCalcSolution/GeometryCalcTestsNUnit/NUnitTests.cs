using NUnit.Framework;
using System;
using GeometryCalcLibrary;
using System.Collections.Generic;

namespace GeometryCalcTestsNUnit
{
    [TestFixture]
    [Category("Circle tests")]
    public class CircleTests
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Console.WriteLine("Run before circle test series.");
        }

        [SetUp]
        public void RunMeFirst()
        {
            Console.WriteLine("Run before each circle test.");
        }
        private static IEnumerable<object[]> GetCircleTestData()
        {
            yield return new object[] { 0 };
            yield return new object[] { 1 };
            yield return new object[] { 2 };
            yield return new object[] { 3 };
            yield return new object[] { 4 };
            yield return new object[] { 5 };
            yield return new object[] { 6 };
            yield return new object[] { 7 };
            yield return new object[] { 8 };
            yield return new object[] { 9 };
        }

        [Test]
        [Category("Area tests")]
        [TestCaseSource(nameof(GetCircleTestData))]
        public void CircleAreaCalculation(double radius)
        {
            double expectedArea = Math.PI * radius * radius; // Assuming radius is 5
            double actualArea = Circle.CalculateArea(radius);
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        [Category("Perimeter tests")]
        [TestCaseSource(nameof(GetCircleTestData))]
        public void CirclePerimeterCalculation(double radius)
        {
            double expectedPerimeter = 2 * Math.PI * radius; // Assuming radius is 5
            double actualPerimeter = Circle.CalculatePerimeter(radius);
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }

        [TearDown]
        public void RunMeLast()
        {
            Console.WriteLine("Run after each circle test.");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Console.WriteLine("Run after circle test series.");
        }
    }

    [TestFixture]
    [Category("Triangle tests")]
    public class TriangleTests
    {
        [Test]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 4)]
        [TestCase(4, 5)]
        [TestCase(5, 6)]
        [TestCase(6, 7)]
        [TestCase(7, 8)]
        [TestCase(8, 9)]
        [TestCase(9, 0)]
        [Category("Area tests")]
        public void TriangleAreaCalculation(double mybase, double myheight)
        {
            double expectedArea = 0.5 * mybase * myheight; // Assuming base length = 5 and height = 4
            double actualArea = Triangle.CalculateArea(mybase, myheight);
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        [TestCase(0, 1, 2)]
        [TestCase(1, 2, 3)]
        [TestCase(2, 3, 4)]
        [TestCase(3, 4, 5)]
        [TestCase(4, 5, 6)]
        [TestCase(5, 6, 7)]
        [TestCase(6, 7, 8)]
        [TestCase(7, 8, 9)]
        [TestCase(8, 9, 0)]
        [TestCase(9, 0, 1)]
        [Category("Perimeter tests")]
        public void TrianglePerimeterCalculation(double a, double b, double c)
        {
            double expectedPerimeter = a + b + c; // Assuming side lengths are 4, 5, and 3
            double actualPerimeter = Triangle.CalculatePerimeter(a, b, c);
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }

        [Test]
        [Category("Right angled tests")]
        public void TriangleRightAngled()
        {
            Assert.IsTrue(Triangle.IsRightAngled(3, 4, 5));
            Assert.IsTrue(Triangle.IsRightAngled(3, 5, 4));
            Assert.IsTrue(Triangle.IsRightAngled(4, 3, 5));
            Assert.IsTrue(Triangle.IsRightAngled(4, 5, 3));
            Assert.IsTrue(Triangle.IsRightAngled(5, 3, 4));
            Assert.IsTrue(Triangle.IsRightAngled(5, 4, 3));

            Assert.IsTrue(Triangle.IsRightAngled(-3, -4, -5));
            Assert.IsTrue(Triangle.IsRightAngled(-3, -5, -4));
            Assert.IsTrue(Triangle.IsRightAngled(-4, -3, -5));
            Assert.IsTrue(Triangle.IsRightAngled(-4, -5, -3));
            Assert.IsTrue(Triangle.IsRightAngled(-5, -3, -4));
            Assert.IsTrue(Triangle.IsRightAngled(-5, -4, -3));
        }

        [Test]
        [Category("Right angled tests")]
        public void TriangleNotRightAngled()
        {
            Assert.IsFalse(Triangle.IsRightAngled(2, 4, 5));
            Assert.IsFalse(Triangle.IsRightAngled(2, 5, 4));
            Assert.IsFalse(Triangle.IsRightAngled(4, 2, 5));
            Assert.IsFalse(Triangle.IsRightAngled(4, 5, 2));
            Assert.IsFalse(Triangle.IsRightAngled(5, 2, 4));
            Assert.IsFalse(Triangle.IsRightAngled(5, 4, 2));

            Assert.IsFalse(Triangle.IsRightAngled(-2, -4, -5));
            Assert.IsFalse(Triangle.IsRightAngled(-2, -5, -4));
            Assert.IsFalse(Triangle.IsRightAngled(-4, -2, -5));
            Assert.IsFalse(Triangle.IsRightAngled(-4, -5, -2));
            Assert.IsFalse(Triangle.IsRightAngled(-5, -2, -4));
            Assert.IsFalse(Triangle.IsRightAngled(-5, -4, -2));
        }
    }

    [TestFixture]
    [Category("Square tests")]
    public class SquareTests
    {
        [Test]
        [Category("Area tests")]
        public void SquareAreaCalculation()
        {
            double expectedArea = 25; // Assuming side length is 5
            double actualArea = Square.CalculateArea(5);
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        [Category("Perimeter tests")]
        public void SquarePerimeterCalculation()
        {
            double expectedPerimeter = 20; // Assuming side length is 5
            double actualPerimeter = Square.CalculatePerimeter(5);
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }
    }

    [TestFixture]
    [Category("Parallelogram tests")]
    public class ParallelogramTests
    {
        [Test]
        [Category("Area tests")]
        public void ParallelogramAreaCalculation()
        {
            double expectedArea = 10 * 7; // Assuming base length is 10 and height is 7
            double actualArea = Parallelogram.CalculateArea(10, 7);
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        [Category("Perimeter tests")]
        public void ParallelogramPerimeterCalculation()
        {
            double expectedPerimeter = 2 * (10 + 7); // Assuming base length is 10 and height is 7
            double actualPerimeter = Parallelogram.CalculatePerimeter(10, 7);
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }
    }

    [TestFixture]
    [Category("Pentagon tests")]
    public class PentagonTests
    {
        [Test]
        [Category("Area tests")]
        public void PentagonAreaCalculation()
        {
            double expectedArea = 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * 7 * 7; // Assuming side length is 7
            double actualArea = Pentagon.CalculateArea(7);
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001)); // Adding a delta to account for potential floating-point errors
        }

        [Test]
        [Category("Perimeter tests")]
        public void PentagonPerimeterCalculation()
        {
            double expectedPerimeter = 5 * 7; // Assuming side length is 7
            double actualPerimeter = Pentagon.CalculatePerimeter(7);
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter).Within(0.0001)); // Adding a delta to account for potential floating-point errors
        }
    }

    [TestFixture]
    [Category("Hexagon tests")]
    public class HexagonTests
    {
        [Test]
        [Category("Area tests")]
        public void HexagonAreaCalculation()
        {
            double expectedArea = 3 * Math.Sqrt(3) * 5 * 5 / 2; // Assuming side length is 5
            double actualArea = Hexagon.CalculateArea(5);
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001)); // Adding delta for floating-point precision
        }

        [Test]
        [Category("Perimeter tests")]
        public void HexagonPerimeterCalculation()
        {
            double expectedPerimeter = 6 * 5; // Assuming side length is 5
            double actualPerimeter = Hexagon.CalculatePerimeter(5);
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }
    }
}