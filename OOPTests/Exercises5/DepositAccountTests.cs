using OOP.Exercises5.Enum;
using Xunit;

namespace OOP.Exercises5.Tests
{
    public class DepositAccountTests
    {
        [Fact]
        public void Contructor_CreateObjectNotNull_DepositAccountTest()
        {
            double balance = 455;
            double interestRate = 6.8;
            var actualMortgageAccount = new DepositAccount(new Customer(CustomerType.Individuals, "Nguyen Ngoc Son", "Ninh Thuan", "0348539913"), balance, interestRate);
            Assert.NotNull(actualMortgageAccount);
        }

        [Fact]
        public void Method_CalculatorWithValidAmount_DepositTest()
        {
            double balance = 455;
            double interestRate = 6.8;
            double depositMoney = 75;
            double expected = 530;
            var depositAccount = new DepositAccount(new Customer(CustomerType.Individuals, "Nguyen Ngoc Son", "Ninh Thuan", "0348539913"), balance, interestRate);
            depositAccount.Deposit(depositMoney);
            double actual = depositAccount.Balance;
            Assert.Equal(expected, actual, 1);
        }

        [Fact]
        public void Method_CalculatorWithValidAmount_WithDrawTest()
        {
            double balance = 455;
            double interestRate = 6.8;
            double withDrawMoney = 75;
            double expected = 380;
            var depositAccount = new DepositAccount(new Customer(CustomerType.Individuals, "Nguyen Ngoc Son", "Ninh Thuan", "0348539913"), balance, interestRate);
            depositAccount.WithDraw(withDrawMoney);
            double actual = depositAccount.Balance;
            Assert.Equal(expected, actual, 1);
        }
    }
}