using NUnit.Framework;
using System;
using GeometryCalcLibrary;
using System.Collections.Generic;
using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;
using System.IO;
using System.Linq;

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

        /*
         * Type 1: data hard coded in method
         */
        [Test]
        [Category("Area tests")]
        public void CircleAreaCalculation1()
        {
            double expectedArea = Math.PI * 5 * 5; // Assuming radius is 5
            double actualArea = Circle.CalculateArea(5);
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        [Category("Perimeter tests")]
        public void CirclePerimeterCalculation1()
        {
            double expectedPerimeter = 2 * Math.PI * 5; // Assuming radius is 5
            double actualPerimeter = Circle.CalculatePerimeter(5);
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }

        /*
         * Type 2: data in TestCase statements
         */
        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        [Category("Area tests")]
        public void CircleAreaCalculation2(double radius)
        {
            double expectedArea = Math.PI * radius * radius;
            double actualArea = Circle.CalculateArea(radius);
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        [Category("Perimeter tests")]
        public void CirclePerimeterCalculation2(double radius)
        {
            double expectedPerimeter = 2 * Math.PI * radius;
            double actualPerimeter = Circle.CalculatePerimeter(radius);
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }

        /*
         * Type 3: data in IEnumerable object
         */
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
        public void CircleAreaCalculation3(double radius)
        {
            double expectedArea = Math.PI * radius * radius;
            double actualArea = Circle.CalculateArea(radius);
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        [Category("Perimeter tests")]
        [TestCaseSource(nameof(GetCircleTestData))]
        public void CirclePerimeterCalculation3(double radius)
        {
            double expectedPerimeter = 2 * Math.PI * radius;
            double actualPerimeter = Circle.CalculatePerimeter(radius);
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }

        /*
         * Type 4: data in CSV file
         */
        public class CircleTestData
        {
            public double Radius { get; set; }
            public double ExpectedArea { get; set; }
            public double ExpectedPerimeter { get; set; }
        }

        private static IEnumerable<CircleTestData> GetCircleTestDataFromCSV()
        {
            string csvFilePath = "GeometryCalcTestsNUnit\\CircleTestDataNUnit.csv";
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                return csv.GetRecords<CircleTestData>().ToList();
            }
        }

        [Test]
        [Category("Area tests")]
        [TestCaseSource(nameof(GetCircleTestDataFromCSV))]
        public void CircleAreaCalculation4(CircleTestData testData)
        {
            double actual = Circle.CalculateArea(testData.Radius);
            double tolerance = 0.0001; // Adjust the tolerance value as needed
            Assert.That(actual, Is.EqualTo(testData.ExpectedArea).Within(tolerance));
        }

        [Test]
        [Category("Perimeter tests")]
        [TestCaseSource(nameof(GetCircleTestDataFromCSV))]
        public void CirclePerimeterCalculation4(CircleTestData testData)
        {
            double actual = Circle.CalculatePerimeter(testData.Radius);
            double tolerance = 0.0001; // Adjust the tolerance value as needed
            Assert.That(actual, Is.EqualTo(testData.ExpectedPerimeter).Within(tolerance));
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
        /*
         * Type 1: data hard coded in method
         */
        [Test]
        [Category("Area tests")]
        public void SquareAreaCalculation1()
        {
            double expectedArea = 5 * 5; // Assuming side is 5
            double actualArea = Square.CalculateArea(5);
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        [Category("Perimeter tests")]
        public void SquarePerimeterCalculation1()
        {
            double expectedPerimeter = 20; // Assuming side length is 5
            double actualPerimeter = Square.CalculatePerimeter(5);
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }

        /*
         * Type 2: data in TestCase statements
         */
        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        [Category("Area tests")]
        public void SquareAreaCalculation2(double side)
        {
            double expectedArea = side * side;
            double actualArea = Square.CalculateArea(side);
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        [Category("Perimeter tests")]
        public void SquarePerimeterCalculation2(double side)
        {
            double expectedPerimeter = 4 * side;
            double actualPerimeter = Square.CalculatePerimeter(side);
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }

        /*
         * Type 3: data in IEnumerable object
         */
        private static IEnumerable<object[]> GetSquareTestData()
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
        [TestCaseSource(nameof(GetSquareTestData))]
        public void SquareAreaCalculation3(double side)
        {
            double expectedArea = side * side;
            double actualArea = Square.CalculateArea(side);
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        [Category("Perimeter tests")]
        [TestCaseSource(nameof(GetSquareTestData))]
        public void SquarePerimeterCalculation3(double side)
        {
            double expectedPerimeter = 4 * side;
            double actualPerimeter = Square.CalculatePerimeter(side);
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }

        /*
         * Type 4: data in CSV file
         */
        public class SquareTestData
        {
            public double Side { get; set; }
            public double ExpectedArea { get; set; }
            public double ExpectedPerimeter { get; set; }
        }

        private static IEnumerable<SquareTestData> GetCircleTestDataFromCSV()
        {
            string csvFilePath = "GeometryCalcTestsNUnit\\SquareTestDataNUnit.csv";
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                return csv.GetRecords<SquareTestData>().ToList();
            }
        }

        [Test]
        [Category("Area tests")]
        [TestCaseSource(nameof(GetCircleTestDataFromCSV))]
        public void SquareAreaCalculation4(SquareTestData testData)
        {
            double actual = Square.CalculateArea(testData.Side);
            double tolerance = 0.0001; // Adjust the tolerance value as needed
            Assert.That(actual, Is.EqualTo(testData.ExpectedArea).Within(tolerance));
        }

        [Test]
        [Category("Perimeter tests")]
        [TestCaseSource(nameof(GetCircleTestDataFromCSV))]
        public void SquarePerimeterCalculation4(SquareTestData testData)
        {
            double actual = Square.CalculatePerimeter(testData.Side);
            double tolerance = 0.0001; // Adjust the tolerance value as needed
            Assert.That(actual, Is.EqualTo(testData.ExpectedPerimeter).Within(tolerance));
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