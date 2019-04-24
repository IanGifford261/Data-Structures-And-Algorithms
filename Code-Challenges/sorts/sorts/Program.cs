using System;

namespace sorts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 7, 3, 5, 6 };
            //int[] result = InsertionSort(array);
            int[] result = MergeSort(array);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        /// <summary>
        /// Takes an array of integers, and returns a sorted array
        /// </summary>
        /// <param name="arr"> the value for int[] </param>
        /// <returns> a sorted int[] arr </returns>
        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while (j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;

                }
                arr[j + 1] = temp;
            }
            return arr;
        }

        /// <summary>
        /// Divides the array recursibely, merges the sub arrays
        /// </summary>
        /// <param name="arr"> the value for int[] </param>
        /// <returns></returns>
        public static int[] MergeSort(int[] arr)
        {
            int n = arr.Length;

            if (n > 1)
            {
                int mP = arr.Length / 2;

                int leftArr = mP + n;
                int rightArr = mP - n;


            }
        }


    }
}
