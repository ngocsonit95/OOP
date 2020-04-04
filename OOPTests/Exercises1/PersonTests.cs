using Xunit;

namespace OOP.Exercises1.Tests
{
    public class PersonTests
    {
        [Fact]
        public void Contructor_CreateObjectNotNull_PersonTest()
        {
            var actualPerson = new Person("Ngoc Son", "Nguyen");
            Assert.NotNull(actualPerson);
        }

        [Fact]
        public void Contructor_CreateObjectNotNull_FirstNameTest()
        {
            var person = new Person("Ngoc Son", "Nguyen");
            var actualFirstName = person.FirstName;
            Assert.NotNull(actualFirstName);
        }

        [Fact]
        public void Contructor_CreateObjectNotNull_LastNameTest()
        {
            var person = new Person("Ngoc Son", "Nguyen");
            var actualLastName = person.LastName;
            Assert.NotNull(actualLastName);
        }
    }
}