using System;
namespace IfCondition;

class Program{
    public static void Main(string[] args)
        {
            //GETTING MARK FROM USER
           Console.Write("Enter your mark:");
           float mark = float.Parse(Console.ReadLine());

            //VALIDATING AND PRINTING GRADES
            if(mark>80 && mark<=100)
            {
                Console.WriteLine("Grade A");
            }
            else if(mark>=61 && mark<=80)
            {
                Console.WriteLine("Grade B");
            }
            else if(mark>=36 && mark<61)
            {
                Console.WriteLine("Grade C");
            }
            else if(mark>=0 && mark<36)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            } 
        }
}
