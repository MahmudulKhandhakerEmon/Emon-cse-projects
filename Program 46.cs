//This Code Written By Mahmudul Khandhaker Emon 

using System;

class Program
{
   
    static int MyMethod(int x)
    {
        
        return x * 2; 
    }

    static float MyMethod(float x)
    {
        
        return x * 2.5f; 
    }

    static double MyMethod(double x, double y)
    {
        
        return x + y; 
    }

    static int PlusMethodInt(int x, int y)
    {
        return x + y;
    }

    static double PlusMethodDouble(double x, double y)
    {
        return x + y;
    }

    static void Main(string[] args)
    {
        int myNum1 = PlusMethodInt(8, 5);
        double myNum2 = PlusMethodDouble(4.3, 6.26);

        Console.WriteLine("Int: " + myNum1);
        Console.WriteLine("Double: " + myNum2);

        int resultInt = MyMethod(10);
        float resultFloat = MyMethod(3.5f);
        double resultDouble = MyMethod(2.5, 4.5);

        Console.WriteLine("MyMethod (int): " + resultInt);
        Console.WriteLine("MyMethod (float): " + resultFloat);
        Console.WriteLine("MyMethod (double): " + resultDouble);
    }
}