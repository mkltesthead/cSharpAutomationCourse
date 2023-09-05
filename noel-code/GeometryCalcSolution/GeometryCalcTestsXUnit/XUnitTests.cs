using CsvHelper.Configuration;
using CsvHelper;
using GeometryCalcLibrary;
using System.ComponentModel;
using System.Globalization;

namespace GeometryCalcTestsXUnit
{
    [Trait("Category", "Circle tests")]
    public class CircleTests
    {
        /*
         * Type 1: data hard coded in method
         */
        [Fact]
        [Trait("Category", "Area tests")]
        public void CircleAreaCalculation1()
        {
            double expectedArea = Math.PI * 5 * 5; // Assuming radius is 5
            double actualArea = Circle.CalculateArea(5);
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        [Trait("Category", "Perimeter tests")]
        public void CirclePerimeterCalculation1()
        {
            double expectedPerimeter = 2 * Math.PI * 5; // Assuming radius is 5
            double actualPerimeter = Circle.CalculatePerimeter(5);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }

        /*
         * Type 2: data in InlineData statements
         */
        [Theory]
        [Trait("Category", "Area tests")]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        public void CircleAreaCalculation2(double radius)
        {
            double expectedArea = Math.PI * radius * radius;
            double actualArea = Circle.CalculateArea(radius);
            Assert.Equal(expectedArea, actualArea);
        }

        [Theory]
        [Trait("Category", "Perimeter tests")]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        public void CirclePerimeterCalculation2(double radius)
        {
            double expectedPerimeter = 2 * Math.PI * radius;
            double actualPerimeter = Circle.CalculatePerimeter(radius);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }

        /*
         * Type 3: data in TheoryData object
         */
        public static TheoryData<double> GetCircleTestData()
        {
            var data = new TheoryData<double>
            {
                { 0},
                { 1},
                { 2},
                { 3},
                { 4},
                { 5},
                { 6},
                { 7},
                { 8},
                { 9}
            };
            return data;
        }

        [Theory]
        [Trait("Category", "Area tests")]
        [MemberData(nameof(GetCircleTestData))]
        public void CircleAreaCalculation3(double radius)
        {
            double expectedArea = Math.PI * radius * radius;
            double actualArea = Circle.CalculateArea(radius);
            Assert.Equal(expectedArea, actualArea);
        }

        [Theory]
        [Trait("Category", "Perimeter tests")]
        [MemberData(nameof(GetCircleTestData))]
        public void CirclePerimeterCalculation3(double radius)
        {
            double expectedPerimeter = 2 * Math.PI * radius; // Assuming radius is 5
            double actualPerimeter = Circle.CalculatePerimeter(radius);
            Assert.Equal(expectedPerimeter, actualPerimeter);
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

        public static IEnumerable<object[]> GetCircleTestDataFromCSV()
        {
            string csvFilePath = "CircleTestDataXUnit.csv";
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                foreach (var record in csv.GetRecords<CircleTestData>().ToList())
                {
                    yield return new object[] { record };
                }
            }
        }

        [Theory]
        [Trait("Category", "Area tests")]
        [MemberData(nameof(GetCircleTestDataFromCSV))]
        public void CircleAreaCalculation4(CircleTestData testData)
        {
            double actual = Circle.CalculateArea(testData.Radius);
            Assert.Equal(testData.ExpectedArea, actual, precision: 5);
        }

        [Theory]
        [Trait("Category", "Perimeter tests")]
        [MemberData(nameof(GetCircleTestDataFromCSV))]
        public void CirclePerimeterCalculation4(CircleTestData testData)
        {
            double actual = Circle.CalculatePerimeter(testData.Radius);
            Assert.Equal(testData.ExpectedPerimeter, actual, precision: 5);
        }
    }

    [Trait("Category", "Triangle tests")]
    public class TriangleTests
    {
        [Theory]
        [Trait("Category", "Area tests")]
        [InlineData(0, 1)]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 4)]
        [InlineData(4, 5)]
        [InlineData(5, 6)]
        [InlineData(6, 7)]
        [InlineData(7, 8)]
        [InlineData(8, 9)]
        [InlineData(9, 0)]
        public void TriangleAreaCalculation(double mybase, double myheight)
        {
            double expectedArea = 0.5 * mybase * myheight; // Assuming base length = 5 and height = 4
            double actualArea = Triangle.CalculateArea(mybase, myheight);
            Assert.Equal(expectedArea, actualArea);
        }

