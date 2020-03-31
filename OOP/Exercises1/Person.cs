using System;

namespace OOP.Exercises1
{
    public class Person : Comment
    {
        // Fields
        private string firstName;

        private string lastName;

        /// <summary>
        /// Constructor Person
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        /// <summary>
        /// Properties
        /// </summary>
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"First name cannot be null!");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"First name cannot be null!");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }
    }
}