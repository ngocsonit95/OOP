using OOP.Exercises5.Enum;
using System;
using Xunit;

namespace OOP.Exercises5.Tests
{
    public class MortgageAccountTests
    {
        [Fact]
        public void Deposit_MortgageAccountTest()
        {
            var mortgageAccount = new MortgageAccount(new Customer(CustomerType.Companies, "Nguyen Ngoc Son", "Ninh Thuan", "0348539913"), 2000, 1000);
            var ex = Assert.Throws<InvalidOperationException>(() => mortgageAccount.Deposit(3000));
            Assert.Equal("Cannot read temperature before initializing.", ex.Message);
        }
    }
}