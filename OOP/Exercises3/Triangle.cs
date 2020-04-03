using System;
using System.Threading;

namespace OOP.Exercises3
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {
        }


        public override double CalculateSurface()
        {
            double surface;
            try
            {
                surface = (Width * Height) / 2;
            }
            catch (Exception ex)
            {
                throw new AbandonedMutexException(ex.ToString());
            }

            return surface;
        }
    }
}