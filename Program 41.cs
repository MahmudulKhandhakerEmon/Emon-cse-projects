// This Code Written by Mahmudul Khandhaker Emon
using System;
using System.Linq; // Importing the System.Linq namespace

namespace MyApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] myNumbers = { 5, 1, 8, 9 };

            Console.WriteLine(myNumbers.Max()); 
            Console.WriteLine(myNumbers.Min()); 
            Console.WriteLine(myNumbers.Sum()); 
        } 
    } 
} 