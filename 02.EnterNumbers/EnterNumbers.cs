// Problem 2. Enter numbers
// Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
// If an invalid number or non-number text is entered, the method should throw an exception.
// Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

namespace _02.EnterNumbers
{
    class EnterNumbers
    {
        static int ReadNumbers(int start, int end, int value)
        {
            if (value < start || value > end)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
                return value;
        }

        static void Main()
        {
            try
            {
                Console.Write("Enter start number: ");
                int startNumber = int.Parse(Console.ReadLine());
                Console.Write("Enter end number: ");
                int endNumber = int.Parse(Console.ReadLine());
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Enter a number in the given range: ");
                    int number = int.Parse(Console.ReadLine());
                    ReadNumbers(startNumber, endNumber, number);
                    startNumber = number;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Number is not in the given range!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a number!");
            }
        }
    }
}
