using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_StacksAndQueues
{
    internal class stack
    {
        LinkedListStack list = new LinkedListStack();
        public stack()
        {
            Console.WriteLine("welcome to Data structures Stack: ");
        }
        public void Push(int value)
        {           
            list.Add(value);
        }
        public void Display()
        {
            list.Display();
        }
    }
}
