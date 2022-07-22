using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_StacksAndQueues
{
    internal class LinkedListStack
    {
        protected Node head = null;

        internal void Append(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                //node.next = head;
            }
            Console.WriteLine("{0} inserted into queue ", node.data);
        }
        public void Remove()
        {
            if (head == null)
            {
                Console.WriteLine("\nQueue is empty, Deletion is not possible");
                return;
            }
            else
            {
                Console.WriteLine("\nValue popped is {0} ", this.head.data);
                head = head.next;
            }
        }
         internal void Display()
         {
                Node temp = this.head;
                if (temp == null)
                {
                    Console.WriteLine("Queue is empty");
                    return;
                }
                while (temp != null)
                {
                    Console.Write(temp.data + "->");
                    temp = temp.next;
                }
          }

    }
}
