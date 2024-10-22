using System;

class NumberPyramidPattern
{
    static void Main()
    {
        int n = 5; // Height of the pyramid
        for (int i = 1; i <= n; i++)
        {
            // Print spaces
            for (int j = i; j < n; j++)
            {
                Console.Write(" ");
            }
            // Print numbers
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
