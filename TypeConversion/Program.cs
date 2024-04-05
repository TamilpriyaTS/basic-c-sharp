using System;
namespace TypeConversion;

class Program
{
    public static void Main(string[] args)
    {
        //GETTING TRAINER DETAILS
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter mark of subject 1: ");
        float sub1 = float.Parse(Console.ReadLine());

        Console.Write("Enter mark of subject 2: ");
        float sub2 = float.Parse(Console.ReadLine());

        Console.Write("Enter mark of subject 3: ");
        float sub3 = float.Parse(Console.ReadLine());

        Console.Write("Enter Grade: ");
        char grade = char.Parse(Console.ReadLine());

        Console.Write("Enter mobile number: ");
        double phone = double.Parse(Console.ReadLine());
        
        Console.Write("Enter Mail id: ");
        string mail = Console.ReadLine();

        //DISPLAYING TRAINER DETAILS
        Console.WriteLine();
        Console.WriteLine("Training Details Are:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Mobile: {phone}");
        Console.WriteLine($"Marks1: {sub1}");
        Console.WriteLine($"Marks1: {sub2}");
        Console.WriteLine($"Marks1: {sub3}");
        Console.WriteLine($"Total: {sub1+sub2+sub3}");
        Console.WriteLine($"Average: {(sub1+sub2+sub3)/3}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Mail id: {mail}");
    }
}