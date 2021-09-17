using System;
using System.Collections;

namespace Abstract_Classes_and_Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle rectangle = new Rectangle();
            rectangle.SetEdge1(25.5);
            rectangle.SetEdge2(5.4);
            Console.WriteLine(rectangle.CalculateArea(rectangle.GetEdge1(), rectangle.GetEdge2()));

            double pi = 3.14;
            Circle circle = new Circle();
            circle.SetRadius(50);
            Console.WriteLine(circle.CalculateArea(circle.GetRadius(), pi));



        }
    }
}
