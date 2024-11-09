fd//This code Write by Mahmudul Khandhaker Emon
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string name = "John Doe";
        int charPos = name.IndexOf("D"); // Finds index of 'D'
        
        // Calculate length of last name
        int length = name.Length - charPos; // Length from 'D' to end of string
        
        string lastName = name.Substring(charPos, length); 
        Console.WriteLine(lastName);
    }
}