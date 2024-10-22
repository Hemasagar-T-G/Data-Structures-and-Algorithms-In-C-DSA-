using System;

class GCD
{
    static void Main()
    {
        int a = 48, b = 18;
        
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        Console.WriteLine($"GCD is {a}.");
    }
}
