using System;
namespace IndicesDiff;

        class Program
        {
            public static void Main(string[] args)
            {
                char player1 = char.Parse(Console.ReadLine());
                char player2 = char.Parse(Console.ReadLine());
                int flag = 0;

                if(player1=='P')
                {
                    if(player2=='R')
                    {
                        flag=1;
                        Console.WriteLine("Player1 - Paper; Player2 - Rock");
                    }
                    else if(player2=='S')
                    {
                        flag=2;
                         Console.WriteLine("Player1 - Paper; Player2 - Scis");
                    }
                }
                

                if(player1=='R')
                {
                    if(player2=='S')
                    {
                        flag=1;
                         Console.WriteLine("Player1 - Rock; Player2 - Scis");
                    }
                    else if(player2=='P')
                    {
                        flag=2;
                         Console.WriteLine("Player1 - Rock; Player2 - Paper");
                    }
                }
                

                if(player1=='S')
                {
                    if(player2=='P')
                    {
                        flag=1;
                         Console.WriteLine("Player1 - Scis; Player2 - Pap");
                    }
                    else if(player2=='R')
                    {
                        flag=2;
                         Console.WriteLine("Player1 - Scis; Player2 - Rock");
                    }
                }
                

                if(flag==1)
                {
                    Console.WriteLine($"Winner: {player1}");
                }
                else if(flag==2)
                {
                    Console.WriteLine($"Winner: {player2}");
                }
                else{
                    Console.WriteLine("D");
                }


            }
        }
            