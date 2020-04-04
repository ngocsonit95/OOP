using System;

namespace OOP.Exercises5
{
    public abstract class Accounts
    {
        //Declar Fields
        private Customer customer;

        private double balance;
        private double interestRate;

        /// <summary>
        /// Constructor Accounts
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="balance"></param>
        /// <param name="interestRate"></param>
        public Accounts(Customer customer, double balance, double interestRate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }

        /// <summary>
        /// Properties Customer
        /// </summary>
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

        public double Balance
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

        public double InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Interest rate cannot < 0 !");
                }
                else
                {
                    this.interestRate = value;
                }
            }
        }
    }
}