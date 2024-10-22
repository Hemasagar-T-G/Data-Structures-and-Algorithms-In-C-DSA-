using System;

class RightTriangleStarPattern
{
    static void Main()
    {
        int n = 5; // Height of the triangle
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
