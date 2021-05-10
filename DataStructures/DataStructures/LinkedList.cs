﻿using System;

namespace DataStructures
{
    public class LinkedList<T>
    {
        public LinkedListNode<T> First { get; set; }

        public void AddToTail(T value)
        {
            if (First == null)
            {
                First = new(value);
                return;
            }

            var current = First;
            while (current.Next != null)
                current = current.Next;

            current.Next = new(value);
        }

        public void AddToHead(T value)
        {
            var next = First;
            First = new(value);
            First.Next = next;
        }

        public void Reverse()
        {
            if (First?.Next == null)
                return;

            var current = First.Next;
            var next = current.Next;
            First.Next = null;
            while (current != null)
            {
                current.Next = First;
                First = current;
                current = next;
                next = current?.Next;
            }
        }

        public void Print()
        {
            var current = First;
            while (current != null)
            {
                current.Print();
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
