using System;

namespace IntegralApp
{
    class IntegralCalculator
    {
        public void CalculateIntegral()
        {
            Console.Write("Enter the number of rectangles for approximation: ");
            if (int.TryParse(Console.ReadLine(), out int numRectangles) && numRectangles > 0)
            {
                double a = 0.0;       // Start of interval
                double b = 2.0;       // End of interval
                double dx = (b - a) / numRectangles;  // Width of each rectangle
                double integralValue = 0.0;

                for (int i = 0; i < numRectangles; i++)
                {
                    double x = a + i * dx;           // Left endpoint of the rectangle
                    double y = 0.5 * x;              // Function value at x
                    integralValue += y * dx;         // Rectangle area (height * width)
                }

                Console.WriteLine($"Approximate value of the integral is: {integralValue}");
            }
            else
            {
                Console.WriteLine("Please enter a positive integer for the number of rectangles.");
            }
        }
    }
}
