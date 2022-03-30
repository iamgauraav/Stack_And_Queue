using System;
using System.Collections.Generic;
namespace Queues
{/// <summary>
/// Queue ---> First in first out (FIFO)
/// </summary>
/// <typeparam name="Gtype"></typeparam>
    public class My_Queue<Gtype>
    {
        Node<Gtype> front;
        Node<Gtype> rare;


        public void Enqueue(Gtype data)
        {
            //creating node with given data
            Node<Gtype> node = new Node<Gtype>(data);

            //if the given element is first element
            //front element = rare element
            //we can check anyone either front or rare
            if (rare is null)
            {
                front = node;
                rare = node;
            }
            else
            {
                rare.next = node;
                rare = node;
            }
        }

        public void show()
        {
            //Created a temp variable
            Node<Gtype> temp = front;
            //traverse from front to last element and print element
            if (temp is null) Console.WriteLine("Queue is Empty");
            else
            {
                while (temp.next != null)
                {
                    Console.Write(temp.value + " ");
                    temp = temp.next;
                }
                //to print the last value
                Console.WriteLine(temp.value);
            }
        }

        public Gtype Dequeue()
        {
            //Created a temp variable
            Node<Gtype> temp;
            //If queue is empty return default value
            if (ISEmpty())
            {
                Console.WriteLine("Print queue is Empty");
                return default(Gtype);
            }
            else
            {
                temp = front;

                if (front.next == null)
                {
                    front = null;
                }
                else
                {
                    front = front.next;
                }
                return temp.value;
            }
        }

        public bool ISEmpty()
        {
            if (front is null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    
}
