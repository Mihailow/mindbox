using Microsoft.VisualStudio.TestTools.UnitTesting;
using mindbox_bramnik;

namespace mindbox_bramnik_test
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CircleArea()
        {
            Circle circle = new Circle(7);
            double expected = 153.9;
            double result = circle.Area;
            Assert.AreEqual(expected, result);
        }
    }

    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Triangle_Area()
        {
            Triangle triangle = new Triangle(6, 8, 10);
            double expected = 24;
            double result = triangle.Area;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void isRectangle_NotRectangle_ReturnFalse()
        {
            Triangle triangle = new Triangle(6, 8, 10);
            var result = triangle.Rectangular;
            Assert.IsTrue(result);
        }
    }
}