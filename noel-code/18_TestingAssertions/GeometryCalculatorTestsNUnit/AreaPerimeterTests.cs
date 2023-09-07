using GeometryCalculatorLibrary;

namespace GeometryCalculatorTestsNUnit
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void CircleAreaCalculation()
        {
            double expectedArea = Math.PI * 5 * 5; // Assuming radius is 5
            double actualArea = Circle.CalculateArea(5);
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        public void CirclePerimeterCalculation()
        {
            double expectedPerimeter = 2 * Math.PI * 5; // Assuming radius is 5
            double actualPerimeter = Circle.CalculatePerimeter(5);
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }
    }

    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void TriangleAreaCalculation()
        {
            double expectedArea = 10.0; // Assuming base length = 5 and height = 4
            double actualArea = Triangle.CalculateArea(5, 4);
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        public void TrianglePerimeterCalculation()
        {
            double expectedPerimeter = 12.0; // Assuming side lengths are 4, 5, and 3
            double actualPerimeter = Triangle.CalculatePerimeter(4, 5, 3);
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }

        [Test]
        public void TestCalculateAreaHeron()
        {
            double expectedArea = 6.0; // Assuming side lengths are 3, 4, and 5
            double actualArea = Triangle.CalculateAreaHeron(3, 4, 5);
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        public void TestIsEquilateral()
        {
            Assert.IsTrue(Triangle.IsEquilateral(5, 5, 5));
            Assert.IsFalse(Triangle.IsEquilateral(3, 4, 5));
        }

        [Test]
        public void TestIsIsosceles()
        {
            Assert.IsTrue(Triangle.IsIsosceles(3, 3, 5));
            Assert.IsFalse(Triangle.IsIsosceles(3, 4, 5));
        }

        [Test]
        public void TestIsScalene()
        {
            Assert.IsTrue(Triangle.IsScalene(3, 4, 5));
            Assert.IsFalse(Triangle.IsScalene(3, 3, 3));
        }

        [Test]
        public void TestIsRightTriangle()
        {
            Assert.IsTrue(Triangle.IsRightTriangle(3, 4, 5));
            Assert.IsFalse(Triangle.IsRightTriangle(3, 4, 6));
        }
    }

    [TestFixture]
    public class SquareTests
    {
        [Test]
        public void SquareAreaCalculation()
        {
            double expectedArea = 25; // Assuming side length is 5
            double actualArea = Square.CalculateArea(5);
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
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
        public void TestCalculateCubeVolume()
        {
            double expectedVolume = 125; // Side length = 5
            double actualVolume = SolidGeometry.CalculateCubeVolume(5);
            Assert.That(actualVolume, Is.EqualTo(expectedVolume));
        }

        [Test]
        public void TestCalculateCubeSurfaceArea()
        {
            double expectedSurfaceArea = 150; // Side length = 5
            double actualSurfaceArea = SolidGeometry.CalculateCubeSurfaceArea(5);
            Assert.That(actualSurfaceArea, Is.EqualTo(expectedSurfaceArea));
        }

        [Test]
        public void TestCalculateSphereVolume()
        {
            double expectedVolume = 113.09733552923254; // Radius = 3
            double actualVolume = SolidGeometry.CalculateSphereVolume(3);
            Assert.That(actualVolume, Is.EqualTo(expectedVolume).Within(0.0001)); // Adding a delta for floating-point precision
        }

        [Test]
        public void TestCalculateSphereSurfaceArea()
        {
            double expectedSurfaceArea = 113.097335529232; // Radius = 3
            double actualSurfaceArea = SolidGeometry.CalculateSphereSurfaceArea(3);
            Assert.That(actualSurfaceArea, Is.EqualTo(expectedSurfaceArea).Within(0.0001)); // Adding a delta for floating-point precision
        }

        [Test]
        public void TestCalculateCylinderVolume()
        {
            double expectedVolume = 50.26548245743669; // Radius = 2, Height = 4
            double actualVolume = SolidGeometry.CalculateCylinderVolume(2, 4);
            Assert.That(actualVolume, Is.EqualTo(expectedVolume).Within(0.0001)); // Adding a delta for floating-point precision
        }

        [Test]
        public void TestCalculateCylinderSurfaceArea()
        {
            double expectedSurfaceArea = 75.39822368615503; // Radius = 2, Height = 4
            double actualSurfaceArea = SolidGeometry.CalculateCylinderSurfaceArea(2, 4);
            Assert.That(actualSurfaceArea, Is.EqualTo(expectedSurfaceArea).Within(0.0001)); // Adding a delta for floating-point precision
        }

        [Test]
        public void TestCalculateConeVolume()
        {
            double expectedVolume = 12.566370614359172; // Radius = 2, Height = 3
            double actualVolume = SolidGeometry.CalculateConeVolume(2, 3);
            Assert.That(actualVolume, Is.EqualTo(expectedVolume).Within(0.0001)); // Adding a delta for floating-point precision
        }

        [Test]
        public void TestCalculateConeSurfaceArea()
        {
            double expectedSurfaceArea = 35.22071741263713; // Radius = 2, Height = 3
            double actualSurfaceArea = SolidGeometry.CalculateConeSurfaceArea(2, 3);
            Assert.That(actualSurfaceArea, Is.EqualTo(expectedSurfaceArea).Within(0.0001)); // Adding a delta for floating-point precision
        }
    }
}
