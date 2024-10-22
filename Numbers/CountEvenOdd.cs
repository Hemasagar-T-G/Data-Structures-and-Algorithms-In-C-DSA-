using System;

class CountEvenOdd
{
    static void Main()
    {
        int start = 1, end = 10;
        int evenCount = 0, oddCount = 0;

        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
                evenCount++;
            else
                oddCount++;
        }

        Console.WriteLine($"Even Count: {evenCount}, Odd Count: {oddCount}");
    }
}