        [Theory]
        [Trait("Category", "Perimeter tests")]
        [InlineData(0, 1, 2)]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 4)]
        [InlineData(3, 4, 5)]
        [InlineData(4, 5, 6)]
        [InlineData(5, 6, 7)]
        [InlineData(6, 7, 8)]
        [InlineData(7, 8, 9)]
        [InlineData(8, 9, 0)]
        [InlineData(9, 0, 1)]
        public void TrianglePerimeterCalculation(double a, double b, double c)
        {
            double expectedPerimeter = a + b + c; // Assuming side lengths are 4, 5, and 3
            double actualPerimeter = Triangle.CalculatePerimeter(a, b, c);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }

        [Fact]
        [Trait("Category", "Right angled tests")]
        public void TriangleRightAngled()
        {
            Assert.True(Triangle.IsRightAngled(3, 4, 5));
            Assert.True(Triangle.IsRightAngled(3, 5, 4));
            Assert.True(Triangle.IsRightAngled(4, 3, 5));
            Assert.True(Triangle.IsRightAngled(4, 5, 3));
            Assert.True(Triangle.IsRightAngled(5, 3, 4));
            Assert.True(Triangle.IsRightAngled(5, 4, 3));

            Assert.True(Triangle.IsRightAngled(-3, -4, -5));
            Assert.True(Triangle.IsRightAngled(-3, -5, -4));
            Assert.True(Triangle.IsRightAngled(-4, -3, -5));
            Assert.True(Triangle.IsRightAngled(-4, -5, -3));
            Assert.True(Triangle.IsRightAngled(-5, -3, -4));
            Assert.True(Triangle.IsRightAngled(-5, -4, -3));
        }

        [Fact]
        [Trait("Category", "Right angled tests")]
        public void TriangleNotRightAngled()
        {
            Assert.False(Triangle.IsRightAngled(2, 4, 5));
            Assert.False(Triangle.IsRightAngled(2, 5, 4));
            Assert.False(Triangle.IsRightAngled(4, 2, 5));
            Assert.False(Triangle.IsRightAngled(4, 5, 2));
            Assert.False(Triangle.IsRightAngled(5, 2, 4));
            Assert.False(Triangle.IsRightAngled(5, 4, 2));

            Assert.False(Triangle.IsRightAngled(-2, -4, -5));
            Assert.False(Triangle.IsRightAngled(-2, -5, -4));
            Assert.False(Triangle.IsRightAngled(-4, -2, -5));
            Assert.False(Triangle.IsRightAngled(-4, -5, -2));
            Assert.False(Triangle.IsRightAngled(-5, -2, -4));
            Assert.False(Triangle.IsRightAngled(-5, -4, -2));
        }
    }

    [Trait("Category", "Square tests")]
    public class SquareTests
    {
        /*
         * Type 1: data hard coded in method
         */
        [Fact]
        [Trait("Category", "Area tests")]
        public void SquareAreaCalculation1()
        {
            double expectedArea = 25; // Assuming side length is 5
            double actualArea = Square.CalculateArea(5);
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        [Trait("Category", "Perimeter tests")]
        public void SquarePerimeterCalculation1()
        {
            double expectedPerimeter = 20; // Assuming side length is 5
            double actualPerimeter = Square.CalculatePerimeter(5);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }

        /*
         * Type 2: data in InlineData statements
         */
        [Theory]
        [Trait("Category", "Area tests")]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        public void SquareAreaCalculation2(double side)
        {
            double expectedArea = side * side;
            double actualArea = Square.CalculateArea(side);
            Assert.Equal(expectedArea, actualArea);
        }

        [Theory]
        [Trait("Category", "Perimeter tests")]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        public void SquarePerimeterCalculation2(double side)
        {
            double expectedPerimeter = 4 * side;
            double actualPerimeter = Square.CalculatePerimeter(side);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }

        /*
         * Type 3: data in TheoryData object
         */
        public static TheoryData<double> GetSquareTestData()
        {
            var data = new TheoryData<double>
            {
                { 0},
                { 1},
                { 2},
                { 3},
                { 4},
                { 5},
                { 6},
                { 7},
                { 8},
                { 9}
            };
            return data;
        }

        [Theory]
        [Trait("Category", "Area tests")]
        [MemberData(nameof(GetSquareTestData))]
        public void SquareAreaCalculation3(double side)
        {
            double expectedArea = side * side;
            double actualArea = Square.CalculateArea(side);
            Assert.Equal(expectedArea, actualArea);
        }

        [Theory]
        [Trait("Category", "Perimeter tests")]
        [MemberData(nameof(GetSquareTestData))]
        public void SquarePerimeterCalculation3(double side)
        {
            double expectedPerimeter = 4 * side;
            double actualPerimeter = Square.CalculatePerimeter(side);
            Assert.Equal(expectedPerimeter, actualPerimeter);
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

        public static IEnumerable<object[]> GetSquareTestDataFromCSV()
        {
            string csvFilePath = "SquareTestDataXUnit.csv";
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                foreach (var record in csv.GetRecords<SquareTestData>().ToList())
                {
                    yield return new object[] { record };
                }
            }
        }

        [Theory]
        [Trait("Category", "Area tests")]
        [MemberData(nameof(GetSquareTestDataFromCSV))]
        public void SquareAreaCalculation4(SquareTestData testData)
        {
            double actual = Square.CalculateArea(testData.Side);
            Assert.Equal(testData.ExpectedArea, actual, precision: 5);
        }

        [Theory]
        [Trait("Category", "Perimeter tests")]
        [MemberData(nameof(GetSquareTestDataFromCSV))]
        public void SquarePerimeterCalculation4(SquareTestData testData)
        {
            double actual = Square.CalculatePerimeter(testData.Side);
            Assert.Equal(testData.ExpectedPerimeter, actual, precision: 5);
        }
    }

    [Trait("Category", "Parallelogram tests")]
    public class ParallelogramTests
    {
        [Fact]
        [Trait("Category", "Area tests")]
        public void ParallelogramAreaCalculation()
        {
            double expectedArea = 10 * 7; // Assuming base length is 10 and height is 7
            double actualArea = Parallelogram.CalculateArea(10, 7);
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        [Trait("Category", "Perimeter tests")]
        public void ParallelogramPerimeterCalculation()
        {
            double expectedPerimeter = 2 * (10 + 7); // Assuming base length is 10 and height is 7
            double actualPerimeter = Parallelogram.CalculatePerimeter(10, 7);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }
    }

    [Trait("Category", "Pentagon tests")]
    public class PentagonTests
    {
        [Fact]
        [Trait("Category", "Area tests")]
        public void PentagonAreaCalculation()
        {
            double expectedArea = 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * 7 * 7; // Assuming side length is 7
            double actualArea = Pentagon.CalculateArea(7);
            Assert.Equal(expectedArea, actualArea, 4); // Adding a tolerance to account for potential floating-point errors
        }

        [Fact]
        [Trait("Category", "Perimeter tests")]
        public void PentagonPerimeterCalculation()
        {
            double expectedPerimeter = 5 * 7; // Assuming side length is 7
            double actualPerimeter = Pentagon.CalculatePerimeter(7);
            Assert.Equal(expectedPerimeter, actualPerimeter, 4); // Adding a tolerance to account for potential floating-point errors
        }
    }

    [Trait("Category", "Hexagon tests")]
    public class HexagonTests
    {
        [Fact]
        [Trait("Category", "Area tests")]
        public void HexagonAreaCalculation()
        {
            double expectedArea = 3 * Math.Sqrt(3) * 5 * 5 / 2; // Assuming side length is 5
            double actualArea = Hexagon.CalculateArea(5);
            Assert.Equal(expectedArea, actualArea, 4); // Adding a tolerance to account for potential floating-point errors
        }

        [Fact]
        [Trait("Category", "Perimeter tests")]
        public void HexagonPerimeterCalculation()
        {
            double expectedPerimeter = 6 * 5; // Assuming side length is 5
            double actualPerimeter = Hexagon.CalculatePerimeter(5);
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }
    }
}