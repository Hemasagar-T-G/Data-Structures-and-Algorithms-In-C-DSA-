using System;

class FibonacciSequence
{
    static void Main()
    {
        int n = 10;
        int a = 0, b = 1;

        Console.Write("Fibonacci Sequence: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            int temp = a;
            a = b;
            b = temp + b;
        }
    }
}
