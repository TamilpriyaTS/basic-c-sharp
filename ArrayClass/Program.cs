using System;
namespace Array;

class Program
{
    public static void Main(string[] args)
    {
        const int N = 5;
        int flag = 0;
        string[] arr = new string[N]{"Sasi","Raju","Naren","Priya","Sharu"};
        
        //PRINTING ARRAY ELEMENTS
        for (int i=0 ; i<N ; i++)
        {
            Console.WriteLine(arr[i]);
        }

        //GETTING USER INPUT
        Console.WriteLine();
        Console.Write("Enter a name: ");
        string name = Console.ReadLine();
        Console.WriteLine();

        //FOR LOOP SEARCH
        for (int j=0 ; j<N; j++)
        {
            if(arr[j]==name)
            {
                Console.WriteLine("The name is present in for array");
                Console.WriteLine($"Index value: {j}");
                flag = 1;
            }
            if(flag!=1)
            {
                Console.WriteLine("The name is not present in for array");
            }
            else{
            }
        }

        
    }



}
