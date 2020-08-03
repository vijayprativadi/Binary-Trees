using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    public class Node
    {
        public int data { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }
        public Node()
        {

        }
        public Node(int data)
        {
            this.data = data;
            left = null;
            right = null;

        }
    }
    public class BinaryTree
    {
        public Node root;
        public BinaryTree()
        {
            root = null;
        }

        //Wrapper Function 
        public void PreOrderTraversal()
        {
            PreOrderTraversal(root);
        }

        //Center/Left/Right Traversal
        private void PreOrderTraversal(Node root)
        {
            if (root == null) return;

            System.Console.WriteLine(root.data + " ");
            PreOrderTraversal(root.left);
            PreOrderTraversal(root.right);

        }

        //Wrapper Function 
        public void InOrderTraversal()
        {
            InOrderTraversal(root);
        }

        //Left/Center/Right Traversal
        private void InOrderTraversal(Node root)
        {
            if (root == null) return;

            InOrderTraversal(root.left);
            System.Console.WriteLine(root.data + " ");
            InOrderTraversal(root.right);
        }

        //Wrapper Function 
        public void PostOrderTraversal()
        {
            PostOrderTraversal(root);
        }

        //Left/Right/Center Traversal
        private void PostOrderTraversal(Node root)
        {
            if (root == null) return;

            PostOrderTraversal(root.left);
            PostOrderTraversal(root.right);
            System.Console.WriteLine(root.data + " ");
        }

        public IList<IList<int>> LevelOrderTraversal()
        {
            Queue<Node> queue = new Queue<Node>();
            IList<IList<int>> result = new List<IList<int>>();

            if (root == null)
            { 
                return result;
            }

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int size = queue.Count;
                IList<int> currentLevel = new List<int>();

                for (int i = 0; i < size; i++)
                {
                    Node current = queue.Dequeue();
                    currentLevel.Add(current.data);
                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }
                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }
                }

                result.Add(currentLevel);
            }
       
            return result;
        }

        //Wrapper
        public void FindParentofNode(int data)
        {
            FindParentofNode(root, data, -1);
        }

        private void FindParentofNode(Node node, int data, int parent)
        {
            if (node == null)
            {
                return;
            }

            if (node.data == data)
            {
                Console.WriteLine("Parent of a Node "+data+" is: " + parent);
            }
            else
            {
                FindParentofNode(node.left, data, node.data);
                FindParentofNode(node.right, data, node.data);
            }
        }

        //Wrapper
        public void FindSiblingofaNode(int value)
        {
            FindSiblingofaNode(root, value);
        }

        private void FindSiblingofaNode(Node node, int value)
        {
            if (node == null)
            {
                return;
            }

            if (node.left != null && node.left.data == value)
            {
                Console.WriteLine("Sibling of a Node " + node.left.data + " is: " + node.right.data);
            }
            else if (node.right != null && node.right.data == value)
            {
                Console.WriteLine("Sibling of a Node " + node.right.data + " is: " + node.left.data);
            }

            FindSiblingofaNode(node.left, value);
            FindSiblingofaNode(node.right, value);
        }
    }
}
