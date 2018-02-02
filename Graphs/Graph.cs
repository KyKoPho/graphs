using System.Collections.Generic;

namespace Graphs
{
    public class Graph<T> where T : struct
    {
        public ICollection<Node<T>> Nodes { get; } = new List<Node<T>>();

        public void AddTree(Node<T> tree)
        {
            Nodes.Add(tree);
        }
    }
}
