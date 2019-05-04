using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Graph<T>
    {
        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }
        public int _size = 0;

        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

        public Vertex<T> AddVertice(T value)
        {
            Vertex<T> vertex = new Vertex<T>(value);
            AdjacencyList.Add(vertex, new List<Edge<T>>());
            _size++;
            return vertex;
        }

        public void AddDirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            AdjacencyList[a].Add(new Edge<T>
            {
                Weight = weight,
                Vertex = b
            });
        }

        public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            AddDirectedEdge(a, b, weight);
            AddDirectedEdge(b, a, weight);

        }

        public List<Vertex<T>> GetVertices()
        {
            List<Vertex<T>> vertexes = new List<Vertex<T>>();
            foreach (var vertice in AdjacencyList.Keys)
            {
                vertexes.Add(vertice);
            }
            return vertexes;
        }

        public void Print()
        {
            foreach (var vertex in AdjacencyList)
            {
                Console.Write($"Vertex: {vertex.Key.Value} ->");
                foreach (var edge in vertex.Value)
                {
                    Console.Write($"{edge.Vertex.Value}, {edge.Weight} ->");
                }
                Console.WriteLine("null");
            }
        }
    }
}
