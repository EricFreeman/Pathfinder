using System;
using System.Collections.Generic;

namespace Pathfinder
{
    public class Graph
    {
        private readonly Dictionary<Point, Dictionary<Point, float>> _vertices = new Dictionary<Point, Dictionary<Point, float>>();

        public void AddVertex(Point name, Dictionary<Point, float> edges)
        {
            _vertices[name] = edges;
        }

        public List<Point> ShortestPath(Point start, Point finish)
        {
            var previous = new Dictionary<Point, Point>();
            var distances = new Dictionary<Point, int>();
            var nodes = new List<Point>();

            List<Point> path = null;

            foreach (var vertex in _vertices)
            {
                if (vertex.Key == start)
                {
                    distances[vertex.Key] = 0;
                }
                else
                {
                    distances[vertex.Key] = int.MaxValue;
                }

                nodes.Add(vertex.Key);
            }

            while (nodes.Count != 0)
            {
                nodes.Sort((x, y) => (int)(distances[x] - distances[y]));

                var smallest = nodes[0];
                nodes.Remove(smallest);

                if (smallest.Equals(finish))
                {
                    path = new List<Point>();
                    while (previous.ContainsKey(smallest))
                    {
                        path.Add(smallest);
                        smallest = previous[smallest];
                    }

                    break;
                }

                if (distances[smallest] == int.MaxValue)
                {
                    break;
                }

                foreach (var neighbor in _vertices[smallest])
                {
                    var alt = distances[smallest] + neighbor.Value;
                    if (alt < distances[neighbor.Key])
                    {
                        distances[neighbor.Key] = (int)alt;
                        previous[neighbor.Key] = smallest;
                    }
                }
            }

            return path;
        }
    }
}