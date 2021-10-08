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

        public void Dequeue()
        {
            Node temp = this.Front;
            this.Front = this.Front.Next;

            if(this.Front == null)
            {
                this.Rear = null;
            }
            Console.WriteLine("Item Deleted is {0}", temp.data);
        }
        
    }
}
