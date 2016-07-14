using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /*
     * Given a circular linked list, implement an algorithm which returns node at the beginning of the loop. DEFINITION Circular linked list: A (corrupt) linked list in which a node’s next pointer points to an earlier node, so as to make a loop in the linked list. EXAMPLE: input: A -> B -> C -> D -> E -> C [the same C as earlier] output: C 
     */
    class LinkedList_CircularFirst
    {

        public static void DoTest()
        {
            Node testList = null;
            Console.WriteLine("The test list is null");
            Node test0 = FindFirstMeetingNode(testList);
            if (test0 == null)
                Console.WriteLine("No circular node");
            else
                test0.PrintLinkedList();

            testList = new Node(1);
            testList.PrintLinkedList();
            Node test1 = FindFirstMeetingNode(testList);
            if (test1 == null)
                Console.WriteLine("No circular node");
            else
                test1.PrintLinkedList();

            testList = new Node(1);
            testList.AppendToTail(2);
            testList.AppendToTail(3);
            Node test11 = FindFirstMeetingNode(testList);
            if (test11 == null)
                Console.WriteLine("No circular node");
            else
                test11.PrintLinkedList();

            Node testList1 = new Node(1);
            testList1.AppendToTail(2);
            Node mNode=testList1.AppendToTail(3);
            testList1.AppendToTail(4);
            testList1.AppendToTail(5);
            Node crashNode=testList1.AppendToTail(6);
            crashNode.next = mNode;
            testList1.PrintCircularLinkedList(12);
            Node test2 = FindFirstMeetingNode(testList1);
            if (test2 == null)
                Console.WriteLine("No circular node");
            else
                test2.PrintCircularLinkedList(12);
        }

        public static Node FindFirstMeetingNode(Node head)
        {
            if (head == null || head.next == null || head.next.next == null) return null;
            Node n1 = head, n2 = head;
            while (n1.next != null && n2.next != null && n2.next.next !=null)
            {
                n1 = n1.next;
                n2 = n2.next.next;
                if (n1 == n2)
                    break;
            }
            if (n1 != n2) return null;

            n1 = head;
            while (n1 != null && n2!=null)
            {
                n1 = n1.next;
                n2 = n2.next;
                if (n1 == n2)
                {
                    Console.WriteLine("the meeting node is {0,3}", n1.data);
                    return n1;
                }
            }
            return null;
        }

        #region Misunderstanding Question
        /// <summary>
        /// This is test for solution when misunderstanding question
        /// </summary>
        public static void DoTest1()
        {
            Node testList = null;
            Console.WriteLine("The test list is null");
            Node test0 = GetBeginningOfTheLoop(testList);
            if (test0 == null)
                Console.WriteLine("No circular node");
            else
                test0.PrintLinkedList();

            testList= new Node(1);
            testList.PrintLinkedList();
            Node test1 = GetBeginningOfTheLoop(testList);
            if (test1 == null)
                Console.WriteLine("No circular node");
            else
                test1.PrintLinkedList();

            testList = new Node(1);
            testList.AppendToTail(2);
            testList.AppendToTail(3);
            Node test11 = GetBeginningOfTheLoop(testList);
            if (test11 == null)
                Console.WriteLine("No circular node");
            else
                test11.PrintLinkedList();

            Node testList1 = new Node(1);
            testList1.AppendToTail(2);
            testList1.AppendToTail(3);
            testList1.AppendToTail(1);
            testList1.AppendToTail(3);
            testList1.PrintLinkedList();
            Node test2 = GetBeginningOfTheLoop(testList1);
            if (test2 == null)
                Console.WriteLine("No circular node");
            else
                test2.PrintLinkedList();

            testList1 = new Node(1);
            testList1.AppendToTail(1);
            testList1.PrintLinkedList();
            Node test21 = GetBeginningOfTheLoop(testList1);
            if (test21 == null)
                Console.WriteLine("No circular node");
            else
                test21.PrintLinkedList();

        }

        /// <summary>
        /// This is the method when I misunderstanding the question.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static Node GetBeginningOfTheLoop(Node head)
        {
            if (head == null) return null;

            Hashtable recorder = new Hashtable();

            Node current = head;
            while (current != null)
            {
                if (recorder.Contains(current.data))
                {
                    return current;
                }
                recorder.Add(current.data, 1);
                current = current.next;
            }
            return null;
        }
        #endregion Misunderstanding Question
    }
}
