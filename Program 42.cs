//The Code Written By Mahmudul Khandhaker Emon
using System;

namespace Hello_World
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

            // Using foreach to print elements (this works but is less common for multi-dimensional arrays)
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            // Using nested for loops to print elements
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }
        }
    }
}