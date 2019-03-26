using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class SLinkedList
    {        
        public Node Head { get; set; }
        //While reviewing in class Amanda showed this, and set it makes the process easier.
        public Node Current { get; set; }
         
         /// <summary>
         /// Method to create a new head if none exists, otherwise inserts a new node at the beginning.
         /// </summary>
         /// <param name="value"> user input</param>
        public void Insert(int value)
        {                 
            Node node = new Node(value);

            if (Head == null)
            {
                Head = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
        }
        /// <summary>
        /// Method to search values
        /// </summary>
        /// <param name="value">Value to be searched within the Linked List</param>
        /// <returns>If current value equals the searched value returns true, otherwise returns false</returns>
        public bool Includes(int value)
        {
            Current = Head;
            while (Current != null)
            {
                if (Current.Value == value)
                {
                    return true;
                }
                Current = Current.Next;
            }
            return false;
        }

        /// <summary>
        /// Prints a list of values in nodes
        /// </summary>
        /// <returns>Prints to console the values in the nodes</returns>
        public List<int> Print()
        {
            //Learned this <int> in class, Amanda gave the approval to use like this.
            Current = Head;
            List<int> values = new List<int>();
            while (Current != null)
            {
                Console.Write($"{Current.Value} --->");
                values.Add(Current.Value);
                Current = Current.Next;
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.ReadLine();
            return values;     
        }

        public void Append(int val)
        {
            Node newInsertedNode = new Node(val);

            Node Current = Head;
            while(Current != null)
            {
                if (Current.Next == null)
                {
                    Current.Next = newInsertedNode;
                }
                Current = Current.Next;
            }
        }

        public void InsertBefore(int val, int newVal)
        {            
            Node newInsertedNode = new Node(newVal);
            Node Current = Head;
            if (Current.Value == val)
            {
                Insert(val);
            }
            while (Current.Next != null)
            {
                if (Current.Next.Value == val)
                {
                    newInsertedNode.Next = Current.Next;
                    Current.Next = newInsertedNode;
                    return;
                }
                Current = Current.Next;
            }
        }

        public void InsertAfter(int val, int newNode)
        {          
            Node newInsertedNode = new Node(newNode);
            Node Current = Head;
            while (Current.Next != null)
            {
                if (Current.Next.Value == val)
                {
                    newInsertedNode.Next = Current.Next;
                    Current.Next = newInsertedNode;
                    return;
                }
                Current = Current.Next;
            }           

        }
    }
}
