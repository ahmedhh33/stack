using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class Stack
    {
        private int[] stack;
        private int Top;

        public Stack(int n)
        {
            stack = new int[n];
            Top = -1;
        }

        public void Push(int number)
        {
            if(Top >= stack.Length-1)
            {
                Console.WriteLine("The stack is full");
                return;//to avoid ex
            }
            //Top++ same as ex[resstio bellow
            stack[++Top] = number;

        }
        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("stack is empty");
                return -1;
            }
            return stack[Top--];
        }

        public int peak()
        {
            if (IsEmpty())
            {
                Console.WriteLine("stack is empty");
            }
            return stack[Top];
        }
        private bool IsEmpty()
        {
            return Top == -1;
        }
    }
}
