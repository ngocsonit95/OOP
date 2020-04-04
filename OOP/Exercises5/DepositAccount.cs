using OOP.Exercises5.Interface;
using System;

namespace OOP.Exercises5
{
    public class DepositAccount : Accounts, IDepositable, IWithDrawable
    {
        // Constructor
        public DepositAccount(Customer customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        {
        }

        // Methods
        // Deposit money
        public void Deposit(double depositMoney)
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

        // Withdraw money
        public void WithDraw(double withDrawMoney)
        {
            if (withDrawMoney <= 0)
            {
                throw new ArgumentException("Withdraw money cannot be negative or zero!");
            }
            else if (this.Balance <= withDrawMoney)
            {
                throw new ArgumentException("Cannot't withdraw more money than have in balance!");
            }
            else
            {
                this.Balance -= withDrawMoney;
            }
        }
    }
}