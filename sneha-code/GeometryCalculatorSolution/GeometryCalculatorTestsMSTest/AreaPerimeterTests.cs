using GeometryCalculatorLibrary;

namespace GeometryCalculatorTestsMSTest
{
    [TestClass]

    public class CircleTests
    {
        [DataTestMethod]
        [TestCategory("Circle Regression DataDriven Tests")]
        [DataRow(5, Math.PI * 5 * 5)]
        [DataRow(6, Math.PI * 6 * 6)]
        public void CircleAreaCalculation(double radius, double expected)
        {
            //double expectedArea = Math.PI * 5 * 5; // Assuming radius is 5
            double actualArea = Circle.CalculateArea(radius);
            Assert.AreEqual(expected, actualArea);
        }

        [TestMethod]
        [TestCategory("Circle Regression Tests")]
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
        private static IEnumerable<object[]> GetTrianglePerimeterTestData()
        {
            yield return new object[] { 4, 5, 3, 4 + 5 + 3 };
            yield return new object[] { 10, 4, 6, 10 + 4 + 6 };
            yield return new object[] { 6, 2, 3, 6 + 2 + 3 };
            yield return new object[] { 7, 3, 4, 7 + 3 + 4 };
            yield return new object[] { 4.5, 8, 4, 4.5 + 8 + 4 };
            yield return new object[] { 12, 9, 6, 12 + 9 + 6 };
            yield return new object[] { 11, 5, 4, 11 + 5 + 4 };

        }
        [TestMethod]
        [TestCategory("Triangle Regression Tests")]
        public void TriangleAreaCalculation()
        {
            double expectedArea = 10.0; // Assuming base length = 5 and height = 4
            double actualArea = Triangle.CalculateArea(5, 4);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [DataTestMethod]
        [TestCategory("Triangle Regression Data Tests")]
        [DynamicData(nameof(GetTrianglePerimeterTestData), DynamicDataSourceType.Method)]
        public void TrianglePerimeterCalculation(double length1, double length2, double length3, double expected)
        {
            //double expectedPerimeter = 12.0; // Assuming side lengths are 4, 5, and 3
            double actualPerimeter = Triangle.CalculatePerimeter(length1, length2, length3);
            Assert.AreEqual(expected, actualPerimeter);
        }
    }

    [TestClass]
    [TestCategory("Square Tests")]
    public class SquareTests
    {
        [ClassInitialize]
        public static void RunMeBeforeAllSquareTests(TestContext testContext)
        {
            Console.WriteLine("Run me before all sqaure tests");
        }
        [TestInitialize]
        public void RunMeBeforeTestMethod()
        {
            Console.WriteLine("Run me before each test execution");
        }
        [TestMethod]
        //[TestCategory("Square Regression Tests")]
        public void SquareAreaCalculation()
        {
            double expectedArea = 25; // Assuming side length is 5
            double actualArea = Square.CalculateArea(5);
            Assert.AreEqual(expectedArea, actualArea);
        }
        [TestMethod]
        //[TestCategory("Square Regression Tests")]
        public void SquarePerimeterCalculation()
        {
            double expectedPerimeter = 20; // Assuming side length is 5
            double actualPerimeter = Square.CalculatePerimeter(5);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }
        [TestCleanup]
        public void RunMeAfterTestMethod()
        {
            Console.WriteLine("Run me after each test execution");
        }
        [ClassCleanup]
        public static void RunMeAfterAllSquareTests()
        {
            Console.WriteLine("Run me after all square tests");
        }
    }

    [TestClass]
    public class ParallelogramTests
    {
        [TestMethod]
        [TestCategory("Parallelogram Regression Tests")]
        public void ParallelogramAreaCalculation()
        {
            double expectedArea = 10 * 7; // Assuming base length is 10 and height is 7
            double actualArea = Parallelogram.CalculateArea(10, 7);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        [TestCategory("Parallelogram Regression Tests")]
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
        public class PentagonTestData
        {
            public double Side { get; set; }
            public double Expected { get; set; }
        }

        private static List<PentagonTestData> LoadTestDataFromCSV(string csvFilePath)
        {
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                return csv.GetRecords<PentagonTestData>().ToList();
            }
        }

        private static IEnumerable<object[]> GetPentagonTestDataFromCSV()
        {
            string csvFilePath = @"C:\Users\u1173906\OneDrive - MMC\Documents\SDET BootCamp\C sharp\GeometryCalculatorSolution\GeometryCalculatorTestsMSTest\PentagonTestData.csv";

            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                var records = csv.GetRecords<PentagonTestData>().ToList();
                foreach (var record in records)
                {
                    yield return new object[] { record.Side, record.Expected };
                }
            }
        }

        [TestMethod]
        [TestCategory("Pentagon Regression Tests")]
        public void PentagonAreaCalculation()
        {
            double expectedArea = 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * 7 * 7; // Assuming side length is 7
            double actualArea = Pentagon.CalculateArea(7);
            Assert.AreEqual(expectedArea, actualArea, 0.0001); // Adding a delta to account for potential floating-point errors
        }

        [TestMethod]
        [TestCategory("Pentagon Regression CSV DataTests")]
        [DynamicData(nameof(GetPentagonTestDataFromCSV), typeof(PentagonTests), DynamicDataSourceType.Method)]
        public void PentagonPerimeterCalculation(double Side, double Expected)
        {
            //double expectedPerimeter = 5 * 7; // Assuming side length is 7
            double actualPerimeter = Pentagon.CalculatePerimeter(Side);
            Assert.AreEqual(Expected, actualPerimeter, 0.0001); // Adding a delta to account for potential floating-point errors
        }
    }
    [TestClass]
    public class HexagonTests
    {
        [TestMethod]
        [TestCategory("Hexagon Regression Tests")]
        public void HexagonAreaCalculation()
        {
            double expectedArea = 3 * Math.Sqrt(3) * 5 * 5 / 2; // Assuming side length is 5
            double actualArea = Hexagon.CalculateArea(5);
            Assert.AreEqual(expectedArea, actualArea, 0.0001); // Adding delta for floating-point precision
        }

        [TestMethod]
        [TestCategory("Hexagon Regression Tests")]
        public void HexagonPerimeterCalculation()
        {
            double expectedPerimeter = 6 * 5; // Assuming side length is 5
            double actualPerimeter = Hexagon.CalculatePerimeter(5);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }
    }
}