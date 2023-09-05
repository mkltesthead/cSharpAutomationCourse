using GeometryCalculatorLibrary;

namespace GeometryCalculatorTestsMSTest
{
    [TestClass]
    [TestCategory("Circle Tests")]
    public class CircleTests
    {
        [ClassInitialize]
        public static void CircleTestsInit(TestContext context)
        {
            Console.WriteLine("Run me at the start of the Circle Test Series.");
        }

        [TestInitialize]
        public void RunMeFirst()
        {
            Console.WriteLine("Run me before the start of each circle test.");
        }

        [TestMethod]
        [TestCategory("Area Tests")]
        //[Ignore("Temporarily Disabled for Refactoring")]
        public void CircleAreaCalculation()
        {
            // Console.WriteLine("Checking out the Area of a Circle");
            double expectedArea = Math.PI * 5 * 5; // Assuming radius is 5
            double actualArea = Circle.CalculateArea(5);
            Assert.AreEqual(expectedArea, actualArea);
            // Console.WriteLine("Our test PASSES!!!");
        }

        [TestMethod]
        [TestCategory("Perimeter Tests")]
        // [Ignore]
        public void CirclePerimeterCalculation()
        {
            double expectedPerimeter = 2 * Math.PI * 5; // Assuming radius is 5
            double actualPerimeter = Circle.CalculatePerimeter(5);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [TestCleanup]
        public void RunMeLast()
        {
            Console.WriteLine("Run me at the end of each circle test.");
        }

        [ClassCleanup]
        public static void CircleCleanup()
        {
            Console.WriteLine("Run me at the end of all of the Circle Tests!");
        }
    }

