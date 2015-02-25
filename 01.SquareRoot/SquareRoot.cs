// Problem 1. Square root
// Write a program that reads an integer number and calculates and prints its square root.
// If the number is invalid or negative, print Invalid number.
// In all cases finally print Good bye.
// Use try-catch-finally block.

using System;

namespace _01.SquareRoot
{
    class SquareRoot
    {
        public static double Sqrt(double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Sqrt for negative numbers is undefined!");
            }
            else
            {
                return Math.Sqrt(value);
            }
        }

        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                double number = int.Parse(Console.ReadLine());
                double result = Sqrt(number);
                Console.WriteLine(result);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Invalid number" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
