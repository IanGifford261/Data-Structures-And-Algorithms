using sorts;
using System;
using Xunit;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnSortedArrayFromRandom()
        {
            int[] array = { 7, 3, 2, 1, 5 };
            int[] sorted = { 1, 2, 3, 5, 7 };
            Assert.Equal(sorted, Program.InsertionSort(array));
        }

        [Fact]
        public void CanReturnArraySameSort()
        {
            int[] arr = { 1, 2, 3, 5, 7 };
            int[] sorted = { 1, 2, 3, 5, 7 };
            Assert.Equal(sorted, Program.InsertionSort(arr));
        }

        [Fact]
        public void CanReturnArrayFromBackwardsSort()
        {
            int[] arr = { 7, 5, 3, 2, 1 };
            int[] sorted = { 1, 2, 3, 5, 7 };
            Assert.Equal(sorted, Program.InsertionSort(arr));
        }

        [Fact]
        public void CanReturnSameEmptyArray()
        {
            int[] arr = { };
            int[] sorted = { };
            Assert.Equal(sorted, Program.InsertionSort(arr));
        }

        [Fact]
        public void CanReturnOneSameSingleElement()
        {
            int[] arr = { 3 };
            int[] sorted = { 3 };
            Assert.Equal(sorted, Program.InsertionSort(arr));
        }


    }
}
