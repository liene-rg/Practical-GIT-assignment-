using System;

namespace Data_Structures_Practical
{

    class Edge
    {

        private Vertix point1, point2;

        public Edge(Vertix point1, Vertix point2)
        {
            this.point1 = point1;
            this.point2 = point2;

            this.point1.AddNewEdge(this);
            this.point2.AddNewEdge(this);
        }

        public Vertix GetPoint1()
        {
            return this.point1;
        }

        public Vertix GetPoint2()
        {
            return this.point2;
        }


        public override string ToString()
        {
            return "Flights " + this.GetPoint1() + " " + this.GetPoint2();
        }
    }
}