using System;
using System.Collections.Generic;

namespace Pathfinder.Demo
{
    public class Program
    {
        static void Main()
        {
            var g = new Graph();
            g.AddVertex('A', new Dictionary<char, int> { { 'B', 7 }, { 'C', 8 } });
            g.AddVertex('B', new Dictionary<char, int> { { 'A', 7 }, { 'F', 2 } });
            g.AddVertex('C', new Dictionary<char, int> { { 'A', 8 }, { 'F', 6 }, { 'G', 4 } });
            g.AddVertex('D', new Dictionary<char, int> { { 'F', 8 } });
            g.AddVertex('E', new Dictionary<char, int> { { 'H', 1 } });
            g.AddVertex('F', new Dictionary<char, int> { { 'B', 2 }, { 'C', 6 }, { 'D', 8 }, { 'G', 9 }, { 'H', 3 } });
            g.AddVertex('G', new Dictionary<char, int> { { 'C', 4 }, { 'F', 9 } });
            g.AddVertex('H', new Dictionary<char, int> { { 'E', 1 }, { 'F', 3 } });

            g.ShortestPath('A', 'H').ForEach(Console.WriteLine);

            Console.ReadLine();
        }
    }
}
