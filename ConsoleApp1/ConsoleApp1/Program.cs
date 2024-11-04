// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Perfect numbers between {num1} and {num2}: ");

        for (int i = num1; i <= num2; i++)
        {
            bool isPerfect = true;

            for (int j = 1; j < i; j++)
            {
                if (i % j == 0 && i / j != j)
                {
                    isPerfect = false;
                    break;
                }
            }

            if (isPerfect)
            {
                Console.WriteLine(i);
            }
        }
    }
}
