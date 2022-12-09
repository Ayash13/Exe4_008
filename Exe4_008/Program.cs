using System;

namespace Exe4_008
{
    class Stack
    {
        //create variable
        private decimal[] ayash;
        private int top;
        private int maxSize;

        //method stack to save the size of array
        public Stack(int size)
        {
            ayash = new decimal[size];
            top = -1;
            maxSize = size;
        }

        //method push
        public void Push(decimal value)
        {
            //condition if push = maxsize show eror
            if (top == maxSize - 1)
            {
                Console.WriteLine("Error: Stack is full!");
            }
            //elsee put the number to stack
            else
            {
                top++;
                ayash[top] = value;
            }
        }

        //method pop
        public decimal Pop()
        {
            //condition if stack empty = show eror
            if (top == -1)
            {
                Console.WriteLine("Error: Stack is empty!");
                return 0;
            }
            //else pop the number
            else
            {
                decimal value = ayash[top];
                top--;
                return value;
            }
        }

        //method display
        public void Display()
        {
            //condition if stack empty = show error
            if (top == -1)
            {
                Console.WriteLine("Error: Stack is empty!");
            }
            
        }
    }

    
}