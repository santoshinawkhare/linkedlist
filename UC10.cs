using System;
using System.Collections.Generic;
using System.Text;

namespace linkedlist
{
    class UC10
    {
        internal Node head;
        public void Add(int data)
        {
            Node newNode = new Node(data);
            Node current;
            if (head == null || head.data >= newNode.data)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                current = head;
                while (current.next != null && current.next.data < newNode.data)
                    current = current.next;
                newNode.next = current.next;
                current.next = newNode;
            }
            Console.WriteLine("inserted into linked list = " + newNode.data);
        }


        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            Console.WriteLine("Sorted linked list = ");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
