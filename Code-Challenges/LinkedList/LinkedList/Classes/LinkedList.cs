using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LinkedList
    {        
        public Node Head { get; set; }

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

        public void Includes()
        {



        }

        public void Print()
        {



        }


    }
}
