using Xunit;

namespace OOP.Exercises4.Tests
{
    public class CatTests
    {
        [Fact]
        public void Contructor_CreateObjectNotNUll_CatTest()
        {
            var actualCat = new Cat("Siro", 2, "male", "telerik");
            Assert.NotNull(actualCat);
        }
    }
}