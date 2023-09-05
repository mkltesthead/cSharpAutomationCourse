using GeometryCalculatorLibrary;

namespace GeometryCalculatorTestsNUnit
{


    [TestFixture]
    [Category("Circle Tests")]
    public class CircleTests
    {
        private static IEnumerable<object[]> GetCircleAreaTestData()
        {
            yield return new object[] { 5, Math.PI * 5 * 5 };
            yield return new object[] { 6, Math.PI * 6 * 6 };
            yield return new object[] { 7, Math.PI * 7 * 7 };
            yield return new object[] { 8, Math.PI * 8 * 8 };
            yield return new object[] { 9, Math.PI * 9 * 9 };
            yield return new object[] { 10, Math.PI * 10 * 10 };
        }

        private static IEnumerable<object[]> GetCirclePerimeterTestData()
        {
            yield return new object[] { 5, 2 * Math.PI * 5 };
            yield return new object[] { 6, 2 * Math.PI * 6 };
            yield return new object[] { 7, 2 * Math.PI * 7 };
            yield return new object[] { 8, 2 * Math.PI * 8 };
            yield return new object[] { 9, 2 * Math.PI * 9 };
            yield return new object[] { 10, 2 * Math.PI * 10 };
        }

        [Test, Category("Area Tests")]
        [TestCaseSource(nameof(GetCircleAreaTestData))]
        public void CircleAreaCalculation(double radius, double expected)
        {
            double actual = Circle.CalculateArea(radius);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test, Category("Perimeter Tests")]
        [TestCaseSource(nameof(GetCirclePerimeterTestData))]
        public void CirclePerimeterCalculation(double radius, double expected)
        {
            double actual = Circle.CalculatePerimeter(radius);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }



    /* // VERSION 1 DDT - TEst Case Level
    [TestFixture]
    [Category("Circle Tests")]
    public class CircleTests
    {
        [Test, Category("Area Tests")]
        [TestCase(5, Math.PI * 5 * 5)]
        [TestCase(6, Math.PI * 6 * 6)]
        [TestCase(7, Math.PI * 7 * 7)]
        [TestCase(8, Math.PI * 8 * 8)]
        [TestCase(9, Math.PI * 9 * 9)]
        [TestCase(10, Math.PI * 10 * 10)]
        public void CircleAreaCalculation(double radius, double expected)
        {
            double actual = Circle.CalculateArea(radius);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
    */

    /*  // ORIGINAL VERSION - No data Drivet Techniques
    public class CircleTests
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Console.WriteLine("Run me at the START of the Circle Test Series.");
        }

        [SetUp]
        public void RunMeFirst()
        {
            Console.WriteLine("Run me before the start of each circle test.");
        }

        [Test]
        [Category("Area Tests")]
        // [Ignore("In the process of refactoring test.")] // If we want to test the ignore feature at the test level
        public void CircleAreaCalculation()
        {
            double expectedArea = Math.PI * 5 * 5; // Assuming radius is 5
            double actualArea = Circle.CalculateArea(5);
            Console.WriteLine("Run me in the middle of the CircleAreaCalculation test.");
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        [Category("Perimeter Tests")]
        public void CirclePerimeterCalculation()
        {
            double expectedPerimeter = 2 * Math.PI * 5; // Assuming radius is 5
            double actualPerimeter = Circle.CalculatePerimeter(5);
            Console.WriteLine("Run me in the middle of the CirclePerimeterCalculation test.");
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }

        [TearDown]
        public void RunMeLast()
        {
            Console.WriteLine("Run me at the end of each circle test.");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Console.WriteLine("Run me at the END of the Circle Test Series.");
        }
    }

    */

