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
    }
}
