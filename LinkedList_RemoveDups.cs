using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /*Write code to remove duplicates from an unsorted linked list. FOLLOW UPS & COMPLICATIONS How would you solve this problem if a temporary buffer is not allowed?
     */
    class LinkedList_RemoveDups
    {
        public static void DoTest()
        {
            Console.WriteLine("The Linked list is:");

            Node testList = null;
            Console.WriteLine("The node is null");
            Node test0 = RemoveDups(testList);
            if (test0 == null)
                Console.WriteLine("The node is null");
            else
                test0.PrintLinkedList();

            testList = new Node(1);
            testList.PrintLinkedList();
            Node test1 = RemoveDups(testList);
            test1.PrintLinkedList();

            testList.AppendToTail(2);
            testList.PrintLinkedList();
            Node test11 = RemoveDups(testList);
            test11.PrintLinkedList();

            testList.AppendToTail(2);
            testList.AppendToTail(1);
            testList.PrintLinkedList();
            Node test2 = RemoveDups(testList);
            test2.PrintLinkedList();

            testList.AppendToTail(2);
            testList.AppendToTail(2);
            testList.AppendToTail(3);
            testList.PrintLinkedList();
            Node test3 = RemoveDups(testList);
            test3.PrintLinkedList();

        }
        public static Node RemoveDups(Node head)
        {
            if (head == null) return null;
            Node previous = head;
            Node current = head.next;

            while(current != null)
            {
                Node runner = head;
                while (runner != current)
                {
                    if (current.data == runner.data)
                    {
                        previous.next = current.next;
                        current = current.next;
                        break;
                    }
                    runner = runner.next;
                }
                if (runner == current)
                {
                    previous = current;
                    current = current.next;
                }
            }
            return head;
        }

        public static void RemoveDups2(Node head)
        {
            if (head == null) return;
            Node current = head;
            while (current != null)
            {
                Node runner = current;
                while (runner.next != null)
                {
                    if (current.data == runner.next.data)
                    {
                        runner.next = runner.next.next;
                    }
                    else
                    {
                        runner = runner.next;
                    }
                }
                current = current.next;
            }
        }

        public static void RemoveDup3(Node head)
        {
            if (head == null) return;
            HashSet<int> elements = new HashSet<int>();
            Node current=head.next;
            Node previous = head;
            elements.Add(previous.data);
            while (current != null)
            {
                if (elements.Contains(current.data))
                {
                    previous.next = current.next;
                }
                else
                {
                    elements.Add(current.data);
                    previous = current;
                }
                current = current.next;
            }
        }
    }
}
