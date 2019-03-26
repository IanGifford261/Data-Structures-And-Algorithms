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
            SLinkedList newList = new SLinkedList();
            Assert.Null(newList.Head);
        }

        [Fact]
        public void TestIfInsertIntoLinkList()
        {
            SLinkedList newList = new SLinkedList();
            newList.Insert(5);
            Assert.Equal(5, newList.Head.Value);
        }

        [Fact]
        public void TestIfHeadPointsToFirstNode()
        {
            SLinkedList newList = new SLinkedList();
            newList.Insert(5);
            newList.Insert(25);
            Assert.Equal(5, newList.Head.Next.Value);
        }

        [Fact]
        public void TestIfNodeHasMultiInserts()
        {
            SLinkedList newList = new SLinkedList();
            newList.Insert(5);
            newList.Insert(10);
            newList.Insert(15);
            Assert.Equal(15, newList.Head.Value);
        }


        [Fact]
        public void TestIfIncludesCanReturnTrue()
        {
            SLinkedList newList = new SLinkedList();
            newList.Insert(5);
            newList.Insert(15);
            newList.Insert(25);
            Assert.True(newList.Includes(15));
        }

        [Fact]
        public void TestIfIncludesCanReturnFalse()
        {
            SLinkedList newList = new SLinkedList();
            newList.Insert(5);
            newList.Insert(55);
            newList.Insert(50);
            Assert.False(newList.Includes(99));
        }

    }
}
