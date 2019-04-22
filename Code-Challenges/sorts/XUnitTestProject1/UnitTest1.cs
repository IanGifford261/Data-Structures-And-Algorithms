using sorts;
using System;
using Xunit;
using static sorts.Program;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnSortedArrayFromRandom()
        {
            int[] array = { 2, 5, 7, 3 };
            int[] sorted = { 2, 3, 5, 7 };
            Assert.Equal(sorted, InsertionSort(array));
        }

        [Fact]
        public void CanReturnArraySameSort()
        {

        }

        [Fact]
        public void CanReturnArrayFromBackwardsSort()
        {

        }

        [Fact]
        public void CanReturnSameEmptyArray()
        {

        }

        [Fact]
        public void CanReturnONeSameSingleElement()
        {

        }
    }
}
