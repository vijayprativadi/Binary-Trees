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
            Queue<Node> nodes = new Queue<Node>();
            IList<IList<int>> result = new List<IList<int>>();

            if (root == null)
            { 
                return result;
            }

            nodes.Enqueue(root);

            while (nodes.Count > 0)
            {
                int size = nodes.Count;
                IList<int> currentLevel = new List<int>();

                for (int i = 0; i < size; i++)
                {
                    Node current = nodes.Dequeue();
                    currentLevel.Add(current.data);
                    if (current.left != null)
                    {
                        nodes.Enqueue(current.left);
                    }
                    if (current.right != null)
                    {
                        nodes.Enqueue(current.right);
                    }
                }

                result.Add(currentLevel);
            }
       
            return result;
        }

        public IList<IList<int>> VerticalOrderTraversal()
        {
            Queue<Node> nodes = new Queue<Node>();
            Queue<int> col = new Queue<int>();
            Dictionary<int, IList<int>> dic = new Dictionary<int, IList<int>>();
            IList<IList<int>> result = new List<IList<int>>();

            if (root == null)
            {
                return result;
            }

            nodes.Enqueue(root);
            col.Enqueue(0);

            while (nodes.Count > 0)
            {
                var node = nodes.Dequeue();
                var colnum = col.Dequeue();
                if (dic.ContainsKey(colnum))
                {
                    dic[colnum].Add(node.data);
                }
                else
                {
                    var list = new List<int>();
                    list.Add(node.data);
                    dic.Add(colnum, list);
                }

                if (node.left != null)
                {
                    nodes.Enqueue(node.left);
                    col.Enqueue(colnum - 1);
                }
                if (node.right != null)
                {
                    nodes.Enqueue(node.right);
                    col.Enqueue(colnum + 1);
                }
            }
            var temp = dic.Keys.ToList();
            temp.Sort();
            foreach (var key in temp)
            {
                result.Add(dic[key]);
            }
            return result;
        }

        //public IList<IList<int>> VerticalOrderTraversal()
        //{
        //    Queue<Node> queue = new Queue<Node>();
        //    IList<IList<int>> result = new List<IList<int>>();
        //    Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
        //    if (root == null)
        //    {
        //        return result;
        //    }

        //    queue.Enqueue(root);
        //    int hd = 0;
        //    dict.Add(hd, new List<int> { root.data });
        //    while (queue.Count > 0)
        //    {
        //        int size = queue.Count;
        //        IList<int> currentLevel = new List<int>();
        //        int hd1 = -99; int hd2 = -99;
        //        for (int i = 0; i < size; i++)
        //        {
        //            Node current = queue.Dequeue();
        //            currentLevel.Add(current.data);
        //            if (current.left != null)
        //            {
        //                queue.Enqueue(current.left);
        //                if (hd1 == -99)
        //                {
        //                    hd1 = hd - 1;
        //                }
        //                else
        //                {
        //                    hd1 = hd1 - 1;
        //                }
        //                if (!dict.ContainsKey(hd1))
        //                {
        //                    dict.Add(hd1, new List<int> { current.left.data });
        //                }
        //                else
        //                {
        //                    dict[hd1].Add(current.left.data);
        //                }
        //            }
        //            if (current.right != null)
        //            {
        //                queue.Enqueue(current.right);
        //                if (hd2 == -99)
        //                {
        //                    hd2 = hd + 1;
        //                }
        //                else
        //                {
        //                    hd2 = hd1 + 1;
        //                }
        //                if (!dict.ContainsKey(hd2))
        //                {
        //                    dict.Add(hd2, new List<int> { current.right.data });
        //                }
        //                else
        //                {
        //                    dict[hd2].Add(current.right.data);
        //                }
        //            }
        //        }

        //        result.Add(currentLevel);
        //    }

        //    return result;
        //}

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

        Node p1;
        Node p2;
        int l1;
        int l2;
        public bool IsCousins(int x, int y)
        {
            if (root == null || root.data == x || root.data == y) return false;

            Find(root.left, root, 0, x, y);
            Find(root.right, root, 0, x, y);

            return (l1 == l2) && (p1.data != p2.data);
        }

        public void Find(Node root, Node parent, int level, int x, int y)
        {
            if (root == null) return;

            if (root.data == x)
            {
                p1 = parent;
                l1 = level;
            }
            else if (root.data == y)
            {
                p2 = parent;
                l2 = level;
            }

            Find(root.left, root, level + 1, x, y);
            Find(root.right, root, level + 1, x, y);
        }

        public int MinDepth(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            int left = MinDepth(root.left);
            int right = MinDepth(root.right);
            return Math.Min(left, right) + 1;
        }

        public int MaxDepth(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);
            return Math.Max(left, right) + 1;
        }
    }
}
