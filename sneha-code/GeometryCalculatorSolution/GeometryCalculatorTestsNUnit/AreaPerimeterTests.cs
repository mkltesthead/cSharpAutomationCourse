using GeometryCalculatorLibrary;

namespace GeometryCalculatorTestsNUnit
{
    [TestFixture]
    public class CircleTests
    {
        [OneTimeSetUp]
        public static void RunMeBeforeAllSquareTests(TestContext testContext)
        {
            Console.WriteLine("Run me before all sqaure tests");
        }
        [SetUp]
        public void RunMeBeforeTestMethod()
        {
            Console.WriteLine("Run me before each test execution");
        }
        [Test]
        [Category("Circle NUnit Tests")]
        public void CircleAreaCalculation()
        {
            double expectedArea = Math.PI * 5 * 5; // Assuming radius is 5
            double actualArea = Circle.CalculateArea(5);
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        [Category("Circle NUnit Tests")]
        public void CirclePerimeterCalculation()
        {
            double expectedPerimeter = 2 * Math.PI * 5; // Assuming radius is 5
            double actualPerimeter = Circle.CalculatePerimeter(5);
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }
        [TearDown]
        public void RunMeAfterTestMethod()
        {
            Console.WriteLine("Run me after each test execution");
        }
        [OneTimeTearDown]
        public static void RunMeAfterAllSquareTests()
        {
            Console.WriteLine("Run me after all square tests");
        }
    }

    [TestFixture]
    public class TriangleTests
    {
        [Test, Category("Triangle NUnit DataDriven Tests")]
        [TestCase(5, 4, 0.5 * 5 * 4)]
        [TestCase(4.8, 6.2, 0.5 * 4.8 * 6.2)]
        [TestCase(10, 5.5, 0.5 * 10 * 5.5)]
        public void TriangleAreaCalculation(double baseLength, double height, double expected)
        {
            //double expectedArea = 10.0; // Assuming base length = 5 and height = 4
            double actualArea = Triangle.CalculateArea(baseLength, height);
            Assert.That(actualArea, Is.EqualTo(expected));
        }

        [Test]
        public void TrianglePerimeterCalculation()
        {
            double expectedPerimeter = 12.0; // Assuming side lengths are 4, 5, and 3
            double actualPerimeter = Triangle.CalculatePerimeter(4, 5, 3);
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }
    }

    [TestFixture]
    public class SquareTests
    {
        private static IEnumerable<TestCaseData> GetSquarePerimeterTestData()
        {
            yield return new TestCaseData(4, 4 * 4);
            yield return new TestCaseData(10, 4 * 10);
            yield return new TestCaseData(6, 4 * 6);
            yield return new TestCaseData(7, 4 * 7);
            yield return new TestCaseData(4.5, 4 * 4.5);
            yield return new TestCaseData(12, 4 * 12);
            yield return new TestCaseData(11, 4 * 11);

        }
        [Test]

        public void SquareAreaCalculation()
        {
            double expectedArea = 25; // Assuming side length is 5
            double actualArea = Square.CalculateArea(5);
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test, Category("Square NUnit Data tests")]
        [TestCaseSource(nameof(GetSquarePerimeterTestData))]
        public void SquarePerimeterCalculation(double side, double expected)
        {
            double expectedPerimeter = 20; // Assuming side length is 5
            double actualPerimeter = Square.CalculatePerimeter(5);
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }
    }

    [TestFixture]
    public class ParallelogramTests
    {
        [Test]
        public void ParallelogramAreaCalculation()
        {
            double expectedArea = 10 * 7; // Assuming base length is 10 and height is 7
            double actualArea = Parallelogram.CalculateArea(10, 7);
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        public void ParallelogramPerimeterCalculation()
        {
            double expectedPerimeter = 2 * (10 + 7); // Assuming base length is 10 and height is 7
            double actualPerimeter = Parallelogram.CalculatePerimeter(10, 7);
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }
    }

    [TestFixture]
    public class PentagonTests
    {
        [Test]
        public void PentagonAreaCalculation()
        {
            double expectedArea = 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * 7 * 7; // Assuming side length is 7
            double actualArea = Pentagon.CalculateArea(7);
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001)); // Adding a delta to account for potential floating-point errors
        }

        [Test]
        public void PentagonPerimeterCalculation()
        {
            double expectedPerimeter = 5 * 7; // Assuming side length is 7
            double actualPerimeter = Pentagon.CalculatePerimeter(7);
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter).Within(0.0001)); // Adding a delta to account for potential floating-point errors
        }
    }

    [TestFixture]
    public class HexagonTests
    {
        [Test]
        public void HexagonAreaCalculation()
        {
            double expectedArea = 3 * Math.Sqrt(3) * 5 * 5 / 2; // Assuming side length is 5
            double actualArea = Hexagon.CalculateArea(5);
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001)); // Adding delta for floating-point precision
        }

        [Test]
        public void HexagonPerimeterCalculation()
        {
            double expectedPerimeter = 6 * 5; // Assuming side length is 5
            double actualPerimeter = Hexagon.CalculatePerimeter(5);
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }
    }
}
