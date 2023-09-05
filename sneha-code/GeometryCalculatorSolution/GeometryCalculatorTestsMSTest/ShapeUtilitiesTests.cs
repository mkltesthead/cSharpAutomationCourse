using GeometryCalculatorLibrary;

namespace GeometryCalculatorTestsMSTest
{
    [TestClass]
    public class ShapeUtilitiesTests
    {
        [TestMethod]
        public void TestIsEven()
        {
            Assert.IsTrue(ShapeUtilities.IsEven(4));
            Assert.IsFalse(ShapeUtilities.IsEven(7));
        }

        [TestMethod]
        public void TestBasicMathOperation()
        {
            int result = ShapeUtilities.AddNumbers(3, 4);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void TestNumericRange()
        {
            double area = ShapeUtilities.CalculateArea(3); // Assuming a shape with side length 3
            Assert.IsTrue(area > 5 && area < 15);
        }

        [TestMethod]
        public void TestFloatingPointEqualityWithTolerance()
        {
            double expected = 0.1 + 0.2;
            double actual = ShapeUtilities.CalculateResultWithFloats();
            Assert.AreEqual(expected, actual, 0.00001);
        }

        [TestMethod]
        public void TestStringAssertions()
        {
            string shapeDescription = ShapeUtilities.GetShapeDescription("Circle", 5);
            StringAssert.Contains(shapeDescription, "Circle with dimension 5");
        }


        [TestMethod]
        public void TestExceptionAssertions()
        {
            Assert.ThrowsException<ArgumentException>(() => ShapeUtilities.ThrowExceptionOnInvalidInput(-1));
        }
    }

}
