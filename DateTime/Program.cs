using System;
namespace Datetime;

class Program{
    public static void Main(string[] args)
    {
       Console.Write("Enter the date in yyyy/MM/dd HH:mm:ss: ");
       DateTime date = DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd HH:mm:ss",null);
       Console.WriteLine(date.ToString("yyyy"));
       Console.WriteLine(date.ToString("MM"));
       Console.WriteLine(date.ToString("DD"));
       Console.WriteLine(date.ToString("HH"));
       Console.WriteLine(date.ToString("mm"));
       Console.WriteLine(date.ToString("ss"));
    }
}