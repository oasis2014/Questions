using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /*Implement an algorithm to find the nth to last element of a singly linked list. 
     */
    class LinkedList_FindNToLast
    {
        public static void DoTest()
        {
            Console.WriteLine("The Linked list is:");
            Node testList = new Node(1);
            Console.Write("{0,3}", testList.data);
            for (int i=0; i<5; i++)
            {
                testList.AppendToTail(i + 2);
                Console.Write("{0,3}", i+2);
            }

            Node ntolastNode = FindNToLast(testList, 2);
            Console.WriteLine("The node is {0,3}", ntolastNode.data);

        }
        public static Node FindNthToLast1(Node head, int n)
        {
            if (head == null) return head;

            Node node1 = head.next;
            Node node2 = head;
            int counter=1;
            while (node1 != null)
            {
                node1 = node1.next;
                counter++;
            }
            if (counter <=n) return null;

            counter = counter - n;
            node1 = head;
            for (int i=1; i<counter; i++)
            {
                node1 = node1.next;
            }
            return node1;
        }

        public static Node FindNToLast(Node head, int n)
        {
            if (head== null || n<=0) return head;
            Node pointer1 = head, pointer2 = head;
            for (int i=0; i<n; i++)
            {
                if (pointer1.next == null) return null;
                pointer1 = pointer1.next;
            }
            while(pointer1.next !=null)
            {
                pointer1 = pointer1.next;
                pointer2 = pointer2.next;
            }
            return pointer2;
        }
    }

    class Node
    {
        public Node next = null;
        public int data;

        public Node(int d)
        {
            data = d;
        }

        public Node AppendToTail(int d)
        {
            Node newNode = new Node(d);
            Node n = this;
            while (n.next != null)
            {
                n = n.next;
            }
            n.next = newNode;
            return newNode;
        }

        public void PrintLinkedList()
        {
            Node list = this;
            if (list == null) return;

            while (list != null)
            {
                Console.Write("{0,3}", list.data);
                list = list.next;
            }
            Console.WriteLine();
        }

        public void PrintCircularLinkedList(int n)
        {
            Node list = this;
            if (list == null) return;
            int count = 0;

            while (list != null && count <n)
            {
                Console.Write("{0,3}", list.data);
                list = list.next;
                count++;
            }
            Console.WriteLine();
        }

    }
}
