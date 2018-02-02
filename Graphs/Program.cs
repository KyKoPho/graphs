using System;

namespace Graphs
{

    class Program
    {
        private static Graph<int> graph = new Graph<int>();

        private static Node<int> bridgeNodeOne = new Node<int>(-1);
        private static Node<int> bridgeNodeTwo = new Node<int>(-2, new[] { bridgeNodeOne });

        private static Node<int>[] connections = new Node<int>[2] { bridgeNodeOne, bridgeNodeTwo };

        private static Node<int> firstTree = new Node<int>(1, new[] { new Node<int>(2), new Node<int>(3), connections[1] });
        private static Node<int> secondTree = new Node<int>(4, new[] { connections[0], new Node<int>(5), new Node<int>(6) });
        private static Node<int> thirdTree = new Node<int>(7, new[] { new Node<int>(8), connections[0], new Node<int>(9) });

        static void Main(string[] args)
        {
            graph.AddTree(new Node<int>(0, new[] { firstTree, secondTree, thirdTree }));


            Console.WriteLine("Traversing graph");

            var nodes = graph.Traverse();

            foreach (int value in nodes)
                Console.WriteLine(value);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
