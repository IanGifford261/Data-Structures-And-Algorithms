using System;
using System.Collections.Generic;
using System.Text;

namespace StacksanQueues.Classes
{
    public class Node
    {
        public int Val { get; set; }
        public Node Next { get; set; }

        public Node (int value)
        {
            Val = value;
        }
    }
}
