﻿using System;
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

            Node Current = Root;
            while (true)
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
        
        public static bool Contains(int val)
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
    }
}