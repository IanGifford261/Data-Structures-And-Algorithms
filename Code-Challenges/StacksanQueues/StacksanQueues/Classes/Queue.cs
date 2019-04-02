using System;
using System.Collections.Generic;
using System.Text;

namespace StacksanQueues.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Back { get; set; }

        public Queue()
        {            
            Front = null;
            Back = null;
        }

        public Queue(Node node)
        {
            Front = node;
            Back = node;
        }

        public void Enqueue(int value)
        {
            Node newNode = new Node(value);
            Back.Next = newNode;
            Back = newNode;
        }



    }
}
