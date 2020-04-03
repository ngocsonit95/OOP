
using Xunit;

namespace OOP.Exercises1.Tests
{
    public class DisciplineTests
    {
        [Fact]
        public void Property_CreateObjectNotNull_DisciplineNameTest()
        {
            var discipline =new Discipline("Mathematics", 2, 2);
            var actualDisciplineName = discipline.DisciplineName;
            Assert.NotNull(actualDisciplineName);
        }

        [Fact]
        public void Property_CreateObjectNotBelowZero_NumberOfLecturesTest()
        {
            var discipline = new Discipline("Mathematics", 2, 2);
            var actualNumberOfLectures = discipline.NumberOfLectures;
            Assert.True(actualNumberOfLectures > 0, "The NumberOfLectures was not greater than zero");
        }

        [Fact]
        public void Property_CreateObjectNotBelowZero_NumberOfExercisesTest()
        {
            var discipline = new Discipline("Mathematics", 2, 2);
            var actualNumberOfExercises = discipline.NumberOfExercises;
            Assert.True(actualNumberOfExercises > 0, "The NumberOfLectures was not greater than zero");
        }
    }
}