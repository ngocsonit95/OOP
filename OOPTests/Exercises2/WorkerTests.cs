using Xunit;

namespace OOP.Exercises2.Tests
{
    public class WorkerTests
    {
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