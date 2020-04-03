using Xunit;

namespace OOP.Exercises3.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Calculate_Circle_SurfaceTest()
        {
            var circle = new Circle(10);
            var actual = circle.CalculateSurface();
            Assert.Equal(78.539816339744831, actual);
        }

       
    }
}