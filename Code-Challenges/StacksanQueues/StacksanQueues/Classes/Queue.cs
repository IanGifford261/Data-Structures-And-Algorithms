using System;
using System.Collections.Generic;
using System.Text;

namespace StacksanQueues.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Back { get; set; }

        public Queue(Node node)
        {            
            Front = node;
        }



    }
}