    [TestClass]
    [TestCategory("Triangle Tests")]
    public class TriangleTests
    {
        [TestMethod]
        [TestCategory("Area Tests")]
        public void TriangleAreaCalculation()
        {
            double expectedArea = 10.0; // Assuming base length = 5 and height = 4
            double actualArea = Triangle.CalculateArea(5, 4);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        [TestCategory("Perimeter Tests")]
        public void TrianglePerimeterCalculation()
        {
            double expectedPerimeter = 12.0; // Assuming side lengths are 4, 5, and 3
            double actualPerimeter = Triangle.CalculatePerimeter(4, 5, 3);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [TestMethod]
        [TestCategory("Area Tests")]
        public void TestCalculateAreaHeron()
        {
            double expectedArea = 6.0; // Assuming side lengths are 3, 4, and 5
            double actualArea = Triangle.CalculateAreaHeron(3, 4, 5);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        [TestCategory("Triangle Types")]
        public void TestIsEquilateral()
        {
            Assert.IsTrue(Triangle.IsEquilateral(5, 5, 5));
            Assert.IsFalse(Triangle.IsEquilateral(3, 4, 5));
        }

        [TestMethod]
        [TestCategory("Triangle Types")]
        public void TestIsIsosceles()
        {
            Assert.IsTrue(Triangle.IsIsosceles(3, 3, 5));
            Assert.IsFalse(Triangle.IsIsosceles(3, 4, 5));
        }

        [TestMethod]
        [TestCategory("Triangle Types")]
        public void TestIsScalene()
        {
            Assert.IsTrue(Triangle.IsScalene(3, 4, 5));
            Assert.IsFalse(Triangle.IsScalene(3, 3, 3));
        }

        [TestMethod]
        [TestCategory("Triangle Types")]
        public void TestIsRightTriangle()
        {
            Assert.IsTrue(Triangle.IsRightTriangle(3, 4, 5));
            Assert.IsFalse(Triangle.IsRightTriangle(3, 4, 6));
        }

        [TestMethod]
        public void TestNumericRange()
        {
            double area = Triangle.CalculateArea(3, 4);
            Assert.IsTrue(area > 5 && area < 15);
        }

    }

    [TestClass]
    [TestCategory("Square Tests")]
    public class SquareTests
    {
        [TestMethod]
        [TestCategory("Area Tests")]
        public void SquareAreaCalculation()
        {
            double expectedArea = 25; // Assuming side length is 5
            double actualArea = Square.CalculateArea(5);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        [TestCategory("Perimeter Tests")]
        public void SquarePerimeterCalculation()
        {
            double expectedPerimeter = 20; // Assuming side length is 5
            double actualPerimeter = Square.CalculatePerimeter(5);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }
    }

    [TestClass]
    [TestCategory("Parallelogram Tests")]
    public class ParallelogramTests
    {
        [TestMethod]
        [TestCategory("Area Tests")]
        public void ParallelogramAreaCalculation()
        {
            double expectedArea = 10 * 7; // Assuming base length is 10 and height is 7
            double actualArea = Parallelogram.CalculateArea(10, 7);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        [TestCategory("Perimeter Tests")]
        public void ParallelogramPerimeterCalculation()
        {
            double expectedPerimeter = 2 * (10 + 7); // Assuming base length is 10 and height is 7
            double actualPerimeter = Parallelogram.CalculatePerimeter(10, 7);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }
    }
    [TestClass]
    [TestCategory("Hexagon Tests")]
    public class HexagonTests
    {
        [TestMethod]
        [TestCategory("Area Tests")]

        public void HexagonAreaCalculation()
        {
            double expectedArea = 3 * Math.Sqrt(3) * 5 * 5 / 2; // Assuming side length is 5
            double actualArea = Hexagon.CalculateArea(5);
            Assert.AreEqual(expectedArea, actualArea, 0.0001); // Adding delta for floating-point precision
        }

        [TestMethod]
        [TestCategory("Perimeter Tests")]
        public void HexagonPerimeterCalculation()
        {
            double expectedPerimeter = 6 * 5; // Assuming side length is 5
            double actualPerimeter = Hexagon.CalculatePerimeter(5);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }
    }

    [TestClass]
    [TestCategory("Polygon Tests")]
    public class PolygonTests
    {
        [TestMethod]
        public void TestIsConvex_ConvexPolygon()
        {
            List<double> angles = new List<double> { 50, 90, 120 };
            Assert.IsFalse(Polygon.IsConvex(angles));
        }

        [TestMethod]
        public void TestIsConvex_InvalidPolygon()
        {
            List<double> angles = new List<double> { 90 };
            Assert.ThrowsException<ArgumentException>(() => Polygon.IsConvex(angles));
        }
    }

    [TestClass]
    [TestCategory("Solid Geometry Tests")]
    public class SolidGeometryTests
    {
        [TestMethod]
        [TestCategory("Volume Tests")]
        public void TestCalculateCubeVolume()
        {
            double expectedVolume = 125; // Side length = 5
            double actualVolume = SolidGeometry.CalculateCubeVolume(5);
            Assert.AreEqual(expectedVolume, actualVolume);
        }

        [TestMethod]
        [TestCategory("Area Tests")]
        public void TestCalculateCubeSurfaceArea()
        {
            double expectedSurfaceArea = 150; // Side length = 5
            double actualSurfaceArea = SolidGeometry.CalculateCubeSurfaceArea(5);
            Assert.AreEqual(expectedSurfaceArea, actualSurfaceArea);
        }

        [TestMethod]
        [TestCategory("Volume Tests")]
        public void TestCalculateSphereVolume()
        {
            double expectedVolume = 113.09733552923254; // Radius = 3
            double actualVolume = SolidGeometry.CalculateSphereVolume(3);
            Assert.AreEqual(expectedVolume, actualVolume, 0.0001); // Adding a delta for floating-point precision
        }

        [TestMethod]
        [TestCategory("Area Tests")]
        public void TestCalculateSphereSurfaceArea()
        {
            double expectedSurfaceArea = 113.097335529232; // Radius = 3
            double actualSurfaceArea = SolidGeometry.CalculateSphereSurfaceArea(3);
            Assert.AreEqual(expectedSurfaceArea, actualSurfaceArea, 0.0001); // Adding a delta for floating-point precision
        }

        [TestMethod]
        [TestCategory("Volume Tests")]
        public void TestCalculateCylinderVolume()
        {
            double expectedVolume = 50.26548245743669; // Radius = 2, Height = 4
            double actualVolume = SolidGeometry.CalculateCylinderVolume(2, 4);
            Assert.AreEqual(expectedVolume, actualVolume, 0.0001); // Adding a delta for floating-point precision
        }

        [TestMethod]
        [TestCategory("Area Tests")]
        public void TestCalculateCylinderSurfaceArea()
        {
            double expectedSurfaceArea = 75.39822368615503; // Radius = 2, Height = 4
            double actualSurfaceArea = SolidGeometry.CalculateCylinderSurfaceArea(2, 4);
            Assert.AreEqual(expectedSurfaceArea, actualSurfaceArea, 0.0001); // Adding a delta for floating-point precision
        }

        [TestMethod]
        [TestCategory("Volume Tests")]
        public void TestCalculateConeVolume()
        {
            double expectedVolume = 12.566370614359172; // Radius = 2, Height = 3
            double actualVolume = SolidGeometry.CalculateConeVolume(2, 3);
            Assert.AreEqual(expectedVolume, actualVolume, 0.0001); // Adding a delta for floating-point precision
        }

        [TestMethod]
        [TestCategory("Area Tests")]
        public void TestCalculateConeSurfaceArea()
        {
            double expectedSurfaceArea = 35.22071741263713; // Radius = 2, Height = 3
            double actualSurfaceArea = SolidGeometry.CalculateConeSurfaceArea(2, 3);
            Assert.AreEqual(expectedSurfaceArea, actualSurfaceArea, 0.0001); // Adding a delta for floating-point precision
        }
    }
}