using System;

class PrimeCheck
{
    static void Main()
    {
        int number = 29;
        bool isPrime = true;

        if (number <= 1)
            isPrime = false;
        else
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        Console.WriteLine(isPrime ? $"{number} is a prime number." : $"{number} is not a prime number.");
    }
}
