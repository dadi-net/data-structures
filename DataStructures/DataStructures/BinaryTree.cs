using System.Collections.Generic;

namespace DataStructures
{
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; set; }

        public void InOrder() => InOrder(Root);
        public void InOrder(BinaryTreeNode<T> node)
        {
            if (node == null)
                return;

            InOrder(node?.Left);
            node.Print();
            InOrder(node?.Right);
        }

        public void PreOrder() => PreOrder(Root);
        public void PreOrder(BinaryTreeNode<T> node)
        {
            if (node == null)
                return;

            node.Print();
            PreOrder(node?.Left);
            PreOrder(node?.Right);
        }

        public void PostOrder() => PostOrder(Root);
        public void PostOrder(BinaryTreeNode<T> node)
        {
            if (node == null)
                return;

            PostOrder(node?.Left);
            PostOrder(node?.Right);
            node.Print();
        }

        public void LevelOrder()
        {
            var queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(Root);
            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                node.Print();

                if (node.Left != null)
                    queue.Enqueue(node.Left);

                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }
        }
    }
}
