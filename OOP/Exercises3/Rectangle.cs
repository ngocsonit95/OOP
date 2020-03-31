using System;

namespace OOP.Exercises3
{
    internal class Rectangle : Shape
    {
        public Rectangle(double _width, double _height) : base(_width, _height)
        {
        }

        /// <summary>
        /// override method CalculateSurface of Shape
        /// </summary>
        /// <returns></returns>
        public override double CalculateSurface()
        {
            double surface = 0;
            try
            {
                surface = Width * Height;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return surface;
        }
    }
}