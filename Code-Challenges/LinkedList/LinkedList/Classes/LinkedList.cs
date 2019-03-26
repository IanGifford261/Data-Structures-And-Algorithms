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
         /// 
         /// </summary>
         /// <param name="value"></param>
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
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <returns></returns>
        public List<int> Print()
        {
            //Learned this <int> in class, Amanda gave the approval to use like this.
            Current = Head;
            List<int> values = new List<int>();
            while (Current.Next != null)
            {
                values.Add(Current.Value);
                Current = Current.Next;
            }
            return values;
        }

    }
}
