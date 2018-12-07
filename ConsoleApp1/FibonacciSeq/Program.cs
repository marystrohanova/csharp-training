using System;

namespace FibonacciSeq
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();
            try
            {
                number = Int32.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine(input + " is not a number! Try again! :) ");
            }

            if (number != 0)
            {
                
            }

            
            
        }
    }
}
