using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Data structure program using Linked List");

            LinkedList linkedList2 = new LinkedList();
            linkedList2.Append(56);
            linkedList2.Append(30);
            linkedList2.Append(70);
            linkedList2.Display();
        }

    }
}