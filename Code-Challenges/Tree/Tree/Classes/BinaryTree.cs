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
        /// 
        /// </summary>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="node"></param>
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
        /// 
        /// </summary>
        /// <returns></returns>
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
        /// 
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
        /// 
        /// </summary>
        /// <returns></returns>
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
