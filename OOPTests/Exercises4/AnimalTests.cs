using Xunit;

namespace OOP.Exercises4.Tests
{
    public class AnimalTests
    {
        [Fact]
        public void Animal_AverageAgeTest()
        {
            Animal[] dogs = {
                new Dog("DogBlack", 3, "male", "Black"),
                new Dog("DogYellow", 3, "male", "Yellow"),
                new Dog("DogRed", 6, "female", "Red"),
                new Dog("DogWhite", 4, "female", "White")
               };
            var actual = Animal.AverageAge(dogs);
            Assert.Equal(4, actual);
        }
    }
}