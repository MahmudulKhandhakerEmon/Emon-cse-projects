//This Code Written by Mahmudul Khandhaker Emon


using System;

namespace HelloWorld
{
    public class Program 
    {
        public static void Main(string[] args)
        {
        

string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

foreach (string i in cars)

{

Console.WriteLine(i);

}

int[] myNumbers = {5, 1, 8, 9};

Array.Sort(myNumbers);

foreach (int i in myNumbers)

{

Console.WriteLine(i);

}



        }
    }
} 