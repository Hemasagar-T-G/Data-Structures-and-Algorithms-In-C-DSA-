using System;

class MaxMinInArray
{
    static void Main()
    {
        int[] numbers = { 5, 3, 8, 1, 4 };
        int max = numbers[0];
        int min = numbers[0];

        foreach (int num in numbers)
        {
            if (num > max)
                max = num;
            if (num < min)
                min = num;
        }

        Console.WriteLine($"Maximum: {max}, Minimum: {min}");
    }
}
