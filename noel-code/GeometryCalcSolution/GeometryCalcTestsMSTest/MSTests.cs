﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GeometryCalcLibrary;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using System.Linq;

namespace GeometryCalcTestsMSTest
{
    [TestClass]
    [TestCategory("Circle tests")]
    public class CircleTests
    {
        [ClassInitialize]
        public static void CircleTestsInit(TestContext context)
        {
            Console.WriteLine("Run before circle test series.");
        }

        [TestInitialize]
        public void RunMeFirst()
        {
            Console.WriteLine("Run before each circle test.");
        }

        /*
         * Type 1: data hard coded in method
         */
        [TestMethod]
        [TestCategory("Area tests")]
        public void CircleAreaCalculation1()
        {
            double expectedArea = Math.PI * 5 * 5;
            double actualArea = Circle.CalculateArea(5);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        [TestCategory("Perimeter tests")]
        public void CirclePerimeterCalculation1()
        {
            double expectedPerimeter = 2 * Math.PI * 5;
            double actualPerimeter = Circle.CalculatePerimeter(5);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        /*
         * Type 2: data in DataRow statements
         */
        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(5)]
        [DataRow(6)]
        [DataRow(7)]
        [DataRow(8)]
        [DataRow(9)]
        [TestCategory("Area tests")]
        public void CircleAreaCalculation2(double radius)
        {
            double expectedArea = Math.PI * radius * radius;
            double actualArea = Circle.CalculateArea(radius);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(5)]
        [DataRow(6)]
        [DataRow(7)]
        [DataRow(8)]
        [DataRow(9)]
        [TestCategory("Perimeter tests")]
        public void CirclePerimeterCalculation2(double radius)
        {
            double expectedPerimeter = 2 * Math.PI * radius;
            double actualPerimeter = Circle.CalculatePerimeter(radius);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
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

        [DataTestMethod]
        [TestCategory("Area tests")]
        [DynamicData(nameof(GetCircleTestData), DynamicDataSourceType.Method)]
        public void CircleAreaCalculation3(double radius)
        {
            double expectedArea = Math.PI * radius * radius;
            double actualArea = Circle.CalculateArea(radius);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [DataTestMethod]
        [TestCategory("Perimeter tests")]
        [DynamicData(nameof(GetCircleTestData), DynamicDataSourceType.Method)]
        public void CirclePerimeterCalculation3(double radius)
        {
            double expectedPerimeter = 2 * Math.PI * radius;
            double actualPerimeter = Circle.CalculatePerimeter(radius);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
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

        private static IEnumerable<object[]> GetCircleTestDataFromCSV()
        {
            string csvFilePath = "CircleTestDataMSTest.csv";
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                foreach (var record in csv.GetRecords<CircleTestData>().ToList())
                {
                    yield return new object[] { record.Radius, record.ExpectedArea, record.ExpectedPerimeter };
                }
            }
        }

        [DataTestMethod]
        [TestCategory("Area tests")]
        [DynamicData(nameof(GetCircleTestDataFromCSV), typeof(CircleTests), DynamicDataSourceType.Method)]
        public void CircleAreaCalculation4(double radius, double expectedArea, double expectedPerimeter)
        {
            double actual = Circle.CalculateArea(radius);
            double tolerance = 0.0001; // Adjust the tolerance value as needed
            Assert.AreEqual(expectedArea, actual, tolerance);
        }

        [DataTestMethod]
        [TestCategory("Perimeter tests")]
        [DynamicData(nameof(GetCircleTestDataFromCSV), typeof(CircleTests), DynamicDataSourceType.Method)]
        public void CirclePerimeterCalculation4(double radius, double expectedArea, double expectedPerimeter)
        {
            double actual = Circle.CalculatePerimeter(radius);
            double tolerance = 0.0001; // Adjust the tolerance value as needed
            Assert.AreEqual(expectedPerimeter, actual, tolerance);
        }

        [TestCleanup]
        public void RunMeLast()
        {
            Console.WriteLine("Run after each circle test.");
        }

        [ClassCleanup]
        public static void CircleCleanup()
        {
            Console.WriteLine("Run after circle test series.");
        }
    }

    [TestClass]
    [TestCategory("Triangle tests")]
    public class TriangleTests
    {
        [TestMethod]
        [TestCategory("Area tests")]
        public void TriangleAreaCalculation()
        {
            double expectedArea = 10.0; // Assuming base length = 5 and height = 4
            double actualArea = Triangle.CalculateArea(5, 4);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        [TestCategory("Perimeter tests")]
        public void TrianglePerimeterCalculation()
        {
            double expectedPerimeter = 12.0; // Assuming side lengths are 4, 5, and 3
            double actualPerimeter = Triangle.CalculatePerimeter(4, 5, 3);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [TestMethod]
        [TestCategory("Right angled tests")]
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

        [TestMethod]
        [TestCategory("Right angled tests")]
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

    [TestClass]
    [TestCategory("Square tests")]
    public class SquareTests
    {
        /*
         * Type 1: data hard coded in method
         */
        [TestMethod]
        [TestCategory("Area tests")]
        public void SquareAreaCalculation1()
        {
            double expectedArea = 5 * 5;
            double actualArea = Square.CalculateArea(5);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        [TestCategory("Perimeter tests")]
        public void SquarePerimeterCalculation1()
        {
            double expectedPerimeter = 4 * 5;
            double actualPerimeter = Square.CalculatePerimeter(5);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        /*
         * Type 2: data in DataRow statements
         */
        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(5)]
        [DataRow(6)]
        [DataRow(7)]
        [DataRow(8)]
        [DataRow(9)]
        [TestCategory("Area tests")]
        public void SquareAreaCalculation2(double side)
        {
            double expectedArea = side * side;
            double actualArea = Square.CalculateArea(side);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(5)]
        [DataRow(6)]
        [DataRow(7)]
        [DataRow(8)]
        [DataRow(9)]
        [TestCategory("Perimeter tests")]
        public void SquarePerimeterCalculation2(double side)
        {
            double expectedPerimeter = side * side;
            double actualPerimeter = Square.CalculateArea(side);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
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

        [DataTestMethod]
        [TestCategory("Area tests")]
        [DynamicData(nameof(GetSquareTestData), DynamicDataSourceType.Method)]
        public void SquareAreaCalculation3(double side)
        {
            double expectedArea = side * side;
            double actualArea = Square.CalculateArea(side);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [DataTestMethod]
        [TestCategory("Perimeter tests")]
        [DynamicData(nameof(GetSquareTestData), DynamicDataSourceType.Method)]
        public void SquarePerimeterCalculation3(double side)
        {
            double expectedPerimeter = 4 * side;
            double actualPerimeter = Square.CalculatePerimeter(side);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
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

        private static IEnumerable<object[]> GetSquareTestDataFromCSV()
        {
            string csvFilePath = "SquareTestDataMSTest.csv";
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                foreach (var record in csv.GetRecords<SquareTestData>().ToList())
                {
                    yield return new object[] { record.Side, record.ExpectedArea, record.ExpectedPerimeter };
                }
            }
        }

        [DataTestMethod]
        [TestCategory("Area tests")]
        [DynamicData(nameof(GetSquareTestDataFromCSV), typeof(SquareTests), DynamicDataSourceType.Method)]
        public void SquareAreaCalculation4(double side, double expectedArea, double expectedPerimeter)
        {
            double actual = Square.CalculateArea(side);
            double tolerance = 0.0001; // Adjust the tolerance value as needed
            Assert.AreEqual(expectedArea, actual, tolerance);
        }

        [DataTestMethod]
        [TestCategory("Perimeter tests")]
        [DynamicData(nameof(GetSquareTestDataFromCSV), typeof(SquareTests), DynamicDataSourceType.Method)]
        public void SquarePerimeterCalculation4(double side, double expectedArea, double expectedPerimeter)
        {
            double actual = Square.CalculatePerimeter(side);
            double tolerance = 0.0001; // Adjust the tolerance value as needed
            Assert.AreEqual(expectedPerimeter, actual, tolerance);
        }
    }

    [TestClass]
    [TestCategory("Parallelogram tests")]
    public class ParallelogramTests
    {
        [TestMethod]
        [TestCategory("Area tests")]
        public void ParallelogramAreaCalculation()
        {
            double expectedArea = 10 * 7; // Assuming base length is 10 and height is 7
            double actualArea = Parallelogram.CalculateArea(10, 7);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        [TestCategory("Perimeter tests")]
        public void ParallelogramPerimeterCalculation()
        {
            double expectedPerimeter = 2 * (10 + 7); // Assuming base length is 10 and height is 7
            double actualPerimeter = Parallelogram.CalculatePerimeter(10, 7);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }
    }
    [TestClass]
    [TestCategory("Pentagon tests")]
    public class PentagonTests
    {
        [TestMethod]
        [TestCategory("Area tests")]
        public void PentagonAreaCalculation()
        {
            double expectedArea = 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * 7 * 7; // Assuming side length is 7
            double actualArea = Pentagon.CalculateArea(7);
            Assert.AreEqual(expectedArea, actualArea, 0.0001); // Adding a delta to account for potential floating-point errors
        }

        [TestMethod]
        [TestCategory("Perimeter tests")]
        public void PentagonPerimeterCalculation()
        {
            double expectedPerimeter = 5 * 7; // Assuming side length is 7
            double actualPerimeter = Pentagon.CalculatePerimeter(7);
            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.0001); // Adding a delta to account for potential floating-point errors
        }
    }
    [TestClass]
    [TestCategory("Hexagon tests")]
    public class HexagonTests
    {
        [TestMethod]
        [TestCategory("Area tests")]
        public void HexagonAreaCalculation()
        {
            double expectedArea = 3 * Math.Sqrt(3) * 5 * 5 / 2; // Assuming side length is 5
            double actualArea = Hexagon.CalculateArea(5);
            Assert.AreEqual(expectedArea, actualArea, 0.0001); // Adding delta for floating-point precision
        }

        [TestMethod]
        [TestCategory("Perimeter tests")]
        public void HexagonPerimeterCalculation()
        {
            double expectedPerimeter = 6 * 5; // Assuming side length is 5
            double actualPerimeter = Hexagon.CalculatePerimeter(5);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }
    }
}
