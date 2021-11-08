using System;
using System.Collections.Generic;
using System.Text;

namespace linkedlist
{
    class UC6
    {
        public Node head;
        public UC6()
        {
            this.head = null;
        }
        /*internal void Add(int item)
        {
            Node node = new Node(item);
            if (head == null)
            {
                head = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
        }*/
        public void Append(int item)
        {
            Node node = new Node(item);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        public void Insert(int position, int item)
        {
            Node node = new Node(item);
            if (position < 1)
                Console.WriteLine("Invalid Position");
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;
                try
                {
                    while (position > 2)
                    {
                        temp = temp.next;
                        position--;
                    }
                    node.next = temp.next;
                    temp.next = node;
                }
                catch (NullReferenceException)
                {
                    System.Console.WriteLine("Index out of bounds");
                }
            }
        }
        public void  Pop()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
               // return null;
            }
            else
            {
                Node popped = head;
                head = head.next;
               // return popped;
            }
        }
        public void RemoveLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("Empty LinkedList");
               // return null;
            }
            else
            {
                Node temp = head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
               // Node removedNode = temp.next;
                temp.next = null;
                //return temp.next;
            }
        }
        public void Display()
        {
            if (head == null)
                System.Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
