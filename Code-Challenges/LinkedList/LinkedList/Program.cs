using System;
using LinkedList.Classes;
namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" It's a small world after all.");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            SLinkedList newList = new SLinkedList();
            newList.Insert(5);  
            //newList.Append();
            newList.Print();


        }
    }
}
