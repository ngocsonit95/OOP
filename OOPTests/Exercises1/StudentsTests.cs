using Xunit;

namespace OOP.Exercises1.Tests
{
    public class StudentsTests
    {
        [Fact]
        public void Contructor_CreateObjectNotNull_StudentsTest()
        {
            var actualStudent = new Students("Thanh Mai", "Nguyen", 1);
            Assert.NotNull(actualStudent);
        }

        [Fact]
        public void Properties_CreateObjectNotBelowZero_StudentClassNumberTest()
        {
            var student = new Students("Thanh Mai", "Nguyen", 1);
            var actualClassNumber = student.StudentClassNumber;
            Assert.True(actualClassNumber > 0, "The StudentClassNumber was not greater than zero");
        }
    }
}