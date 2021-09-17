using System;
using System.Collections;

namespace Abstract_Classes_and_Interface
{
    public class Circle : IFigure
    {
        private double radius;

        public Circle()
        {

        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetRadius()
        {
            return this.radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * this.radius * Math.PI;

        }

        public double CalculateArea(double pi, double radius)
        {

            return Math.PI * Math.Pow(this.radius, 2);
        }
    }
}