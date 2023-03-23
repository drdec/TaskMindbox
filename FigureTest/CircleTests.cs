using Figure;

namespace FigureTest
{
    [TestFixture]
    public class CircleTests
    {
        [TestCase(1, ExpectedResult = Math.PI)]
        [TestCase(2, ExpectedResult = Math.PI * 4)]
        [TestCase(5, ExpectedResult = Math.PI * 25)]
        public double GetSquare_ReturnsCorrectValue(double radius)
        {
            var circle = new Circle(radius);
            return circle.GetSquare();
        }
        
        [Test]
        public void Constructor_ThrowsArgumentException_WhenRadiusIsNegative()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }

        [Test]
        public void Constructor_ThrowsArgumentException_WhenRadiusIsZero()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }
    }
}