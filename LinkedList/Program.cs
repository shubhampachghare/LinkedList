using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Data structure program using Linked List");
            /*LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();*/
            LinkedList linkedList1 = new LinkedList();
            linkedList1.Add2(70);
            linkedList1.Add2(30);
            linkedList1.Add2(56);
            linkedList1.Display();
            /*56 30 70*/
        }
    }
}