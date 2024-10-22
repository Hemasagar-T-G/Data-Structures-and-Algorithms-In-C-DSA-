using System;

class LCM
{
    static void Main()
    {
        int a = 4, b = 5;
        int lcm = (a * b) / GCD(a, b); // Using GCD to find LCM

        Console.WriteLine($"LCM of {a} and {b} is {lcm}.");
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
