using System;
using System.Collections.Generic;

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

            graph.AddVertex(a, new Dictionary<Point, float> { { b, 7 }, { c, 8 } });
            graph.AddVertex(b, new Dictionary<Point, float> { { a, 7 }, { f, 2 } });
            graph.AddVertex(c, new Dictionary<Point, float> { { a, 8 }, { f, 6 }, { g, 4 } });
            graph.AddVertex(d, new Dictionary<Point, float> { { f, 8 } });
            graph.AddVertex(e, new Dictionary<Point, float> { { h, 1 } });
            graph.AddVertex(f, new Dictionary<Point, float> { { b, 2 }, { c, 6 }, { d, 8 }, { g, 9 }, { h, 3 } });
            graph.AddVertex(g, new Dictionary<Point, float> { { c, 4 }, { f, 9 } });
            graph.AddVertex(h, new Dictionary<Point, float> { { e, 1 }, { f, 3 } });

            Console.WriteLine("Start: " + a);
            graph.ShortestPath(a, h).ForEach(Console.WriteLine);
            Console.WriteLine("End: " + h);

            Console.ReadLine();
        }
    }
}
