using System;
using System.Linq;
namespace StringClass;

class Program
{
    public static void Main(string[] args)
    {
        // string main_string = "Blalala";
        // string temp = string.Empty;
        
        int start_index;
        int end_index;
        int temp = 0;
        Console.Write("Enter Main String: ");
        string main_string = Console.ReadLine();
        Console.Write("Enter Short String: ");
        string short_string = Console.ReadLine();

        int main_length = main_string.Length;
        int short_length = short_string.Length;

        //for (int i=0 ; i<main_length ; i++)
        while(main_string.Contains("la"))
        {
            start_index = main_string.IndexOf("la");
            end_index = start_index + (short_length-1);
            //Console.WriteLine($"{start_index}, {end_index}");
            main_string = main_string.Remove(start_index,end_index);
            Console.WriteLine($"{main_string}");
            temp+=1;    
        }
        Console.WriteLine($"temp: {temp}");

        
        
        
        



        



    }
}