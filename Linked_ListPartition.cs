using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /*Partition: Write code to partition a linked list around a value x, such that all nodes less than x come before all nodes greater than or equal to x. if x is contained within the list the values of x only need "right partition"; it does not need to appear between the left and right partitions.*/
    class Linked_ListPartition
    {
        public static void DoTest()
        {
            Console.WriteLine("The Linked list is:");
            Node testList = new Node(3);
            testList.AppendToTail(5);
            testList.AppendToTail(8);
            testList.AppendToTail(5);
            testList.AppendToTail(10);
            testList.AppendToTail(2);
            testList.AppendToTail(1);
            //testList.AppendToTail(9);
            testList.PrintLinkedList();

            Node newList = Partition2(testList, 5);
            newList.PrintLinkedList();
        }
        public static Node Partition(Node node, int x)
        {
            Node beforeStart = null, beforeEnd = null, afterStart = null, afterEnd = null;
            while (node != null)
            {
                Node next = node.next;
                node.next = null;
                if (node.data < x)
                {
                    if (beforeStart == null)
                    {
                        beforeStart = node;
                        beforeEnd= beforeStart;
                    }
                    else
                    {
                        beforeEnd.next = node;
                        beforeEnd = node;
                    }
                }
                else
                {
                    if (afterStart == null)
                    {
                        afterStart = node;
                        afterEnd = afterStart;
                    }
                    else
                    {
                        afterEnd.next = node;
                        afterEnd = node;
                    }
                }
                node = next;
            }

            if (beforeStart == null) return afterStart;
            beforeEnd.next = afterStart;
            return beforeStart;
        }

        public static Node Partition2(Node node, int k)
        {
            Node head = node, tail = node;

            while (node != null)
            {
                Node next = node.next;
                if (node.data < k)
                {
                    node.next = head;
                    head = node;
                }
                else
                {
                    tail.next = node;
                    tail = node;
                }
                node = next;
            }
            tail.next = null;
            return head;
        }
    }
}
