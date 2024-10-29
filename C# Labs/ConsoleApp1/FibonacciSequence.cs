using System;

//Exercise 1

namespace FibonacciApp
{
    class FibonacciSequence
    {
        public void GenerateSequence()
        {
            Console.Write("Enter the number of elements in the Fibonacci sequence: ");
            if (int.TryParse(Console.ReadLine(), out int numElements) && numElements > 0)
            {
                int[] fibonacci = new int[numElements];
                fibonacci[0] = 0;
                if (numElements > 1)
                {
                    fibonacci[1] = 1;
                }
                
                for (int i = 2; i < numElements; i++)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }

                Console.WriteLine("Fibonacci sequence:");
                foreach (int number in fibonacci)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Please enter a positive integer.");
            }
        }
    }
}
