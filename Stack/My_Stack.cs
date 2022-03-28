using System;
using System.Collections.Generic;
namespace Stack
{/// <summary>
 /// Stack ---> Last in First out (LIFO)
 /// </summary>
    public class My_Stack<Gtype>
    {
        //variable
        Node<Gtype> top;

        //Using Constructor

        public My_Stack()
        {
            this.top = null;
        }
        //method to push element in stack
        public void push(Gtype data)
        {
            //create node
            Node<Gtype> node = new Node<Gtype>(data);
            //If top is null mark it as node,there is no linking
            if (top is null)
            {
                top = node;
            }
            else //make new node--> link with top---> mark it top
            {
                //linking 
                node.next = top;
                //mark it as a top
                top = node;
            }
        }
        //method to show element
        public void Show()
        {
            //start from top and traverse upto last
            Node<Gtype> temp_top = top;

            while (temp_top.next != null)
            {
                Console.WriteLine(temp_top.value + " ");
                temp_top = temp_top.next;
            }
            Console.WriteLine(temp_top.value);
        }
        //to check stack is empty or not
        public bool IsEmpty()
        {
            if (top is null) return true;
            else return false;
        }

        public Gtype Pop()
        {
            //variable
            Gtype temp;

            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return default(Gtype);
            }
            //stack has onw element  --> remove the element
            else if (top.next is null)
            {
                temp = top.data;
                top = null;
                return temp;
            }
            else // remove top and assign top as  next element 
            {
                temp = top.data;
                top = top.next;
                return temp;
            }
        }

        public void pop_pos(int pos)
        {
            //variable
            int length = Size();
            //user is giving the position from uper side
            //so we need to go to that position so length - pos -1
            pos = length - pos - 1;
            Node<Gtype> temp_node;
            Node<Gtype> temp;

            if (pos < 0 || pos >= length)
            {
                Console.WriteLine("Index out of Boundary");
                return;
            }
            temp_node = top;
            //if in stack we have one element so to remove it
            if (top.next is null)
            {
                top = null; return;
            }
            //remove the top and and change top position 
            if (pos == 0) top = temp_node.next;
            //traverse upto just before element and remove it
            for (int i = 1; i < pos; i++) temp_node = temp_node.next;
            temp = temp_node.next;
            temp_node.next = temp.next;
        }

        public Gtype Peak()
        {
            return top.data;
        }

        public int Size()
        {
            //temp variable
            Node<Gtype> temp;
            int count = 0;
            //check that stack is empty or not
            if (IsEmpty()) return 0;
            //traverse and count the element in the stack
            temp = top;
            count++;

            while (temp.next != null)
            {
                count++;
                temp = temp.next;

            }
            return count;

        }

    }
}
