using System;

namespace OOP.Exercises1
{
    public class Students : Person
    {
        // Fields
        private int studentClassNumber;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="studentClassNumber"></param>
        public Students(string firstName, string lastName, int studentClassNumber)
            : base(firstName, lastName)
        {
            this.studentClassNumber = studentClassNumber;
        }

        /// <summary>
        /// Properties
        /// </summary>
        public int StudentClassNumber
        {
            get { return this.studentClassNumber; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException($"Student class number cannot be negative or zero!");
                }
                else
                {
                    this.studentClassNumber = value;
                }
            }
        }
    }
}