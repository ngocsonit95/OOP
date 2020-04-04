using Xunit;

namespace OOP.Exercises4.Tests
{
    public class TomCatTests
    {
        [Fact]
        public void Contructor_CreatObjectNotNull_TomCatTest()
        {
            var actualTomCat = new TomCat("Siro", 9, "telerik");
            Assert.NotNull(actualTomCat);
        }
    }
}