using CsvHelper.Configuration;
using GeometryCalculatorLibrary;

namespace GeometryCalculatorTestsXUnit
{
    [Trait("Category", "Circle Tests")]
    public class CircleTests
    {
        public class CircleTestData
        {
            public double Radius { get; set; }
            public double Expected { get; set; }
        }

        private static List<CircleTestData> LoadTestDataFromCSV(string csvFilePath)
        {
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                return csv.GetRecords<CircleTestData>().ToList();
            }
        }

        public static IEnumerable<object[]> GetCircleTestDataFromCSV()
        {
            string csvFilePath = "CircleTestData.csv";
            var testData = LoadTestDataFromCSV(csvFilePath);

            foreach (var data in testData)
            {
                yield return new object[] { data };
            }
        }

        [Theory]
        [Trait("Category", "Area Tests")]
        [MemberData(nameof(GetCircleTestDataFromCSV))]
        public void CircleAreaCalculation(CircleTestData testData)
        {
            double actual = Circle.CalculateArea(testData.Radius);
            Assert.Equal(testData.Expected, actual, precision: 5); // Using precision instead of tolerance
        }
    }

    /*
    //VERSION 2 - MEthod Level Data Driven Test Values
     public static TheoryData<double, double> CircleAreaTestData()
     {
         var data = new TheoryData<double, double>
         {
             { 5, Math.PI * 5 * 5 },
             { 6, Math.PI * 6 * 6 },
             { 7, Math.PI * 7 * 7 },
             { 8, Math.PI * 8 * 8 },
             { 9, Math.PI * 9 * 9 },
             { 10, Math.PI * 10 * 10 }
         };
         return data;
     }

     public static TheoryData<double, double> CirclePerimeterTestData()
     {
         var data = new TheoryData<double, double>
         {
             { 5, 2 * Math.PI * 5 },
             { 6, 2 * Math.PI * 6 },
             { 7, 2 * Math.PI * 7 },
             { 8, 2 * Math.PI * 8 },
             { 9, 2 * Math.PI * 9 },
             { 10, 2 * Math.PI * 10 }
         };
         return data;
     }

     [Theory]
     [Trait("Category", "Area Tests")]
     [MemberData(nameof(CircleAreaTestData))]
     public void CircleAreaCalculation(double radius, double expected)
     {
         double actual = Circle.CalculateArea(radius);
         Assert.Equal(expected, actual, 4); // Adjust the precision (number of decimal places) as needed
     }

     [Theory]
     [Trait("Category", "Perimeter Tests")]
     [MemberData(nameof(CirclePerimeterTestData))]
     public void CirclePerimeterCalculation(double radius, double expected)
     {
         double actual = Circle.CalculatePerimeter(radius);
         Assert.Equal(expected, actual, 4); // Adjust the precision (number of decimal places) as needed
     }
    */

    /* VERSION 1 DDT - Test Case Level w/ InLine Data
    [Trait("Category", "Circle Tests")]
    public class CircleTests
    {
        [Theory]
        [Trait("Category", "Area Tests")]
        [InlineData(5, Math.PI * 5 * 5)]
        [InlineData(6, Math.PI * 6 * 6)]
        [InlineData(7, Math.PI * 7 * 7)]
        [InlineData(8, Math.PI * 8 * 8)]
        [InlineData(9, Math.PI * 9 * 9)]
        [InlineData(10, Math.PI * 10 * 10)]
        public void CircleAreaCalculation(double radius, double expected)
        {
            double actual = Circle.CalculateArea(radius);
            Assert.Equal(expected, actual, 4); // Adjust the precision (number of decimal places) as needed
        }
    }
    */

    /* ORIGINAL VERSION - No Data Driven Parameters

    [Trait("Category", "Circle Tests")]
    // [Ignore("In the process of refactoring test.")] // If we want to test the ignore feature at the class level
    public class CircleTests
    {
        private readonly ITestOutputHelper _output;

        public CircleTests(ITestOutputHelper output)
        {
            _output = output;
        }
        [Fact]
        // [Fact(Skip = "Comment out for refactoring")] // uncomment if we want to ignore this test example
        [Trait("Category", "Area Tests")]
        public void CircleAreaCalculation()
        {
            double expectedArea = Math.PI * 5 * 5; // Assuming radius is 5
            double actualArea = Circle.CalculateArea(5);
            _output.WriteLine("Run me in the middle of the CircleAreaCalculation test.");
            // Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        [Trait("Category", "Perimeter Tests")]
        public void CirclePerimeterCalculation()
        {
            double expectedPerimeter = 2 * Math.PI * 5; // Assuming radius is 5
            double actualPerimeter = Circle.CalculatePerimeter(5);
            _output.WriteLine("Run me in the middle of the CirclePerimeterCalculation test.");
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }
    }

    */


    public class TriangleTests
    {
        [Fact]
        [Trait("Category", "Area Tests")]
        public void TriangleAreaCalculation()
        {
            double expectedArea = 10.0; // Assuming base length = 5 and height = 4
            double actualArea = Triangle.CalculateArea(5, 4);
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        [Trait("Category", "Perimeter Tests")]
        public void TrianglePerimeterCalculation()
        {
            double expectedPerimeter = 12.0; // Assuming side lengths are 4, 5, and 3
            double actualPerimeter = Triangle.CalculatePerimeter(4, 5, 3);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }

        [Fact]
        [Trait("Category", "Area Tests")]
        public void TestCalculateAreaHeron()
        {
            double expectedArea = 6.0; // Assuming side lengths are 3, 4, and 5
            double actualArea = Triangle.CalculateAreaHeron(3, 4, 5);
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        [Trait("Category", "Triangle Types")]
        public void TestIsEquilateral()
        {
            Assert.True(Triangle.IsEquilateral(5, 5, 5));
            Assert.False(Triangle.IsEquilateral(3, 4, 5));
        }

        [Fact]
        [Trait("Category", "Triangle Types")]
        public void TestIsIsosceles()
        {
            Assert.True(Triangle.IsIsosceles(3, 3, 5));
            Assert.False(Triangle.IsIsosceles(3, 4, 5));
        }

        [Fact]
        [Trait("Category", "Triangle Types")]
        public void TestIsScalene()
        {
            Assert.True(Triangle.IsScalene(3, 4, 5));
            Assert.False(Triangle.IsScalene(3, 3, 3));
        }

        [Fact]
        [Trait("Category", "Triangle Types")]
        public void TestIsRightTriangle()
        {
            Assert.True(Triangle.IsRightTriangle(3, 4, 5));
            Assert.False(Triangle.IsRightTriangle(3, 4, 6));
        }

        [Fact]
        public void TestNumericRange()
        {
            double area = Triangle.CalculateArea(3, 4);
            Assert.True(area > 5 && area < 15);
        }
    }

    public class SquareTests
    {
        [Fact]
        [Trait("Category", "Area Tests")]
        public void SquareAreaCalculation()
        {
            double expectedArea = 25; // Assuming side length is 5
            double actualArea = Square.CalculateArea(5);
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        [Trait("Category", "Perimeter Tests")]
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
        [Trait("Category", "Area Tests")]
        public void ParallelogramAreaCalculation()
        {
            double expectedArea = 10 * 7; // Assuming base length is 10 and height is 7
            double actualArea = Parallelogram.CalculateArea(10, 7);
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        [Trait("Category", "Perimeter Tests")]
        public void ParallelogramPerimeterCalculation()
        {
            double expectedPerimeter = 2 * (10 + 7); // Assuming base length is 10 and height is 7
            double actualPerimeter = Parallelogram.CalculatePerimeter(10, 7);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }
    }

    public class HexagonTests
    {
        [Fact]
        [Trait("Category", "Area Tests")]
        public void HexagonAreaCalculation()
        {
            double expectedArea = 3 * Math.Sqrt(3) * 5 * 5 / 2; // Assuming side length is 5
            double actualArea = Hexagon.CalculateArea(5);
            Assert.Equal(expectedArea, actualArea, 4); // Adding delta for floating-point precision
        }

        [Fact]
        [Trait("Category", "Perimeter Tests")]
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
        [Trait("Category", "Solid Geometry Volume")]
        public void TestCalculateCubeVolume()
        {
            double expectedVolume = 125; // Side length = 5
            double actualVolume = SolidGeometry.CalculateCubeVolume(5);
            Assert.Equal(expectedVolume, actualVolume);
        }

        [Fact]
        [Trait("Category", "Area Tests")]
        public void TestCalculateCubeSurfaceArea()
        {
            double expectedSurfaceArea = 150; // Side length = 5
            double actualSurfaceArea = SolidGeometry.CalculateCubeSurfaceArea(5);
            Assert.Equal(expectedSurfaceArea, actualSurfaceArea);
        }

        [Fact]
        [Trait("Category", "Solid Geometry Volume")]
        public void TestCalculateSphereVolume()
        {
            double expectedVolume = 113.09733552923254; // Radius = 3
            double actualVolume = SolidGeometry.CalculateSphereVolume(3);
            Assert.Equal(expectedVolume, actualVolume, 4); // Adding a delta for floating-point precision
        }

        [Fact]
        [Trait("Category", "Area Tests")]
        public void TestCalculateSphereSurfaceArea()
        {
            double expectedSurfaceArea = 113.097335529232; // Radius = 3
            double actualSurfaceArea = SolidGeometry.CalculateSphereSurfaceArea(3);
            Assert.Equal(expectedSurfaceArea, actualSurfaceArea, 4); // Adding a delta for floating-point precision
        }

        [Fact]
        [Trait("Category", "Solid Geometry Volume")]
        public void TestCalculateCylinderVolume()
        {
            double expectedVolume = 50.26548245743669; // Radius = 2, Height = 4
            double actualVolume = SolidGeometry.CalculateCylinderVolume(2, 4);
            Assert.Equal(expectedVolume, actualVolume, 4); // Adding a delta for floating-point precision
        }

        [Fact]
        [Trait("Category", "Area Tests")]
        public void TestCalculateCylinderSurfaceArea()
        {
            double expectedSurfaceArea = 75.39822368615503; // Radius = 2, Height = 4
            double actualSurfaceArea = SolidGeometry.CalculateCylinderSurfaceArea(2, 4);
            Assert.Equal(expectedSurfaceArea, actualSurfaceArea, 4); // Adding a delta for floating-point precision
        }

        [Fact]
        [Trait("Category", "Solid Geometry Volume")]
        public void TestCalculateConeVolume()
        {
            double expectedVolume = 12.566370614359172; // Radius = 2, Height = 3
            double actualVolume = SolidGeometry.CalculateConeVolume(2, 3);
            Assert.Equal(expectedVolume, actualVolume, 4); // Adding a delta for floating-point precision
        }

        [Fact]
        [Trait("Category", "Area Tests")]
        public void TestCalculateConeSurfaceArea()
        {
            double expectedSurfaceArea = 35.22071741263713; // Radius = 2, Height = 3
            double actualSurfaceArea = SolidGeometry.CalculateConeSurfaceArea(2, 3);
            Assert.Equal(expectedSurfaceArea, actualSurfaceArea, 4); // Adding a delta for floating-point precision
        }
    }
}
