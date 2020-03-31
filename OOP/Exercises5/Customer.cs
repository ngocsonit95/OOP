using OOP.Exercises5.Enum;
using System;

namespace OOP.Exercises5
{
    public class Customer
    {

        private string fullName;
        private string address;
        private string phoneNumber;

        // Constructor
        public Customer(CustomerType customerType, string fullName, string address, string phoneNumber)
        {
            this.CustomerType = customerType;
            this.fullName = fullName;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        // Properties
        public CustomerType CustomerType { get; set; }

        public string FullName
        {
            get { return this.fullName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"Customer fullName cannot be null!");
                }
                else
                {
                    this.fullName = value;
                }
            }
        }

        public string Address
        {
            get { return this.address; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"Customer address cannot be null!");
                }
                else
                {
                    this.address = value;
                }
            }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"Customer phone number cannot be null!");
                }
                else
                {
                    this.phoneNumber = value;
                }
            }
        }
    }
}