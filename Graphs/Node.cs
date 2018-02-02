using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class Node<T> where T : struct
    {
        public readonly T Value;
        public ICollection<Node<T>> Children { get; } = new List<Node<T>>();
        public Node(T value)
        {
            Value = value;
        }

        public Node(T value, IEnumerable<Node<T>> children)
        {
            Value = value;
            foreach (var child in children)
                AddChild(child);
        }

        public void AddChild(Node<T> child)
        {
            Children.Add(child);
        }
    }
}
