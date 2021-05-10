using System;

namespace DataStructures
{
    public sealed class LinkedListNode<T>
    {
        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T value) => Value = value;

        public void Print()
        {
            Console.Write(Value);
            if (Next != null)
                Console.Write("->");
        }
    }
}
