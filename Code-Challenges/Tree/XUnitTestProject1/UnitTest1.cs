using System;
using Xunit;
using Tree.Classes;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestForEmptyTreeInstantiation()
        {
            BinaryTree test = new BinaryTree();
            Assert.Null(test.Root);
        }

        [Fact]
        public void TestForTreeWithSingleRoot()
        {
            BinaryTree test = new BinaryTree(5);
            Assert.Equal(5, test.Root.Value);
        }

        //[Fact]
        //public void TestForAddLeftAndRightChild()
        //{
        //    BinarySearchTree test = new BinarySearchTree();
        //    //test.Root = new Node(10);
        //    test.Add(10);
        //    test.Add(5);

        //    Assert.Equal(5, test.Root.Left.Value);
        //}

        //[Fact]
        //public void TestForEmptyTreeInstantiation()
        //{
        //    BinaryTree test = new BinaryTree();
        //    List<int> testing = new List<int> { };
        //    Assert.Equal(testing, test.)
        //}

        //[Fact]
        //public void TestForEmptyTreeInstantiation()
        //{
        //    BinaryTree test = new BinaryTree();
        //    List<int> testing = new List<int> { };
        //    Assert.Equal(testing, test.)
        //}
    }
}
