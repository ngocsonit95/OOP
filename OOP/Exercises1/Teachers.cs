using System;
using System.Collections.Generic;

namespace OOP.Exercises1
{
    public class Teachers : Person
    {
        // Fields
        private List<Discipline> discipline;

        // Constructor
        public Teachers(string firstName, string lastName, List<Discipline> discipline)
            : base(firstName, lastName)
        {
            this.discipline = discipline;
        }

        // Properties
        public List<Discipline> Discipline
        {
            get { return this.discipline; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"Discipline cannot be null!");
                }
                else
                {
                    this.discipline = value;
                }
            }
        }
    }
}