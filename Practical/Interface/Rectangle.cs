using System;

namespace Abstract_Classes_and_Interface
{
    public class Rectangle : IFigure
    {
        private double edge1, edge2;

        public Rectangle()
        {

        }

        public Rectangle(double edge1, double edge2)
        {
            this.edge1 = edge1;
            this.edge2 = edge2;
        }

        public double GetEdge1()
        {
            return this.edge1;
        }

        public void SetEdge1(double edge1)
        {
            this.edge1 = edge1;
        }

        public double GetEdge2()
        {
            return this.edge2;
        }

        public void SetEdge2(double edge2)
        {
            this.edge2 = edge2;
        }


        public double CalculatePerimeter(double edge1, double edge2)
        {
            double perimeter = 2 * (edge1 + edge2);
            return perimeter;
        }

        public double CalculateArea(double edge1, double edge2)
        {
            double area = this.edge1 * this.edge2;
            return area;
        }

    }

}