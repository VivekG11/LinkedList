using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List........");
            List list = new List();
            list.Addfront(70);
            list.Addfront(30);
            list.Addfront(56);
            list.Display();
        }
    }
}
