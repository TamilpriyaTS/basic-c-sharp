using System;
using System.Collections;
using System.Globalization;
namespace TypeConversion;

class Program{
public static void Main(string[] args)
{
    Console.Write("EXERCISE 1");
    int number = 0;
    while(number<=25)
    {
        Console.WriteLine(number);
        number++;
    }


    Console.WriteLine("EXERCISE 2");
    Console.Write("Enter a number: ");
    bool isValid = int.TryParse(Console.ReadLine(), out int output);

    while(!isValid)
    {
        Console.Write("Invalid input format. Please enter the input in number format:");
        isValid = int.TryParse(Console.ReadLine(), out output);
    } 
    Console.Write("Correct Input");
}
}