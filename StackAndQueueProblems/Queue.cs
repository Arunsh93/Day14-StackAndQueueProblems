using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueProblems
{
    class Queue
    {
        Node Front, Rear;

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if(this.Rear == null)
            {
                this.Rear = newNode;
            }
            else
            {
                this.Rear.Next = newNode;
                this.Rear = newNode;
            }
            Console.WriteLine("{0} Inserted into Queue: " + data);
        }
    }
}
