using System;
using System.Threading;

namespace OOP.Exercises3
{
    public class Circle : Shape
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
                surface = Math.PI * (Width / 2.0) * (Height / 2.0);
            }
            catch (Exception ex)
            {
              throw new AbandonedMutexException(ex.ToString());
            }
            return surface;
        }
    }
}