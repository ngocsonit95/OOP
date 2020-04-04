using Xunit;

namespace OOP.Exercises2.Tests
{
    public class WorkerTests
    {
        [Fact]
        public void Contructor_CreateObjectNotNull_WorkerTest()
        {
            var actualWorker = new Worker("Ngoc Son", "Nguyen", 3500, 8);
            Assert.NotNull(actualWorker);
        }

        [Fact]
        public void Properties_CreateObjectNotBelowZero_MoneyPerHourTest()
        {
            var worker = new Worker("Ngoc Son", "Nguyen", 3500, 8);
            var actualWeekSalary = worker.WeekSalary;
            Assert.True(actualWeekSalary > 0, "Number of MoneyPerHour cannot be negative or zero!");
        }

        [Fact]
        public void Properties_CreateObjectNotBelowZero_WorkHoursPerDayTest()
        {
            var worker = new Worker("Ngoc Son", "Nguyen", 3500, 8);
            var actualWorkHoursPerDay = worker.WorkHoursPerDay;
            Assert.True(actualWorkHoursPerDay > 0, "Number of WorkHoursPerDay cannot be negative or zero!");
        }

        [Fact]
        public void Calculator_MoneyPerHourTest()
        {
            var workHoursPerDay = 8;
            var weekSalary = 3500;
            var worker = new Worker("Ngoc Son", "Nguyen", weekSalary, workHoursPerDay);
            var actual = worker.MoneyPerHour();
            Assert.Equal(87.5, actual);
        }
    }
}