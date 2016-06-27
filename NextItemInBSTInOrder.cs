using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class NextItemInBSTInOrder
    {
    }

    public class BSTNode_P
    {
        public int Value;
        public BSTNode_P Parent;
        public BSTNode_P Left;
        public BSTNode_P Right;

        public BSTNode_P() { }
    }

    public class BST_P
    {
        public BSTNode_P Root;

        public BST_P() { }

        public void Add(int data)
        {
            BSTNode_P node = new BSTNode_P();
            node.Value = data;

            BSTNode_P current = Root, parent = null;
            while (current != null)
            {
                if (current.Value > data)
                {
                    parent = current;
                    current = current.Left;
                }
                else if (current.Value < data)
                {
                    parent = current;
                    current = current.Right;
                }
                else if (current.Value == data)
                    return;
            }

            if (parent == null)
            {
                node.Parent = null;
                this.Root = node;
            }
            else
            {
                if (parent.Value > data)
                {
                    parent.Left = node;
                    parent.Left.Parent = parent;
                }
                else
                {
                    parent.Right = node;
                    parent.Right.Parent = parent;
                }
            }
        }

        public BSTNode_P NextInOrder(int data)
        {
            if (this.Root == null) return null;

            //find the node with value data
            BSTNode_P current = FindNodeByValue(data);
            if (current == null) return null;
            if (current.Parent == null || current.Right != null)
                return LeftMost(current);
            else
            /*
            If right sbtree of node is NULL, then succ is one of the ancestors. Do following.
Travel up using the parent pointer until you see a node which is left child of it’s parent. The parent of such a node is the succ.*/
            {
                BSTNode_P parent = current.Parent;
                while (parent!= null)
                {
                    if (parent.Left == current)
                        break;
                    parent = parent.Parent;
                }
                return parent;
            }
        }

        public BSTNode_P LeftMost(BSTNode_P node)
        {
            if (node == null) return null;
            BSTNode_P current = node, parent = null;
            while (current != null)
            {
                parent = current;
                current = current.Left;
            }
            return current;
        }

        public BSTNode_P FindNodeByValue(int data)
        {
            if (this.Root == null) return null;

            BSTNode_P current = this.Root;
            while (current != null)
            {
                if (current.Value == data)
                    return current;
                else if (current.Value > data)
                    current = current.Left;
                else
                    current = current.Right;
            }
            return current;
        }
    }
}
