using System;
using System.Collections.Generic;
using System.Text;


namespace Tree.Classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        /// <summary>
        /// Adds a value to the tree, if no root exists, it creates a new one with the input value as current.
        /// </summary>
        /// <param name="val">Number input</param>
        public void Add(int val)
        {
            Node newNode = new Node(val);

            if (Root == null)
            {
                Root = newNode;
                return;
            }

            Node Current = Root;
            while (Current != null)
            {
                if (Current.Value > val)
                {
                    if (Current.Left is null)
                    {
                        Current.Left = newNode;
                    }

                    Current = Current.Left;
                }
                
                if (Current.Value < val && Current.Right != null)
                {
                    if (Current.Right is null)
                    {
                        Current.Right = newNode;
                    }
                    Current = Current.Right;
                }
            }
        }

        /// <summary>
        /// Loops throught to find a value within the tree.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public bool Contains(int val)
        {
            Node current = Root;
            while (current.Value != val)
            {
                if (val == current.Value)
                {
                    return true;
                }
                if (current.Value > val && current.Right != null)
                {
                    current = current.Right;                    
                }                          
                if (current.Value < val && current.Left != null)
                {
                    current = current.Left;
                }
            }
            return false;
        }

        public void BreadthFirst()
        {
            Node queue = 
            

        }
    }
}
