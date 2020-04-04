using Xunit;

namespace OOP.Exercises4.Tests
{
    public class KittenTests
    {
        [Fact]
        public void Contructor_CreateObjectNotNull_KittenTest()
        {
            var actualKitten = new Kitten("Tom", 2, "Max");
            Assert.NotNull(actualKitten);
        }
    }
}