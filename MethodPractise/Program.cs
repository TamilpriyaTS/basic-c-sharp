using System;
namespace MethodPractise;

class Program
{
    public static void Main(string[] args)
    {
        //declaring for with arguments and return - multiply
        int a = 10;
        int b = 20;
        int product = multiply(a, b);
        Console.WriteLine($"product: {product}");

        //declaring for with arguments and without return - divide
        float x = 30.2f;
        float y = 32.1f;
        divide(x, y);

    }
    static int multiply(int x, int y)
    {
        return x * y;
    }
    static void divide(float x, float y)
    {
        Console.WriteLine($"Quotient: {x / y}");
    }
}