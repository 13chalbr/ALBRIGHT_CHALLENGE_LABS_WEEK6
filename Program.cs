using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALBRIGHT_CHALLENGE_LABS_WEEK6
{
    internal class Program
    {
        // MSSA CCAD16 - 12DEC2024
        // CHRIS ALBRIGHT
        // CHALLENGE LAB - WEEK 6
        static void Main(string[] args)
        {
            //Challenge Lab 6.1.---------------------------------------------------------------------------------------------

            // Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

            Console.WriteLine("Challenge Lab 6.1: ---------------------------------------------------------------------");
            Console.WriteLine("SINGLE INSTANCE FINDER:");
            char hold1 = 'y';
            do
            {
                Console.WriteLine("\nHow large of an integer array do you want to create?:");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Enter array[{i}]:");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                Dictionary<int,int> counts = new Dictionary<int,int>();
                foreach (int var in array)
                {
                    if (counts.ContainsKey(var))
                    {
                        counts[var]++;
                    }
                    else
                    {
                        counts[var] = 1;
                    }
                }
                Console.WriteLine("\nYour inputted array is as follows:");
                Console.Write($"[ ");
                foreach (int var in array)
                {
                    Console.Write($"{var}, ");
                }
                Console.Write("]");
                var singleInstance = counts.Where(kvp => kvp.Value == 1).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                
                foreach(var kvp in  singleInstance)
                {
                    Console.WriteLine($"\n\nSingle instance number: {kvp.Key}.");
                }
                Console.WriteLine($"\nWant to run Challenge Lab 6.1 again? type y/n");
                hold1 = Console.ReadKey().KeyChar;
                hold1 = Char.ToLower(hold1);
            }
            while (hold1 == 'y');

            //Challenge Lab 6.2.---------------------------------------------------------------------------------------------

            // Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that
            // is missing from the array.

            Console.WriteLine("\n\nChallenge Lab 6.2: ---------------------------------------------------------------------");
            Console.WriteLine("RETURN MISSING NUMBER:");
            char hold2 = 'y';
            do
            {
                Console.WriteLine("\nHow large of an integer array do you want to create?:");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] nums = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Enter nums[{i}]:");
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\nYour inputted nums array is as follows:");
                Console.Write($"[ ");
                foreach (int var in nums)
                {
                    Console.Write($"{var}, ");
                }
                Console.Write("]");
                Dictionary<int, int> wholeNumbers = new Dictionary<int, int>();
                for (int i =0; i  <= n; i++)
                {
                    wholeNumbers[i] = 1;
                }
                foreach (int var in nums)
                {
                    if (wholeNumbers.ContainsKey(var))
                    {
                        wholeNumbers[var]++;
                    }
                }
                var missingNumber = wholeNumbers.Where(kvp => kvp.Value == 1).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                foreach (var kvp in missingNumber)
                {
                    Console.WriteLine($"\n\nInput array missing = ({kvp.Key}) in the whole number sequence [0,{n}]");
                }
                Console.WriteLine($"\nWant to run Challenge Lab 6.2 again? type y/n");
                hold2 = Console.ReadKey().KeyChar;
                hold2 = Char.ToLower(hold2);
            }
            while (hold2 == 'y');

            Console.WriteLine("Goodbye!");
        }
        //------------------------------------------------------METHODS---------------------------------------------------
    }
}
