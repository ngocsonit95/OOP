using Xunit;

namespace OOP.Exercises4.Tests
{
    public class DogTests
    {
        [Fact]
        public void Contructor_CreateObjectNotNUll_DogTest()
        {
            var actualDog = new Dog("DogWhite", 4, "female", "White");
            Assert.NotNull(actualDog);
        }
    }
}