using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue operations using Linked List");
            StackOperations stackList = new StackOperations();
            stackList.Push(70);
            stackList.Push(30);
            stackList.Push(56);
            stackList.Display();
            stackList.IsEmpty();
            stackList.Display();
            Console.ReadKey();
        }
    }
}
