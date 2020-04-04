using System;

namespace OOP.Exercises3
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Properties Width
        /// </summary>
        public double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be negative or zero!");
                }
                else
                {
                    this.width = value;
                }
            }
        }

        /// <summary>
        /// Properties height
        /// </summary>
        public double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be negative or zero!");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        //virtual method CalculateSurface
        public abstract double CalculateSurface();
    }
}