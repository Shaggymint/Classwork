using System;

//Exercise 2

namespace FibonacciApp
{
    class CustomFibonacciSequence
    {
        public void GenerateCustomSequence()
        {
            Console.Write("Enter the starting position (L1) in the Fibonacci sequence: ");
            if (!int.TryParse(Console.ReadLine(), out int start) || start < 0)
            {
                Console.WriteLine("Please enter a valid non-negative integer for the starting position.");
                return;
            }

            Console.Write("Enter the number of elements to display (L2): ");
            if (!int.TryParse(Console.ReadLine(), out int length) || length <= 0)
            {
                Console.WriteLine("Please enter a valid positive integer for the number of elements.");
                return;
            }

            // Pre-compute enough Fibonacci numbers to handle any valid user input
            int maxSize = start + length;
            int[] fibonacci = new int[maxSize];
            fibonacci[0] = 0;
            if (maxSize > 1)
            {
                fibonacci[1] = 1;
            }
            
            for (int i = 2; i < maxSize; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            Console.WriteLine("Custom Fibonacci sequence:");
            for (int i = start; i < start + length; i++)
            {
                Console.Write(fibonacci[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
