using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string str = Console.ReadLine();
        string[] str_arr = str.Split(',');


        int[] int_arr = new int[n];

        for(int i=0; i<n ; i++)
        {
            int_arr[i]=int.Parse(str_arr[i]);
        }
        //7, 8 ,2,4, 6 , 2
        for(int i=0 ; i<n ; i++)
        {
            if(i==n-1)
            {
                Console.Write($"{int_arr[i]}");
            }
            
            else if(int_arr[i]>int_arr[i+1])
                {
                    Console.Write($"{int_arr[i]} ");

                }
            }
            
        }
    }