//The Code Written By Mahmudul Khandhaker Emon
using System;

namespace Nahrin_Medam
{
    public class Program 
    {
        // Define MyMethod outside of Main
        static void MyMethod(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }

        // Correctly define the Main method
        public static void Main(string[] args)
        {
            MyMethod("John", 5);
            MyMethod("William", 8);
            MyMethod("Jane", 31);
        }
    }
}
