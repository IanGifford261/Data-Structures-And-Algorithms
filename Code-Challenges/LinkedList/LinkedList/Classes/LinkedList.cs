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
            Node newHead = new Node(value);

            if (Head == null)
            {
                newHead = Head;
            }
            else
            {
                Node.Next(value) = Head;
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
