using System.Collections.Generic;
using Xunit;

namespace OOP.Exercises1.Tests
{
    public class TeachersTests
    {
        [Fact]
        public void Contructor_CreateObjectNull_TeachersTest()
        {
            var economy = new Discipline("Economy", 1, 1);
            var actualTeacher = new Teachers("Minh Quang", "Le", new List<Discipline> { economy });
            Assert.NotNull(actualTeacher);
        }
    }
}