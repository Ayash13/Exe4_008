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
            //else display stack
            else
            {
                Console.WriteLine("Stack: ");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(ayash[i]);
                }
            }
        }
    }

    class Program
    {
        //method main
        static void Main(string[] args)
        {
            //instantiate Stack
            //sizing array of stack
            Stack stack = new Stack(27);

            //create var
            int choice;
            decimal value;

            //create condition to choose menu
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        //function for push number to stack
                        Console.Write("Enter value to push: ");
                        value = decimal.Parse(Console.ReadLine());
                        stack.Push(value);
                        break;
                    case 2:
                        //function to pop number
                        value = stack.Pop();
                        if (value != 0)
                        {
                            Console.WriteLine("Popped value: " + value);
                        }
                        break;
                    case 3:
                        //to thisplay stack
                        stack.Display();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Error: Invalid choice!");
                        break;
                }
            }
            while (choice != 4);
        }
    }
}