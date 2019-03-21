using System;
using Xunit;
using BinarySearch;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestForIfTheSearchKeyIsInTheArray()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            int testResult = Program.BinarySearch(numbers, 4);
            Assert.Equal(3, testResult);

        }

        [Fact]
        public void TestForIfTheSearchKeyIsOutSideOfTheArray()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            int testResult = Program.BinarySearch(numbers, 7);
            Assert.Equal(-1, testResult);
        }

        //[Fact]
        //public void TestForIfTheArrayIsEmpty()
        //{
        //    int[] numbers = new int[6];
        //    int testResult = Program.BinarySearch(numbers, 5);
        //    Assert.Equal(-1, testResult);
        //}
    }
}
