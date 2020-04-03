using System.Collections.Generic;
using Xunit;

namespace OOP.Exercises1.Tests
{
    public class ClassTests
    {
        [Fact]
        public void Contructor_CreateObjectNotNull_ClassTest()
        {
            var goodStudent = new Students("Thanh Mai", "Nguyen", 1);
            var badStudent = new Students("Tan Phuc", "Huynh", 2);

            var mathematics = new Discipline("Mathematics", 2, 2);
            var physics = new Discipline("Physics", 8, 4);
            var chemistry = new Discipline("Chemistry", 3, 2);

            var teacher = new Teachers("Dinh Hai Son", "Phan", new List<Discipline> { mathematics, physics, chemistry });
            var actualClass = new Class(new List<Students> { goodStudent, badStudent }, new List<Teachers> { teacher }, "A");
            Assert.NotNull(actualClass);
        }

        [Fact]
        public void Properties_CreateObjectNotNull_ClassIdTest()
        {
            var goodStudent = new Students("Thanh Mai", "Nguyen", 1);
            var badStudent = new Students("Tan Phuc", "Huynh", 2);

            var mathematics = new Discipline("Mathematics", 2, 2);
            var physics = new Discipline("Physics", 8, 4);
            var chemistry = new Discipline("Chemistry", 3, 2);

            var teacher = new Teachers("Dinh Hai Son", "Phan", new List<Discipline> { mathematics, physics, chemistry });
            var ctClass = new Class(new List<Students> { goodStudent, badStudent }, new List<Teachers> { teacher }, "A");
            var actualClassId = ctClass.ClassId;
            Assert.NotNull(actualClassId);
        }
    }
}