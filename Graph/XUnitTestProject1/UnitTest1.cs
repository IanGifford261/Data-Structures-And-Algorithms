using Graph.Classes;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanCreateOneVertice()
        {
            Vertex<string> vertex = new Vertex<string>("Node1");
            Assert.Equal("Node1", vertex.Value);
        }

        [Fact]
        public void CanCreateEdge()
        {
            Vertex<string> vertex = new Vertex<string>("Node1");
            Edge<string> edge = new Edge<string>();
            edge.Vertex = vertex;
            Assert.Equal("Node1", edge.Vertex.Value.ToString());
        }

        //[Fact]
        //public void CanRetrieveNodes()
        //{
        //    Graph<string> graph = new Graph<string>();
        //    Assert.IsType(Graph<string>(graph);
        //}
    }
}
