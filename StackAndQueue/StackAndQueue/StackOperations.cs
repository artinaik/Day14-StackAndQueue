using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
            
    }
    public class StackOperations
    {
        public Node top;
        public void Push(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = top;
            }
            top = node;
            Console.WriteLine("Element {0} is added to stack", top.data);
        }
        public void Display()
        {
            if (top == null)
                Console.WriteLine("Stack is empty");
            else
            {
                Node temp = top;
                Console.Write("Elements in stack are :");
                while (temp != null)
                {
                    Console.Write(" " + temp.data);
                    temp = temp.next;
                }
            }
               
        }
    }
}
