using System;
using System.Collections.Generic;
using System.Text;

namespace linkedlist
{
    class UC9
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            Console.WriteLine("Squence of linked list");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        public void deleteNode(int deletData)
        {
            if (this.head == null)
                return;
            else if (this.head.data == deletData && this.head.next == null)
                this.head = null;
            else if (this.head.data == deletData)
                this.head = this.head.next;
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    if (temp.next.data == deletData)
                    {
                        temp.next = temp.next.next;
                        break;
                    }
                    temp = temp.next;
                }
            }
        }


        public int size()
        {
            int size = 0;
            Node temp = this.head;
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }
            return size;
            Console.WriteLine();
        
        }
    }
}
