using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stackQueue
{
    class queue:stack
    {
        private object[] queueArray = new object[5];
        private int front;
        private int rear;
        
        
        public queue()
        {
            front = 0;
            rear = 0;
        }
        public void printQ()
        {
            for (int i = 0; i < queueArray.Length; i++)
            {
                Console.WriteLine(queueArray[i]);
            }
        }
        public  bool emptyCheck()
        {
            if (rear == front)
            {
                return true;
            }
            else
                return false;
        }

        public void insertQue(object a)
        {
           
            if (rear == queueArray.Length)
            {
                Console.WriteLine("queue is full!");
            }
            else
            {
                queueArray[rear] = a;

                rear++;
            }
                 
        }

        public void delQue()
        {
            if (front == rear)
            {
                Console.WriteLine("queue is empty!");
            }
            else 
            {
                queueArray[front] = null;
                front++;
            }
         
        }
        
    }

   
}
