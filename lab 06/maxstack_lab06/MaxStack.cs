using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxstack_lab06
{
    public class MaxStack
    {
        public Stack<int> stack=new Stack<int>();
        public Stack<int> maxStack;

      public MaxStack()
        {
            stack = new Stack<int>();
            maxStack = new Stack<int>();


        }

        public void push(int x)
        {
            stack.Push(x);
            if(maxStack.Count==0 || x >= maxStack.Peek())
            {
                maxStack.Push(x);
            }


        }



        public void pop()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("stack is empty");
            }
            
           
            if (stack.Peek() == maxStack.Peek())
            {
              maxStack.Pop();
            }
           stack.Pop();

        }

        public int Max()
        {

            if(maxStack.Count == 0)
            {
                throw new InvalidOperationException("stack empty");
            }

            return maxStack.Peek();
        }
    }
}
