using System.Collections.Generic;
using Xunit;

namespace OOP.Exercises1.Tests
{
    public class SchoolTests
    {
        [Fact]
        public void Contructor_CreateObjectNotNull_SchoolTest()
        {
            var goodStudent = new Students("Thanh Mai", "Nguyen", 1);
            var badStudent = new Students("Tan Phuc", "Huynh", 2);

            var mathematics = new Discipline("Mathematics", 2, 2);
            var physics = new Discipline("Physics", 8, 4);
            var chemistry = new Discipline("Chemistry", 3, 2);
            var teacher = new Teachers("Dinh Hai Son", "Phan", new List<Discipline> { mathematics, physics, chemistry });

            var classes = new Class(new List<Students> { goodStudent, badStudent }, new List<Teachers> { teacher }, "A");

            var actualSchool = new School(new List<Class> { classes }, "Phan Chu Trinh");
            Assert.NotNull(actualSchool);
        }

        [Fact]
        public void Properties_CreateObjectNotNull_SchoolNameTest()
        {
            var goodStudent = new Students("Thanh Mai", "Nguyen", 1);
            var badStudent = new Students("Tan Phuc", "Huynh", 2);

            var mathematics = new Discipline("Mathematics", 2, 2);
            var physics = new Discipline("Physics", 8, 4);
            var chemistry = new Discipline("Chemistry", 3, 2);
            var teacher = new Teachers("Dinh Hai Son", "Phan", new List<Discipline> { mathematics, physics, chemistry });

            var classes = new Class(new List<Students> { goodStudent, badStudent }, new List<Teachers> { teacher }, "A");

            var school = new School(new List<Class> { classes }, "Phan Chu Trinh");
            var actualSchoolName = school.SchoolName;
            Assert.NotNull(actualSchoolName);
        }

        [Fact]
        public void Properties_CreateObjectNotNull_ClassesTest()
        {
            var goodStudent = new Students("Thanh Mai", "Nguyen", 1);
            var badStudent = new Students("Tan Phuc", "Huynh", 2);

            var mathematics = new Discipline("Mathematics", 2, 2);
            var physics = new Discipline("Physics", 8, 4);
            var chemistry = new Discipline("Chemistry", 3, 2);
            var teacher = new Teachers("Dinh Hai Son", "Phan", new List<Discipline> { mathematics, physics, chemistry });

            var classes = new Class(new List<Students> { goodStudent, badStudent }, new List<Teachers> { teacher }, "A");

            var school = new School(new List<Class> { classes }, "Phan Chu Trinh");
            var actualClasses = school.Classes;
            Assert.NotNull(actualClasses);
        }
    }
}