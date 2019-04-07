using System;
using System.Collections.Generic;
using System.Text;


namespace Tree.Classes
{
    public class BinaryTree
    {
        public static Node Root { get; set; }
        public static List<int> ValueList = new List<int>();
        //Pre
        public static int[] PreOrder()
        {
            if(ValueList.Count > 0)
            {
                ValueList.Clear();           
            }

            PreorderRecurs(Root);
            int[] arr = new int[ValueList.Count];
            int i = 0;
            foreach (var item in ValueList)
            {
                arr[i] = item;
                i++;
            }
            return arr;

        }

        public static void PreorderRecurs(Node node)
        {
            ValueList.Add(node.Value);

            if (node.Left != null)
            {
                PreorderRecurs(node.Left);
            }
            if (node.Right != null)
            {
                PreorderRecurs(node.Right);
            }
        }

        //In
        public static int[] InOrder()
        {

        }

        //Post
        public static int[] PostOrder()
        {

        }

    }
}
