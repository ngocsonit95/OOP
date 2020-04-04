using Xunit;

namespace OOP.Exercises3.Tests
{
    public class RectangleTests
    {
        [Fact]
        public void Contructor_CreateObjectNotNull_RectangleTest()
        {
            var actualRectangle = new Rectangle(5, 10);
            Assert.NotNull(actualRectangle);
        }

        [Fact]
        public void Calculate_Rectangle_SurfaceTest()
        {
            var rectangle = new Rectangle(5, 10);
            var actualCalculateSurface = rectangle.CalculateSurface();
            Assert.Equal(50, actualCalculateSurface);
        }
    }
}