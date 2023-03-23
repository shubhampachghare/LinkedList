using System;

namespace DataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Data structure program using Linked List");

            /*LinkedList linkedList2 = new LinkedList();
            linkedList2.Append(56);
            linkedList2.Append(30);
            linkedList2.Append(70);
            linkedList2.Display();
            LinkedList linkedList3 = new LinkedList();
            linkedList3.Add(56);
            linkedList3.Add(70);
            //linkedList.Display();
            linkedList3.InsertAtParticularPoistion(2, 30);
            linkedList3.Display();
            LinkedList remove = new LinkedList();
            remove.Add(56);
            remove.Add(30);
            remove.Add(70);
            remove.Display();
            Console.WriteLine("First element is poped out from linked list = " + remove.removeFirstNode().data);
            remove.Display();*/

            LinkedList rm = new LinkedList();
            rm.Add(56);
            rm.Add(30);
            rm.Add(70);
            rm.Display();
            Console.WriteLine("last element is poped out from linked list = " + rm.removeLastNode().data);
            rm.Display();

        }

    }
}
