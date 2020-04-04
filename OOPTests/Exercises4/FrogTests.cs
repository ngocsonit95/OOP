using Xunit;

namespace OOP.Exercises4.Tests
{
    public class FrogTests
    {
        [Fact]
        public void Contructor_CreateObjectNotNull_FrogTest()
        {
            var actualFrog = new Frog("FrogRed", 1, "female");
            Assert.NotNull(actualFrog);
        }
    }
}