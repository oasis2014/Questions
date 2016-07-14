using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /* Implement an algorithm to delete a node in the middle of a single linked list, given only access to that node. EXAMPLE input: the node ‘c’ from the linked list a->b->c->d->e result: nothing is returned, but the new linked list looks like a->b>d->e 
     */
    class LinkedList_DeleteMiddleNode
    {
        public static void DoTest()
        {
            Node testList = null, m=null;
            Console.WriteLine("The test list is null");
            DeleteMiddleNode(testList, m);
            if (testList == null)
                Console.WriteLine("Nothing happened.");
            else
                testList.PrintLinkedList();

            testList = new Node(1);
            m = testList;
            testList.PrintLinkedList();
            DeleteMiddleNode(testList, m);
            testList.PrintLinkedList();

            testList = new Node(1);
            m=testList.AppendToTail(2);
            testList.AppendToTail(3);
            DeleteMiddleNode(testList, m);
            if (testList == null)
                Console.WriteLine("Nothing happened.");
            else
                testList.PrintLinkedList();

        }

        public static bool DeleteMiddleNode2(Node middle)
        {
            if (middle == null || middle.next == null) return false;

            middle = middle.next;
            middle.next = middle.next.next;
            middle.data = middle.next.data;
            return true;
        }
        public static void DeleteMiddleNode(Node head, Node m)
        {
            if (head == null || (head != null && head.next == null)) return;

            Node previous = head;
            Node current = head.next;
            while (current != null)
            {
                if (current == m)
                {
                    previous.next = m.next;
                    return;
                }
                previous = current;
                current = current.next;
            }
        }
    }
}
