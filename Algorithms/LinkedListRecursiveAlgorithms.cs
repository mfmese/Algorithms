using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Node
    {
        public int Data = 0;
        public Node Next = null;
    }

    public static class LinkedListRecursiveAlgorithms
    {
        public static void Append(ref Node head, int data)
        {
            if(head != null)
            {
                Node current = head;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node();
                current.Next.Data = data;
            }
            else
            {
                head = new Node();
                head.Data = data;
            }
        }

        public static string Print(Node head)
        {
            string result = "";
            if (head == null) return "";

            Node current = head;
            do
            {
                result += current.Data + ",";
                current = current.Next;
            } while (current != null);

            return result;
        }

        public static void Reverse(ref Node head)
        {
            if (head == null) return;

            Node prev = null, current = head, next = null;

            while(current.Next != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            current.Next = prev;
            head = current;
        }

        public static Node newHead;

        public static void ReverseUsingRecursion(Node head)
        {
            if (head == null) return;

            if(head.Next == null)
            {
                newHead = head;
                return;
            }

            ReverseUsingRecursion(head.Next);
            head.Next.Next = head;
            head.Next = null;
        }
    }
}
