using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace doublyLinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            doublyLinkList dList = new doublyLinkList();

            dList.addFirst(1);
            dList.addFirst(2);
            dList.addFirst(3);
            dList.addFirst(4);
          //  addList.printAllNodes();

            Console.WriteLine("********");
            dList.addLast(5);
            dList.addLast(6);
            dList.addLast(7);
            dList.addLast(8);
            Console.WriteLine("link list sort is equal with:");
            dList.printAllNodes();
            Console.WriteLine("********");
            dList.deleteNode(5);
            Console.WriteLine("link list after delete 5:");
            dList.printAllNodes();
             dList.reverse();
            //Console.WriteLine("link list after delete 5:");
           // dList.printAllNodes();

            int a = dList.search(7);
            Console.WriteLine("Number of Node:{0} ",a);

            Console.ReadKey();

        }
    }
}
