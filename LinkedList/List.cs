using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class List
    {
        public int count = 0;
        int ptr;
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
        //Adding elements from front
        public void Addfront(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                Console.WriteLine("List is Empty");
                this.head = node;
            }
            else if (this.head != null)
            {
                node.next = head;
                this.head = node;
            }
            Console.WriteLine("Element added is :" + node.data);
        }
        //Inserting an element
        public void insert(int data)
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty.");
            }
            else
            {
                Node node = new Node(data);
                Node temp = head;
                int ptr = ((count % 2) == 0) ? (count / 2) : (count + 1) / 2;
                while (ptr-- > 1)
                    temp = temp.next;
                node.next = temp.next;
                temp.next = node;
            }
        }
        //Deleting first element from Linked List
        public Node DeleteFirst()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;

        }
        public Node DeleteLast()
        {
            Node temp = head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
            return temp;
        }
        public Node searchNode(int val)
        {
            Node temp = head;
            int index = 0;
            int flag = 0;

            while (temp != null)
            {
                index++;
                if (temp.data == val)
                {
                    flag = 1;
                    break;
                }
                temp = temp.next;
            }
            if (flag == 1)
            {
                Console.WriteLine("Element is found at :" + index);
            }
            else
            {
                Console.WriteLine("There is no such element in the list.");
            }
            return temp;

        }

        public int SearchNInsert(int val, int data)
        {
            Node search = searchNode(data);
            Node node = new Node(val);
            Node temp = search.next;
            search.next = node;
            node.next = temp;
            return (node.data);
        }
        public void DeleteNode(int val)
        {

            Node temp = this.head;
            Console.WriteLine("Deleting a specific Node.");

            if (temp.next.data == val)
            {
                temp.next = temp.next.next;

            }

            temp = temp.next;

            Console.WriteLine("Deleted element is :" + val);
        }
        public void Sort()
        {
            Node i, j;
            int temp;
            for(i = this.head;i.next!=null;i=i.next)
            {
                for(j = i.next;j!=null;j=j.next)
                {
                    if(i.data > j.data)
                    {
                        temp = i.data;
                        i.data = j.data;
                        j.data = temp;
                    }
                }

            }
        }
       

        public void Display()
        {
            int count = 0;
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
                count++;
            }
            Console.WriteLine("\nTotal elements in the list are :"+count);
            
        }
      
    }
}
