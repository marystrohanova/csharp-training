using System;
using System.Collections.Generic;

namespace FibonacciSeq
{
    class Program
    {
        public static void doFibonacci()
        {
            int number = 0;
            int[] fibInts = new int[number];

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

            if (number != 0 || number < 0)
            {

                fibInts = new int[number];
                fibInts[0] = 0;
                fibInts[1] = 1;

                for (int i = 1; i < number; i++)
                {
                    fibInts[number] = fibInts[i] + fibInts[i - 1];
                    Console.WriteLine(fibInts[number]);
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Cannot process sequence. Number is 0 or less then 0");
            }

        }
    }
}
