using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class FindFirstCommonNode
    {
        private static BST CreateTree()
        {
            BST myTree = new BST();
            myTree.Add(5);
            myTree.Add(4);
            myTree.Add(2);
            myTree.Add(1);
            myTree.Add(3);
            myTree.Add(8);
            myTree.Add(6);
            myTree.Add(7);
            return myTree;
        }
        public static void AnswerQuestion()
        {
            BST myTree = CreateTree();

            BSTNode node1 = new BSTNode();
            node1.Value = 1;
            BSTNode node2 = new BSTNode();
            node2.Value = 3;
            Console.WriteLine(CommonRoot(myTree.root, node1, node2).Value.ToString());

            BST myTree1 = CreateTree();

            BSTNode node3 = new BSTNode();
            node3.Value = 6;
            BSTNode node4 = new BSTNode();
            node4.Value = 0;
            Console.WriteLine(CommonRootTouch(myTree1.root, node3, node4).Value.ToString());
            Console.WriteLine(CommonRoot(myTree1.root, node3, node4).Value.ToString());

        }

        public static BSTNode CommonRootTouch(BSTNode rt, BSTNode node1, BSTNode node2)
        {
            if (rt == null) return null;
            if (touch(rt.Left, node1) && touch(rt.Left, node2)) return CommonRootTouch(rt.Left, node1, node2);
            if (touch(rt.Right, node1) && touch(rt.Right, node2)) return CommonRootTouch(rt.Right, node1, node2);
            return rt;
        }

        private static bool touch(BSTNode rt, BSTNode node)
        {
            if (rt == null) return false;
            if (rt.Value == node.Value) return true;
            return touch(rt.Left, node) || touch(rt.Right, node);
        }
        public static BSTNode CommonRoot(BSTNode rt, BSTNode node1, BSTNode node2)
        {
            if (rt == null)
            {
                Console.WriteLine("The root is null");
                return null;
            }
            if (rt.Value == node1.Value || rt.Value == node2.Value)
            {
                return rt;
            }
            BSTNode left, right;
            left = CommonRoot(rt.Left, node1, node2);
            right = CommonRoot(rt.Right, node1, node2);

            if ((left != null && right != null) && ((left.Value == node1.Value && right.Value == node2.Value) || (right.Value == node1.Value && left.Value == node2.Value)))
            {
                Console.WriteLine(string.Format("the root is {0}. the current.left is {1}. the current.right is {2}.", rt.Value.ToString(), left != null ? left.Value.ToString() : string.Empty, right != null ? right.Value.ToString() : string.Empty));
                return rt;
            }
            return left != null ? left : right != null ? right : null;
        }
    }

    public class BST
    {
        public BSTNode root;

        public BST() { }

        public void Add(int data)
        {
            BSTNode node = new BSTNode();
            node.Value = data;

            BSTNode current = root, parent = null;
            while (current != null)
            {
                if (data == current.Value) 
                    return;
                else if (data > current.Value)
                {
                    parent = current;
                    current = current.Right;
                }
                else if (data < current.Value)
                {
                    parent = current;
                    current = current.Left;
                }
            }

            if (parent == null)
                this.root = node;
            else
            {
                if (parent.Value > data) parent.Left = node;
                else parent.Right = node;
            }
        }

        public bool Delete(int data)
        {
            if (root == null) return false;
            // Find the node 
            BSTNode current = root, parent = null;
            while (current.Value != data)
            {
                if (current.Value > data)
                {
                    parent = current;
                    current = current.Left;
                    if (current == null) return false;
                }
                else if (current.Value < data)
                {
                    parent = current;
                    current = current.Right;
                    if (current == null) return false;
                }
            }

            //Case 1: the node is a leaf node
            if (current.Left == null && current.Right == null)
            {
                if (parent.Value > data) parent.Left = null;
                else if (parent.Value < data) parent.Right = null;
            }
            
            //Case 2: the node has one child
            if (current.Left != null && current.Right == null)
            {
                parent.Left = current.Left;
            }
            else if (current.Left == null && current.Right != null)
            {
                parent.Right = current.Right;
            }

            //Case 3: the node has two children
            if (current.Right != null && current.Left != null)
            {
                while (current.Right != null)
                {
                    current.Value = current.Right.Value;
                    parent = current;
                    current = current.Right;
                }
                parent.Right = null;
            }
            return true;
        }

        public bool Contains(int data)
        {
            BSTNode current = root;
            while (current != null)
            {
                if (current.Value == data)
                    return true;
                else if (current.Value < data)
                    current = current.Right;
                else if (current.Value > data)
                    current = current.Left;
            }
            return false;
        }
    }

    public class BSTNode
    {
        public int Value;
        public BSTNode Left;
        public BSTNode Right;

        public BSTNode() { }

        public BSTNode(int data, BSTNode left, BSTNode right)
        {
            this.Value = data;
            this.Left = left;
            this.Right = right;
        }

        public void PrintATreeNode()
        {
            if (this != null)
                Console.WriteLine(this.Value);
            if (this.Left != null) this.Left.PrintATreeNode();
            if (this.Right != null) this.Right.PrintATreeNode();
        }
    }
}
