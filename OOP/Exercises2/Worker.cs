﻿using System;

namespace OOP.Exercises2
{
    public class Worker : Human
    {
        // Fields
        private double weekSalary;

        private int workHoursPerDay;

        // Constructor
        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        // Properties
        public double WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Week salary cannot be negative or zero!");
                }
                else
                {
                    this.weekSalary = value;
                }
            }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Work hours per day cannot be negative or zero!");
                }
                else
                {
                    this.workHoursPerDay = value;
                }
            }
        }

        // Methods
        // Calculate money earned by hour by the worker
        public double MoneyPerHour()
        {
            var workHoursPerWeek = (5 * this.workHoursPerDay);
            var moneyPerHour = this.weekSalary / workHoursPerWeek;
            return moneyPerHour;
        }
    }
}