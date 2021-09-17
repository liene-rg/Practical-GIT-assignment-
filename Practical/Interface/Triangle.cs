using System;
using System.Collections;

namespace Abstract_Classes_and_Interface
{
    public class Triangle : IFigure
    {
        private double edge1, edge2, edge3, heigh1;


        public Triangle()
        {

        }

        public Triangle(double edge1, double edge2, double edge3, double heigh1)
        {

            this.edge1 = edge1;
            this.edge2 = edge2;
            this.edge3 = edge3;
            this.heigh1 = heigh1;
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

        public double GetEdge3()
        {
            return this.edge3;
        }

        public void SetEdge3(double edge3)
        {
            this.edge3 = edge3;
        }

        public double GetHeigh1()
        {
            return this.heigh1;
        }

        public void SetHeigh1(double heigh1)
        {
            this.heigh1 = heigh1;
        }

        public double CalculatePerimeter()
        {

            return this.edge1 + this.edge2 + this.edge3;
        }


        public double CalculateArea()
        {
            return (this.edge1 * this.heigh1) / 2;

        }
    }
}
