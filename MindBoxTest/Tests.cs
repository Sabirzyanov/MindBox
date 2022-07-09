using MindBoxLib;

namespace MindBoxTest
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void Triangle_4_5_6_Return_9_92()
        {
            Triangle triangle = new Triangle("ABC", 4, 5, 6);
            double square = 9.92;
            Assert.That(square, Is.EqualTo(triangle.CalculateFigureArea()));
        }

        [Test]
        public void Triangle_Exist_ReturnFalse()
        {
            Assert.Throws<ArgumentException>(() => { Triangle triangle = new Triangle("ABC", 4, 1, 1); });
        }

        [Test]
        public void Triangle_Exist_ReturnTrue()
        {
            Assert.DoesNotThrow(() => { Triangle triangle = new Triangle("ABC", 4, 5, 6); });
        }

        [Test]
        public void Triangle_IsRectangle_ReturnTrue()
        {
            Triangle triangle = new Triangle("ABC", 3, 4, 5);
            Assert.IsTrue(triangle.IsRectangular());
        }
    }

    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void Circle_3_Return_28_27()
        {
            Circle circle = new Circle("Cirlce_1", 3);
            double square = 28.27;
            Assert.That(square, Is.EqualTo(circle.CalculateFigureArea()));
        }
    }
}