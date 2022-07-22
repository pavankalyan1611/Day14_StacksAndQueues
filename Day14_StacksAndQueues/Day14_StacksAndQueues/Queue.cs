using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_StacksAndQueues
{
    internal class Queue : LinkedListStack
    {
       
        public Queue()
        {
            Console.WriteLine("welcome to Data structures Queue: ");
        }
        public void Enqueu(int value)
        {           
            base.Append(value);
        }
        public void Display()
        {
            base.Display();
        }
       
    }
}
