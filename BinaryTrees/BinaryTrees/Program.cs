using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.root = new Node(1);
            binaryTree.root.left = new Node(2);
            binaryTree.root.right = new Node(3);
            binaryTree.root.left.left = new Node(4);
            binaryTree.root.left.right = new Node(5);

            //Pre Order Traversal
            Console.WriteLine("Pre Order Traversal");
            binaryTree.PreOrderTraversal();

            //In Order Traversal
            Console.WriteLine("In Order Traversal");
            binaryTree.InOrderTraversal();

            //Post Order Traversal
            Console.WriteLine("Post Order Traversal");
            binaryTree.PostOrderTraversal();

            //Level Order Traversal
            IList<IList<int>> result = binaryTree.LevelOrderTraversal();
            Console.WriteLine("Level Order Traversal");
            for (int i = 0; i < result.Count; i++)
            {
                StringBuilder sb = new StringBuilder();
                foreach(var item in result[i])
                {
                    sb.Append(item);
                }
                Console.WriteLine("Result at Level " + i + " is " + sb.ToString());
            }

            //Find Parent of a Node
            binaryTree.FindParentofNode(4);

            //Find Sibling of a Node
            binaryTree.FindSiblingofaNode(3);

            Console.ReadKey();
            //08/02/2020
            //BFS
            //DFS

            //08/03/2020
            //Find Cousin of a Node
            //Sum of all leaf nodes
            //Branch Sum
            //Min Depth or height
            //Max Depth or height
            //Boundry Traversal
            //Check If binary trees are identical

            //08/04/2020
            //Check if binary tree is part of subtree
            //Top View
            //Bottom View
            //Left View
            //Right View
            //Delete Binary Tree
            //Diameter of Binary Tree
            //Delete Binary Tree

            //08/05/2020
            //LCS
            //Max Path Sum
            //Reverse Alternate Levels
            //Invert Binary Tree
            //Closed Value in BST
            //Valid Binary Tree
            //Flatten Binary Tree
            //Max Path Sum

            //08/06/2020
            //Node Depth
            //Mirror Tree
        }
    }
}
