﻿using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List........");
            List list = new List();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.SearchNInsert(40,30);
            list.DeleteNode(40);
            list.Display();
           
        }
    }
}
