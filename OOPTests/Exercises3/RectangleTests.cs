using Xunit;

namespace OOP.Exercises3.Tests
{
    public class RectangleTests
    {
        [Fact]
        public void Calculate_Rectangle_SurfaceTest()
        {
            var rectangle = new Rectangle(5, 10);
            var actual = rectangle.CalculateSurface();
            Assert.Equal(50, actual);
        }
    }
}