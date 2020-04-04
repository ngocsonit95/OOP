using Xunit;

namespace OOP.Exercises2.Tests
{
    public class StudentTests
    {
        [Fact]
        public void Contructor_CreateObjectNotNull_StudentTest()
        {
            var actualStudent = new Student("Ngoc Son", "Nguyen", 12);
            Assert.NotNull(actualStudent);
        }
    }
}