using System.Collections.Generic;

namespace Pathfinder
{
    public class Graph
    {
        private readonly Node[,] _graph;

        public Graph(Node[,] graph)
        {
            _graph = graph;
        }

        public List<Node> FindPath(Location start, Location end)
        {
            var startNode = _graph[start.X, start.Y];
            var endNode = _graph[end.X, end.Y];

            return BreadthFirstSearch(new List<Node>(), startNode, endNode);
        }

        private List<Node> BreadthFirstSearch(List<Node> nodes, Node currentNode, Node endNode)
        {
            nodes.Add(currentNode);

            if (currentNode == endNode)
            {
                return nodes;
            }
            
            if (currentNode.Connections == null)
            {
                return null;
            }
            
            foreach (var nextNode in currentNode.Connections)
            {
                return BreadthFirstSearch(nodes, nextNode, endNode);
            }

            return null;
        }
    }
}