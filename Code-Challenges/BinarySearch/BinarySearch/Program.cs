using System;

namespace BinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            BinarySearch(numbers, 4);
        }

        public static int BinarySearch(int[] binary, int key)
        {
           int mP = binary.Length / 2;
            int lft = 0;
            int rgt = binary.Length - 1;

            while (lft <= rgt)
	        {
                mP = ((rgt + lft) / 2);

                if (binary[mP] == key)
                {
                    return mP;

                } else if (binary[mP] < key)
                {
                    lft = mP + 1;

                } else if (binary[mP] > key)
                {
                    rgt = mP - 1;
                }   
	        }
            return -1;
        }
    }
}
