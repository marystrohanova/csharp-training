using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

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

                Console.WriteLine("");
                Console.WriteLine("Numbers to be summed: ");

                foreach (var number in userInputNumberNoDups)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();

                int sum = userInputNumberNoDups.Sum();
                Console.WriteLine("Sum = " + sum);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No numbers entered! Please try again =) ");
                Console.ReadLine();
            }
        }

        private static string UserInput()
        {
            Console.WriteLine("Enter numbers: ");
            return Console.ReadLine();
        }

        private static List<int> ConvertArrayStringToListInt(string[] userInput)
        {
            Console.WriteLine("Converting string into list of numbers ...");

            List<int> numbersList = new List<int>();

            for (int i = 0; i < userInput.Length; i++)
            {
                try
                {
                    numbersList.Add(Convert.ToInt32(userInput[i]));
                }
                catch (FormatException)
                {
              
                }
            }

     

            return numbersList;
        }

        private static List<int> RemoveDuplicates(List<int> numbers)
        {
            Console.WriteLine("Removing duplicates from list of numbers...");

            List<int> noDupLis = new List<int>();

            try
            {
               noDupLis =  numbers.Distinct().ToList();
            }
            catch (ArgumentNullException )
            {
                Console.WriteLine("Incorrect input!");
            }

            return noDupLis;

        }
    }
}
