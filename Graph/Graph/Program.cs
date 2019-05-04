using Graph.Classes;
using System;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<string> graph = new Graph<string>();
            var a = graph.AddVertice("a");
            var b = graph.AddVertice("b");
            var c = graph.AddVertice("c");
            var d = graph.AddVertice("d");

            graph.AddUndirectedEdge(a, b, 5);
            graph.AddUndirectedEdge(b, c, 5);
            graph.AddUndirectedEdge(c, d, 5);
            graph.AddUndirectedEdge(d, a, 5);

            graph.Print();
        }
    }
}
