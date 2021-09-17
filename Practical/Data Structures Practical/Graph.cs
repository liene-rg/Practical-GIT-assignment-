using System;
using System.Collections;
using System.Collections.Generic;

namespace Data_Structures_Practical
{
    class Graph
    {
        private LinkedList<Edge> edges = new LinkedList<Edge>();
        private LinkedList<Vertix> vertixes = new LinkedList<Vertix>();

        public void AddNewEdge(Edge edge)
        {
            this.edges.AddLast(edge);
        }

        public void AddVertex(Vertix vertix)
        {
            this.vertixes.AddLast(vertix);
        }



    }


}

