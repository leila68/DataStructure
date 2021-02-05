using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace doublyLinkList
{
    public class node
    {
        public object data;
        public node next;
        public node previous;

        public node()
        { 
        }

        public node(node newNode)
        {
            data = newNode.data;
            next = newNode.next;
            previous = newNode.previous;
        }
    }
       
    class doublyLinkList
    {
        public doublyLinkList()
        {
 
        }
        
        private node head;
        

        public void printAllNodes()
        {
           
            node current = head;
            if (current.next == null)
            {
                while (current.previous != null)
                {
                    current = current.previous;
                }
                head = current;
                
                               
            }
           
            
           
           while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
           Console.WriteLine(current.data);
           
        }
        public void addFirst(object data)
        {
            node add = new node();
            
          
            if (head != null)
            {
                add.data = data;
                head.previous = add;
                add.next = head;
                head = add;
            }
            else
            {
                add.data = data;
                add.next = null;
                add.previous = null;
                head = add;
            }
                 
                
        }

        public void addLast(object data)
        {
            node addLast = new node();
            node current = new node();
            current = head;
            if (head == null)
            {
                addLast.data = data;
                addLast.previous = null;
                addLast.next = null;
                head = addLast;
            }
            else
            {
                while (current.next != null)
                {
                    current = current.next;
                }

                addLast.data = data;
                current.next = addLast;
                addLast.previous = current;
               // addLast.next = null;
                head = addLast;
            } 
        }

        public int search(object data)
        {
            node searchNode;
            int count=0;
            searchNode = head;

            while(searchNode.previous != null)
            {
                count++;
                if (searchNode.data.Equals(data))
                {
                    return count;
                        
                }
                searchNode = searchNode.previous;
            }

            searchNode = searchNode.previous;
            if (searchNode.data.Equals(data))
            {
                return count;

            }
            else

             return 0;
        }
        

         public void deleteNode(object data)
        {
            node current = head;
            node previous = null;
            node deleted = null;
            while(current.next != null)
            {
                if (current.data.Equals(data))
                {
                   
                    if (previous == null)
                    {

                        current = current.next;
                        current.previous = null;
                        head = current;
                    }
                    else
                    {
                        deleted = current;
                        current = current.next;
                        current.previous = previous;
                        previous.next = current;
                        deleted.previous = null;
                        deleted.next = null;
                    }
                }

                else 
                {
                    previous = current;
                    current = current.next;
                }
                   

            }

            
        }

        public void reverse()
        {

            node temp = null;
            node root = head;

            while (root.next != null)
            {
                temp = root.next;
                root.next = root.previous;
                root.previous = temp;
                root = temp;

            }
            temp = root.previous;
            root.previous = null;
            root.next = temp;
            Console.WriteLine("Reverse: ");
            while (root.next != null)
            {
                Console.WriteLine(root.data);
                root = root.next;
            }
            Console.WriteLine(root.data);

        }
    }
}
