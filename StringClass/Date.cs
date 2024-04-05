using System;
namespace Datie;

class Programy{
    public static void Main(string[] args)
    {
        DateTime date;
        Console.Write("Enter date: ");
        bool temp = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None, out date);
        System.Console.WriteLine();
        while(!temp)
        {
            Console.WriteLine("Invalid Format");
            temp = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None, out date);
        }

        Console.WriteLine(date);
    }
}