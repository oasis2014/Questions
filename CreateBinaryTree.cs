using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    class CreateBinaryTree
    {
        public static void CreateBinaryTreeQuestion()
        {
            int[] sortedArray = new int[] {1,2,3,4,5,6};
            BinaryTree balancedtree = CreateABinaryTree(sortedArray, 0, 5);
            balancedtree.PrintTree();
            Console.WriteLine("the max height of the tree:"+balancedtree.Height);
            Console.WriteLine("the min height of the tree:" + balancedtree.MinHeight);
            Console.WriteLine("The tree is balanced?" + balancedtree.IsBalanced);

            Console.WriteLine("The duplicate array:");
            int[] sortedarrdup = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            BinaryTree balancedtree2 = CreateABinaryTree(sortedarrdup, 0, 6);
            balancedtree2.PrintTree();
            Console.WriteLine("the height of the tree:" + balancedtree2.Height);
            Console.WriteLine("the min height of the tree:" + balancedtree2.MinHeight);
            Console.WriteLine("The tree is balanced?" + balancedtree2.IsBalanced);

        }

        public static void PrintPathsUpToGivenSum()
        {
            int[] sortedArray = new int[] { 1, 2, 3, 4, 5, 6 };
            BinaryTree balancedtree = CreateABinaryTree(sortedArray, 0, 5);
            //balancedtree.PrintTree();
            //Console.WriteLine("the max height of the tree:" + balancedtree.Height);
            //Console.WriteLine("the min height of the tree:" + balancedtree.MinHeight);
            //Console.WriteLine("The tree is balanced?" + balancedtree.IsBalanced);

            //FindPathsUpToTheGivenSum(balancedtree, 6, string.Empty);
            int[] buffer= new int[balancedtree.Height];
            FindPathUpToSum(balancedtree, 6, buffer, 0);
        }

        public static void FindPathsUpToTheGivenSum(BinaryTree node, int sum, string path)
        {
            if (node == null)
                return;
            else
            {
                int subSum = sum - node.Data;
                path += string.IsNullOrEmpty(path) ? node.Data.ToString() : "," + node.Data.ToString();
                if (subSum == 0 && node.Left == null && node.Right == null)
                {
                    Console.WriteLine(path);
                    return;
                }
                FindPathsUpToTheGivenSum(node.Left, subSum, path);
                FindPathsUpToTheGivenSum(node.Right, subSum, path);
            }
        }

        public static void FindPathUpToSum(BinaryTree node, int sum, int[] buffer, int level)
        {
            if (node == null) return;
            int temp = sum;
            buffer[level] = node.Data;

            for (int i = level; i >= 0; i--)
            {
                temp = temp - buffer[i];
                if (temp == 0)
                {
                    PrintPath(buffer, i, level);
                }
            }
            FindPathUpToSum(node.Left, sum, buffer, level + 1);
            FindPathUpToSum(node.Right, sum, buffer, level + 1);
        }

        public static void PrintPath(int[] buffer, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(buffer[i]);
                Console.Write(",");
            }
            Console.WriteLine();
        }

        public static BinaryTree CreateABinaryTree(int[] array, int lindex, int rindex)
        {
            if (rindex < lindex)
            {
                return null;
            }
            int current = (rindex + lindex) / 2;
            BinaryTree tree = new BinaryTree(array[current]);
            tree.Left = CreateABinaryTree(array, lindex, current - 1);
            tree.Right = CreateABinaryTree(array, current + 1, rindex);
            return tree;
        }
    }

    public class BinaryTree
    {
        public int Data {get; set;}
        public BinaryTree Left { get; set; }
        public BinaryTree Right { get; set; }

        public BinaryTree(int value)
        {
            Data = value;
        }

        public void PrintTree()
        {
            Console.WriteLine(this.Data);
            if (this.Left != null)
            {
                Console.Write("Left:");
                this.Left.PrintTree();
            }
            if (this.Right != null)
            {
                Console.Write("Right:");
                this.Right.PrintTree();
            }
        }

        public int Height
        {
            get
            {
                if (this == null) return 0;
                int height = Math.Max(this.Right != null ?this.Right.Height : 0, this.Left != null ? this.Left.Height : 0) + 1;
                return height;
            }
        }

        public bool IsBalanced
        {
            get { return this.Height - this.MinHeight <= 1 ? true : false; }
        }

        public int MinHeight
        {
            get
            {
                if (this == null) return 0;
                int min = Math.Min(this.Right !=null ? this.Right.MinHeight : 0, this.Left !=null ?this.Left.MinHeight : 0) + 1;
                return min;
            }
        }
    }
}
