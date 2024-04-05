using System;
using System.Collections;
namespace TypeConversion;

class Program{
public static void Main(string[] args)
{
 Console.Write("Enter Range starting number: ");
 int number1 = int.Parse(Console.ReadLine());
 Console.Write("Enter Range ending number: ");
 int number2 = int.Parse(Console.ReadLine());
 int sum=0;

 for(int i=number1; i<=number2; i++)
 {
    sum+=(i*i);
 }
 Console.WriteLine(sum);
}
}