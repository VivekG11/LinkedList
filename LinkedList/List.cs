using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class List
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if ((this.head) == null)
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
            Console.WriteLine(node.data + " is added to the list.");
        }
        public void Addfront(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                Console.WriteLine("List is Empty");
                this.head = node;
            }
            else if(this.head!= null)
            {
                node.next = head;
                this.head = node;
            }
            Console.WriteLine("Element added is :"+node.data);
        }
        public void Display()
        {
            Console.WriteLine("Elements in the list are ..");
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("List is Empty..");
            }
            while(temp!= null)
            {
                Console.Write(temp.data+",");
                temp = temp.next;
            }
        }
      
    }
}
