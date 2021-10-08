using System;

namespace StackAndQueueProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);


           /* Stack stack = new Stack();
            stack.Push(56);
            stack.Push(30);
            stack.Push(70);

            int peakElement = stack.Peak();
            Console.WriteLine("The Peak(top) Element of the Stack is: " + peakElement);

            stack.Pop();
            Console.WriteLine("After Poping the Element: ");
            stack.Display();*/
        }
    }
}
