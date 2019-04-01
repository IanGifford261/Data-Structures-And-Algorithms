using System;
using System.Collections.Generic;
using System.Text;

namespace StacksanQueues.Classes
{
    public class Stack
    {
        public Node Head { get; set; }

        public Stack (Node node)
        {
            Head = node;
        }

        public void PushInto(int val)
        {
            Node push = new Node(val);
            push.Next = Head;
            Head = push;
        }
    }
}
