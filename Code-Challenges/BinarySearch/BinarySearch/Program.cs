using System;

namespace BinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
               //BinarySearch();
        }

        public static int BinarySearch(int[] binary, int key)
        {
           int mP = binary.Length / 2;
            int lft = 0;
            int rgt = binary.Length;
            while (lft <= rgt)
	        {

                if(binary[mP] == key)
                {
                    return mP;
                } else if (binary[mP] < key)
                {
                    lft = mP;
                    mP = ((rgt + lft) / 2);

                } else if (binary[mP] > key)
                {
                    rgt = mP;
                    mP = ((lft + rgt) / 2);
                }
            
	        }
            return -1;
        }
    }
}
