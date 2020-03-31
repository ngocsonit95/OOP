using System;

namespace OOP.Exercises5
{
    public abstract class Account
    {
        // Fields
        private Customer customer;

        private decimal balance;
        private decimal interestRate;

        /// <summary>
        /// Contructor Account
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="balance"></param>
        /// <param name="interestRate"></param>
        protected Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }

        // Properties
        public Customer Customer
        {
            get { return this.customer; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"Customer cannot be null!");
                }
                else
                {
                    this.customer = value;
                }
            }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance cannot < 0!");
                }
                else
                {
                    this.balance = value;
                }
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Interest rate cannot < 0!");
                }
                else
                {
                    this.interestRate = value;
                }
            }
        }
    }
}