using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stackQueue
{
    class stack
    {  
       private int[] stackArray = new int[3];
       private int top ;

       public stack()
       {
           top = -1;
    
       }
        public void print()
        {
            for (int i = 0; i < stackArray.Length; i++)
            {
                Console.WriteLine(stackArray[i]);
            }
        }
       public virtual bool empty()
       {
           if (top == -1)
               return true;
           else
               return false;
       }

       public bool full()
       {
           if (top == stackArray.Length - 1)
               return true;
           else
               return false;
       }

        public bool push(int  num)
        {
            bool f = full();
            if (f == false)
            {
                top++;
                stackArray[top] = num;
                return true;
            }
            else
                return false;
           
        }

        public int pop()
        { 
           bool e = empty();
           if (e == false)
           {
               int temp = stackArray[top];
               top--;
               return temp;
           }
           else
               return 0;
        
        }



    }
}
