using System;
using Xunit;
using StacksanQueues.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestForPushOntoStack()
        {
            Stack stackTest = new Stack();
            Node newNode = new Node(1);
            stackTest.PushNode(newNode);
            Assert.Equal(1, stackTest.Top.Val);
        }
    }
}
