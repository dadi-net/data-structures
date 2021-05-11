using System;

namespace DataStructures
{
    public class SinglyLinkedList<T>
    {
        public SinglyLinkedListNode<T> Head { get; set; }

        public void AddToHead(T value)
        {
            var next = Head;
            Head = new(value);
            Head.Next = next;
        }

        public void AddToTail(T value)
        {
            if (Head == null)
            {
                Head = new(value);
                return;
            }

            var current = Head;
            while (current.Next != null)
                current = current.Next;

            current.Next = new(value);
        }

        public void Reverse()
        {
            if (Head?.Next == null)
                return;

            var current = Head.Next;
            var next = current.Next;
            Head.Next = null;
            while (current != null)
            {
                current.Next = Head;
                Head = current;
                current = next;
                next = current?.Next;
            }
        }

        public void Print()
        {
            var current = Head;
            while (current != null)
            {
                current.Print();
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
