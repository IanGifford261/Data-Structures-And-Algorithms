using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinarySearchTree
    {
        public static Node Root { get; set; }

        public static void Add(int val)
        {
            Node newNode = new Node(val);

            if (Root == null)
            {
                Root = newNode;
                return;
            }



        }
        
    }
}
