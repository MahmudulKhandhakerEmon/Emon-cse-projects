//This Code Written by Mahmudul Khandhaker Emon


using System;

namespace HelloWorld
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            // First loop using for
            for (int i = 0; i < 10; i++) 
            {
                if (i == 4) 
                {
                    continue; // Skip the rest of the loop when i is 4
                }
                Console.WriteLine(i); // Print i
            }

            // Second loop using while
            int j = 0; // Use a different variable name to avoid conflict
            while (j < 10)
            {
                Console.WriteLine(j); // Print j
                j++;

                if (j == 4)
                {
                    break; // Exit the loop when j is 4
                }
            }

            // Third loop using while
            int k = 0; // Use another different variable name
            while (k < 10)
            {
                if (k == 4)
                {
                    k++; // Increment k before continuing to avoid infinite loop
                    continue; // Skip the rest of the loop when k is 4
                }
                Console.WriteLine(k); // Print k
                k++;
            }
        }
    }
} 