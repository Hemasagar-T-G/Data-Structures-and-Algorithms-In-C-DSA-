using System;

class PyramidStarPattern
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
            // Print stars
            for (int j = 1; j <= (2 * i - 1); j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
