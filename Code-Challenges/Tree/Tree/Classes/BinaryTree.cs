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
            new int[] arr = new int[ValueList.Count];
            for (int i = 0; i < ValueList.Count; i++)
            {
                ValueList = 
            }

        }

        public static void PreorderRecurs(Node node)
        {
            ValueList.Add.node.
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
