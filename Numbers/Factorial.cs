using System;

class Factorial
{
    static void Main()
    {
        int number = 5;
        long factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"Factorial of {number} is {factorial}.");
    }
}
