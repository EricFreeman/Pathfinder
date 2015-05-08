using System;

namespace Pathfinder.Demo
{
    public class Program
    {
        static void Main()
        {
            var graph = new Graph();

            var a = new Point(0, 0);
            var b = new Point(1, 0);
            var c = new Point(2, 0);
            var d = new Point(0, 1);
            var e = new Point(1, 1);
            var f = new Point(2, 1);
            var g = new Point(0, 3);
            var h = new Point(1, 3);

            graph.AddVertex(a, b, c);
            graph.AddVertex(b, a, f);
            graph.AddVertex(c, a, f, g);
            graph.AddVertex(d, f);
            graph.AddVertex(e, h);
            graph.AddVertex(f, b, c, d, g, h);
            graph.AddVertex(g, c, f);
            graph.AddVertex(h, e, f);

            Console.WriteLine("Start: " + a);
            graph.ShortestPath(a, h).ForEach(Console.WriteLine);
            Console.WriteLine("End: " + h);

            Console.ReadLine();
        }
    }
}
