using System;
using System.Collections.Generic;
using System.Text;

namespace StacksanQueues.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        public Stack()
        {
            Top = null;
        }

        public void PushNode(Node newNode)
        {
            newNode.Next = Top;
            Top = newNode;
        }

        public void PushValue(int val)
        {
            Node push = new Node(val);
            push.Next = Top;
            Top = push;
        }

        public Node PopOff()
        {
            Node temporaryNode = Top;

            Top = Top.Next;
            temporaryNode.Next = null;
            return temporaryNode;
        }

        public Node Peek()
        {
            return Top;
        }

    }
}
