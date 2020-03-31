using OOP.Exercises5.Interface;
using System;

namespace OOP.Exercises5
{
    public class MortgageAccount : Account, IDepositable
    {
        /// <summary>
        /// Constructor MortgageAccount
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="balance"></param>
        /// <param name="interestRate"></param>
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        //Methods Deposit money.
        public void Deposit(decimal depositMoney)
        {
            if (depositMoney <= 0)
            {
                throw new ArgumentException("Deposit money cannot be negative or zero!");
            }
            else
            {
                this.Balance += depositMoney;
            }
        }
    }
}