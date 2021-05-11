using System;

namespace DataStructures
{
    public class DoublyLinkedListNode<T>
    {
        public T Value { get; set; }
        public DoublyLinkedListNode<T> Next { get; set; }
        public DoublyLinkedListNode<T> Prev { get; set; }

        public DoublyLinkedListNode(T value) => Value = value;

        public void Print()
        {
            Console.Write(Value);
            if (Next != null)
                Console.Write("<->");
        }
    }
}
