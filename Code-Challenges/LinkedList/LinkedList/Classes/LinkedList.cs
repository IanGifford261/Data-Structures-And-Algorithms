using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LinkedList
    {        
        public Node Head { get; set; }
        //While reviewing in class Amanda showed this, and set it makes the process easier.
        public Node Current { get; set; }

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

        public bool Includes()
        {
            Current = Head;
            while(Current != null)
            {
                if(Current.Value == value)
            }



        }

        public void Print()
        {



        }

    }
}
