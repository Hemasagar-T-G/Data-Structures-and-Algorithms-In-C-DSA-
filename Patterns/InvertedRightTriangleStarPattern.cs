using System;

class InvertedRightTriangleStarPattern
{
    static void Main()
    {
        int n = 5; // Height of the triangle
        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
