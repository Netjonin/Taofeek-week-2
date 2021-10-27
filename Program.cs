using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        //Implementation of the methods in Stack, Queue and LinkedList
        static void Main(string[] args)
        {
            //List of names to be pushed into the stack
            List<string> names = new List<string>{"Mr Ibe", "Louis", "Solomon", "Clemet", 
            "Ahmed", "Taofeek", "Kamilu", "Ugo", "Ben"};

            Stack<string> stack = new Stack<string>();

            foreach(string name in names) {
                stack.Push(name);
            }
            
            //checking whether stack is empty
            Console.WriteLine(stack.IsEmpty());

            //removing an item from top of the stack
            Console.WriteLine(stack.Pop());

            //Checking the no of items
            Console.WriteLine(stack.Size());

            //Returning the last item in the stack
            Console.WriteLine(stack.Peek());

            //Implementation for Queue methods
            Queue<int> queue = new Queue<int>();
            List<int> nums = new List<int>{20, 30, 40, 50, 60};

            foreach(int num in nums) {
                queue.Enqueue(num);
            }
            
            //checking whether queue is empty
            Console.WriteLine(queue.IsEmpty());

            //removing an item from the queue
            Console.WriteLine(queue.Size());

            //Checking the no of items
            Console.WriteLine(queue.Dequeue());

            //Implementation of LinkedList
            LinkedList<char> linkedlist = new LinkedList<char>();

            Console.WriteLine(linkedlist.Add('a'));
            Console.WriteLine(linkedlist.Check('b'));
            Console.WriteLine(linkedlist.Index('c'));
            Console.WriteLine(linkedlist.Remove('b'));

            

            
        }
    }
}
