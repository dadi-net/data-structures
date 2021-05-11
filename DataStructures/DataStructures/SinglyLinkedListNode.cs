using System;

namespace DataStructures
{
    public sealed class SinglyLinkedListNode<T>
    {
        public T Value { get; set; }
        public SinglyLinkedListNode<T> Next { get; set; }

        public SinglyLinkedListNode(T value) => Value = value;

        public void Print()
        {
            Console.Write(Value);
            if (Next != null)
                Console.Write("->");
        }
    }
}
