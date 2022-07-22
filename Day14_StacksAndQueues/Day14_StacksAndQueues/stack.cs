using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_StacksAndQueues
{
    internal class stack : LinkedListStack
    {
       
        public stack()
        {
            Console.WriteLine("welcome to Data structures Stack: ");
        }
        public void Push(int value)
        {           
            base.Add(value);
        }
        public void Display()
        {
            base.Display();
        }
        internal void IsEmpty()
        {
            while (base.top != null)
            {
                base.Peek();
                base.Pop();
            }
        }
    }
}
