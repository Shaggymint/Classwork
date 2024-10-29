using System;

namespace FibonacciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            var fibonacciSequence = new FibonacciSequence();
            fibonacciSequence.GenerateSequence();

            // Exercise 2
            var customFibonacciSequence = new CustomFibonacciSequence();
            customFibonacciSequence.GenerateCustomSequence();
        }
    }
}
