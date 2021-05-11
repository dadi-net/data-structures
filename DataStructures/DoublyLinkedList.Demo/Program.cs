using DataStructures;
using System;

namespace DoublyLinkedList.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new DoublyLinkedList<int>();

            linkedList.AddToHead(5);
            linkedList.AddToHead(3);
            linkedList.AddToHead(1);
            linkedList.Print();

            linkedList.AddToTail(7);
            linkedList.AddToTail(9);
            linkedList.AddToTail(11);
            linkedList.Print();

            linkedList.ReversePointers();
            linkedList.Print();

            linkedList.ReverseValues();
            linkedList.Print();

            Console.ReadKey();
        }
    }
}
