using System;

namespace DataStructures
{
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }

        public void AddToHead(T value)
        {
            var next = Head;
            Head = new(value);
            Head.Next = next;

            if (next != null)
                next.Prev = Head;

            Tail = Tail ?? Head;
        }

        public void AddToTail(T value)
        {
            var prev = Tail;
            Tail = new(value);
            Tail.Prev = prev;

            if (prev != null)
                prev.Next = Tail;

            Head = Head ?? Tail;
        }

        public void ReversePointers()
        {
            if (Head == null || Head == Tail)
                return;

            Head.Prev = Head.Next;
            Head.Next = null;
            Tail.Next = Tail.Prev;
            Tail.Prev = null;

            var current = Head.Prev;
            while (current != Tail)
            {
                var next = current.Next;
                current.Next = current.Prev;
                current.Prev = next;
                current = next;
            }

            Tail = Head;
            Head = current;
        }

        public void ReverseValues()
        {
            if (Head == null || Head == Tail)
                return;

            var currentFront = Head;
            var currentBack = Tail;

            while(currentFront != currentBack && currentFront.Prev != currentBack)
            {
                var temp = currentBack.Value;
                currentBack.Value = currentFront.Value;
                currentFront.Value = temp;

                currentFront = currentFront.Next;
                currentBack = currentBack.Prev;
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
