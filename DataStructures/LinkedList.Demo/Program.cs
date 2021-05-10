using DataStructures.LinkedList;
using System;

namespace LinkedList.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList<int>();

            linkedList.AddToHead(5);
            linkedList.AddToHead(3);
            linkedList.AddToHead(1);
            linkedList.Print();

            linkedList.AddToTail(7);
            linkedList.AddToTail(9);
            linkedList.Print();

            linkedList.Reverse();
            linkedList.Print();

            Console.ReadKey();
        }
    }
}
