﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linkList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add First:");
            LinkedList myList1 = new LinkedList();

            myList1.AddFirst("Hello");
            myList1.AddFirst("Magical");
            myList1.AddFirst("World");
            myList1.printAllNodes();
           // myList1.Reverse();

            Console.WriteLine();

            Console.WriteLine("Add Last:");
            LinkedList myList2 = new LinkedList();

            myList2.AddLast("Hello");
            myList2.AddLast("Magical");
            myList2.AddLast("World");
            myList2.printAllNodes();

         //   myList2.deleteNode("Hello");
            myList2.printAllNodes();

            Console.ReadLine();
        }
    }
}
