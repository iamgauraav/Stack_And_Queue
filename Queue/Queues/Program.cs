using System;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            My_Queue<int> my_Queue = new My_Queue<int>();
            my_Queue.Enqueue(20);
            my_Queue.Enqueue(30);
            my_Queue.Enqueue(40);
            my_Queue.Enqueue(50);
            my_Queue.Enqueue(60);
            my_Queue.Enqueue(70);
            my_Queue.Enqueue(80);
            my_Queue.Enqueue(90);

            my_Queue.show();
        }
    }
}
