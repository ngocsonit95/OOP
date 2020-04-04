using Xunit;

namespace OOP.Exercises3.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Contructor_CreateObjectNotNull_TriangleTest()
        {
            var actualTriangle = new Triangle(2, 3);
            Assert.NotNull(actualTriangle);
        }

        [Fact()]
        public void Method_Calculate_TriangleSurfaceTest()
        {
            var triangle = new Triangle(20, 10);
            var resultSurface = triangle.CalculateSurface();
            Assert.Equal(100, resultSurface);
        }
    }
}