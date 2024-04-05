using System;
namespace DoWhile;

class Program
{
    public static void Main(string[] args)
    {
        string choice = "";
        do
        {
            Console.Write("Enter number: ");
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("Entered value is Even.");
            }
            else
            {
                Console.WriteLine("Entered value is Odd.");
            }

            Console.WriteLine("Do you want to repeat the process with another number? (yes/no) ");
            choice = Console.ReadLine();

            if (choice != "yes" && choice != "no")
            {
                Console.WriteLine("Invalid input.Enter yes/no: ");
                Console.Write("Enter number: ");
                choice = Console.ReadLine();
            }

        } while (choice == "yes");
    }
}

