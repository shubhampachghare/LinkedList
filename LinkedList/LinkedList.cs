using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedList
    {
        internal node head;
        public void Add(int id)
        {
            node node1 = new node(id);
            if (this.head == null)
            {
                this.head = node1;
            }
            else
            {
                node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                    temp.next = node1;
                }

            }
            Console.WriteLine("{0} is inserted int linked list ", node1.id);
        }
    }
}