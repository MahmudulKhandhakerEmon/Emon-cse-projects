// This Code Written By Mahmudul Khandhaker Emon
using System;

class Program
{
    public static void Main(string[] args)
    {
        int myInt1 = 9;

        // Automatic casting: int to double
        double myDouble1 = myInt1; // Corrected variable name

        Console.WriteLine(myInt1); // Outputs 9
        Console.WriteLine(myDouble1); // Outputs 9.0

        double myDouble2 = 9.78;

        // Manual casting: double to int
        int myInt2 = (int)myDouble2; 

        Console.WriteLine(myDouble2); // Outputs 9.78
        Console.WriteLine(myInt2); // Outputs 9
    }
}