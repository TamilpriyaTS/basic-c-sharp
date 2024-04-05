using System;
namespace Array;

class Program
{
    public static void Main(string[] args)
    {
        string[] arr = new string[5]{"Sasi","Raju","Naren","Priya","Sharu"};
        
        //PRINTING ARRAY ELEMENTS
        for (int i=0 ; i<5 ; i++)
        {
            Console.WriteLine(arr[i]);
        }

        //GETTING USER INPUT
        Console.WriteLine();
        Console.Write("Enter a name: ");
        string name = Console.ReadLine();
        Console.WriteLine();

        //FOR LOOP SEARCH
        for (int j=0 ; j<5; j++)
        {

            Console.WriteLine($"Index value: {j}");
            if(arr[j]==name)
            {
                Console.WriteLine("The name is present in for array");
                Console.WriteLine($"Index value: {j}");
                Console.WriteLine($"Index value: {j}");
                break;
            }
            else{
                Console.WriteLine("The name is not present in for array");
                break;
            }
        }
#pragma warning restore CS0162 // Unreachable code detected

        //FOREACH LOOP SEARCH
        // foreach (string k in arr)
        // {
        //     if(k==name)
        //     {
        //         Console.WriteLine("The name is present in for array");
        //         Console.WriteLine($"Index value: {k}");
        //         break;
        //     }
        //     else{
        //         Console.WriteLine("The name is not present in foreach array");
        //         break;
        //     }
        }



    }
}