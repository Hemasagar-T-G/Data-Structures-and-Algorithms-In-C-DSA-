using System;

class SumOfDigits
{
    static void Main()
    {
        int number = 12345;
        int sum = 0;

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        Console.WriteLine($"Sum of digits is {sum}.");
    }
}
