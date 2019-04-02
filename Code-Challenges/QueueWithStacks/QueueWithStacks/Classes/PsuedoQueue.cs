using System;
using System.Collections.Generic;
using System.Text;
using StacksanQueues.Classes;

namespace QueueWithStacks.Classes
{
    public class PsuedoQueue : Stack
    {
        public Stack S1 { get; set; }
        public Stack S2 { get; set; }

        public void Enqueue(int value)
        {
            S1.PushValue(value);
        }

        public void Dequeue()
        {
            S2.PopOff();

            if(S2 == null)
            {
                S2.PushValue(Stack.S1.PopOff());
            }

        }
    }
}
