using GeometryCalculatorLibrary;

namespace GeometryCalculatorTestsMSTest
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CircleAreaCalculation()
        {
            double expectedArea = Math.PI * 5 * 5; // Assuming radius is 5
            double actualArea = Circle.CalculateArea(5);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
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
        [TestMethod]
        public void TriangleAreaCalculation()
        {
            double expectedArea = 10.0; // Assuming base length = 5 and height = 4
            double actualArea = Triangle.CalculateArea(5, 4);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void TrianglePerimeterCalculation()
        {
            double expectedPerimeter = 12.0; // Assuming side lengths are 4, 5, and 3
            double actualPerimeter = Triangle.CalculatePerimeter(4, 5, 3);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [TestMethod]
        public void TestCalculateAreaHeron()
        {
            double expectedArea = 6.0; // Assuming side lengths are 3, 4, and 5
            double actualArea = Triangle.CalculateAreaHeron(3, 4, 5);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void TestIsEquilateral()
        {
            Assert.IsTrue(Triangle.IsEquilateral(5, 5, 5));
            Assert.IsFalse(Triangle.IsEquilateral(3, 4, 5));
        }

        [TestMethod]
        public void TestIsIsosceles()
        {
            Assert.IsTrue(Triangle.IsIsosceles(3, 3, 5));
            Assert.IsFalse(Triangle.IsIsosceles(3, 4, 5));
        }

        [TestMethod]
        public void TestIsScalene()
        {
            Assert.IsTrue(Triangle.IsScalene(3, 4, 5));
            Assert.IsFalse(Triangle.IsScalene(3, 3, 3));
        }

        [TestMethod]
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
    public class SquareTests
    {
        [TestMethod]
        public void SquareAreaCalculation()
        {
            double expectedArea = 25; // Assuming side length is 5
            double actualArea = Square.CalculateArea(5);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void SquarePerimeterCalculation()
        {
            double expectedPerimeter = 20; // Assuming side length is 5
            double actualPerimeter = Square.CalculatePerimeter(5);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }
    }

    [TestClass]
    public class ParallelogramTests
    {
        [TestMethod]
        public void ParallelogramAreaCalculation()
        {
            double expectedArea = 10 * 7; // Assuming base length is 10 and height is 7
            double actualArea = Parallelogram.CalculateArea(10, 7);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void ParallelogramPerimeterCalculation()
        {
            double expectedPerimeter = 2 * (10 + 7); // Assuming base length is 10 and height is 7
            double actualPerimeter = Parallelogram.CalculatePerimeter(10, 7);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }
    }
    [TestClass]
    public class HexagonTests
    {
        [TestMethod]
        public void HexagonAreaCalculation()
        {
            double expectedArea = 3 * Math.Sqrt(3) * 5 * 5 / 2; // Assuming side length is 5
            double actualArea = Hexagon.CalculateArea(5);
            Assert.AreEqual(expectedArea, actualArea, 0.0001); // Adding delta for floating-point precision
        }

        [TestMethod]
        public void HexagonPerimeterCalculation()
        {
            double expectedPerimeter = 6 * 5; // Assuming side length is 5
            double actualPerimeter = Hexagon.CalculatePerimeter(5);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }
    }

    [TestClass]
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
    public class SolidGeometryTests
    {
        [TestMethod]
        public void TestCalculateCubeVolume()
        {
            double expectedVolume = 125; // Side length = 5
            double actualVolume = SolidGeometry.CalculateCubeVolume(5);
            Assert.AreEqual(expectedVolume, actualVolume);
        }

        [TestMethod]
        public void TestCalculateCubeSurfaceArea()
        {
            double expectedSurfaceArea = 150; // Side length = 5
            double actualSurfaceArea = SolidGeometry.CalculateCubeSurfaceArea(5);
            Assert.AreEqual(expectedSurfaceArea, actualSurfaceArea);
        }

        [TestMethod]
        public void TestCalculateSphereVolume()
        {
            double expectedVolume = 113.09733552923254; // Radius = 3
            double actualVolume = SolidGeometry.CalculateSphereVolume(3);
            Assert.AreEqual(expectedVolume, actualVolume, 0.0001); // Adding a delta for floating-point precision
        }

        [TestMethod]
        public void TestCalculateSphereSurfaceArea()
        {
            double expectedSurfaceArea = 113.097335529232; // Radius = 3
            double actualSurfaceArea = SolidGeometry.CalculateSphereSurfaceArea(3);
            Assert.AreEqual(expectedSurfaceArea, actualSurfaceArea, 0.0001); // Adding a delta for floating-point precision
        }

        [TestMethod]
        public void TestCalculateCylinderVolume()
        {
            double expectedVolume = 50.26548245743669; // Radius = 2, Height = 4
            double actualVolume = SolidGeometry.CalculateCylinderVolume(2, 4);
            Assert.AreEqual(expectedVolume, actualVolume, 0.0001); // Adding a delta for floating-point precision
        }

        [TestMethod]
        public void TestCalculateCylinderSurfaceArea()
        {
            double expectedSurfaceArea = 75.39822368615503; // Radius = 2, Height = 4
            double actualSurfaceArea = SolidGeometry.CalculateCylinderSurfaceArea(2, 4);
            Assert.AreEqual(expectedSurfaceArea, actualSurfaceArea, 0.0001); // Adding a delta for floating-point precision
        }

        [TestMethod]
        public void TestCalculateConeVolume()
        {
            double expectedVolume = 12.566370614359172; // Radius = 2, Height = 3
            double actualVolume = SolidGeometry.CalculateConeVolume(2, 3);
            Assert.AreEqual(expectedVolume, actualVolume, 0.0001); // Adding a delta for floating-point precision
        }

        [TestMethod]
        public void TestCalculateConeSurfaceArea()
        {
            double expectedSurfaceArea = 35.22071741263713; // Radius = 2, Height = 3
            double actualSurfaceArea = SolidGeometry.CalculateConeSurfaceArea(2, 3);
            Assert.AreEqual(expectedSurfaceArea, actualSurfaceArea, 0.0001); // Adding a delta for floating-point precision
        }
    }
}