using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List........");
            List list = new List();
            list.Add(56);
            list.Add(70);
            list.insert(30);
            list.Display();
            list.DeleteFirst();
            list.Display();
        }
    }
}
