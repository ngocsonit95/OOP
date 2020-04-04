using Xunit;

namespace OOP.Exercises3.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Contructor_CreateObjectNotNull_CircleTest()
        {
            var actualCircle = new Circle(2);
            Assert.NotNull(actualCircle);
        }

        [Fact]
        public void Calculate_Circle_SurfaceTest()
        {
            var circle = new Circle(2);
            var actual = circle.CalculateSurface();
            Assert.Equal(3.1415926535897931, actual);
        }
    }
}