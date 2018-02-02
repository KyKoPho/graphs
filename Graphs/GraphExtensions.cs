using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public static class GraphExtensions
    {
        public static IEnumerable<T> Traverse<T>(this Graph<T> graph) where T : struct
        {

            foreach (Node<T> node in graph.Nodes)
            {
                foreach (var child in Traverse(node))
                    yield return child;
            }
        }

        private static IEnumerable<T> Traverse<T>(Node<T> tree) where T : struct
        {
            HashSet<Node<T>> visitedNodes = new HashSet<Node<T>>(tree.Children.Count + 1);
            yield return tree.Value;
            foreach (var child in tree.Children)
            {
                foreach (var node in Traverse(child))
                {
                    if (!visitedNodes.Contains(node))
                    {
                        visitedNodes.Add(node);
                        yield return node;

                    }
                }
            }
        }
    }
}
