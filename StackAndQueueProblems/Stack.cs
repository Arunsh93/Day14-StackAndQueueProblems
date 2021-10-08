using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueProblems
{
    class Stack
    {
        internal Node top;

        public Stack()
        {
            this.top = null;
        }

        //Pushing Elemnts in the Stack
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if(top == null)
            {
                top = newNode;
            }
            else
            {
                newNode.Next = top;
                top = newNode;
            }
            Console.WriteLine("{0} Pushed to Stack ", data);
        }

        //checking stack is empty or not
        public bool isEmpty()
        {
            return top == null;
        }

        //peek element(top element in the Stack)
        public int Peak()
        {
            if (!isEmpty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
        }

        public void Pop()
        {
            if(top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            top = top.Next;
        }

        public void Display()
        {
            if(top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                Node temp = top;
                while(temp != null)
                {
                    Console.WriteLine("{0}->", temp.data);
                    temp = temp.Next;
                }

                Console.WriteLine();
            }
        }
    }
}
