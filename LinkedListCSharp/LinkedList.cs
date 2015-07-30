using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListCSharp
{
    public class LinkedList
    {
        private Node head;
        public bool Empty
        {
            get { return this.head == null; }
        }

        public void AddToBeginning(object obj)
        {
            Node nodeToAdd = new Node(obj, head);
            head = nodeToAdd;
        }

        public void AddToEnd(object obj)
        {
            if (this.Empty)
            {
                this.head = new Node(obj);
            }
            else
            {
                Node nodeToAdd = new Node(obj);
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = nodeToAdd;
            }
        }

        public bool IsFound (object obj)
        {
            Node nodeToFind = new Node(obj, null);
            Node current = head;
            while (current.Next != null)
            {
                if (current.Equals(nodeToFind))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void PrintAllNodeData()
        {
            Node current = head;
            while (current.Next != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
