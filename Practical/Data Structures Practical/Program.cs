using System;
using System.Collections;
using System.Collections.Generic;

namespace Data_Structures_Practical
{
    class Program
    {
        static void Main(string[] args)
        {
            Vertix livingstone = new Vertix("Livingstone");
            Vertix victoriaFalls = new Vertix("Victoria Falls");
            Vertix harare = new Vertix("Harare");
            Vertix windhoek = new Vertix("Windhoek");
            Vertix mauritius = new Vertix("Mauritius");
            Vertix joburg = new Vertix("JoBurg/Tambo");
            Vertix durbs = new Vertix("Durb");
            Vertix pe = new Vertix("PE");
            Vertix capeTown = new Vertix("Cape Town");
            Console.WriteLine(livingstone);


            Graph graph = new Graph();
            graph.AddVertex(livingstone);
            graph.AddVertex(victoriaFalls);
            graph.AddVertex(harare);
            graph.AddVertex(windhoek);
            graph.AddVertex(mauritius);
            graph.AddVertex(joburg);
            graph.AddVertex(durbs);
            graph.AddVertex(pe);
            graph.AddVertex(capeTown);
            Console.WriteLine(graph);


            Edge edge1 = new Edge(livingstone, joburg);
            Edge edge2 = new Edge(joburg, livingstone);

            Edge edge3 = new Edge(victoriaFalls, joburg);
            Edge edge4 = new Edge(joburg, victoriaFalls);

            Edge edge5 = new Edge(harare, joburg);
            Edge edge6 = new Edge(joburg, harare);

            Edge edge7 = new Edge(windhoek, joburg);
            Edge edge8 = new Edge(joburg, windhoek);

            Edge edge9 = new Edge(capeTown, joburg);
            Edge edge10 = new Edge(joburg, capeTown);

            Edge edge11 = new Edge(capeTown, durbs);
            Edge edge12 = new Edge(durbs, capeTown);

            Edge edge13 = new Edge(capeTown, pe);
            Edge edge14 = new Edge(pe, capeTown);

            Edge edge15 = new Edge(pe, joburg);
            Edge edge16 = new Edge(joburg, pe);

            Edge edge17 = new Edge(pe, durbs);
            Edge edge18 = new Edge(durbs, pe);

            Edge edge19 = new Edge(durbs, joburg);
            Edge edge20 = new Edge(joburg, durbs);

            Edge edge21 = new Edge(joburg, mauritius);
            Edge edge22 = new Edge(mauritius, joburg);

            graph.AddNewEdge(edge1);
            graph.AddNewEdge(edge2);
            graph.AddNewEdge(edge3);
            graph.AddNewEdge(edge4);
            graph.AddNewEdge(edge5);
            graph.AddNewEdge(edge6);
            graph.AddNewEdge(edge7);
            graph.AddNewEdge(edge8);
            graph.AddNewEdge(edge9);
            graph.AddNewEdge(edge10);
            graph.AddNewEdge(edge11);
            graph.AddNewEdge(edge12);
            graph.AddNewEdge(edge13);
            graph.AddNewEdge(edge14);
            graph.AddNewEdge(edge15);
            graph.AddNewEdge(edge16);
            graph.AddNewEdge(edge17);
            graph.AddNewEdge(edge18);
            graph.AddNewEdge(edge19);
            graph.AddNewEdge(edge20);
            graph.AddNewEdge(edge21);
            graph.AddNewEdge(edge22);



        }
    }
}
