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
            binaryTree.root = new Node(4);
            binaryTree.root.left = new Node(2);
            binaryTree.root.right = new Node(6);
            binaryTree.root.left.left = new Node(1);
            binaryTree.root.left.right = new Node(3);
            binaryTree.root.right.left = new Node(5);
            binaryTree.root.right.right = new Node(7);

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
            IList<IList<int>> levelOrderTraversal = binaryTree.LevelOrderTraversal();
            Console.WriteLine("Level Order Traversal");
            for (int i = 0; i < levelOrderTraversal.Count; i++)
            {
                StringBuilder sblevelOrderTraversal = new StringBuilder();
                foreach(var item in levelOrderTraversal[i])
                {
                    sblevelOrderTraversal.Append(item);
                }
                Console.WriteLine("Result at Level " + i + " is " + sblevelOrderTraversal.ToString());
            }

            //Find Parent of a Node
            binaryTree.FindParentofNode(4);

            //Find Sibling of a Node
            binaryTree.FindSiblingofaNode(3);

            //Find Cousins of a Node
            Console.WriteLine("Is nodes 3 and 5 cousins: " + binaryTree.IsCousins(3, 5));

            //Vertical Order Traversal
            IList<IList<int>> verticalOrderTraversal = binaryTree.VerticalOrderTraversal();
            for (int i = 0; i < verticalOrderTraversal.Count; i++)
            {
                StringBuilder sbverticalOrderTraversal = new StringBuilder();
                foreach (var item in verticalOrderTraversal[i])
                {
                    sbverticalOrderTraversal.Append(item);
                }
                Console.WriteLine("Result at Vertical Order Traversal is: " + sbverticalOrderTraversal.ToString());
            }

            //Minimum Depth/Height of Binary Tree
            Console.WriteLine("Minimum Depth of the Binary Tree is: " + binaryTree.MinDepth(binaryTree.root));

            //Maximum Depth/Height of Binary Tree
            Console.WriteLine("Maximum Depth of the Binary Tree is: " + binaryTree.MaxDepth(binaryTree.root));

            //Diameter of Binary Tree
            Console.WriteLine("Diameter of the Binary Tree is: " + binaryTree.DiamterofBinaryTree(binaryTree.root));

            //Sum of all Leaf Nodes
            binaryTree.SumofAllLeafNodes();

            //Sum of all Left Leaf Nodes
            binaryTree.SumofAllLeftLeafNodes();

            //Sum of all Right Leaf Nodes
            binaryTree.SumofAllRightLeafNodes();

            //Closest Value in Binary Tree
            binaryTree.ClosestValueInBinaryTree(binaryTree.root, 3.8);

            //Delete a Node in Binary Tree
            BinaryTree deleteNodeBinaryTree = new BinaryTree();
            deleteNodeBinaryTree.root = new Node(5);
            deleteNodeBinaryTree.root.left = new Node(3);
            deleteNodeBinaryTree.root.right = new Node(6);
            deleteNodeBinaryTree.root.left.left = new Node(2);
            deleteNodeBinaryTree.root.left.right = new Node(4);
            deleteNodeBinaryTree.root.right.right = new Node(7);

            Node deletedResultRoot = deleteNodeBinaryTree.DeleteNodeInBinaryTree(deleteNodeBinaryTree.root, 3);

            //Is Valid Binary Search Tree
            Console.WriteLine("Is Valid Binary Search Tree: " + binaryTree.isValidBinarySearchTree());

            Console.ReadKey();

            //Check If binary trees are identical
            //Check if binary tree is part of subtree
            //Invert or Mirror Binary Tree
            //Boundry Traversal

            //08/03/2020
            //Branch Sum
            //Top View
            //Bottom View
            //Left View
            //Right View
            //LCS
            //Max Path Sum
            //Reverse Alternate Levels
            //Flatten Binary Tree
        }
    }
}
