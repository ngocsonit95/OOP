using System;
using System.Threading;

namespace OOP.Exercises3
{
    internal class Circle : Shape
    {
        public Circle(double radius)
            : base(radius, radius)
        {
        }

        /// <summary>
        /// override method CalculateSurface of Shape
        /// </summary>
        /// <returns></returns>
        public override double CalculateSurface()
        {
            double surface;
            try
            {
                surface = Math.PI * (this.Width / 2.0) * (this.Height / 2.0);
            }
            catch (Exception ex)
            {
              throw new AbandonedMutexException(ex.ToString());
            }
            return surface;
        }
    }
}