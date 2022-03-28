using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            My_Stack<int> myStack = new My_Stack<int>();

            myStack.push(10);
            myStack.push(20);
            myStack.push(30);
            myStack.push(40);
            myStack.push(50);
            myStack.push(60);
            myStack.push(70);
            myStack.push(80);
            myStack.push(90);

            myStack.Show();


        }
    }
}
