using OOP.Exercises5.Enum;
using Xunit;

namespace OOP.Exercises5.Tests
{
    public class MortgageAccountTests
    {
        [Fact]
        public void Contructor_CreateObjectNotNull_MortgageAccountTest()
        {
            double balance = 455;
            double interestRate = 6.8;
            var actualMortgageAccount = new MortgageAccount(new Customer(CustomerType.Individuals, "Nguyen Ngoc Son", "Ninh Thuan", "0348539913"), balance, interestRate);
            Assert.NotNull(actualMortgageAccount);
        }

        [Fact]
        public void Method_CalculatorWithValidAmount_DepositTest()
        {
            double balance = 455;
            double interestRate = 6.8;
            double depositMoney = 75;
            double expected = 530;
            var mortgageAccount = new MortgageAccount(new Customer(CustomerType.Individuals, "Nguyen Ngoc Son", "Ninh Thuan", "0348539913"), balance, interestRate);
            mortgageAccount.Deposit(depositMoney);
            double actual = mortgageAccount.Balance;
            Assert.Equal(expected, actual, 1);
        }
    }
}