using GeometryCalculatorLibrary;

namespace GeometryCalculatorTestsNUnit
{
    [TestFixture]
    public class ShapeUtilitiesTests
    {
        [Test]
        public void TestIsEven()
        {
            Assert.IsTrue(ShapeUtilities.IsEven(4));
            Assert.IsFalse(ShapeUtilities.IsEven(7));
        }

        [Test]
        public void TestBasicMathOperation()
        {
            int result = ShapeUtilities.AddNumbers(3, 4);
            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void TestNumericRange()
        {
            double area = ShapeUtilities.CalculateArea(3); // Assuming a shape with side length 3
            Assert.IsTrue(area > 5 && area < 15);
        }

        [Test]
        public void TestFloatingPointEqualityWithTolerance()
        {
            double expected = 0.1 + 0.2;
            double actual = ShapeUtilities.CalculateResultWithFloats();
            Assert.That(actual, Is.EqualTo(expected).Within(0.00001));
        }

        [Test]
        public void TestStringAssertions()
        {
            string shapeDescription = ShapeUtilities.GetShapeDescription("Circle", 5);
            Assert.That(shapeDescription, Does.Contain("Circle with dimension 5"));
        }

        [Test]
        public void TestExceptionAssertions()
        {
            Assert.Throws<ArgumentException>(() => ShapeUtilities.ThrowExceptionOnInvalidInput(-1));
        }
    }
}
