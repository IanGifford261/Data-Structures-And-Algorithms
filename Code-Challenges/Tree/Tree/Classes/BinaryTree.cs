using System;
using System.Collections.Generic;
using System.Text;


namespace Tree.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public List<int> ValueList = new List<int>();

        public BinaryTree()
        {

        }
        
        public BinaryTree(int val)
        {
            Root = new Node(val);
        }

        /// <summary>
        /// Pre order traversal of a BT
        /// </summary>
        /// <returns> Returns arr </returns>
        public int[] PreOrder()
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

        /// <summary>
        /// Recursion of Preorder
        /// </summary>
        /// <param name="node"> name of the Node Arg.</param>
        public void PreorderRecurs(Node node)
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

        /// <summary>
        /// In order traversal.
        /// </summary>
        /// <returns>returns arr of valuelist</returns>
        public int[] InOrder()
        {
            if (ValueList.Count > 0)
            {
                ValueList.Clear();
            }

            InOrderRecurs(Root);
            int[] arr = new int[ValueList.Count];
            int i = 0;
            foreach (var item in ValueList)
            {
                arr[i] = item;
                i++;
            }
            return arr;

        }

        /// <summary>
        /// Recursion of In order
        /// </summary>
        /// <param name="node"></param>
        public void InOrderRecurs(Node node)
        {
            if (node.Left != null)
            {
                InOrderRecurs(node.Left);
            }

            ValueList.Add(node.Value);

            if (node.Right != null)
            {
                InOrderRecurs(node.Right);
            }

        }

        /// <summary>
        /// Post Order Traversal of BT
        /// </summary>
        /// <returns>returns arr of valuelist</returns>
        public int[] PostOrder()
        {
            if (ValueList.Count > 0)
            {
                ValueList.Clear();
            }

            PostOrderRecurs(Root);
            int[] arr = new int[ValueList.Count];
            int i = 0;
            foreach (var item in ValueList)
            {
                arr[i] = item;
                i++;
            }
            return arr;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        public void PostOrderRecurs(Node node)
        {
            if (node.Left != null)
            {
                PostOrderRecurs(node.Left);
            }
            if (node.Right != null)
            {
                PostOrderRecurs(node.Right);
            }

            ValueList.Add(node.Value);
        }

    }    
}
