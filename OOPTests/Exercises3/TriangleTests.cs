using Xunit;
namespace OOP.Exercises3.Tests
{
    public class TriangleTests
    {
        [Fact()]
        public void Calculate_Triangle_SurfaceTest()
        {
            var triangle = new Triangle(20, 10);
            var resultSurface = triangle.CalculateSurface();
            Assert.Equal(100, resultSurface);
        }
    }
}