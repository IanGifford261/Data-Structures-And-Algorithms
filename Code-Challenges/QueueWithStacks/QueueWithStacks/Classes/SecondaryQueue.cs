using System;
using System.Collections.Generic;
using System.Text;
using StacksanQueues.Classes;

namespace QueueWithStacks.Classes
{
    public class SecondaryQueue : Stack
    {
        public Node Front { get; set; }
        public Node Back { get; set; }

        public void Enqueue(int value)
        {
            Node newNode = new Node(value);
            Back.Next = newNode;
            Back = newNode;
        }

        public void Dequeue()
        {

        }
    }
}