    [TestFixture]
    public class TriangleTests
    {
        [Test]
        [Category("Area Tests")]
        public void TriangleAreaCalculation()
        {
            double expectedArea = 10.0; // Assuming base length = 5 and height = 4
            double actualArea = Triangle.CalculateArea(5, 4);
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        [Category("Perimeter Tests")]
        public void TrianglePerimeterCalculation()
        {
            double expectedPerimeter = 12.0; // Assuming side lengths are 4, 5, and 3
            double actualPerimeter = Triangle.CalculatePerimeter(4, 5, 3);
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }

        [Test]
        [Category("Area Tests")]
        public void TestCalculateAreaHeron()
        {
            double expectedArea = 6.0; // Assuming side lengths are 3, 4, and 5
            double actualArea = Triangle.CalculateAreaHeron(3, 4, 5);
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        [Category("Triangle Types")]
        public void TestIsEquilateral()
        {
            Assert.IsTrue(Triangle.IsEquilateral(5, 5, 5));
            Assert.IsFalse(Triangle.IsEquilateral(3, 4, 5));
        }

        [Test]
        [Category("Triangle Types")]
        public void TestIsIsosceles()
        {
            Assert.IsTrue(Triangle.IsIsosceles(3, 3, 5));
            Assert.IsFalse(Triangle.IsIsosceles(3, 4, 5));
        }

        [Test]
        [Category("Triangle Types")]
        public void TestIsScalene()
        {
            Assert.IsTrue(Triangle.IsScalene(3, 4, 5));
            Assert.IsFalse(Triangle.IsScalene(3, 3, 3));
        }

        [Test]
        [Category("Triangle Types")]
        public void TestIsRightTriangle()
        {
            Assert.IsTrue(Triangle.IsRightTriangle(3, 4, 5));
            Assert.IsFalse(Triangle.IsRightTriangle(3, 4, 6));
        }

        [Test]
        public void TestNumericRange()
        {
            double area = Triangle.CalculateArea(3, 4);
            Assert.IsTrue(area > 5 && area < 15);
        }
    }

    [TestFixture]
    public class SquareTests
    {
        [Test]
        [Category("Area Tests")]
        public void SquareAreaCalculation()
        {
            double expectedArea = 25; // Assuming side length is 5
            double actualArea = Square.CalculateArea(5);
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        [Category("Perimeter Tests")]
        public void SquarePerimeterCalculation()
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
        [Category("Area Tests")]
        public void ParallelogramAreaCalculation()
        {
            double expectedArea = 10 * 7; // Assuming base length is 10 and height is 7
            double actualArea = Parallelogram.CalculateArea(10, 7);
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        [Category("Perimeter Tests")]
        public void ParallelogramPerimeterCalculation()
        {
            double expectedPerimeter = 2 * (10 + 7); // Assuming base length is 10 and height is 7
            double actualPerimeter = Parallelogram.CalculatePerimeter(10, 7);
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }
    }

    [TestFixture]
    public class HexagonTests
    {
        [Test]
        [Category("Area Tests")]
        public void HexagonAreaCalculation()
        {
            double expectedArea = 3 * Math.Sqrt(3) * 5 * 5 / 2; // Assuming side length is 5
            double actualArea = Hexagon.CalculateArea(5);
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001)); // Adding delta for floating-point precision
        }

        [Test]
        [Category("Perimeter Tests")]
        public void HexagonPerimeterCalculation()
        {
            double expectedPerimeter = 6 * 5; // Assuming side length is 5
            double actualPerimeter = Hexagon.CalculatePerimeter(5);
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }
    }

    [TestFixture]
    public class PolygonTests
    {
        [Test]
        public void TestIsConvex_ConvexPolygon()
        {
            List<double> angles = new List<double> { 50, 90, 120 };
            Assert.IsFalse(Polygon.IsConvex(angles));
        }

        [Test]
        public void TestIsConvex_InvalidPolygon()
        {
            List<double> angles = new List<double> { 90 };
            Assert.Throws<ArgumentException>(() => Polygon.IsConvex(angles));
        }
    }

    [TestFixture]
    public class SolidGeometryTests
    {
        [Test]
        [Category("Solid Geometry Volume")]
        public void TestCalculateCubeVolume()
        {
            double expectedVolume = 125; // Side length = 5
            double actualVolume = SolidGeometry.CalculateCubeVolume(5);
            Assert.That(actualVolume, Is.EqualTo(expectedVolume));
        }

        [Test]
        [Category("Area Tests")]
        public void TestCalculateCubeSurfaceArea()
        {
            double expectedSurfaceArea = 150; // Side length = 5
            double actualSurfaceArea = SolidGeometry.CalculateCubeSurfaceArea(5);
            Assert.That(actualSurfaceArea, Is.EqualTo(expectedSurfaceArea));
        }

        [Test]
        [Category("Solid Geometry Volume")]
        public void TestCalculateSphereVolume()
        {
            double expectedVolume = 113.09733552923254; // Radius = 3
            double actualVolume = SolidGeometry.CalculateSphereVolume(3);
            Assert.That(actualVolume, Is.EqualTo(expectedVolume).Within(0.0001)); // Adding a delta for floating-point precision
        }

        [Test]
        [Category("Area Tests")]
        public void TestCalculateSphereSurfaceArea()
        {
            double expectedSurfaceArea = 113.097335529232; // Radius = 3
            double actualSurfaceArea = SolidGeometry.CalculateSphereSurfaceArea(3);
            Assert.That(actualSurfaceArea, Is.EqualTo(expectedSurfaceArea).Within(0.0001)); // Adding a delta for floating-point precision
        }

        [Test]
        [Category("Solid Geometry Volume")]
        public void TestCalculateCylinderVolume()
        {
            double expectedVolume = 50.26548245743669; // Radius = 2, Height = 4
            double actualVolume = SolidGeometry.CalculateCylinderVolume(2, 4);
            Assert.That(actualVolume, Is.EqualTo(expectedVolume).Within(0.0001)); // Adding a delta for floating-point precision
        }

        [Test]
        [Category("Area Tests")]
        public void TestCalculateCylinderSurfaceArea()
        {
            double expectedSurfaceArea = 75.39822368615503; // Radius = 2, Height = 4
            double actualSurfaceArea = SolidGeometry.CalculateCylinderSurfaceArea(2, 4);
            Assert.That(actualSurfaceArea, Is.EqualTo(expectedSurfaceArea).Within(0.0001)); // Adding a delta for floating-point precision
        }

        [Test]
        [Category("Solid Geometry Volume")]
        public void TestCalculateConeVolume()
        {
            double expectedVolume = 12.566370614359172; // Radius = 2, Height = 3
            double actualVolume = SolidGeometry.CalculateConeVolume(2, 3);
            Assert.That(actualVolume, Is.EqualTo(expectedVolume).Within(0.0001)); // Adding a delta for floating-point precision
        }

        [Test]
        [Category("Area Tests")]
        public void TestCalculateConeSurfaceArea()
        {
            double expectedSurfaceArea = 35.22071741263713; // Radius = 2, Height = 3
            double actualSurfaceArea = SolidGeometry.CalculateConeSurfaceArea(2, 3);
            Assert.That(actualSurfaceArea, Is.EqualTo(expectedSurfaceArea).Within(0.0001)); // Adding a delta for floating-point precision
        }
    }
}
