using System;

class ArmstrongNumber
{
    static void Main()
    {
        int number = 153; // Example number
        int originalNumber = number;
        int sum = 0;

        while (number > 0)
        {
            int digit = number % 10;
            sum += digit * digit * digit; // Cube the digit
            number /= 10;
        }

        Console.WriteLine(sum == originalNumber ? $"{originalNumber} is an Armstrong number." : $"{originalNumber} is not an Armstrong number.");
    }
}
