using Figure;

namespace FigureTest
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void GetSquare_TriangleWithSides3_4_5_Returns6()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var square = triangle.GetSquare();

            // Assert
            Assert.AreEqual(6, square);
        }

        [Test]
        public void IsRightAngled_TriangleWithSides3_4_5_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.IsTrue(isRightAngled);
        }

        [Test]
        public void IsRightAngled_TriangleWithSides3_4_6_ReturnsFalse()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 6);

            // Act
            var isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.IsFalse(isRightAngled);
        }

        [Test]
        public void Constructor_InvalidTriangle_ThrowsArgumentException()
        {
            // Arrange, Act, Assert
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
        }
    }
}
