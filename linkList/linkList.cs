using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linkList
{
    public class Node
    {
        public Node next;
        public Object data;
    }

    public class LinkedList
    {
        private Node head;

        public void printAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void AddFirst(Object data)
        {
            Node toAdd = new Node();

            toAdd.data = data;
            toAdd.next = head;            
            head = toAdd;
        }

        public void AddLast(Object data)
        {
            if (head == null)
            {
                head = new Node();

                head.data = data;
                head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }
        public void deleteNode(ref Node head)
        {
            //Node pre = new Node();
            //Node cur = new Node();
            

            //while (cur.next != null)
            //{
                              
            //     if(!cur.data.Equals(data))
            //     {
            //         pre.next = cur.next;
            //         cur = cur.next;
            //     }
            //     else if (cur.data == data)
            //     {
            //         pre.next = cur.next;
            //     }

            //}


            Node p = head, n = null;
            while (p != null)
            {
                Node tmp = p.next;
                p.next = n;
                n = p;
                p = tmp;
            }
            head = n;


        }

        public void Reverse(ref Node root)
        {
            Node tmp = root;
            Node nroot = null;
            Node prev = null;

            while (tmp != null)
            {
                //Make a new node and copy tmp
                nroot = new Node();
                nroot.data = tmp.data;

                nroot.next = prev;
                prev = nroot;
                tmp = tmp.next;
            }
            root = nroot;
        }
    }

    
}
