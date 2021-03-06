﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = UserInput();

            List<int> userInputNumbers = ConvertArrayStringToListInt(inputLine.Split(" "));

            if (userInputNumbers.Count != 0)
            {
                List<int> userInputNumberNoDups = RemoveDuplicates(userInputNumbers);

                Console.Write("\n => Numbers to be summed: ");

                foreach (var number in userInputNumberNoDups)
                {
                    Console.Write(number + " ");
                }

                int sum = userInputNumberNoDups.Sum();
                Console.WriteLine("\n || Sum = " + sum + " ||\n");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("=> No numbers entered! Please try again =) ");
                Console.ReadLine();
            }

            doFibonacci();
        }

        private static string UserInput()
        {
            Console.WriteLine("=> Enter numbers: ");
            return Console.ReadLine();
        }

        private static List<int> ConvertArrayStringToListInt(string[] userInput)
        {
            Console.WriteLine("\n => Converting string into list of numbers ... \n");

            List<int> numbersList = new List<int>();

            for (int i = 0; i < userInput.Length; i++)
            {
                try
                {
                    numbersList.Add(Convert.ToInt32(userInput[i]));
                }
                catch (FormatException)
                {
                    Console.WriteLine("=> Not a number : " + userInput[i]);
                }
            }

            return numbersList;
        }

        private static List<int> RemoveDuplicates(List<int> numbers)
        {
            Console.WriteLine("\n => Removing duplicates from list of numbers...");

            List<int> noDupList = new List<int>();

            noDupList = numbers.Distinct().ToList();

            return noDupList;
        }

        private static void doFibonacci()
        {
            int number = 0;

            Console.Write("Enter a number: ");
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

                for (int i = 0; i < 15; i++)
                {
                    Console.WriteLine(Fibonacci(i));
                }
            }

            Console.ReadLine();

        }

        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
