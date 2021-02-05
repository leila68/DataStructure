using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            stack st1 = new stack();
            queue qu1 = new queue();

          
            for (int i = 1; i <= 4; i++)
            {
                st1.push(i);
            }
            

            for (int i = 1; i <= 3; i++)
            {
                st1.pop();

            }

            
            for (int i = 6; i <= 8; i++)
            {
                st1.push(i);
            }
            st1.print();
            qu1.insertQue(5);
            qu1.insertQue(6);
            qu1.insertQue(7);
            qu1.delQue();
            qu1.printQ();
            bool re1 = qu1.emptyCheck();
            if (re1 == true)
                Console.WriteLine("queue is empty");
            Console.ReadKey();

        }
    }
}
