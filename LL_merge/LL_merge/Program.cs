using System;
using LinkedList.Classes;

namespace LL_merge
{
    class Program
    {
        public static void Main()
        {
            SLinkedList list1 = new SLinkedList();
            SLinkedList list2 = new SLinkedList();

            list1.Insert(1);
            list1.Insert(2);
            list1.Insert(3);
            list2.Insert(4);
            list2.Insert(5);
            list2.Insert(6);

            Node resultMerge = MergeList(list1, list2);
            Console.WriteLine(resultMerge.Value);
        }

        public static Node MergeList(SLinkedList list1, SLinkedList list2)
        {
            Node MainList = list1.Head;
            Node SecList = list2.Head;
            
            while (list1.Head != null && list2.Head != null)
            {
                list2.Current = list1.Head.Next;
                list1.Head.Next = list2.Current;
                
            }
            return list1.Head;
        }
    }
}

