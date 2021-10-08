using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        private ListNode head;
        private ListNode tail;

        public int Count { get; private set; }

        public void AddFirst(int element)
        {
            if (Count == 0)
            {
                head = tail = new ListNode(element);
            }
            else
            {
                ListNode newHead = new ListNode(element);
                newHead.Next = head;
                head.Previous = newHead;
            }
            Count++;
        }

        public void AddLast(int element)
        {
            if (Count == 0)
            {
                head = tail = new ListNode(element);
            }
            else
            {
                ListNode newTail = new ListNode(element);
                newTail.Previous = tail;
                tail.Next = newTail;
                tail = newTail;
            }
            Count++;
        }

        public int RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            int firstElement = head.Value;
            head = head.Next;
            if (head != null)
            {
                head.Previous = null;
            }
            else
            {
                tail = null;
            }
            Count--;
            return firstElement;
        }

        public int RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            int lastElement = tail.Value;
            tail = tail.Previous;
            if (tail != null)
            {
                tail.Next = null;
            }
            else
            {
                head = null;
            }
            Count--;
            return lastElement;
        }

        public void ForEach(Action<int> action)
        {
            ListNode currentNode = head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[Count];
            int counter = 0;
            ListNode currentNode = head;
            while (currentNode != null)
            {
                array[counter] = currentNode.Value;
                currentNode = currentNode.Next;
                counter++;
            }
            return array;
        }
    }
}
               
