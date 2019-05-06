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
    }
}
