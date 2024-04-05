using System;
using System.Collections;
namespace TypeConversion;

class Program{
public static void Main(string[] args)
{
    Console.Write("Enter number 1: ");
    float number1 = float.Parse(Console.ReadLine());

    Console.Write("Enter number 2: ");
    float number2 = float.Parse(Console.ReadLine());

    Console.Write("Enter the operation to perform:");
    char operation = char.Parse(Console.ReadLine());

    switch(operation)
    {
        case '+':
        {
            Console.WriteLine($"{number1+number2}");
            break;
        }
        case '-':
        {
            Console.WriteLine($"{number1-number2}");
            break;
        }
        case '*':
        {
            Console.WriteLine($"{number1*number2}");
            break;
        }
        case '/':
        {
            Console.WriteLine($"{number1/number2}");
            break;
        }
        case '%':
        {
            Console.WriteLine($"{number1%number2}");
            break;
        }
        default:
        {
            Console.WriteLine("Invalid Input");
            break;
        }
    }
    }
}
