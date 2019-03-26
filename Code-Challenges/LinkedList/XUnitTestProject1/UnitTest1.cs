using System;
using Xunit;
using LinkedList.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestToInstantiateEmptyLinkedList()
        {
            LinkedList newList = new LinkedList();
            Assert.Null(newList.Head);
        }

        }
        [Fact]
        public void TestIfValueIsFound()
        {
            LinkedList newList = new LinkedList();
            newList.Insert(5);

        }

        [Fact]
        public void ()
        {
    }
}
