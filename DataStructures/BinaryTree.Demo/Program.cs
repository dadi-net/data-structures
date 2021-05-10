using DataStructures;
using System;

namespace BinaryTree.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var binaryTree = new BinaryTree<int>()
            {
                Root = new BinaryTreeNode<int>(1)
                {
                    Left = new BinaryTreeNode<int>(2)
                    {
                        Left = new BinaryTreeNode<int>(4),
                        Right = new BinaryTreeNode<int>(5)
                    },
                    Right = new BinaryTreeNode<int>(3)
                    {
                        Left = new BinaryTreeNode<int>(6),
                        Right = new BinaryTreeNode<int>(7)
                    }
                }
            };

            binaryTree.InOrder();
            Console.WriteLine();
            binaryTree.PreOrder();
            Console.WriteLine();
            binaryTree.PostOrder();
            Console.WriteLine();
            binaryTree.LevelOrder();
            Console.WriteLine();
        }
    }
}
