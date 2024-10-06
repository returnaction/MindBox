using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace FigureTest4
{
    [TestClass]
    public class FigureTest
    {
        [TestMethod]
        public void TestCircleArea()
        {
            var circle = new Circle(5);
            double area = circle.GetArea();
            Assert.AreEqual(Math.PI * 25, area, 0.00001);
        }

        [TestMethod]
        public void TestTriangleArea()
        {
            var triangle = new Triangle(3,4,5);
            double area = triangle.GetArea();
            Assert.AreEqual(6, area, 0.0001);
        }

        [TestMethod]
        public void TestRightAngleTriangle()
        {
            var triangle = new Triangle(3, 4, 5);
            bool is90Angled = triangle.IsRightAngle();
            Assert.IsTrue(is90Angled);
        }
    }
}
