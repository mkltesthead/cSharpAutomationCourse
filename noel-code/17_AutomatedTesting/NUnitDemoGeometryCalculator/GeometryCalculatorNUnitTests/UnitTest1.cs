using GeometryCalculator;
using NUnit.Framework;

namespace GeometryCalculatorNUnitTests
{
    public class GeometryAreaNUnitTests
    {
        [Test]
        public void TestCircleArea()
        {
            double radius = 5;
            double expectedArea = Math.PI * radius * radius;
            double actualArea = Circle.CalculateArea(radius);
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001));
        }

        // Other test methods
    }
}