using System;
namespace DoWhile;
        class Programy
        {
            public static void Main(string[] args)
            {
                int sum = 0;
                int N = int.Parse(Console.ReadLine());
                
                for(int i=0 ; i<=N ; i++)
                {
                    if(i%2==0)
                    {
                        sum+=i;
                    }
                }
                Console.WriteLine(sum);
            }
        }
            