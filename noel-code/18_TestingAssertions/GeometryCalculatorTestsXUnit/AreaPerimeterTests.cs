using GeometryCalculatorLibrary;

namespace GeometryCalculatorTestsXUnit
{
    public class CircleTests
    {
        [Fact]
        public void CircleAreaCalculation()
        {
            double expectedArea = Math.PI * 5 * 5; // Assuming radius is 5
            double actualArea = Circle.CalculateArea(5);
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void CirclePerimeterCalculation()
        {
            double expectedPerimeter = 2 * Math.PI * 5; // Assuming radius is 5
            double actualPerimeter = Circle.CalculatePerimeter(5);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }
    }

    public class TriangleTests
    {
        [Fact]
        public void TriangleAreaCalculation()
        {
            double expectedArea = 10.0; // Assuming base length = 5 and height = 4
            double actualArea = Triangle.CalculateArea(5, 4);
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void TrianglePerimeterCalculation()
        {
            double expectedPerimeter = 12.0; // Assuming side lengths are 4, 5, and 3
            double actualPerimeter = Triangle.CalculatePerimeter(4, 5, 3);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }

        [Fact]
        public void TestCalculateAreaHeron()
        {
            double expectedArea = 6.0; // Assuming side lengths are 3, 4, and 5
            double actualArea = Triangle.CalculateAreaHeron(3, 4, 5);
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void TestIsEquilateral()
        {
            Assert.True(Triangle.IsEquilateral(5, 5, 5));
            Assert.False(Triangle.IsEquilateral(3, 4, 5));
        }

        [Fact]
        public void TestIsIsosceles()
        {
            Assert.True(Triangle.IsIsosceles(3, 3, 5));
            Assert.False(Triangle.IsIsosceles(3, 4, 5));
        }

        [Fact]
        public void TestIsScalene()
        {
            Assert.True(Triangle.IsScalene(3, 4, 5));
            Assert.False(Triangle.IsScalene(3, 3, 3));
        }

        [Fact]
        public void TestIsRightTriangle()
        {
            Assert.True(Triangle.IsRightTriangle(3, 4, 5));
            Assert.False(Triangle.IsRightTriangle(3, 4, 6));
        }
    }
    public class SquareTests
    {
        [Fact]
        public void SquareAreaCalculation()
        {
            double expectedArea = 25; // Assuming side length is 5
            double actualArea = Square.CalculateArea(5);
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void SquarePerimeterCalculation()
        {
            double expectedPerimeter = 20; // Assuming side length is 5
            double actualPerimeter = Square.CalculatePerimeter(5);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }
    }

    public class ParallelogramTests
    {
        [Fact]
        public void ParallelogramAreaCalculation()
        {
            double expectedArea = 10 * 7; // Assuming base length is 10 and height is 7
            double actualArea = Parallelogram.CalculateArea(10, 7);
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void ParallelogramPerimeterCalculation()
        {
            double expectedPerimeter = 2 * (10 + 7); // Assuming base length is 10 and height is 7
            double actualPerimeter = Parallelogram.CalculatePerimeter(10, 7);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }
    }

    public class PentagonTests
    {
        [Fact]
        public void PentagonAreaCalculation()
        {
            double expectedArea = 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * 7 * 7; // Assuming side length is 7
            double actualArea = Pentagon.CalculateArea(7);
            Assert.Equal(expectedArea, actualArea, 4); // Adding a tolerance to account for potential floating-point errors
        }

        [Fact]
        public void PentagonPerimeterCalculation()
        {
            double expectedPerimeter = 5 * 7; // Assuming side length is 7
            double actualPerimeter = Pentagon.CalculatePerimeter(7);
            Assert.Equal(expectedPerimeter, actualPerimeter, 4); // Adding a tolerance to account for potential floating-point errors
        }
    }

    public class HexagonTests
    {
        [Fact]
        public void HexagonAreaCalculation()
        {
            double expectedArea = 3 * Math.Sqrt(3) * 5 * 5 / 2; // Assuming side length is 5
            double actualArea = Hexagon.CalculateArea(5);
            Assert.Equal(expectedArea, actualArea, 4); // Adding a tolerance to account for potential floating-point errors
        }

        [Fact]
        public void HexagonPerimeterCalculation()
        {
            double expectedPerimeter = 6 * 5; // Assuming side length is 5
            double actualPerimeter = Hexagon.CalculatePerimeter(5);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }
    }

    public class PolygonTests
    {
        [Fact]
        public void TestIsConvex_ConvexPolygon()
        {
            List<double> angles = new List<double> { 50, 90, 120 };
            Assert.False(Polygon.IsConvex(angles));
        }

        [Fact]
        public void TestIsConvex_InvalidPolygon()
        {
            List<double> angles = new List<double> { 90 };
            Assert.Throws<ArgumentException>(() => Polygon.IsConvex(angles));
        }
    }

    public class SolidGeometryTests
    {
        [Fact]
        public void TestCalculateCubeVolume()
        {
            double expectedVolume = 125; // Side length = 5
            double actualVolume = SolidGeometry.CalculateCubeVolume(5);
            Assert.Equal(expectedVolume, actualVolume);
        }

        [Fact]
        public void TestCalculateCubeSurfaceArea()
        {
            double expectedSurfaceArea = 150; // Side length = 5
            double actualSurfaceArea = SolidGeometry.CalculateCubeSurfaceArea(5);
            Assert.Equal(expectedSurfaceArea, actualSurfaceArea);
        }

        [Fact]
        public void TestCalculateSphereVolume()
        {
            double expectedVolume = 113.09733552923254; // Radius = 3
            double actualVolume = SolidGeometry.CalculateSphereVolume(3);
            Assert.Equal(expectedVolume, actualVolume, 4); // Using a tolerance of 4 for floating-point precision
        }

        [Fact]
        public void TestCalculateSphereSurfaceArea()
        {
            double expectedSurfaceArea = 113.097335529232; // Radius = 3
            double actualSurfaceArea = SolidGeometry.CalculateSphereSurfaceArea(3);
            Assert.Equal(expectedSurfaceArea, actualSurfaceArea, 4); // Using a tolerance of 4 for floating-point precision
        }

        [Fact]
        public void TestCalculateCylinderVolume()
        {
            double expectedVolume = 50.26548245743669; // Radius = 2, Height = 4
            double actualVolume = SolidGeometry.CalculateCylinderVolume(2, 4);
            Assert.Equal(expectedVolume, actualVolume, 4); // Using a tolerance of 4 for floating-point precision
        }

        [Fact]
        public void TestCalculateCylinderSurfaceArea()
        {
            double expectedSurfaceArea = 75.39822368615503; // Radius = 2, Height = 4
            double actualSurfaceArea = SolidGeometry.CalculateCylinderSurfaceArea(2, 4);
            Assert.Equal(expectedSurfaceArea, actualSurfaceArea, 4); // Using a tolerance of 4 for floating-point precision
        }

        [Fact]
        public void TestCalculateConeVolume()
        {
            double expectedVolume = 12.566370614359172; // Radius = 2, Height = 3
            double actualVolume = SolidGeometry.CalculateConeVolume(2, 3);
            Assert.Equal(expectedVolume, actualVolume, 4); // Using a tolerance of 4 for floating-point precision
        }

        [Fact]
        public void TestCalculateConeSurfaceArea()
        {
            double expectedSurfaceArea = 35.22071741263713; // Radius = 2, Height = 3
            double actualSurfaceArea = SolidGeometry.CalculateConeSurfaceArea(2, 3);
            Assert.Equal(expectedSurfaceArea, actualSurfaceArea, 4); // Using a tolerance of 4 for floating-point precision
        }
    }
}
