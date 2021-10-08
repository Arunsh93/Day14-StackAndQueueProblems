using System;

namespace StackAndQueueProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(56);
            stack.Push(30);
            stack.Push(70);

            int peakElement = stack.Peak();
            Console.WriteLine("The Peak(top) Element of the Stack is: " + peakElement);

            stack.Pop();
            Console.WriteLine("After Poping the Element: ");
            stack.Display();
        }
    }
}
