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

        public void PushNode(Node newNode)
        {
            newNode.Next = Head;
            Head = newNode;
        }

        public void PushValue(int val)
        {
            Node push = new Node(val);
            push.Next = Head;
            Head = push;
        }


    }
}
